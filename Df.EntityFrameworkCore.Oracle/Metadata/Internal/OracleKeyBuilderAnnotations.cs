// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Citms.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Citms.EntityFrameworkCore.Oracle.Metadata.Internal
{
    public class OracleKeyBuilderAnnotations : RelationalKeyAnnotations
    {
        public OracleKeyBuilderAnnotations(
            [NotNull] InternalKeyBuilder internalBuilder,
            ConfigurationSource configurationSource)
            : base(new RelationalAnnotationsBuilder(internalBuilder, configurationSource))
        {
        }

        public new virtual bool Name([CanBeNull] string value) => SetName(value);
    }
}
