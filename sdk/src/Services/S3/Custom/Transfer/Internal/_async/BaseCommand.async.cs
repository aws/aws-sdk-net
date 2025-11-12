/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    internal abstract partial class BaseCommand<TResponse> where TResponse : class
    {
        /// <summary>
        /// Executes the command and returns a typed response
        /// </summary>
        public abstract Task<TResponse> ExecuteAsync(CancellationToken cancellationToken);

        protected static async Task ExecuteCommandAsync<T>(BaseCommand<T> command, CancellationTokenSource internalCts, SemaphoreSlim throttler) where T : class
        {
            try
            {
                await command.ExecuteAsync(internalCts.Token)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            catch (Exception exception)
            {
                if (!(exception is OperationCanceledException))
                {
                    // Cancel scheduling any more tasks.
                    // Cancel other upload requests.
                    internalCts.Cancel();
                }
                throw;
            }
            finally
            {
                throttler.Release();
            }
        }
    }
}
