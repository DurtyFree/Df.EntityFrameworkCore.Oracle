// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Df.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Df.EntityFrameworkCore.Oracle.ValueGeneration.Internal
{
    public interface IOracleValueGeneratorCache : IValueGeneratorCache
    {
        OracleSequenceValueGeneratorState GetOrAddSequenceState([NotNull] IProperty property);
    }
}
