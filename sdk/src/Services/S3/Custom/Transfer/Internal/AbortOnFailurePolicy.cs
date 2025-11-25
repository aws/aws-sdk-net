/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Failure policy that cancels all related operations and rethrows the exception when
    /// an action fails.
    /// </summary>
    /// <remarks>
    /// Use this policy when any single failure should abort the entire higher-level operation.
    /// When an <see cref="Action"/> executed under this policy throws, the policy will cancel
    /// the provided <see cref="CancellationTokenSource"/>, invoke an optional failure callback,
    /// and then rethrow the exception so the caller can observe the original failure.
    /// </remarks>
    internal class AbortOnFailurePolicy : IFailurePolicy
    {
        /// <summary>
        /// Executes the provided asynchronous <paramref name="action"/> under the abort-on-failure policy.
        /// </summary>
        /// <param name="action">An asynchronous delegate that performs the work to execute under the policy.</param>
        /// <param name="onFailure">An optional callback that will be invoked with the exception if <paramref name="action"/> fails.</param>
        /// <param name="cancellationTokenSource">A <see cref="CancellationTokenSource"/> that will be canceled by this policy to signal termination
        /// of related work when a failure occurs.</param>
        /// <returns>
        /// A <see cref="Task{Boolean}"/> that completes with <c>true</c> when <paramref name="action"/> completes successfully.
        /// If <paramref name="action"/> fails, this method cancels <paramref name="cancellationTokenSource"/>, invokes
        /// <paramref name="onFailure"/> if provided, and rethrows the original exception; it does not return <c>false</c>.
        /// </returns>
        public async Task<bool> ExecuteAsync(Func<Task> action, Action<Exception> onFailure, CancellationTokenSource cancellationTokenSource)
        {
            try
            {
                await action().ConfigureAwait(false);

                return true;
            }
            catch (Exception ex)
            {
                // Cancel all pending operations before propagating the exception
                cancellationTokenSource.Cancel();
                
                onFailure?.Invoke(ex);
                
                throw;
            }
        }
    }
}
