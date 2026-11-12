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

using Amazon.Runtime.Internal.Util;
using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// A set of CA certificates, loaded from a PEM file, that replaces the operating system's trust store
    /// when the SDK validates a server's TLS certificate. The file is located with the AWS_CA_BUNDLE
    /// environment variable, matching the behavior of the AWS CLI and other AWS SDKs.
    /// <para>
    /// The bundle only applies to HTTP clients the SDK creates itself. When a custom
    /// HttpClientFactory is configured on the client config, that factory owns certificate validation.
    /// </para>
    /// </summary>
    internal sealed class CABundle
    {
        /// <summary>
        /// The environment variable holding the path to the PEM CA bundle.
        /// </summary>
        public const string EnvironmentVariableName = "AWS_CA_BUNDLE";

#if !NET8_0_OR_GREATER
        private const string PemCertificateBegin = "-----BEGIN CERTIFICATE-----";
        private const string PemCertificateEnd = "-----END CERTIFICATE-----";
#endif

        // The most recently loaded bundle. The environment variable is read on every HTTP client creation
        // (and on every request for .NET Framework), so the parsed file is cached by path to avoid
        // re-reading it each time. Changes to the file's contents are not picked up while the path stays the same.
        private static readonly object _cacheLock = new object();
        private static CABundle _cachedBundle;

        private CABundle(string filePath, X509Certificate2Collection certificates)
        {
            FilePath = filePath;
            Certificates = certificates;
            RemoteCertificateValidationCallback = ValidateServerCertificate;
        }

        /// <summary>
        /// The path of the PEM file the certificates were loaded from.
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// The trusted CA certificates.
        /// </summary>
        public X509Certificate2Collection Certificates { get; }

        /// <summary>
        /// A single delegate instance for <see cref="ValidateServerCertificate"/>. .NET Framework includes the
        /// validation callback in the HttpWebRequest connection group, so reusing one instance keeps
        /// connections shared across requests.
        /// </summary>
        public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; }

        /// <summary>
        /// Returns the CA bundle configured by the AWS_CA_BUNDLE environment variable, or null when the variable is not set.
        /// </summary>
        /// <exception cref="AmazonClientException">
        /// The variable is set but the file can't be read or contains no certificates. The SDK fails closed rather than
        /// silently falling back to the operating system's trust store.
        /// </exception>
        public static CABundle FromEnvironment()
        {
            var filePath = Environment.GetEnvironmentVariable(EnvironmentVariableName);
            if (string.IsNullOrWhiteSpace(filePath))
            {
                return null;
            }

            lock (_cacheLock)
            {
                if (_cachedBundle == null || !string.Equals(_cachedBundle.FilePath, filePath, StringComparison.Ordinal))
                {
                    _cachedBundle = Load(filePath);
                    Logger.GetLogger(typeof(CABundle)).InfoFormat("Using the CA bundle {0} from the {1} environment variable to validate server certificates.",
                        filePath, EnvironmentVariableName);
                }

                return _cachedBundle;
            }
        }

        /// <summary>
        /// Loads the CA certificates from a PEM file. Blocks other than CERTIFICATE (for example private keys) are ignored.
        /// </summary>
        /// <exception cref="AmazonClientException">The file can't be read or contains no certificates.</exception>
        public static CABundle Load(string filePath)
        {
            X509Certificate2Collection certificates;
            try
            {
                certificates = ReadPemCertificates(filePath);
            }
            catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is CryptographicException ||
                                      e is FormatException || e is ArgumentException || e is NotSupportedException)
            {
                throw new AmazonClientException(
                    $"Unable to load the CA bundle '{filePath}' set by the {EnvironmentVariableName} environment variable: {e.Message}", e);
            }

            if (certificates.Count == 0)
            {
                throw new AmazonClientException(
                    $"The CA bundle '{filePath}' set by the {EnvironmentVariableName} environment variable contains no PEM encoded certificates.");
            }

            return new CABundle(filePath, certificates);
        }

        private static X509Certificate2Collection ReadPemCertificates(string filePath)
        {
            var certificates = new X509Certificate2Collection();
#if NET8_0_OR_GREATER
            certificates.ImportFromPemFile(filePath);
#else
            // ImportFromPemFile isn't available before .NET 5, so extract each CERTIFICATE block and decode its DER body.
            var pem = File.ReadAllText(filePath);
            var searchIndex = 0;
            int beginIndex;
            while ((beginIndex = pem.IndexOf(PemCertificateBegin, searchIndex, StringComparison.Ordinal)) >= 0)
            {
                var bodyIndex = beginIndex + PemCertificateBegin.Length;
                var endIndex = pem.IndexOf(PemCertificateEnd, bodyIndex, StringComparison.Ordinal);
                if (endIndex < 0)
                {
                    throw new FormatException($"A '{PemCertificateBegin}' block has no matching '{PemCertificateEnd}'.");
                }

                // Convert.FromBase64String skips the line breaks and other whitespace inside the block.
                var der = Convert.FromBase64String(pem.Substring(bodyIndex, endIndex - bodyIndex));
                certificates.Add(new X509Certificate2(der));
                searchIndex = endIndex + PemCertificateEnd.Length;
            }
#endif
            return certificates;
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Creates a chain policy that trusts only the bundle's certificates. Assigned to
        /// SocketsHttpHandler.SslOptions.CertificateChainPolicy so SslStream builds the chain itself; host name
        /// validation is unaffected.
        /// </summary>
        public X509ChainPolicy CreateChainPolicy()
        {
            var policy = new X509ChainPolicy
            {
                TrustMode = X509ChainTrustMode.CustomRootTrust,
                // Matches SslStream's default. CAs for emulators and private endpoints typically have no revocation endpoint.
                RevocationMode = X509RevocationMode.NoCheck
            };
            policy.CustomTrustStore.AddRange(Certificates);
            return policy;
        }
#endif

        /// <summary>
        /// Certificate validation callback for transports that can't be given a custom chain policy
        /// (HttpClientHandler before .NET 8 and HttpWebRequest on .NET Framework).
        /// The certificate is accepted when it chains, without any other error, to a root certificate in the bundle.
        /// The operating system's trust decision is ignored, so certificates trusted only by the OS are rejected.
        /// </summary>
        public bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // A missing certificate or a host name mismatch is never acceptable. Only the chain's trust is re-evaluated.
            if (certificate == null || (sslPolicyErrors & ~SslPolicyErrors.RemoteCertificateChainErrors) != SslPolicyErrors.None)
            {
                return false;
            }

            using (var serverCertificate = new X509Certificate2(certificate))
            using (var bundleChain = new X509Chain())
            {
                bundleChain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                // The bundle's roots usually aren't in the OS trust store. Allow the chain to end at an unknown root,
                // then require below that the root is one of the bundle's certificates.
                bundleChain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
                bundleChain.ChainPolicy.ExtraStore.AddRange(Certificates);

                // Intermediates sent by the server are in the chain the platform built.
                if (chain != null)
                {
                    foreach (var element in chain.ChainElements)
                    {
                        bundleChain.ChainPolicy.ExtraStore.Add(element.Certificate);
                    }
                }

                bundleChain.Build(serverCertificate);

                var elements = bundleChain.ChainElements;
                if (elements.Count == 0 || !ContainsCertificate(elements[elements.Count - 1].Certificate))
                {
                    return false;
                }

                // Allowing an unknown CA also suppresses errors such as an expired certificate from Build's return value,
                // so check every element's status. UntrustedRoot is expected only on the root, which was matched above.
                for (int i = 0; i < elements.Count; i++)
                {
                    var isRoot = i == elements.Count - 1;
                    foreach (var status in elements[i].ChainElementStatus)
                    {
                        if (status.Status == X509ChainStatusFlags.NoError ||
                            (isRoot && status.Status == X509ChainStatusFlags.UntrustedRoot))
                        {
                            continue;
                        }

                        Logger.GetLogger(typeof(CABundle)).DebugFormat("Server certificate rejected by the CA bundle {0}: {1}", FilePath, status.Status);
                        return false;
                    }
                }

                return true;
            }
        }

        private bool ContainsCertificate(X509Certificate2 certificate)
        {
            var rawData = certificate.RawData;
            foreach (var bundleCertificate in Certificates)
            {
                if (ByteArraysEqual(rawData, bundleCertificate.RawData))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ByteArraysEqual(byte[] left, byte[] right)
        {
            if (left.Length != right.Length)
            {
                return false;
            }

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
