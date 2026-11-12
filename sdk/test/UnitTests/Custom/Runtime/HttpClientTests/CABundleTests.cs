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

// CertificateRequest, SubjectAlternativeNameBuilder and RSA.Create(int) aren't in .NET Standard 2.0. The netstandard2.0
// test target is only compiled, never run, so these tests are limited to the targets that run them.
#if NETFRAMEWORK || NET8_0_OR_GREATER
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.HttpClientTests
{
    /// <summary>
    /// Tests for AWS_CA_BUNDLE support. The certificates are generated per test run, so no certificate files are checked in.
    /// The certificate validation rules are tested directly against <see cref="CABundle.ValidateServerCertificate"/>;
    /// the service client tests only check that the SDK applies the bundle to the HTTP clients it creates.
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    public class CABundleTests
    {
        private const string ServerAuthenticationOid = "1.3.6.1.5.5.7.3.1";
        private const string ClientAuthenticationOid = "1.3.6.1.5.5.7.3.2";

        private string _tempDirectory;

        [TestInitialize]
        public void Initialize()
        {
            _tempDirectory = Path.Combine(Path.GetTempPath(), "CABundleTests-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_tempDirectory);
            Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, null);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, null);
            Directory.Delete(_tempDirectory, true);
        }

        [TestMethod]
        public void Load_ReadsEveryCertificateAndIgnoresOtherPemBlocks()
        {
            using (var root1 = CreateCertificate("CN=Root 1", isCertificateAuthority: true))
            using (var root2 = CreateCertificate("CN=Root 2", isCertificateAuthority: true))
            {
                var path = WriteFile("bundle.pem", ToPem(root1) + "-----BEGIN PUBLIC KEY-----\nAAAA\n-----END PUBLIC KEY-----\n" + ToPem(root2));

                var bundle = CABundle.Load(path);

                Assert.AreEqual(2, bundle.Certificates.Count);
                Assert.AreEqual(root1.Thumbprint, bundle.Certificates[0].Thumbprint);
                Assert.AreEqual(root2.Thumbprint, bundle.Certificates[1].Thumbprint);
            }
        }

        [TestMethod]
        public void Load_MissingFile_Throws()
        {
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => CABundle.Load(Path.Combine(_tempDirectory, "missing.pem")));
            StringAssert.Contains(exception.Message, CABundle.EnvironmentVariableName);
        }

        [TestMethod]
        public void Load_FileWithoutCertificates_Throws()
        {
            var path = WriteFile("empty.pem", "not a certificate");

            var exception = Assert.ThrowsExactly<AmazonClientException>(() => CABundle.Load(path));
            StringAssert.Contains(exception.Message, "contains no PEM encoded certificates");
        }

        [TestMethod]
        public void FromEnvironment_NotSet_ReturnsNull()
        {
            Assert.IsNull(CABundle.FromEnvironment());
        }

        [TestMethod]
        public void FromEnvironment_InvalidFile_FailsClosed()
        {
            Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, Path.Combine(_tempDirectory, "missing.pem"));

            Assert.ThrowsExactly<AmazonClientException>(() => CABundle.FromEnvironment());
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafIssuedByBundleRoot_Accepted()
        {
            using (var root = CreateCertificate("CN=Test Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root))
            {
                Assert.IsTrue(Validate(root, leaf));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafIssuedByIntermediateSentByServer_Accepted()
        {
            using (var root = CreateCertificate("CN=Test Root", isCertificateAuthority: true))
            using (var intermediate = CreateCertificate("CN=Test Intermediate", root, isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", intermediate))
            using (var platformChain = new X509Chain())
            {
                // Simulates the chain the platform built from the certificates the server sent.
                platformChain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                platformChain.ChainPolicy.ExtraStore.Add(intermediate);
                platformChain.Build(leaf);

                Assert.IsTrue(Validate(root, leaf, platformChain));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafIssuedByOtherCA_Rejected()
        {
            using (var trustedRoot = CreateCertificate("CN=Trusted Root", isCertificateAuthority: true))
            using (var otherRoot = CreateCertificate("CN=Other Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", otherRoot))
            {
                Assert.IsFalse(Validate(trustedRoot, leaf));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_NameMismatch_Rejected()
        {
            using (var root = CreateCertificate("CN=Test Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root))
            {
                Assert.IsFalse(Validate(root, leaf, sslPolicyErrors: SslPolicyErrors.RemoteCertificateNameMismatch));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_ExpiredLeaf_Rejected()
        {
            using (var root = CreateCertificate("CN=Test Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root, notAfter: DateTimeOffset.UtcNow.AddDays(-1)))
            {
                Assert.IsFalse(Validate(root, leaf));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafNotValidForServerAuthentication_Rejected()
        {
            using (var root = CreateCertificate("CN=Test Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root, extendedKeyUsageOid: ClientAuthenticationOid))
            {
                Assert.IsFalse(Validate(root, leaf));
            }
        }

        [TestMethod]
        public async Task ServiceClient_UsesCABundleFromEnvironment()
        {
            using (var root = CreateCertificate("CN=Emulator Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root))
            using (var server = new LoopbackTlsServer(leaf))
            {
                // Without the bundle the server's certificate isn't trusted.
                var exception = await PutBucketExpectingFailureAsync(server.Port);
                Assert.IsNotNull(FindInChain<AuthenticationException>(exception), "Expected a TLS trust failure, got: " + exception);

                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, WriteFile("emulator.pem", ToPem(root)));
                using (var s3Client = CreateS3Client(server.Port))
                {
                    var response = await s3Client.PutBucketAsync("test-bucket");
                    Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                }
            }
        }

        [TestMethod]
        public async Task ServiceClient_InvalidCABundle_FailsRequest()
        {
            using (var root = CreateCertificate("CN=Emulator Root", isCertificateAuthority: true))
            using (var leaf = CreateCertificate("CN=localhost", root))
            using (var server = new LoopbackTlsServer(leaf))
            {
                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, Path.Combine(_tempDirectory, "missing.pem"));

                var exception = await PutBucketExpectingFailureAsync(server.Port);
                Assert.IsTrue(FindInChain<AmazonClientException>(exception)?.Message.Contains(CABundle.EnvironmentVariableName) == true,
                    "Expected an AmazonClientException naming the environment variable, got: " + exception);
            }
        }

        private bool Validate(X509Certificate2 bundleCertificate, X509Certificate2 serverCertificate, X509Chain platformChain = null,
            SslPolicyErrors sslPolicyErrors = SslPolicyErrors.RemoteCertificateChainErrors)
        {
            var bundle = CABundle.Load(WriteFile(Guid.NewGuid().ToString("N") + ".pem", ToPem(bundleCertificate)));
            return bundle.ValidateServerCertificate(null, serverCertificate, platformChain, sslPolicyErrors);
        }

        private static AmazonS3Client CreateS3Client(int port)
        {
            return new AmazonS3Client(new AnonymousAWSCredentials(), new AmazonS3Config
            {
                ServiceURL = $"https://localhost:{port}",
                AuthenticationRegion = "us-east-1",
                ForcePathStyle = true,
                MaxErrorRetry = 0
            });
        }

        private static async Task<Exception> PutBucketExpectingFailureAsync(int port)
        {
            using (var s3Client = CreateS3Client(port))
            {
                try
                {
                    await s3Client.PutBucketAsync("test-bucket");
                }
                catch (Exception e)
                {
                    return e;
                }
            }

            Assert.Fail("Expected the request to fail.");
            return null;
        }

        private static T FindInChain<T>(Exception exception) where T : Exception
        {
            for (var current = exception; current != null; current = current.InnerException)
            {
                if (current is T match)
                {
                    return match;
                }
            }

            return null;
        }

        private string WriteFile(string name, string contents)
        {
            var path = Path.Combine(_tempDirectory, name);
            File.WriteAllText(path, contents);
            return path;
        }

        private static string ToPem(X509Certificate2 certificate)
        {
            return "-----BEGIN CERTIFICATE-----\n" +
                   Convert.ToBase64String(certificate.RawData, Base64FormattingOptions.InsertLineBreaks) +
                   "\n-----END CERTIFICATE-----\n";
        }

        /// <summary>
        /// Creates a certificate with its private key. With no issuer the certificate is self-signed. Leaf certificates
        /// are issued for localhost with the given extended key usage.
        /// </summary>
        private static X509Certificate2 CreateCertificate(string subject, X509Certificate2 issuer = null, bool isCertificateAuthority = false,
            DateTimeOffset? notAfter = null, string extendedKeyUsageOid = ServerAuthenticationOid)
        {
            using (var key = RSA.Create(2048))
            {
                var request = new CertificateRequest(subject, key, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                request.CertificateExtensions.Add(new X509BasicConstraintsExtension(isCertificateAuthority, false, 0, true));
                if (!isCertificateAuthority)
                {
                    request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid(extendedKeyUsageOid) }, false));
                    var san = new SubjectAlternativeNameBuilder();
                    san.AddDnsName("localhost");
                    request.CertificateExtensions.Add(san.Build());
                }

                // Backdated so a leaf can be issued with a validity period entirely in the past (an expired certificate).
                var notBefore = DateTimeOffset.UtcNow.AddDays(-7);
                var validUntil = notAfter ?? DateTimeOffset.UtcNow.AddDays(isCertificateAuthority ? 30 : 7);
                if (issuer == null)
                {
                    return request.CreateSelfSigned(notBefore, validUntil);
                }

                // A certificate can't outlive its issuer. Without the cap, an intermediate created just after its root
                // could end a second later than the root and be rejected by CertificateRequest.Create.
                if (validUntil > issuer.NotAfter)
                {
                    validUntil = issuer.NotAfter;
                }

                using (var certificate = request.Create(issuer, notBefore, validUntil, Guid.NewGuid().ToByteArray()))
                {
                    return certificate.CopyWithPrivateKey(key);
                }
            }
        }

        /// <summary>
        /// A minimal HTTPS server on loopback that answers every request with an empty 200 response.
        /// </summary>
        private sealed class LoopbackTlsServer : IDisposable
        {
            private readonly TcpListener _listener = new TcpListener(IPAddress.Loopback, 0);
            private readonly X509Certificate2 _certificate;

            public LoopbackTlsServer(X509Certificate2 certificate)
            {
                // Round trip through PFX because Windows SslStream can't use the ephemeral key CertificateRequest creates.
                var pfx = certificate.Export(X509ContentType.Pfx);
#if NET9_0_OR_GREATER
                _certificate = X509CertificateLoader.LoadPkcs12(pfx, null);
#else
                _certificate = new X509Certificate2(pfx);
#endif
                _listener.Start();
                _ = AcceptLoopAsync();
            }

            public int Port => ((IPEndPoint)_listener.LocalEndpoint).Port;

            private async Task AcceptLoopAsync()
            {
                while (true)
                {
                    TcpClient client;
                    try
                    {
                        client = await _listener.AcceptTcpClientAsync();
                    }
                    catch (Exception)
                    {
                        return; // The listener was stopped.
                    }

                    _ = RespondAsync(client);
                }
            }

            private async Task RespondAsync(TcpClient client)
            {
                using (client)
                using (var sslStream = new SslStream(client.GetStream()))
                {
                    try
                    {
                        await sslStream.AuthenticateAsServerAsync(_certificate);

                        // Skip the request headers. The response closes the connection, so the request body isn't needed.
                        var reader = new StreamReader(sslStream);
                        while (!string.IsNullOrEmpty(await reader.ReadLineAsync()))
                        {
                        }

                        var response = Encoding.ASCII.GetBytes("HTTP/1.1 200 OK\r\nContent-Length: 0\r\nConnection: close\r\n\r\n");
                        await sslStream.WriteAsync(response, 0, response.Length);
                    }
                    catch (Exception)
                    {
                        // Expected when the client rejects the certificate and aborts the handshake.
                    }
                }
            }

            public void Dispose()
            {
                _listener.Stop();
                _certificate.Dispose();
            }
        }
    }
}
#endif
