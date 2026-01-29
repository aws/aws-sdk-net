using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class PreemptExpiryTests
    {
        [DataTestMethod]
        [DataRow(900, 5)]
        [DataRow(1199, 5)]
        [DataRow(1201, 15)]
        [DataRow(3600, 15)]
        public void Test_CorrectPreemptTime_IsUsedForDuration(int durationInSeconds, int expectedExpiryInMinutes)
        {
            var source = new BasicAWSCredentials("foo", "bar");
            var assumeRole = new AssumeRoleAWSCredentials(
                source,
                "arn:aws:iam::123456789012:role/demo",
                "sessionName",
                new AssumeRoleAWSCredentialsOptions
                {
                    DurationSeconds = durationInSeconds
                }
            );
            Assert.AreEqual(expectedExpiryInMinutes, assumeRole.PreemptExpiryTime.TotalMinutes);

            var testPath = Path.Combine(Path.GetTempPath(), "webIdentityTokenFile");
            var assumeRoleWebIdentity = new AssumeRoleWithWebIdentityCredentials(
                testPath,
                "arn:aws:iam::123456789012:role/demo",
                "sessionName",
                new AssumeRoleWithWebIdentityCredentialsOptions
                {
                    DurationSeconds = durationInSeconds
                }
            );
            Assert.AreEqual(expectedExpiryInMinutes, assumeRoleWebIdentity.PreemptExpiryTime.TotalMinutes);
        }
    }
}
