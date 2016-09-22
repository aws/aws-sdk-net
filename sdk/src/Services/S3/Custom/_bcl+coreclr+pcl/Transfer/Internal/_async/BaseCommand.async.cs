/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    internal abstract partial class BaseCommand
    {
        public abstract Task ExecuteAsync(CancellationToken cancellationToken);

        /// <summary>
        ///  Waits for all of the tasks to complete or till any task fails.
        /// </summary>        
        protected static async Task<List<T>> WhenAllOrFirstExceptionAsync<T>(List<Task<T>> pendingTasks, CancellationToken cancellationToken)
        {
            int processed = 0;
            int total = pendingTasks.Count;
            var responses = new List<T>();
            while (processed < total)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var completedTask = await Task.WhenAny(pendingTasks)
                    .ConfigureAwait(continueOnCapturedContext: false);
                if (completedTask.Status == TaskStatus.RanToCompletion ||
                    completedTask.Status == TaskStatus.Faulted)
                {
                    // Only process results from completed or faulted tasks.                    
                    // so that we can capture the result of the operation or the exception,
                    // and ignore OperationCancelledException from cancelled tasks.
                    var response = await completedTask
                        .ConfigureAwait(continueOnCapturedContext: false);
                    responses.Add(response);
                }
                pendingTasks.Remove(completedTask);
                processed++;
            }
            return responses;
        }

        /// <summary>
        /// Waits for all of the tasks to complete or till any task fails.
        /// </summary>        
        protected static async Task WhenAllOrFirstExceptionAsync(List<Task> pendingTasks, CancellationToken cancellationToken)
        {
            int processed = 0;
            int total = pendingTasks.Count;            
            while (processed < total)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var completedTask = await Task.WhenAny(pendingTasks)
                    .ConfigureAwait(continueOnCapturedContext: false);                
                if (completedTask.Status == TaskStatus.Faulted)
                {
                    // Only process results from faulted tasks so that the exception is thrown.                    
                    await completedTask
                        .ConfigureAwait(continueOnCapturedContext: false);                    
                }
                pendingTasks.Remove(completedTask);
                processed++;
            }
        }

        protected static async Task ExecuteCommandAsync(BaseCommand command, CancellationTokenSource internalCts, SemaphoreSlim throttler)
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
