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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Process credential provider unit tests.
    /// </summary>
    [TestClass]
    public class ProcessAWSCredentialsTest
    {
        private const string ArgumentsSession = "Session";
        private const int InvalidVersionNumber = 2;
        private const string ExitKey = "Exit";
        private static readonly string ProjectPath =
            Regex.Match(Directory.GetCurrentDirectory(), @"^.*?(?=\\bin\\)").Captures[0].Value;
        public static readonly string ActualSecretKey = "SecretKey";
        public static readonly string ActualAccessKey = "AccessKey";
        public static readonly string ArgumentsBasic = "Basic";
        public const int ValidVersionNumber = 1;
        public static readonly string Executable = Path.Combine(ProjectPath, @"Custom\Util\linux-credentials-script.sh");

        static ProcessAWSCredentialsTest()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Executable = $@"{ProjectPath}\Custom\Util\windows-credentials-script.bat";
            }
        }

        [TestMethod]
        public void ValidBasicProcessCredentialInput()
        {
            var processCredential = new ProcessAWSCredentials($"{Executable} {ArgumentsBasic} {ValidVersionNumber}");
            var credentialsRefreshState = processCredential.DetermineProcessCredential();
            Assert.AreEqual(DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Utc), credentialsRefreshState.Expiration);
            Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
            Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
            Assert.IsTrue(string.IsNullOrEmpty(credentialsRefreshState.Credentials.Token));
        }
#if BCL
        [TestMethod]
        public async Task ValidBasicProcessCredentialInputAsync()
        {
            var processCredential = new ProcessAWSCredentials($"{Executable} {ArgumentsBasic} {ValidVersionNumber}");
            var credentialsRefreshState = await processCredential.DetermineProcessCredentialAsync().ConfigureAwait(false);
            Assert.AreEqual(DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Utc), credentialsRefreshState.Expiration);
            Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
            Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
            Assert.IsTrue(string.IsNullOrEmpty(credentialsRefreshState.Credentials.Token));
        }
        
        [TestMethod]
        public void ErrorExitCode()
        {
            Assert.ThrowsExactlyAsync<ProcessAWSCredentialException>(async () =>
                await new ProcessAWSCredentials($"{Executable} {ExitKey} ").DetermineProcessCredentialAsync());
        }
#endif
        [TestMethod]
        public void ValidSessionProcessCredentialInput()
        {
            var processCredential = new ProcessAWSCredentials($"{Executable} {ArgumentsSession} {ValidVersionNumber}");
            var credentialsRefreshState = processCredential.DetermineProcessCredential();
            Assert.AreNotEqual(DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Utc), credentialsRefreshState.Expiration);
            Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
            Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
            Assert.IsNotNull(credentialsRefreshState.Credentials.Token);
        }

        /// <summary>
        /// The test validates the credential refresh logic for session credentials.
        /// The executable generates mock creds and Guid tokens with an expiration of
        /// 1 min. Hence a delay of 1 min is added to allow successful credential refresh.
        /// </summary>
        [TestMethod]
        public void ValidateCredentialRefresh()
        {
            var processCredential = new ProcessAWSCredentials($"{Executable} {ArgumentsSession} {ValidVersionNumber}");
            var credentialsRefreshState = processCredential.DetermineProcessCredential();
            var oldToken = credentialsRefreshState.Credentials.Token;
            
            Thread.Sleep(TimeSpan.FromSeconds(60));
            
            credentialsRefreshState = processCredential.DetermineProcessCredential();
            Assert.AreNotEqual(oldToken, credentialsRefreshState.Credentials.Token);
        }
        [TestMethod]
        public void NoCredentialProcessConfigured()
        {
            Assert.ThrowsExactly<ProcessAWSCredentialException>(() =>
                new ProcessAWSCredentials(string.Empty).DetermineProcessCredential());
        }

        [TestMethod]
        public void InvalidCredentialProcessConfigured()
        {
            Assert.ThrowsExactly<ProcessAWSCredentialException>(() =>
                new ProcessAWSCredentials("foobar").DetermineProcessCredential());
        }

        [TestMethod]
        public void InvalidVersionNumberTest()
        {
            Assert.ThrowsExactly<ProcessAWSCredentialException>(() =>
                new ProcessAWSCredentials($"{Executable} {ArgumentsSession} {InvalidVersionNumber}").DetermineProcessCredential());
        }
        
        [TestMethod]
        public void NoVersionNumberSpecifiedTest()
        {
            Assert.ThrowsExactly<ProcessAWSCredentialException>(() =>
                new ProcessAWSCredentials($"{Executable} {ArgumentsSession}").DetermineProcessCredential());
        }

#if NETFRAMEWORK
        [TestMethod]
        public void ValidateRequiredFieldsCheck()
        {
            try
            {
                new ProcessAWSCredentials($"{Executable} \"Junk\" {ValidVersionNumber}").DetermineProcessCredential();
            }
            catch (ProcessAWSCredentialException proc)
            {
                Assert.AreEqual("System.ArgumentNullException", proc.InnerException.GetType().FullName);
                Assert.IsTrue(proc.InnerException.ToString().Contains("System.ArgumentNullException: Value cannot be null.\r\nParameter name: awsAccessKeyId\r\n"));
            }
        }
#endif

        [TestMethod]
        public void QuotedExecutablePathWithSpaces()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return;
            }

            var dirWithSpace = Path.Combine(Path.GetTempPath(), $"aws sdk test {Guid.NewGuid():N}");
            Directory.CreateDirectory(dirWithSpace);

            try
            {
                var scriptCopy = Path.Combine(dirWithSpace, "windows-credentials-script.bat");
                File.Copy(Executable, scriptCopy, overwrite: true);

                var processCredential = new ProcessAWSCredentials(
                    $"\"{scriptCopy}\" {ArgumentsBasic} {ValidVersionNumber}");
                var credentialsRefreshState = processCredential.DetermineProcessCredential();
                Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
                Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
            }
            finally
            {
                Directory.Delete(dirWithSpace, recursive: true);
            }
        }

        [TestMethod]
        public void UnquotedExecutablePathWithoutSpaces()
        {
            var processCredential = new ProcessAWSCredentials(
                $"{Executable} {ArgumentsBasic} {ValidVersionNumber}");
            var credentialsRefreshState = processCredential.DetermineProcessCredential();
            Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
            Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
        }


        [TestMethod]
        public void QuotedExecutablePathWithMultipleArguments()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return;
            }

            var dirWithSpace = Path.Combine(Path.GetTempPath(), $"aws sdk test {Guid.NewGuid():N}");
            Directory.CreateDirectory(dirWithSpace);

            try
            {
                var scriptCopy = Path.Combine(dirWithSpace, "windows-credentials-script.bat");
                File.Copy(Executable, scriptCopy, overwrite: true);

                var processCredential = new ProcessAWSCredentials(
                    $"\"{scriptCopy}\" {ArgumentsSession} {ValidVersionNumber}");
                var credentialsRefreshState = processCredential.DetermineProcessCredential();
                Assert.AreEqual(ActualAccessKey, credentialsRefreshState.Credentials.AccessKey);
                Assert.AreEqual(ActualSecretKey, credentialsRefreshState.Credentials.SecretKey);
                Assert.IsNotNull(credentialsRefreshState.Credentials.Token);
            }
            finally
            {
                Directory.Delete(dirWithSpace, recursive: true);
            }
        }

        [TestMethod]
        public void UnmatchedDoubleQuoteThrows()
        {
            Assert.ThrowsExactly<ProcessAWSCredentialException>(() =>
                new ProcessAWSCredentials("\"C:\\Program Files\\foo.exe").DetermineProcessCredential());
        }

    }
}