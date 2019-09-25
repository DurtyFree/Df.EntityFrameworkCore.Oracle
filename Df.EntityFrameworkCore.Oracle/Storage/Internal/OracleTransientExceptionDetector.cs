// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Citms.EntityFrameworkCore.Oracle.Utilities;
using Oracle.ManagedDataAccess.Client;

namespace Citms.EntityFrameworkCore.Oracle.Storage.Internal
{
    /// <summary>
    ///     Detects the exceptions caused by Oracle transient failures.
    /// </summary>
    public static class OracleTransientExceptionDetector
    {
        public static bool ShouldRetryOn([NotNull] Exception ex)
        {
            if (ex is OracleException sqlException)
            {
                // TODO: Add Oracle specific error numbers.

                return false;
            }

            return ex is TimeoutException;
        }
    }
}
