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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Configuration semantics for Clock Skew Correction: the global
    /// <see cref="AWSConfigs.CorrectForClockSkew"/> switch, the per-client
    /// <see cref="IClientConfig.DisableClockSkewCorrection"/> option, and their
    /// interaction (the enable/disable truth table) plus source precedence.
    ///
    /// These tests mutate process-global <see cref="AWSConfigs"/> state. Each test captures the
    /// prior values with <see cref="SaveClockState"/> and restores them in a finally via
    /// <see cref="RestoreClockState"/>, so the restore is guaranteed on any exception without
    /// depending on the MSTest TestInitialize/TestCleanup lifecycle (TestCleanup is skipped when
    /// TestInitialize throws). Each signing test uses a unique endpoint string so the process-global
    /// per-endpoint correction store is never shared across tests.
    /// </summary>
    [TestClass]
    public class ClockSkewCorrectionConfigTests
    {
        /// <summary>Snapshot of the process-global AWSConfigs state these tests mutate.</summary>
        private readonly struct SavedClockState
        {
            public readonly bool CorrectForClockSkew;
            public readonly TimeSpan? ManualClockCorrection;
            public readonly Func<DateTime> UtcNowSource;

            public SavedClockState(bool correctForClockSkew, TimeSpan? manualClockCorrection, Func<DateTime> utcNowSource)
            {
                CorrectForClockSkew = correctForClockSkew;
                ManualClockCorrection = manualClockCorrection;
                UtcNowSource = utcNowSource;
            }
        }

        /// <summary>Captures the current process-global clock state (does not mutate).</summary>
        private static SavedClockState SaveClockState() =>
            new SavedClockState(AWSConfigs.CorrectForClockSkew, AWSConfigs.ManualClockCorrection, AWSConfigs.utcNowSource);

        /// <summary>Restores a previously captured clock state. Call from a finally block.</summary>
        private static void RestoreClockState(SavedClockState saved)
        {
            AWSConfigs.CorrectForClockSkew = saved.CorrectForClockSkew;
            AWSConfigs.ManualClockCorrection = saved.ManualClockCorrection;
            AWSConfigs.utcNowSource = saved.UtcNowSource;
        }

        /// <summary>
        /// Correction is enabled only when CorrectForClockSkew is true AND the client's
        /// DisableClockSkewCorrection is false. Any other combination disables it.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void IsCorrectionEnabled_TruthTable()
        {
            var saved = SaveClockState();
            try
            {
                // Neutralize the orthogonal manual-correction override so this test isolates the
                // CorrectForClockSkew x DisableClockSkewCorrection matrix.
                AWSConfigs.ManualClockCorrection = null;

                // correctForClockSkew, disableOnClient, expectedEnabled
                var cases = new[]
                {
                    new { Correct = true,  Disable = false, Expected = true  },
                    new { Correct = true,  Disable = true,  Expected = false },
                    new { Correct = false, Disable = false, Expected = false },
                    new { Correct = false, Disable = true,  Expected = false },
                };

                foreach (var c in cases)
                {
                    AWSConfigs.CorrectForClockSkew = c.Correct;
                    var config = new MockClientConfig { DisableClockSkewCorrection = c.Disable };

                    Assert.AreEqual(
                        c.Expected,
                        ClockSkewPipelineHelper.IsCorrectionEnabled(config),
                        $"CorrectForClockSkew={c.Correct}, DisableClockSkewCorrection={c.Disable}");
                }
            }
            finally
            {
                RestoreClockState(saved);
            }
        }

        /// <summary>
        /// At signing, the endpoint-learned correction is applied to now() only when
        /// correction is enabled (CorrectForClockSkew true AND client not disabled).
        /// Otherwise the raw now() is returned unchanged.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Signing_AppliesEndpointCorrectionOnlyWhenEnabled()
        {
            var saved = SaveClockState();
            try
            {
                AWSConfigs.ManualClockCorrection = null;

                var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                var correction = TimeSpan.FromMinutes(10);
                AWSConfigs.utcNowSource = () => now;

                // (1) enabled: CorrectForClockSkew true + client not disabled => now + correction
                AWSConfigs.CorrectForClockSkew = true;
                var enabledEndpoint = "https://svc.clock-skew.test/enabled-" + Guid.NewGuid();
                CorrectClockSkew.SetClockCorrectionForEndpoint(enabledEndpoint, correction);
                var enabledConfig = new MockClientConfig { DisableClockSkewCorrection = false };
                Assert.AreEqual(
                    now + correction,
                    CorrectClockSkew.GetCorrectedUtcNowForEndpoint(enabledEndpoint, enabledConfig),
                    "Correction should be applied when enabled.");

                // (2) disabled on the client: CorrectForClockSkew true + client disabled => now
                var clientDisabledEndpoint = "https://svc.clock-skew.test/client-disabled-" + Guid.NewGuid();
                CorrectClockSkew.SetClockCorrectionForEndpoint(clientDisabledEndpoint, correction);
                var clientDisabledConfig = new MockClientConfig { DisableClockSkewCorrection = true };
                Assert.AreEqual(
                    now,
                    CorrectClockSkew.GetCorrectedUtcNowForEndpoint(clientDisabledEndpoint, clientDisabledConfig),
                    "Correction should be skipped when the client disables it.");

                // (3) disabled globally: CorrectForClockSkew false => now (regardless of client value)
                AWSConfigs.CorrectForClockSkew = false;
                var globalDisabledEndpoint = "https://svc.clock-skew.test/global-off-" + Guid.NewGuid();
                CorrectClockSkew.SetClockCorrectionForEndpoint(globalDisabledEndpoint, correction);
                Assert.AreEqual(
                    now,
                    CorrectClockSkew.GetCorrectedUtcNowForEndpoint(globalDisabledEndpoint, enabledConfig),
                    "Correction should be skipped when the global switch is off.");
            }
            finally
            {
                RestoreClockState(saved);
            }
        }

        /// <summary>
        /// An explicit per-client value is authoritative (top precedence). When the client
        /// value is not set, the property defers to the environment/profile fallback
        /// resolved by <see cref="FallbackInternalConfigurationFactory"/> (false when neither
        /// is configured, which is the unit-test default). This mirrors the UseDualstackEndpoint
        /// pattern: client config > environment variable > shared-config profile.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DisableClockSkewCorrection_ClientValueTakesPrecedenceOverFallback()
        {
            var saved = SaveClockState();
            try
            {
                AWSConfigs.ManualClockCorrection = null;

                var explicitlyDisabled = new MockClientConfig { DisableClockSkewCorrection = true };
                Assert.IsTrue(explicitlyDisabled.DisableClockSkewCorrection,
                    "An explicit true on the client must be honored.");

                var explicitlyEnabled = new MockClientConfig { DisableClockSkewCorrection = false };
                Assert.IsFalse(explicitlyEnabled.DisableClockSkewCorrection,
                    "An explicit false on the client must be honored.");

                var unset = new MockClientConfig();
                Assert.AreEqual(
                    FallbackInternalConfigurationFactory.DisableClockSkewCorrection ?? false,
                    unset.DisableClockSkewCorrection,
                    "When unset on the client, the property must fall back to env/profile resolution.");
            }
            finally
            {
                RestoreClockState(saved);
            }
        }
    }
}
