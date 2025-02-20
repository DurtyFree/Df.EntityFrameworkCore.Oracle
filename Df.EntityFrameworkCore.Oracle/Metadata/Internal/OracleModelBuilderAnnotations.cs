// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Df.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Df.EntityFrameworkCore.Oracle.Metadata.Internal
{
    public class OracleModelBuilderAnnotations : OracleModelAnnotations
    {
        public OracleModelBuilderAnnotations(
            [NotNull] InternalModelBuilder internalBuilder,
            ConfigurationSource configurationSource)
            : base(new RelationalAnnotationsBuilder(internalBuilder, configurationSource))
        {
        }

#pragma warning disable 109

        public new virtual bool HiLoSequenceName([CanBeNull] string value) => SetHiLoSequenceName(value);

        public new virtual bool ValueGenerationStrategy(OracleValueGenerationStrategy? value) => SetValueGenerationStrategy(value);
#pragma warning restore 109
    }
}
