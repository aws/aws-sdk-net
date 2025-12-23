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
    /// Defines a policy for handling failures when executing asynchronous operations.
    /// Implementations encapsulate cancellation behavior for
    /// operations that may fail and need controlled continuation or termination.
    /// </summary>
    internal interface IFailurePolicy
    {
        /// <summary>
        /// Executes an asynchronous <paramref name="action"/> under this failure policy.
        /// </summary>
        /// <remarks>
        /// Implementations of this interface control how failures that occur while running
        /// <paramref name="action"/> are handled (for example, whether to abort the overall
        /// operation, continue on failure, or aggregate errors). When <paramref name="action"/>
        /// throws or faults, the policy implementation is responsible for invoking
        /// <paramref name="onFailure"/> with the thrown <see cref="Exception"/> and for
        /// taking any policy-specific cancellation action (for example by calling
        /// <paramref name="cancellationTokenSource"/>.Cancel()).
        ///
        /// The returned <see cref="Task{Boolean}"/> completes with <c>true</c> when the
        /// <paramref name="action"/> completed successfully according to the policy and
        /// the caller may proceed. It completes with <c>false</c> when the action failed and
        /// the policy handled the failure (the caller should treat this as a failed step).
        /// </remarks>
        /// <param name="action">A function that performs the asynchronous work to execute under the policy.</param>
        /// <param name="onFailure">A callback that will be invoked with the exception when <paramref name="action"/> fails.</param>
        /// <param name="cancellationTokenSource">A <see cref="CancellationTokenSource"/> the policy may cancel to signal termination of related work.</param>
        /// <returns>
        /// A <see cref="Task{Boolean}"/> that resolves to <c>true</c> if the action completed successfully
        /// (no failure), or <c>false</c> if the action failed but the policy handled the failure.
        /// </returns>
        Task<bool> ExecuteAsync(Func<Task> action, Action<Exception> onFailure, CancellationTokenSource cancellationTokenSource);
    }
}
