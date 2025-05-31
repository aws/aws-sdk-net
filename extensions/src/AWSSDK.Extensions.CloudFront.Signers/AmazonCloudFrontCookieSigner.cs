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
using System.Collections.Generic;
using System.IO;
using System.Text;

using Amazon.Util;

namespace Amazon.CloudFront
{
    /// <summary>
    /// This utility class provides methods for creating signed cookies for 
    /// Amazon CloudFront distributions using canned or custom policies.
    /// </summary>
    public static class AmazonCloudFrontCookieSigner
    {
        private const string ExpiresKey = "CloudFront-Expires";
        private const string SignatureKey = "CloudFront-Signature";
        private const string PolicyKey = "CloudFront-Policy";
        private const string KeyPairIdKey = "CloudFront-Key-Pair-Id";

        /// <summary>
        /// The supported protocols for accessing restricted content
        /// using signed cookies. You may combine the enums for specifying
        /// multiple protocols.
        /// </summary>
        [Flags]
        public enum Protocols
        {
            /// <summary>
            /// Http Protocol
            /// </summary>
            Http = 1,
            /// <summary>
            /// Https Protocol
            /// </summary>
            Https = 2
        }

        /// <summary>
        /// Returns signed cookies that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="protocol">The protocol used to access content using signed cookies.</param>
        /// <param name="distributionDomain">The domain name of the distribution.</param>
        /// <param name="resourcePath">The path for the resource.</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCannedPolicy GetCookiesForCannedPolicy(Protocols protocol,
                                                string distributionDomain,
                                                FileSystemInfo privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn)
        {
            using (var reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return GetCookiesForCannedPolicy(protocol, distributionDomain, reader, resourcePath, keyPairId, expiresOn);
            }
        }

        /// <summary>
        /// Returns signed cookies that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="protocol">The protocol used to access content using signed cookies.</param>
        /// <param name="distributionDomain">The domain name of the distribution.</param>
        /// <param name="resourcePath">The path for the resource.</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCannedPolicy GetCookiesForCannedPolicy(Protocols protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn)
        {
            string url = GenerateResourcePath(protocol, distributionDomain, resourcePath);
            return GetCookiesForCannedPolicy(url, keyPairId, privateKey, expiresOn);
        }

        /// <summary>
        /// Generate signed cookies that allows access to a specific distribution and
        /// resource path by applying a access restrictions from a "canned" (simplified)
        /// policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + path</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCannedPolicy GetCookiesForCannedPolicy(string resourceUrlOrPath,
                                           string keyPairId,
                                           FileSystemInfo privateKey,
                                           DateTime expiresOn)
        {
            using (var reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return GetCookiesForCannedPolicy(resourceUrlOrPath, keyPairId, reader, expiresOn);
            }
        }

        /// <summary>
        /// Generate signed cookies that allows access to a specific distribution and
        /// resource path by applying a access restrictions from a "canned" (simplified)
        /// policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + path</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCannedPolicy GetCookiesForCannedPolicy(string resourceUrlOrPath,
                                           string keyPairId,
                                           TextReader privateKey,
                                           DateTime expiresOn)
        {
            var cookies = new CookiesForCannedPolicy();

            string epochSeconds = AWSSDKUtils.ConvertToUnixEpochSecondsString(expiresOn);
            cookies.Expires = new KeyValuePair<string, string>(
                ExpiresKey, epochSeconds);

            string cannedPolicy = "{\"Statement\":[{\"Resource\":\"" + resourceUrlOrPath
                    + "\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":" + epochSeconds
                    + "}}}]}";
            byte[] signatureBytes = AmazonCloudFrontUrlSigner.SignWithSha1RSA(
                UTF8Encoding.UTF8.GetBytes(cannedPolicy), privateKey);
            string urlSafeSignature = AmazonCloudFrontUrlSigner.MakeBytesUrlSafe(signatureBytes);
            cookies.Signature = new KeyValuePair<string, string>(SignatureKey, urlSafeSignature);

            cookies.KeyPairId = new KeyValuePair<string, string>(KeyPairIdKey, keyPairId);

            return cookies;
        }

        /// <summary>
        /// Returns signed cookies that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol used to access content using signed cookies.</param>
        /// <param name="distributionDomain">The domain name of the distribution.</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <param name="activeFrom">The date from which content can be accessed using the generated cookies.</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCustomPolicy GetCookiesForCustomPolicy(Protocols protocol,
                                                string distributionDomain,
                                                FileSystemInfo privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            using (var reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return GetCookiesForCustomPolicy(protocol, distributionDomain, reader, resourcePath, keyPairId, expiresOn, activeFrom, ipRange);
            }
        }

        /// <summary>
        /// Returns signed cookies that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol used to access content using signed cookies.</param>
        /// <param name="distributionDomain">The domain name of the distribution.</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <param name="activeFrom">The date from which content can be accessed using the generated cookies.</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCustomPolicy GetCookiesForCustomPolicy(Protocols protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            var url = GenerateResourcePath(protocol, distributionDomain, resourcePath);
            return GetCookiesForCustomPolicy(url, privateKey, keyPairId, expiresOn,
                activeFrom, ipRange);
        }

        /// <summary>
        /// Returns signed cookies that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path for resource within a distribution.
        /// </param>        
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>        
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>
        /// <param name="activeFrom">The date from which content can be accessed using the generated cookies.</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCustomPolicy GetCookiesForCustomPolicy(string resourceUrlOrPath,
                                                TextReader privateKey,                                                
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            var cookies = new CookiesForCustomPolicy();
            var policy = AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resourceUrlOrPath, expiresOn, 
                ipRange, activeFrom);

            var base64EncodedPolicy = AmazonCloudFrontUrlSigner.MakeStringUrlSafe(policy);
            cookies.Policy = new KeyValuePair<string, string>(PolicyKey, base64EncodedPolicy);

            byte[] signatureBytes = AmazonCloudFrontUrlSigner.SignWithSha1RSA(
                Encoding.UTF8.GetBytes(policy), privateKey);
            string urlSafeSignature = AmazonCloudFrontUrlSigner.MakeBytesUrlSafe(signatureBytes);
            cookies.Signature = new KeyValuePair<string, string>(SignatureKey, urlSafeSignature);

            cookies.KeyPairId = new KeyValuePair<string, string>(KeyPairIdKey, keyPairId);

            return cookies;
        }

        /// <summary>
        /// Returns signed cookies that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol used to access content using signed cookies.</param>
        /// <param name="distributionDomain">The domain name of the distribution.</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date till which content can be accessed using the generated cookies.</param>        
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed cookies.</returns>
        public static CookiesForCustomPolicy GetCookiesForCustomPolicy(Protocols protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                string ipRange)
        {
            return GetCookiesForCustomPolicy(protocol, distributionDomain, privateKey, resourcePath, keyPairId,
                expiresOn, DateTime.MinValue, ipRange);
        }

        /// <summary>
        /// Returns the resource path for the given distribution, object, 
        /// and protocol.
        /// </summary>
        private static string GenerateResourcePath(Protocols protocol,
                                                   string distributionDomain,
                                                   string path)
        {
            path = path.TrimStart('/');
            
            if (protocol == 0)
            {
                // Uninitialized protocol value.
                throw new ArgumentException("Invalid value for AmazonCloudFrontCookieSigner.Protocols enum." +
                    " Valid values are AmazonCloudFrontCookieSigner.Protocols.Http or AmazonCloudFrontCookieSigner.Protocols.Https .",
                    "protocol");
            }

            if (protocol == (Protocols.Http | Protocols.Https))
            {
                return "http*://" + distributionDomain + "/" + path;
            }
            else
            {
                return protocol.ToString().ToLowerInvariant() + "://" + distributionDomain +
                    "/" + path;
            }
        }
    }


    /// <summary>
    /// Contains common cookies used by Amazon CloudFront.
    /// </summary>
    public abstract class SignedCookies
    {
        /// <summary>
        /// The active CloudFront key pair Id for the key pair (Trusted Signer) that you are using to generate the signature.
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-trusted-signers.html">
        /// Specifying the AWS Accounts That Can Create Signed URLs and Signed Cookies (Trusted Signers)</a>
        /// in the <i>Amazon CloudFront User Guide</i>.
        /// </para>
        /// </summary>
        public KeyValuePair<string, string> KeyPairId { get; internal set; }

        /// <summary>
        /// The hashed and signed version of the policy.
        /// </summary>
        public KeyValuePair<string, string> Signature { get; internal set; }
    }

    /// <summary>
    /// Contains the cookies used to access restricted content from
    /// CloudFront using a canned policy.
    /// </summary>
    public class CookiesForCannedPolicy : SignedCookies
    {
        /// <summary>
        /// Date and time in Unix time format (in seconds) and Coordinated Universal Time (UTC).
        /// </summary>
        public KeyValuePair<string, string> Expires { get; internal set; }
    }

    /// <summary>
    /// Contains the cookies used to access restricted content from
    /// CloudFront using a custom policy.
    /// </summary>
    public class CookiesForCustomPolicy : SignedCookies
    {
        /// <summary>
        /// Base64 encoded version of the custom policy.
        /// </summary>
        public KeyValuePair<string, string> Policy { get; internal set; }
    }

}