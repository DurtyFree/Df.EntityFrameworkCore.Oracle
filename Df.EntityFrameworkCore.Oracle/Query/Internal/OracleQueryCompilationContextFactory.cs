// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Df.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Df.EntityFrameworkCore.Oracle.Query.Internal
{
    public class OracleQueryCompilationContextFactory : RelationalQueryCompilationContextFactory
    {
        public OracleQueryCompilationContextFactory(
            [NotNull] QueryCompilationContextDependencies dependencies,
            [NotNull] RelationalQueryCompilationContextDependencies relationalDependencies)
            : base(dependencies, relationalDependencies)
        {
        }

        public override QueryCompilationContext Create(bool async)
            => async
                ? new OracleQueryCompilationContext(
                    Dependencies,
                    new AsyncLinqOperatorProvider(),
                    new AsyncQueryMethodProvider(),
                    TrackQueryResults)
                : new OracleQueryCompilationContext(
                    Dependencies,
                    new LinqOperatorProvider(),
                    new QueryMethodProvider(),
                    TrackQueryResults);
    }
}
