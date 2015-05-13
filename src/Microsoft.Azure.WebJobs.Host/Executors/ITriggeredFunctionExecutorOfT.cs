﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Host.Executors
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TTriggerValue">The trigger value type for the trigger binding.</typeparam>
    public interface ITriggeredFunctionExecutor<TTriggerValue> : ITriggeredFunctionExecutor
    {
        /// <summary>
        /// Try to invoke the triggered function using the values specified.
        /// </summary>
        /// <param name="parentId">The parent ID</param>
        /// <param name="triggerValue">The value that caused the trigger to fire</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>True if the invocation succeeded, false otherwise.</returns>
        Task<bool> TryExecuteAsync(Guid? parentId, TTriggerValue triggerValue, CancellationToken cancellationToken);
    }
}