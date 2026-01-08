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
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Failure policy that records exceptions and allows other operations to continue.
    /// </summary>
    /// <remarks>
    /// Use this policy when individual operation failures should not abort the overall
    /// download directory operation. Exceptions thrown by the action are captured and
    /// stored in the supplied <see cref="ConcurrentBag{Exception}"/>, and an optional
    /// onFailure callback is invoked. For cancellation triggered by
    /// the provided <see cref="CancellationTokenSource"/>, cancellation is propagated
    /// to callers by rethrowing the <see cref="OperationCanceledException"/>.
    /// </remarks>
    internal class ContinueOnFailurePolicy : IFailurePolicy
    {
        private readonly ConcurrentBag<Exception> _errors;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueOnFailurePolicy"/> class.
        /// </summary>
        /// <param name="errors">A <see cref="ConcurrentBag{Exception}"/> used to collect exceptions
        /// that occur while executing actions under this policy. Failures are added to this bag
        /// so the caller can examine aggregated errors after the overall operation completes.</param>
        internal ContinueOnFailurePolicy(ConcurrentBag<Exception> errors)
        {
            _errors = errors;
        }

        /// <summary>
        /// Executes <paramref name="action"/> and records failures without throwing them,
        /// unless the failure is an operation cancellation triggered by the provided
        /// <paramref name="cancellationTokenSource"/>.
        /// </summary>
        /// <param name="action">The asynchronous operation to execute under the policy.</param>
        /// <param name="onFailure">A callback invoked with the exception when <paramref name="action"/> fails.</param>
        /// <param name="cancellationTokenSource">A <see cref="CancellationTokenSource"/> used to determine and signal cancellation.
        /// The policy will rethrow cancellations when the cancellation token was requested.</param>
        /// <returns>
        /// A <see cref="Task{Boolean}"/> that completes with <c>true</c> when the action completed successfully.
        /// If the action threw a non-cancellation exception, the exception is added to the internal error bag,
        /// <paramref name="onFailure"/> is invoked if provided, and the method completes with <c>false</c> to indicate
        /// the action failed but the policy handled it and allowed processing to continue.
        /// </returns>
        public async Task<bool> ExecuteAsync(Func<Task> action, Action<Exception> onFailure, CancellationTokenSource cancellationTokenSource)
        {
            try
            {
                await action().ConfigureAwait(false);

                return true;
            }
            // If the operation was canceled via the provided token, propagate cancellation.
            catch (OperationCanceledException ex) when (cancellationTokenSource?.IsCancellationRequested == true)
            {
                onFailure?.Invoke(ex);

                // Collect the exception for later reporting.
                _errors.Add(ex);
                
                throw;
            }
// Disabled warning CA1031 to allow catching all exceptions to continue processing.
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                onFailure?.Invoke(ex);

                // Collect the exception for later reporting but don't throw it.
                // This allows other downloads to continue processing.
                _errors.Add(ex);

                return false;
            }
        }
    }
}
