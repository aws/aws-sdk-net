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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Provides helper methods for Task-based operations.
    /// </summary>
    internal static class TaskHelpers
    {
        /// <summary>
        /// Waits for all tasks to complete or till any task fails or is canceled.
        /// </summary>
        /// <param name="pendingTasks">List of tasks to wait for completion</param>
        /// <param name="cancellationToken">Cancellation token to observe</param>
        /// <returns>A task that represents the completion of all tasks or the first exception</returns>
        internal static async Task WhenAllOrFirstExceptionAsync(List<Task> pendingTasks, CancellationToken cancellationToken)
        {
            int processed = 0;
            int total = pendingTasks.Count;            
            while (processed < total)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var completedTask = await Task.WhenAny(pendingTasks)
                    .ConfigureAwait(continueOnCapturedContext: false);                
                
                //If RanToCompletion a response will be returned
                //If Faulted or Canceled an appropriate exception will be thrown       
                await completedTask
                    .ConfigureAwait(continueOnCapturedContext: false);                    
                
                pendingTasks.Remove(completedTask);
                processed++;
            }
        }

        /// <summary>
        /// Waits for all tasks to complete or till any task fails or is canceled.
        /// Returns results from all completed tasks.
        /// </summary>
        /// <typeparam name="T">The type of result returned by the tasks</typeparam>
        /// <param name="pendingTasks">List of tasks to wait for completion</param>
        /// <param name="cancellationToken">Cancellation token to observe</param>
        /// <returns>A task that represents the completion of all tasks with their results, or the first exception</returns>
        internal static async Task<List<T>> WhenAllOrFirstExceptionAsync<T>(List<Task<T>> pendingTasks, CancellationToken cancellationToken)
        {
            int processed = 0;            
            int total = pendingTasks.Count;
            var responses = new List<T>();
            while (processed < total)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var completedTask = await Task.WhenAny(pendingTasks)
                    .ConfigureAwait(continueOnCapturedContext: false);
                
                //If RanToCompletion a response will be returned
                //If Faulted or Canceled an appropriate exception will be thrown  
                var response = await completedTask
                    .ConfigureAwait(continueOnCapturedContext: false);
                responses.Add(response);
                
                pendingTasks.Remove(completedTask);
                processed++;
            }
            
            return responses;
        }
    }
}
