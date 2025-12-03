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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Provides helper methods for Task-based operations.
    /// </summary>
    internal static class TaskHelpers
    {
        private static Logger Logger
        {
            get { return Logger.GetLogger(typeof(TaskHelpers)); }
        }

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
            
            Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync: Starting with TotalTasks={0}", total);
            
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
                
                Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync: Task completed (Processed={0}/{1}, Remaining={2})",
                    processed, total, pendingTasks.Count);
            }
            
            Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync: All tasks completed (Total={0})", total);
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
            
            Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync<T>: Starting with TotalTasks={0}", total);
            
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
                
                Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync<T>: Task completed (Processed={0}/{1}, Remaining={2})",
                    processed, total, pendingTasks.Count);
            }
            
            Logger.DebugFormat("TaskHelpers.WhenAllOrFirstExceptionAsync<T>: All tasks completed (Total={0})", total);
            
            return responses;
        }

        /// <summary>
        /// Executes work items with limited concurrency using a task pool pattern.
        /// Creates only as many tasks as the concurrency limit allows, rather than creating
        /// all tasks upfront. This reduces memory overhead for large collections.
        /// </summary>
        /// <remarks>
        /// This method provides a clean way to limit concurrent operations without creating
        /// all tasks upfront. It maintains a pool of active tasks up to the maxConcurrency limit,
        /// replacing completed tasks with new ones until all items are processed.
        /// The caller is responsible for implementing failure handling within the processAsync function.
        /// </remarks>
        /// <typeparam name="T">The type of items to process</typeparam>
        /// <param name="items">The collection of items to process</param>
        /// <param name="maxConcurrency">Maximum number of concurrent tasks</param>
        /// <param name="processAsync">Async function to process each item</param>
        /// <param name="cancellationToken">Cancellation token to observe</param>
        /// <returns>A task that completes when all items are processed, or throws on first failure</returns>
        internal static async Task ForEachWithConcurrencyAsync<T>(
            IEnumerable<T> items,
            int maxConcurrency,
            Func<T, CancellationToken, Task> processAsync,
            CancellationToken cancellationToken)
        {
            var itemList = items as IList<T> ?? items.ToList();
            if (itemList.Count == 0)
            {
                Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: No items to process");
                return;
            }

            Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: Starting with TotalItems={0}, MaxConcurrency={1}",
                itemList.Count, maxConcurrency);

            int nextIndex = 0;
            var activeTasks = new List<Task>();

            // Start initial batch up to concurrency limit
            int initialBatchSize = Math.Min(maxConcurrency, itemList.Count);
            Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: Starting initial batch of {0} tasks", initialBatchSize);
            
            for (int i = 0; i < initialBatchSize; i++)
            {
                var task = processAsync(itemList[nextIndex++], cancellationToken);
                activeTasks.Add(task);
            }

            // Process completions and start new tasks until all work is done
            while (activeTasks.Count > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var completedTask = await Task.WhenAny(activeTasks)
                    .ConfigureAwait(continueOnCapturedContext: false);

                // Propagate exceptions (fail-fast behavior by default)
                // Caller's processAsync function should handle failure policy if needed
                await completedTask
                    .ConfigureAwait(continueOnCapturedContext: false);

                activeTasks.Remove(completedTask);

                int itemsCompleted = nextIndex - activeTasks.Count;
                Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: Task completed (Active={0}, Completed={1}/{2}, Remaining={3})",
                    activeTasks.Count, itemsCompleted, itemList.Count, itemList.Count - itemsCompleted);

                // Start next task if more work remains
                if (nextIndex < itemList.Count)
                {
                    Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: Starting next task (Index={0}/{1}, Active={2})",
                        nextIndex + 1, itemList.Count, activeTasks.Count + 1);
                    var nextTask = processAsync(itemList[nextIndex++], cancellationToken);
                    activeTasks.Add(nextTask);
                }
            }
            
            Logger.DebugFormat("TaskHelpers.ForEachWithConcurrencyAsync: All items processed (Total={0})", itemList.Count);
        }
    }
}
