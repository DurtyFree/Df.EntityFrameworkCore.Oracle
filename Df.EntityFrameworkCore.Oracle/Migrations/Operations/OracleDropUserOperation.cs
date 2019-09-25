// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Citms.EntityFrameworkCore.Oracle.Utilities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Citms.EntityFrameworkCore.Oracle.Migrations.Operations
{
    public class OracleDropUserOperation : MigrationOperation
    {
        public virtual string UserName { get; [param: NotNull] set; }
    }
}
