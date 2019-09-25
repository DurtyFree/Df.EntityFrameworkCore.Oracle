// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Df.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Df.EntityFrameworkCore.Oracle.Query.Internal
{
    public class OracleQueryCompilationContext : RelationalQueryCompilationContext
    {
        private readonly ISet<string> _tableAliasSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public OracleQueryCompilationContext(
            [NotNull] QueryCompilationContextDependencies dependencies,
            [NotNull] ILinqOperatorProvider linqOperatorProvider,
            [NotNull] IQueryMethodProvider queryMethodProvider,
            bool trackQueryResults)
            : base(
                dependencies,
                linqOperatorProvider,
                queryMethodProvider,
                trackQueryResults)
        {
        }

        public override bool IsLateralJoinSupported => true;

        public override int MaxTableAliasLength => 5;

        private string GetRandomLetter(Random rng)
        {
            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int index = rng.Next(letters.Length);
            return letters[index].ToString();
        }

        private string GenerateAlias(bool includeNumber = true)
        {
            var rdm = new Random();
            var alias = GetRandomLetter(rdm);
            if (includeNumber)
            {
                alias = $"{alias}{rdm.Next(0, 10)}";
            }
            return alias;
        }

        private string GetTableAlias(string currentAlias)
        {
            if (currentAlias.Contains("."))
            {
                return $"{GenerateAlias(false)}.{GenerateAlias()}";
            }

            return GenerateAlias();
        }

        public override string CreateUniqueTableAlias([NotNull] string currentAlias)
        {
            Check.NotNull(currentAlias, nameof(currentAlias));

            if (currentAlias.Length == 0)
            {
                return currentAlias;
            }

            string uniqueAlias = GetTableAlias(currentAlias);
            while (_tableAliasSet.Contains(uniqueAlias))
            {
                uniqueAlias = GetTableAlias(currentAlias);
            }

            _tableAliasSet.Add(uniqueAlias);

            return uniqueAlias;
        }
    }
}