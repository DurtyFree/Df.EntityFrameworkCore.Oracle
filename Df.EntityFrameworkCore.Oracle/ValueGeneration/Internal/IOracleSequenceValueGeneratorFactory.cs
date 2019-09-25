// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Df.EntityFrameworkCore.Oracle.Storage.Internal;
using Df.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Df.EntityFrameworkCore.Oracle.ValueGeneration.Internal
{
    public interface IOracleSequenceValueGeneratorFactory
    {
        ValueGenerator Create(
            [NotNull] IProperty property,
            [NotNull] OracleSequenceValueGeneratorState generatorState,
            [NotNull] IOracleConnection connection);
    }
}
