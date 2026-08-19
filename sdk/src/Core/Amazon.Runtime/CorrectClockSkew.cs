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
using System.Collections.Generic;

using Amazon.Util.Internal;
using System.Threading;

namespace Amazon.Runtime
{
    /// <summary>
    /// Utility class that stores clock skew information.
    /// </summary>
    public static class CorrectClockSkew
    {
        private static TimeSpan? manualClockCorrection;
        private static ReaderWriterLockSlim manualClockCorrectionLock = new ReaderWriterLockSlim();

        /// <summary>
        /// GlobalClockCorrection should be only set by AWSConfigs.ManualClockCorrection property
        /// and is only available to maintain backward compatibilty.  This should override any
        /// endpoint specific clockskew correction.
        /// </summary>
        internal static TimeSpan? GlobalClockCorrection
        {
            get
            {
                TimeSpan? value;
                manualClockCorrectionLock.EnterReadLock();
                {
                    value = manualClockCorrection;
                }
                manualClockCorrectionLock.ExitReadLock();
                return value;
            }

            set
            {
                manualClockCorrectionLock.EnterWriteLock();
                {
                    manualClockCorrection = value;
                }
                manualClockCorrectionLock.ExitWriteLock();
            }
        }

        // ConcurrentDictionary gives lock-free reads (every signed request reads this via
        // GetCorrectedUtcNowForEndpoint) and per-bucket striped writes, so ClientSkew is recorded
        // on every response without serializing all endpoints through a single global write lock.
        private static readonly ConcurrentDictionary<string, TimeSpan> clockCorrectionDictionary = new ConcurrentDictionary<string, TimeSpan>();

        /// <summary>
        /// Return clock skew correction value for an endpoint if there is one.
        /// 
        /// AWSConfigs.ManualClockCorrection overrides globally any calculated service endpoint specific
        /// clock correction value.
        /// </summary>
        /// <param name="endpoint">Endpoint should in a form such as "https://s3"</param>
        /// <returns>Clock correction value for an endpoint in TimeSpan.  TimeSpan.Zero if no such clock correction is set.</returns>
        public static TimeSpan GetClockCorrectionForEndpoint(string endpoint)
        {
            return clockCorrectionDictionary.TryGetValue(endpoint, out var span) ? span : TimeSpan.Zero;
        }

        /// <summary>
        /// Get clock skew corrected UTC now value.  If ManualClockCorrection is set, 
        /// use ManualClockCorrection instead of endpoint specific clock correction value.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static DateTime GetCorrectedUtcNowForEndpoint(string endpoint)
        {
            // Backwards-compatible overload. There is no client config at this call site, so no
            // per-client disable value is resolved and none is invented from env/profile here
            // (the disable precedence chain lives on the client config property). This behaves
            // exactly as it did before the disable option existed: correction is gated only by
            // AWSConfigs.CorrectForClockSkew and ManualClockCorrection.
            return GetCorrectedUtcNowForEndpoint(endpoint, (IClientConfig)null);
        }

        /// <summary>
        /// Overload that honors the per-client <see cref="IClientConfig.DisableClockSkewCorrection"/>
        /// setting, which itself resolves the env var and shared-config profile fallbacks, giving
        /// the per-client option top precedence over the environment and profile sources.
        /// </summary>
        public static DateTime GetCorrectedUtcNowForEndpoint(string endpoint, IClientConfig clientConfig)
        {
            TimeSpan adjustment = TimeSpan.Zero;

            manualClockCorrectionLock.EnterReadLock();
            try
            {
                if (manualClockCorrection != null)
                    adjustment = manualClockCorrection.Value;
            }
            finally
            {
                manualClockCorrectionLock.ExitReadLock();
            }

            if (AWSConfigs.CorrectForClockSkew && adjustment == TimeSpan.Zero
                && !(clientConfig != null && clientConfig.DisableClockSkewCorrection))
            {
                adjustment = GetClockCorrectionForEndpoint(endpoint);
            }

            return AWSConfigs.utcNowSource() + adjustment;
        }

        internal static void SetClockCorrectionForEndpoint(string endpoint, TimeSpan correction)
        {
            clockCorrectionDictionary[endpoint] = correction;
        }
    }
}
