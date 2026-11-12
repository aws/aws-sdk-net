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
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.HttpClientTests
{
    /// <summary>
    /// Tests for AWS_CA_BUNDLE support. The certificates are generated per test run, so no certificate files are checked in.
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    public class CABundleTests
    {
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
            using (var root1 = CreateCertificateAuthority("CN=Root 1"))
            using (var root2 = CreateCertificateAuthority("CN=Root 2"))
            {
                var pem = ToPem(root1) +
                          "-----BEGIN PRIVATE KEY-----\nAAAA\n-----END PRIVATE KEY-----\n" +
                          ToPem(root2);
                var path = WriteFile("bundle.pem", pem);

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
            using (var root = CreateCertificateAuthority("CN=Test Root"))
            using (var leaf = CreateServerCertificate(root))
            {
                var bundle = LoadBundle(root);

                Assert.IsTrue(bundle.ValidateServerCertificate(null, leaf, null, SslPolicyErrors.RemoteCertificateChainErrors));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafIssuedByIntermediateSentByServer_Accepted()
        {
            using (var root = CreateCertificateAuthority("CN=Test Root"))
            using (var intermediate = CreateCertificateAuthority("CN=Test Intermediate", root))
            using (var leaf = CreateServerCertificate(intermediate))
            using (var platformChain = new X509Chain())
            {
                // Simulates the chain the platform built from the certificates the server sent.
                platformChain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                platformChain.ChainPolicy.ExtraStore.Add(intermediate);
                platformChain.Build(leaf);

                var bundle = LoadBundle(root);

                Assert.IsTrue(bundle.ValidateServerCertificate(null, leaf, platformChain, SslPolicyErrors.RemoteCertificateChainErrors));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafIssuedByOtherCA_Rejected()
        {
            using (var trustedRoot = CreateCertificateAuthority("CN=Trusted Root"))
            using (var otherRoot = CreateCertificateAuthority("CN=Other Root"))
            using (var leaf = CreateServerCertificate(otherRoot))
            {
                var bundle = LoadBundle(trustedRoot);

                Assert.IsFalse(bundle.ValidateServerCertificate(null, leaf, null, SslPolicyErrors.RemoteCertificateChainErrors));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_NameMismatch_Rejected()
        {
            using (var root = CreateCertificateAuthority("CN=Test Root"))
            using (var leaf = CreateServerCertificate(root))
            {
                var bundle = LoadBundle(root);

                Assert.IsFalse(bundle.ValidateServerCertificate(null, leaf, null, SslPolicyErrors.RemoteCertificateNameMismatch));
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_ExpiredLeaf_Rejected()
        {
            using (var root = CreateCertificateAuthority("CN=Test Root"))
            using (var leaf = CreateServerCertificate(root, DateTimeOffset.UtcNow.AddDays(-2), DateTimeOffset.UtcNow.AddDays(-1)))
            {
                var bundle = LoadBundle(root);

                Assert.IsFalse(bundle.ValidateServerCertificate(null, leaf, null, SslPolicyErrors.RemoteCertificateChainErrors));
            }
        }

        [TestMethod]
        public async Task ServiceClient_UsesCABundleFromEnvironment()
        {
            using (var root = CreateCertificateAuthority("CN=Emulator Root"))
            using (var leaf = CreateServerCertificate(root))
            using (var server = new LoopbackTlsServer(leaf))
            {
                // Without the bundle the emulator's certificate isn't trusted.
                await AssertTlsTrustFailureAsync(server.Port);

                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, WriteFile("emulator.pem", ToPem(root)));
                using (var s3Client = CreateS3Client(server.Port))
                {
                    var response = await s3Client.ListBucketsAsync();
                    Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                }
            }
        }

        [TestMethod]
        public void ValidateServerCertificate_LeafNotValidForServerAuthentication_Rejected()
        {
            using (var root = CreateCertificateAuthority("CN=Test Root"))
            using (var leaf = CreateServerCertificate(root, ClientAuthenticationOid))
            {
                var bundle = LoadBundle(root);

                Assert.IsFalse(bundle.ValidateServerCertificate(null, leaf, null, SslPolicyErrors.RemoteCertificateChainErrors));
            }
        }

        [TestMethod]
        public async Task ServiceClient_LeafNotValidForServerAuthentication_RejectsServer()
        {
            using (var root = CreateCertificateAuthority("CN=Emulator Root"))
            using (var leaf = CreateServerCertificate(root, ClientAuthenticationOid))
            using (var server = new LoopbackTlsServer(leaf))
            {
                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, WriteFile("emulator.pem", ToPem(root)));

                await AssertTlsTrustFailureAsync(server.Port);
            }
        }

        [TestMethod]
        public async Task ServiceClient_CABundleWithOtherCA_RejectsServer()
        {
            using (var serverRoot = CreateCertificateAuthority("CN=Emulator Root"))
            using (var otherRoot = CreateCertificateAuthority("CN=Other Root"))
            using (var leaf = CreateServerCertificate(serverRoot))
            using (var server = new LoopbackTlsServer(leaf))
            {
                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, WriteFile("other.pem", ToPem(otherRoot)));

                await AssertTlsTrustFailureAsync(server.Port);
            }
        }

        [TestMethod]
        public async Task ServiceClient_InvalidCABundle_FailsRequest()
        {
            using (var root = CreateCertificateAuthority("CN=Emulator Root"))
            using (var leaf = CreateServerCertificate(root))
            using (var server = new LoopbackTlsServer(leaf))
            {
                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, Path.Combine(_tempDirectory, "missing.pem"));

                using (var s3Client = CreateS3Client(server.Port))
                {
                    var exception = await CaptureExceptionAsync(() => s3Client.ListBucketsAsync());
                    Assert.IsTrue(FindInChain<AmazonClientException>(exception)?.Message.Contains(CABundle.EnvironmentVariableName) == true,
                        "Expected an AmazonClientException naming the environment variable, got: " + exception);
                }
            }
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public async Task ServiceClient_ServerSendsIntermediate_Accepted()
        {
            using (var root = CreateCertificateAuthority("CN=Emulator Root"))
            using (var intermediate = CreateCertificateAuthority("CN=Emulator Intermediate", root))
            using (var leaf = CreateServerCertificate(intermediate))
            using (var server = new LoopbackTlsServer(leaf, intermediate))
            {
                // Only the root is in the bundle; the intermediate must come from the TLS handshake.
                Environment.SetEnvironmentVariable(CABundle.EnvironmentVariableName, WriteFile("root.pem", ToPem(root)));
                using (var s3Client = CreateS3Client(server.Port))
                {
                    var response = await s3Client.ListBucketsAsync();
                    Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                }
            }
        }
#endif

        private async Task AssertTlsTrustFailureAsync(int port)
        {
            using (var s3Client = CreateS3Client(port))
            {
                var exception = await CaptureExceptionAsync(() => s3Client.ListBucketsAsync());
                Assert.IsNotNull(FindInChain<AuthenticationException>(exception),
                    "Expected the TLS handshake to fail certificate validation, got: " + exception);
            }
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

        private static async Task<Exception> CaptureExceptionAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception e)
            {
                return e;
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

        private CABundle LoadBundle(X509Certificate2 certificate)
        {
            return CABundle.Load(WriteFile(Guid.NewGuid().ToString("N") + ".pem", ToPem(certificate)));
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

        private static X509Certificate2 CreateCertificateAuthority(string subject, X509Certificate2 issuer = null)
        {
            using (var key = RSA.Create(2048))
            {
                var request = new CertificateRequest(subject, key, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, true));
                request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.CrlSign, true));
                request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

                // Backdated so test leaves can be issued with validity periods in the past (expired certificates).
                var notBefore = DateTimeOffset.UtcNow.AddDays(-7);
                var notAfter = DateTimeOffset.UtcNow.AddDays(30);
                if (issuer == null)
                {
                    return request.CreateSelfSigned(notBefore, notAfter);
                }

                using (var signed = request.Create(issuer, notBefore, notAfter, CreateSerialNumber()))
                {
                    return signed.CopyWithPrivateKey(key);
                }
            }
        }

        private const string ServerAuthenticationOid = "1.3.6.1.5.5.7.3.1";
        private const string ClientAuthenticationOid = "1.3.6.1.5.5.7.3.2";

        private static X509Certificate2 CreateServerCertificate(X509Certificate2 issuer, string extendedKeyUsageOid = ServerAuthenticationOid)
        {
            return CreateServerCertificate(issuer, DateTimeOffset.UtcNow.AddDays(-1), DateTimeOffset.UtcNow.AddDays(7), extendedKeyUsageOid);
        }

        private static X509Certificate2 CreateServerCertificate(X509Certificate2 issuer, DateTimeOffset notBefore, DateTimeOffset notAfter,
            string extendedKeyUsageOid = ServerAuthenticationOid)
        {
            using (var key = RSA.Create(2048))
            {
                var request = new CertificateRequest("CN=localhost", key, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
                request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.KeyEncipherment, true));
                request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(
                    new OidCollection { new Oid(extendedKeyUsageOid) }, false));
                var san = new SubjectAlternativeNameBuilder();
                san.AddDnsName("localhost");
                san.AddIpAddress(IPAddress.Loopback);
                request.CertificateExtensions.Add(san.Build());

                using (var signed = request.Create(issuer, notBefore, notAfter, CreateSerialNumber()))
                using (var withKey = signed.CopyWithPrivateKey(key))
                {
                    // Round trip through PFX so the private key is usable by SslStream on every platform (Windows needs
                    // a key that isn't ephemeral).
                    var pfx = withKey.Export(X509ContentType.Pfx);
#if NET9_0_OR_GREATER
                    return X509CertificateLoader.LoadPkcs12(pfx, null, X509KeyStorageFlags.Exportable);
#else
                    return new X509Certificate2(pfx, (string)null, X509KeyStorageFlags.Exportable);
#endif
                }
            }
        }

        private static byte[] CreateSerialNumber()
        {
            var serial = new byte[8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(serial);
            }
            serial[0] &= 0x7F; // Keep the serial number positive.
            return serial;
        }

        /// <summary>
        /// A minimal HTTPS server on loopback that answers every request with an empty S3 ListBuckets response.
        /// </summary>
        private sealed class LoopbackTlsServer : IDisposable
        {
            private const string ListBucketsResponse =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<ListAllMyBucketsResult xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">" +
                "<Owner><ID>owner</ID></Owner><Buckets></Buckets></ListAllMyBucketsResult>";

            private readonly TcpListener _listener;
            private readonly X509Certificate2 _certificate;
            private readonly X509Certificate2 _intermediate;
            private readonly CancellationTokenSource _cancellation = new CancellationTokenSource();

            public LoopbackTlsServer(X509Certificate2 certificate, X509Certificate2 intermediate = null)
            {
                _certificate = certificate;
                _intermediate = intermediate;
                _listener = new TcpListener(IPAddress.Loopback, 0);
                _listener.Start();
                Port = ((IPEndPoint)_listener.LocalEndpoint).Port;
                _ = AcceptLoopAsync();
            }

            public int Port { get; }

            private async Task AcceptLoopAsync()
            {
                while (!_cancellation.IsCancellationRequested)
                {
                    TcpClient client;
                    try
                    {
                        client = await _listener.AcceptTcpClientAsync();
                    }
                    catch (Exception) when (_cancellation.IsCancellationRequested)
                    {
                        return;
                    }

                    _ = HandleClientAsync(client);
                }
            }

            private async Task HandleClientAsync(TcpClient client)
            {
                using (client)
                using (var sslStream = new SslStream(client.GetStream(), false))
                {
                    try
                    {
#if NET8_0_OR_GREATER
                        var options = new SslServerAuthenticationOptions
                        {
                            ServerCertificateContext = SslStreamCertificateContext.Create(_certificate,
                                _intermediate == null ? null : new X509Certificate2Collection(_intermediate), offline: true)
                        };
                        await sslStream.AuthenticateAsServerAsync(options, _cancellation.Token);
#else
                        await sslStream.AuthenticateAsServerAsync(_certificate);
#endif
                        // Connection: close keeps each request on its own connection, so reading up to the end of the
                        // headers is enough. ListBuckets requests have no body.
                        await ReadRequestHeadersAsync(sslStream);

                        var body = Encoding.UTF8.GetBytes(ListBucketsResponse);
                        var headers = Encoding.ASCII.GetBytes(
                            "HTTP/1.1 200 OK\r\n" +
                            "Content-Type: application/xml\r\n" +
                            $"Content-Length: {body.Length}\r\n" +
                            "Connection: close\r\n\r\n");
                        await sslStream.WriteAsync(headers, 0, headers.Length);
                        await sslStream.WriteAsync(body, 0, body.Length);
                        await sslStream.FlushAsync();
                    }
                    catch (Exception)
                    {
                        // Expected when the client rejects the certificate and aborts the handshake.
                    }
                }
            }

            private static async Task ReadRequestHeadersAsync(Stream stream)
            {
                var buffer = new byte[1];
                var matched = 0;
                var terminator = new byte[] { (byte)'\r', (byte)'\n', (byte)'\r', (byte)'\n' };
                while (matched < terminator.Length)
                {
                    if (await stream.ReadAsync(buffer, 0, 1) == 0)
                    {
                        throw new IOException("Connection closed before the request headers were received.");
                    }

                    matched = buffer[0] == terminator[matched] ? matched + 1 : (buffer[0] == terminator[0] ? 1 : 0);
                }
            }

            public void Dispose()
            {
                _cancellation.Cancel();
                _listener.Stop();
                _cancellation.Dispose();
            }
        }
    }
}
