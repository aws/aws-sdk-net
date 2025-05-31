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
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Amazon.Runtime;
using Amazon.Util;
#if !NET
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
#endif

#pragma warning disable 1591

namespace Amazon.CloudFront
{
    /// <summary>
    /// This utility class provides methods for creating signed URLs for 
    /// Amazon CloudFront distributions using canned or custom policies.
    /// </summary>
    public static class AmazonCloudFrontUrlSigner
    {
        public enum Protocol
        {
            http, https, rtmp
        }


        /// <summary>
        /// Returns a signed URL that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="resourcePath">The path for the resource, or the name of the stream for rtmp</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <returns>The signed URL.</returns>
        public static string GetCannedSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                FileSystemInfo privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn)
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return GetCannedSignedURL(protocol, distributionDomain, reader, resourcePath, keyPairId, expiresOn);
            }
        }

        /// <summary>
        /// Returns a signed URL that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="resourcePath">The path for the resource, or the name of the stream for rtmp</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <returns>The signed URL.</returns>
        public static string GetCannedSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn)
        {
            string url = GenerateResourcePath(protocol, distributionDomain, resourcePath);
            return GetCannedSignedURL(url, privateKey, keyPairId, expiresOn);
        }

        /// <summary>
        /// Returns a signed URL that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="url">The full url (protocol + domain + resource path) to the resource, or the name of the stream for rtmp</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given.</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <returns>The signed URL.</returns>
        public static string GetCannedSignedURL(string url, 
                                                TextReader privateKey,
                                                string keyPairId,
                                                DateTime expiresOn)
        {
            string signedUrlCanned = SignUrlCanned(url, keyPairId, privateKey, expiresOn);
            return signedUrlCanned;
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource, or the name of the stream for rtmp</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <param name="activeFrom">The beginning valid date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                FileSystemInfo privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return GetCustomSignedURL(protocol, distributionDomain, reader, resourcePath, keyPairId, expiresOn, activeFrom, ipRange);
            }
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource, or the name of the stream for rtmp</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <param name="activeFrom">The beginning valid date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            string path = GenerateResourcePath(protocol, distributionDomain, resourcePath);
            return GetCustomSignedURL(path, privateKey, keyPairId, expiresOn, activeFrom, ipRange);
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="resourcePath">The path for the resource, or the name of the stream for rtmp</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>        
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                TextReader privateKey,
                                                string resourcePath,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                string ipRange)
        {
            string path = GenerateResourcePath(protocol, distributionDomain, resourcePath);
            return GetCustomSignedURL(path, privateKey, keyPairId, expiresOn, ipRange);
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="url">The protocol of the URL</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <param name="activeFrom">The beginning valid date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(string url,
                                                TextReader privateKey,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                DateTime activeFrom,
                                                string ipRange)
        {
            string policy = BuildPolicyForSignedUrl(url, expiresOn, ipRange, activeFrom);
            return SignUrl(url, keyPairId, privateKey, policy);
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="url">The protocol of the URL</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="expiresOn">The expiration date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(string url,
                                                TextReader privateKey,
                                                string keyPairId,
                                                DateTime expiresOn,
                                                string ipRange)
        {
            string policy = BuildPolicyForSignedUrl(url, expiresOn, ipRange);
            return SignUrl(url, keyPairId, privateKey, policy);
        }

        /// <summary>
        /// Generate a signed URL that allows access to distribution and resource path
        /// by applying access restrictions specified in a custom policy document.
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
        /// <param name="policy">A policy document that describes the access permissions that will be applied by 
        /// the signed URL.</param>
        /// <returns>A signed URL that will permit access to distribution and resource path as specified in the policy document.</returns>
        public static string SignUrl(string resourceUrlOrPath, string keyPairId, FileInfo privateKey, string policy)
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return SignUrl(resourceUrlOrPath, keyPairId, reader, policy);
            }
        }

        /// <summary>
        /// Generate a signed URL that allows access to distribution and resource path
        /// by applying access restrictions specified in a custom policy document.
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
        /// <param name="policy">A policy document that describes the access permissions that will be applied by 
        /// the signed URL.</param>
        /// <returns>A signed URL that will permit access to distribution and S3 objects as specified in the policy document.</returns>
        public static string SignUrl(string resourceUrlOrPath, string keyPairId, TextReader privateKey, string policy)
        {
            byte[] signatureBytes = SignWithSha1RSA(Encoding.UTF8.GetBytes(policy), privateKey);

            string urlSafePolicy = MakeStringUrlSafe(policy);
            string urlSafeSignature = MakeBytesUrlSafe(signatureBytes);

            string signedUrl = resourceUrlOrPath + (resourceUrlOrPath.IndexOf('?') >= 0 ? "&" : "?") + "Policy="
                    + urlSafePolicy + "&Signature=" + urlSafeSignature + "&Key-Pair-Id=" + keyPairId;
            return signedUrl;
        }

        /// <summary>
        /// Generate a signed URL that allows access to a specific distribution and
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
        /// <param name="expiresOn">The time and date when the signed URL will expire.</param>
        public static String SignUrlCanned(string resourceUrlOrPath,
                                           string keyPairId,
                                           FileInfo privateKey,
                                           DateTime expiresOn)
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(privateKey.FullName)))
            {
                return SignUrlCanned(resourceUrlOrPath, keyPairId, reader, expiresOn);
            }
        }

        /// <summary>
        /// Generate a signed URL that allows access to a specific distribution and
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
        /// <param name="expiresOn">The time and date when the signed URL will expire.</param>
        public static String SignUrlCanned(string resourceUrlOrPath,
                                           string keyPairId,
                                           TextReader privateKey,
                                           DateTime expiresOn)
        {
            string epochSeconds = AWSSDKUtils.ConvertToUnixEpochSecondsString(expiresOn);
            string cannedPolicy = "{\"Statement\":[{\"Resource\":\"" + resourceUrlOrPath
                    + "\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":" + epochSeconds
                    + "}}}]}";
            byte[] signatureBytes = SignWithSha1RSA(Encoding.UTF8.GetBytes(cannedPolicy), privateKey);

            string urlSafeSignature = MakeBytesUrlSafe(signatureBytes);

            string signedUrl = resourceUrlOrPath + (resourceUrlOrPath.IndexOf('?') >= 0 ? "&" : "?") + "Expires="
                    + epochSeconds +
                    "&Signature=" + urlSafeSignature + "&Key-Pair-Id=" + keyPairId;
            return signedUrl;
        }

        /// <summary>
        /// Generate a policy document that describes custom access permissions to
        /// apply via a private distribution's signed URL.
        /// </summary>
        /// <param name="resourcePath">
        /// An optional HTTP/S or RTMP resource path that restricts which
        /// distribution and S3 objects will be accessible in a signed
        /// URL. For standard distributions the resource URL will be
        /// <tt>"http://" + distributionName + "/" + path</tt> (may
        /// also include URL parameters. For distributions with the HTTPS
        /// required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name. The '*' and '?' characters can be used as a wildcards to
        /// allow multi-character or single-character matches
        /// respectively:
        /// <ul>
        /// <li><tt>*</tt> : All distributions/objects will be accessible</li>
        /// <li><tt>a1b2c3d4e5f6g7.cloudfront.net/*</tt> : All objects
        /// within the distribution a1b2c3d4e5f6g7 will be accessible</li>
        /// <li><tt>a1b2c3d4e5f6g7.cloudfront.net/path/to/object.txt</tt>
        /// : Only the S3 object named <tt>path/to/object.txt</tt> in the
        /// distribution a1b2c3d4e5f6g7 will be accessible.</li>
        /// </ul>
        /// If this parameter is null the policy will permit access to all
        /// distributions and S3 objects associated with the certificate
        /// keypair used to generate the signed URL.
        /// </param>
        /// <param name="expiresOn">The time and date when the signed URL will expire.</param>
        /// <param name="limitToIpAddressCIDR">An optional range of client IP addresses that will be allowed
        /// to access the distribution, specified as a CIDR range. If
        /// null or empty any client will be permitted.</param>
        /// <param name="activeFrom">An optional UTC time and date when the signed URL will become
        /// active. A value of DateTime.MinValue (the default value of DateTime) is ignored.
        /// </param>
        /// <returns>A policy document describing the access permission to apply when
        /// generating a signed URL.</returns>
        public static string BuildPolicyForSignedUrl(string resourcePath,
                                                     DateTime expiresOn,
                                                     string limitToIpAddressCIDR,
                                                     DateTime activeFrom)
        {
            // Reference: 
            // http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-creating-signed-url-custom-policy.html#private-content-custom-policy-statement

            // Validate if activeFrom (time at which the URL will be active)
            // is less than expiresOn (time at which the URL will expire)
            if (activeFrom > expiresOn)
            {
                throw new AmazonClientException("The parameter activeFrom (time at which the URL will be active)" +
                    "must be less than expiresOn (time at which the URL will expire).");
            }

            if (resourcePath == null)
            {
                resourcePath = "*";
            }

            string policy = "{\"Statement\": [{"
                    + "\"Resource\":\""
                    + resourcePath
                    + "\""
                    + ",\"Condition\":{"
                    + "\"DateLessThan\":{\"AWS:EpochTime\":"
                    + AWSSDKUtils.ConvertToUnixEpochSecondsString(expiresOn)
                    + "}"
                // omitting IpAddress parameter indicates any ip address access
                    + (string.IsNullOrEmpty(limitToIpAddressCIDR)
                        ? ""
                        : ",\"IpAddress\":{\"AWS:SourceIp\":\"" + limitToIpAddressCIDR + "\"}")
                // Ignore epochDateGreaterThan if its value is DateTime.MinValue, the default value of DateTime.
                    + (activeFrom > DateTime.MinValue ? ",\"DateGreaterThan\":{\"AWS:EpochTime\":"
                    + AWSSDKUtils.ConvertToUnixEpochSecondsString(activeFrom) + "}"
                            : string.Empty)
                    + "}}]}";
            return policy;
        }

        /// <summary>
        /// Generate a policy document that describes custom access permissions to
        /// apply via a private distribution's signed URL.
        /// </summary>
        /// <param name="resourcePath">
        /// An optional HTTP/S or RTMP resource path that restricts which
        /// distribution and resource path will be accessible in a signed
        /// URL. For standard distributions the resource URL will be
        /// <tt>"http://" + distributionName + "/" + path</tt> (may
        /// also include URL parameters. For distributions with the HTTPS
        /// required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name. The '*' and '?' characters can be used as a wildcards to
        /// allow multi-character or single-character matches
        /// respectively:
        /// <ul>
        /// <li><tt>*</tt> : All distributions/objects will be accessible</li>
        /// <li><tt>a1b2c3d4e5f6g7.cloudfront.net/*</tt> : All objects
        /// within the distribution a1b2c3d4e5f6g7 will be accessible</li>
        /// <li><tt>a1b2c3d4e5f6g7.cloudfront.net/path/to/object.txt</tt>
        /// : Only the resource named <tt>path/to/object.txt</tt> in the
        /// distribution a1b2c3d4e5f6g7 will be accessible.</li>
        /// </ul>
        /// If this parameter is null the policy will permit access to all
        /// distributions and resource path associated with the certificate
        /// keypair used to generate the signed URL.
        /// </param>
        /// <param name="expiresOn">The time and date when the signed URL will expire.</param>
        /// <param name="limitToIpAddressCIDR">An optional range of client IP addresses that will be allowed
        /// to access the distribution, specified as a CIDR range. If  null, or empty, any client will
        /// be permitted.</param>        
        /// <returns>A policy document describing the access permission to apply when
        /// generating a signed URL.</returns>
        public static string BuildPolicyForSignedUrl(string resourcePath,
                                                     DateTime expiresOn,
                                                     string limitToIpAddressCIDR)
        {
            return BuildPolicyForSignedUrl(resourcePath, expiresOn,
                limitToIpAddressCIDR, DateTime.MinValue);
        }

        /// <summary>
        /// Converts the given data to be safe for use in signed URLs for a private
        /// distribution by using specialized Base64 encoding.
        /// </summary>
        internal static string MakeBytesUrlSafe(byte[] bytes)
        {
            return Convert.ToBase64String(bytes).Replace('+', '-').Replace('=', '_').Replace('/', '~');
        }

        /// <summary>
        /// Converts the given string to be safe for use in signed URLs for a private distribution.
        /// </summary>
        internal static String MakeStringUrlSafe(string str)
        {
            return MakeBytesUrlSafe(UTF8Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// Returns the resource path for the given distribution, object, and protocol.
        /// </summary>
        private static string GenerateResourcePath(Protocol protocol,
                                                   string distributionDomain,
                                                   string path)
        {

            if (protocol == Protocol.http || protocol == Protocol.https)
            {
                return protocol.ToString() + "://" + distributionDomain + "/" + path;
            }
            else
            {
                return path;
            }
        }

        /// <summary>
        /// Signs the data given with the private key given, using the SHA1withRSA
        /// algorithm provided by bouncy castle.
        /// </summary>
        internal static byte[] SignWithSha1RSA(byte[] dataToSign, TextReader privateKey)
        {
            using (SHA1 cryptoSHA1 = SHA1.Create())
            using (RSA rsa = RSA.Create())
            {
                ImportRSAFromPem(rsa, privateKey);

                byte[] hashedData = cryptoSHA1.ComputeHash(dataToSign);
                return GetRSAPKCS1SignatureFromSHA1(hashedData, rsa);
            }
        }

        private static void ImportRSAFromPem(RSA rsa, TextReader privateKeyReader)
        {
#if NET
            rsa.ImportFromPem(privateKeyReader.ReadToEnd());
#else
            RSAParameters rsaParams;
            try
            {
                using (var pemReader = new PemReader(privateKeyReader))
                {
                    var keyPair = pemReader.ReadObject();
                    if (keyPair is RsaPrivateCrtKeyParameters)
                    {
                        rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair);
                    }
                    else if (keyPair is AsymmetricCipherKeyPair)
                    {
                        var asymmetricKeyPair = keyPair as AsymmetricCipherKeyPair;
                        var privateKey = asymmetricKeyPair.Private as RsaPrivateCrtKeyParameters;
                        rsaParams = DotNetUtilities.ToRSAParameters(privateKey);
                    }
                    else
                    {
                        throw new AmazonClientException("Unknown key type");
                    }
                }
            }
            catch (Exception e)
            {
                throw new AmazonClientException("Invalid RSA Private Key", e);
            }
            rsa.ImportParameters(rsaParams);
#endif
        }

        private static byte[] GetRSAPKCS1SignatureFromSHA1(byte[] hashedData, RSA providerRSA)
        {
            // Format the RSACryptoServiceProvider and create the signature.
#if NETSTANDARD
            return providerRSA.SignHash(hashedData, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
#else
            RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(providerRSA);
            rsaFormatter.SetHashAlgorithm("SHA1");
            return rsaFormatter.CreateSignature(hashedData);
#endif
        }
    }
}
