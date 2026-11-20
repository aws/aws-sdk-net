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

using System.Linq;
using System.Reflection;
using System.Threading;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Reads private state of <see cref="RefreshingAWSCredentials"/> so that the credential refresh tests can wait for a
    /// refresh to finish, or for a caller to queue on the refresh lock, instead of sleeping. The private member names are
    /// only written here: if the provider renames one, every probe fails with a message that names the member.
    /// </summary>
    internal static class RefreshingCredentialsTestProbes
    {
        private static readonly FieldInfo RefreshLockField =
            typeof(RefreshingAWSCredentials).GetField("_updateGeneratedCredentialsSemaphore", BindingFlags.Instance | BindingFlags.NonPublic);
        private static readonly FieldInfo BackgroundRefreshInFlightField =
            typeof(RefreshingAWSCredentials).GetField("_backgroundRefreshInFlight", BindingFlags.Instance | BindingFlags.NonPublic);

        // SemaphoreSlim's count of waiting threads. Null on a runtime that does not have the field; see
        // AreWaitingForRefreshLock.
        private static readonly FieldInfo SemaphoreWaitCountField =
            typeof(SemaphoreSlim).GetField("m_waitCount", BindingFlags.Instance | BindingFlags.NonPublic);

        // The first entry of SemaphoreSlim's queue of asynchronous waiters, or null when none is queued. See
        // IsAsyncCallWaitingForRefreshLock.
        private static readonly FieldInfo SemaphoreAsyncHeadField =
            typeof(SemaphoreSlim).GetField("m_asyncHead", BindingFlags.Instance | BindingFlags.NonPublic);

        /// <summary>
        /// Fails the test when <paramref name="member"/>, a private member of <see cref="RefreshingAWSCredentials"/>
        /// looked up by <paramref name="name"/>, was not found; otherwise returns it.
        /// </summary>
        internal static T Require<T>(T member, string name) where T : MemberInfo
        {
            if (member == null)
                Assert.Fail("RefreshingAWSCredentials." + name + " was not found; update the test probes to match the provider.");
            return member;
        }

        /// <summary>The semaphore that serializes every call to the credential source.</summary>
        internal static SemaphoreSlim RefreshLock(RefreshingAWSCredentials creds)
            => (SemaphoreSlim)Require(RefreshLockField, "_updateGeneratedCredentialsSemaphore").GetValue(creds);

        /// <summary>True while a background refresh has been started and has not finished.</summary>
        internal static bool IsBackgroundRefreshInFlight(RefreshingAWSCredentials creds)
            => (int)Require(BackgroundRefreshInFlightField, "_backgroundRefreshInFlight").GetValue(creds) != 0;

        /// <summary>True when no refresh holds the refresh lock and no background refresh is pending.</summary>
        internal static bool IsIdle(RefreshingAWSCredentials creds)
            => RefreshLock(creds).CurrentCount == 1 && !IsBackgroundRefreshInFlight(creds);

        /// <summary>
        /// True when every thread in <paramref name="waiters"/> is blocked in SemaphoreSlim.Wait() on the refresh lock.
        /// Uses the semaphore's count of waiting threads where the runtime has one, and otherwise the state of the
        /// threads: the callers these tests start block nowhere else before they take the lock.
        /// </summary>
        internal static bool AreWaitingForRefreshLock(RefreshingAWSCredentials creds, params Thread[] waiters)
        {
            if (SemaphoreWaitCountField != null)
                return (int)SemaphoreWaitCountField.GetValue(RefreshLock(creds)) == waiters.Length;
            return waiters.All(t => (t.ThreadState & ThreadState.WaitSleepJoin) != 0);
        }

        /// <summary>
        /// True when a call is queued on the refresh lock by SemaphoreSlim.WaitAsync(), read from the semaphore's queue
        /// of asynchronous waiters.
        /// </summary>
        internal static bool IsAsyncCallWaitingForRefreshLock(RefreshingAWSCredentials creds)
        {
            if (SemaphoreAsyncHeadField == null)
                Assert.Fail("SemaphoreSlim.m_asyncHead was not found on this runtime; update the test probes to match it.");
            return SemaphoreAsyncHeadField.GetValue(RefreshLock(creds)) != null;
        }
    }
}
