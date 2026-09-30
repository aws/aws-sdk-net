using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class PreemptExpiryTests
    {
        private const string TestRoleArn = "arn:aws:iam::123456789012:role/demo";

        // The advisory (preempt) window follows the lifetime of the credentials STS returns: a session of at most
        // 20 minutes gets a 5-minute window and a longer one (under 90 minutes) a 15-minute window. The window is
        // measured from the expiration STS reported.
        [TestMethod]
        [DataRow(900, 5)]
        [DataRow(1199, 5)]
        [DataRow(1200, 5)]
        [DataRow(1201, 15)]
        [DataRow(3600, 15)]
        public void Test_CorrectPreemptTime_IsUsedForDuration(int durationInSeconds, int expectedExpiryInMinutes)
        {
            var expectedWindow = TimeSpan.FromMinutes(expectedExpiryInMinutes);
            var sts = StsReturningSessionsOfRequestedDuration();

            GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient(sts.Object);
            try
            {
                var assumeRole = new InspectableAssumeRoleCredentials(
                    new BasicAWSCredentials("foo", "bar"),
                    new AssumeRoleAWSCredentialsOptions { DurationSeconds = durationInSeconds });
                assumeRole.GetCredentials();
                AssertAdvisoryWindow(expectedWindow, assumeRole.PreemptExpiryTime, assumeRole.State, "AssumeRoleAWSCredentials");
            }
            finally
            {
                // The registry cannot unregister; a factory that returns null restores the default lookup.
                GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient((RuntimeDependencyFactory)(context => null));
            }

            var tokenFile = Path.Combine(Path.GetTempPath(), "preempt-expiry-token-" + Guid.NewGuid().ToString("N") + ".jwt");
            File.WriteAllText(tokenFile, "web.identity.token");
            try
            {
                var webIdentity = new InspectableWebIdentityCredentials(tokenFile,
                    new AssumeRoleWithWebIdentityCredentialsOptions { DurationSeconds = durationInSeconds }, sts.Object);
                webIdentity.GetCredentials();
                AssertAdvisoryWindow(expectedWindow, webIdentity.PreemptExpiryTime, webIdentity.State, "AssumeRoleWithWebIdentityCredentials");
            }
            finally
            {
                File.Delete(tokenFile);
            }
        }

        // The constructors do not hard-code PreemptExpiryTime. Before the first fetch the lifetime is unknown, and the
        // lifetime table's value for an unknown lifetime is 5 minutes, whatever DurationSeconds is requested.
        [TestMethod]
        [DataRow(900)]
        [DataRow(1199)]
        [DataRow(1200)]
        [DataRow(1201)]
        [DataRow(3600)]
        public void PreemptExpiryTime_IsNoLongerHardCodedByConstructor(int durationInSeconds)
        {
            const double expectedDefaultMinutes = 5; // table default for an unknown (not-yet-fetched) lifetime

            var source = new BasicAWSCredentials("foo", "bar");
            var assumeRole = new AssumeRoleAWSCredentials(
                source,
                TestRoleArn,
                "sessionName",
                new AssumeRoleAWSCredentialsOptions
                {
                    DurationSeconds = durationInSeconds
                }
            );
            Assert.AreEqual(expectedDefaultMinutes, assumeRole.PreemptExpiryTime.TotalMinutes);

            var testPath = Path.Combine(Path.GetTempPath(), "webIdentityTokenFile");
            var assumeRoleWebIdentity = new AssumeRoleWithWebIdentityCredentials(
                testPath,
                TestRoleArn,
                "sessionName",
                new AssumeRoleWithWebIdentityCredentialsOptions
                {
                    DurationSeconds = durationInSeconds
                }
            );
            Assert.AreEqual(expectedDefaultMinutes, assumeRoleWebIdentity.PreemptExpiryTime.TotalMinutes);
        }

        [TestMethod]
        public void ExplicitPreemptExpiryTime_StillWins()
        {
            var source = new BasicAWSCredentials("foo", "bar");
            var assumeRole = new AssumeRoleAWSCredentials(
                source,
                TestRoleArn,
                "sessionName",
                new AssumeRoleAWSCredentialsOptions { DurationSeconds = 3600 })
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(42)
            };

            Assert.AreEqual(42, assumeRole.PreemptExpiryTime.TotalMinutes);
        }

        private static void AssertAdvisoryWindow(TimeSpan expectedWindow, TimeSpan preemptExpiryTime,
            RefreshingAWSCredentials.CredentialsRefreshState state, string provider)
        {
            Assert.AreEqual(expectedWindow, preemptExpiryTime, provider + ": PreemptExpiryTime reports the window chosen for the fetched credentials");
            Assert.AreEqual(state.RawExpiration - expectedWindow, state.AdvisoryRefreshAt,
                provider + ": the advisory refresh is scheduled the window's length before the expiration STS reported");
        }

        // STS issues credentials that last exactly the requested DurationSeconds, measured from the SDK's clock.
        private static Mock<ICoreAmazonSTS> StsReturningSessionsOfRequestedDuration()
        {
            var sts = new Mock<ICoreAmazonSTS>();
            sts.Setup(c => c.CredentialsFromAssumeRoleAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleAWSCredentialsOptions>()))
               .Returns((string roleArn, string sessionName, AssumeRoleAWSCredentialsOptions options) => Session(options.DurationSeconds.Value));
            sts.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
               .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) => Session(options.DurationSeconds.Value));
            return sts;
        }

        private static AssumeRoleImmutableCredentials Session(int durationSeconds)
            => new AssumeRoleImmutableCredentials("ASIASESSION", "secret", "token", AWSSDKUtils.CorrectedUtcNow.AddSeconds(durationSeconds));

        private sealed class InspectableAssumeRoleCredentials : AssumeRoleAWSCredentials
        {
            public InspectableAssumeRoleCredentials(AWSCredentials source, AssumeRoleAWSCredentialsOptions options)
                : base(source, TestRoleArn, "sessionName", options) { }

            public CredentialsRefreshState State => currentState;
        }

        private sealed class InspectableWebIdentityCredentials : AssumeRoleWithWebIdentityCredentials
        {
            private readonly ICoreAmazonSTS _sts;

            public InspectableWebIdentityCredentials(string tokenFile, AssumeRoleWithWebIdentityCredentialsOptions options, ICoreAmazonSTS sts)
                : base(tokenFile, TestRoleArn, "sessionName", options)
            {
                _sts = sts;
            }

            public CredentialsRefreshState State => currentState;

            protected override ICoreAmazonSTS CreateClient() => _sts;
        }
    }
}
