// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Df.EntityFrameworkCore.Oracle.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Df.EntityFrameworkCore.Oracle.Metadata.Conventions.Internal
{
    public class OracleValueGenerationStrategyConvention : IModelInitializedConvention
    {
        public virtual InternalModelBuilder Apply(InternalModelBuilder modelBuilder)
        {
            modelBuilder.Oracle(ConfigurationSource.Convention).ValueGenerationStrategy(OracleValueGenerationStrategy.IdentityColumn);

            return modelBuilder;
        }
    }
}
