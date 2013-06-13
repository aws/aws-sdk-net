/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Security.Cryptography;
using System.Text;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Util;

using ThirdParty.BouncyCastle.OpenSsl;

namespace Amazon.CloudFront
{
    public class AmazonCloudFrontUrlSigner
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
        /// <param name="s3ObjectKey">The s3 key of the object, or the name of the stream for rtmp</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="dateLessThan">The expiration date of the signed URL</param>
        /// <returns>The signed URL.</returns>
        public static string GetCannedSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                FileInfo privateKey,
                                                string s3ObjectKey,
                                                string keyPairId,
                                                DateTime dateLessThan) 
        {
            using (StreamReader reader = new StreamReader(privateKey.FullName))
            {
                return GetCannedSignedURL(protocol, distributionDomain, reader, s3ObjectKey, keyPairId, dateLessThan);
            }
        }

        /// <summary>
        /// Returns a signed URL that grants universal access to private content until a given date.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="s3ObjectKey">The s3 key of the object, or the name of the stream for rtmp</param>
        /// <param name="privateKey">The private key file. RSA private key (.pem) are supported.</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="dateLessThan">The expiration date of the signed URL</param>
        /// <returns>The signed URL.</returns>
        public static string GetCannedSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                StreamReader privateKey,
                                                string s3ObjectKey,
                                                string keyPairId,
                                                DateTime dateLessThan)
        {
            string resourcePath = GenerateResourcePath(protocol, distributionDomain, s3ObjectKey);
            string signedUrlCanned = SignUrlCanned(resourcePath, keyPairId, privateKey, dateLessThan);

            return signedUrlCanned;
        }
       
        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="s3ObjectKey">The s3 key of the object, or the name of the stream for rtmp</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="dateLessThan">The expiration date of the signed URL</param>
        /// <param name="dateGreaterThan">The beginning valid date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                FileInfo privateKey,
                                                string s3ObjectKey,
                                                string keyPairId,
                                                DateTime dateLessThan,
                                                DateTime? dateGreaterThan,
                                                string ipRange) 
        {
            using (StreamReader reader = new StreamReader(privateKey.FullName))
            {
                return GetCustomSignedURL(protocol, distributionDomain, reader, s3ObjectKey, keyPairId, dateLessThan, dateGreaterThan, ipRange);
            }
        }

        /// <summary>
        /// Returns a signed URL that provides tailored access to private content based on an access time window and an ip range.
        /// </summary>
        /// <param name="protocol">The protocol of the URL</param>
        /// <param name="distributionDomain">The domain name of the distribution</param>
        /// <param name="privateKey">Your private key file. RSA private key (.pem) are supported.</param>
        /// <param name="s3ObjectKey">The s3 key of the object, or the name of the stream for rtmp</param>
        /// <param name="keyPairId">The key pair id corresponding to the private key file given</param>
        /// <param name="dateLessThan">The expiration date of the signed URL</param>
        /// <param name="dateGreaterThan">The beginning valid date of the signed URL</param>
        /// <param name="ipRange">The allowed IP address range of the client making the GET request, in CIDR form (e.g. 192.168.0.1/24).</param>
        /// <returns>The signed URL.</returns>
        public static string GetCustomSignedURL(Protocol protocol,
                                                string distributionDomain,
                                                StreamReader privateKey,
                                                string s3ObjectKey,
                                                string keyPairId,
                                                DateTime dateLessThan,
                                                DateTime? dateGreaterThan,
                                                string ipRange)
        {
            string resourcePath = GenerateResourcePath(protocol, distributionDomain, s3ObjectKey);
            string policy = BuildPolicyForSignedUrl(resourcePath, dateLessThan, ipRange, dateGreaterThan);

            return SignUrl(resourcePath, keyPairId, privateKey, policy);
        }
       
        /// <summary>
        /// Generate a signed URL that allows access to distribution and S3 objects
        /// by applying access restrictions specified in a custom policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + objectKey</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="policy">A policy document that describes the access permissions that will be applied by 
        /// the signed URL. To generate a custom policy use</param>
        /// <returns>A signed URL that will permit access to distribution and S3 objects as specified in the policy document.</returns>
        public static string SignUrl(string resourceUrlOrPath, string keyPairId, FileInfo privateKey, string policy)
        {
            using (StreamReader reader = new StreamReader(privateKey.FullName))
            {
                return SignUrl(resourceUrlOrPath, keyPairId, reader, policy);
            }
        }

        /// <summary>
        /// Generate a signed URL that allows access to distribution and S3 objects
        /// by applying access restrictions specified in a custom policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + objectKey</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="policy">A policy document that describes the access permissions that will be applied by 
        /// the signed URL. To generate a custom policy use</param>
        /// <returns>A signed URL that will permit access to distribution and S3 objects as specified in the policy document.</returns>
        public static string SignUrl(string resourceUrlOrPath, string keyPairId, StreamReader privateKey, string policy)
        {
            RSAParameters rsaParameters = ConvertPEMToRSAParameters(privateKey);
            byte[] signatureBytes = SignWithSha1RSA(UTF8Encoding.UTF8.GetBytes(policy), rsaParameters);

            string urlSafePolicy = MakeStringUrlSafe(policy);
            string urlSafeSignature = MakeBytesUrlSafe(signatureBytes);

            string signedUrl = resourceUrlOrPath + (resourceUrlOrPath.IndexOf('?') >= 0 ? "&" : "?") + "Policy="
                    + urlSafePolicy + "&Signature=" + urlSafeSignature + "&Key-Pair-Id=" + keyPairId;
            return signedUrl;
        }
        
        /// <summary>
        /// Generate a signed URL that allows access to a specific distribution and
        /// S3 object by applying a access restrictions from a "canned" (simplified)
        /// policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + objectKey</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="dateLessThan">The time and date when the signed URL will expire.</param>
        public static String SignUrlCanned(string resourceUrlOrPath,
                                           string keyPairId,
                                           FileInfo privateKey,
                                           DateTime dateLessThan)
        {
            using (StreamReader reader = new StreamReader(privateKey.FullName))
            {
                return SignUrlCanned(resourceUrlOrPath, keyPairId, reader, dateLessThan);
            }
        }

        /// <summary>
        /// Generate a signed URL that allows access to a specific distribution and
        /// S3 object by applying a access restrictions from a "canned" (simplified)
        /// policy document.
        /// </summary>
        /// <param name="resourceUrlOrPath">
        /// The URL or path that uniquely identifies a resource within a
        /// distribution. For standard distributions the resource URL will
        /// be <tt>"http://" + distributionName + "/" + objectKey</tt>
        /// (may also include URL parameters. For distributions with the
        /// HTTPS required protocol, the resource URL must start with
        /// <tt>"https://"</tt>. RTMP resources do not take the form of a
        /// URL, and instead the resource path is nothing but the stream's
        /// name.
        /// </param>
        /// <param name="keyPairId">Identifier of a public/private certificate keypair already configured in your Amazon Web Services account.</param>
        /// <param name="privateKey">The RSA private key data that corresponding to the certificate keypair identified by keyPairId.</param>
        /// <param name="dateLessThan">The time and date when the signed URL will expire.</param>
        public static String SignUrlCanned(string resourceUrlOrPath,
                                           string keyPairId,
                                           StreamReader privateKey,
                                           DateTime dateLessThan)
        {
            int epochSeconds = AWSSDKUtils.ConvertToUnixEpochSeconds(dateLessThan.ToUniversalTime());
            RSAParameters rsaParameters = ConvertPEMToRSAParameters(privateKey);
            string cannedPolicy = "{\"Statement\":[{\"Resource\":\"" + resourceUrlOrPath
                    + "\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":" + epochSeconds
                    + "}}}]}";
            byte[] signatureBytes = SignWithSha1RSA(UTF8Encoding.UTF8.GetBytes(cannedPolicy), rsaParameters);

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
        /// <tt>"http://" + distributionName + "/" + objectKey</tt> (may
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
        /// <param name="epochDateGreaterThan">The time and date when the signed URL will expire.</param>
        /// <param name="limitToIpAddressCIDR">An optional range of client IP addresses that will be allowed
        /// to access the distribution, specified as a CIDR range. If
        /// null, the CIDR will be <tt>0.0.0.0/0</tt> and any client will
        /// be permitted.</param>
        /// <param name="epochDateLessThan">An optional UTC time and date when the signed URL will become
        /// active. If null, the signed URL will be active as soon as it
        /// is created.</param>
        /// <returns>A policy document describing the access permission to apply when
        /// generating a signed URL.</returns>
        public static string BuildPolicyForSignedUrl(string resourcePath,
                                                     DateTime epochDateLessThan,
                                                     string limitToIpAddressCIDR,
                                                     DateTime? epochDateGreaterThan)
        {
            if (resourcePath == null)
            {
                resourcePath = "*";
            }
            string ipAddress = (limitToIpAddressCIDR == null ? "0.0.0.0/0" // No IP
                // restriction
                    : limitToIpAddressCIDR);
            string epochDateGreaterThanValue = !epochDateGreaterThan.HasValue ? "" :
                ",\"DateGreaterThan\":{\"AWS:EpochTime\":" +
                    AWSSDKUtils.ConvertToUnixEpochSeconds(epochDateGreaterThan.Value.ToUniversalTime()) + "}";

            string policy = "{\"Statement\": [{"
                    + "\"Resource\":\""
                    + resourcePath
                    + "\""
                    + ",\"Condition\":{"
                    + "\"DateLessThan\":{\"AWS:EpochTime\":"
                    + AWSSDKUtils.ConvertToUnixEpochSeconds(epochDateLessThan.ToUniversalTime())
                    + "}"
                    + ",\"IpAddress\":{\"AWS:SourceIp\":\""
                    + ipAddress
                    + "\"}"
                    + epochDateGreaterThanValue
                    + "}}]}";
            return policy;
        }

        /// <summary>
        /// Converts the given data to be safe for use in signed URLs for a private
        /// distribution by using specialized Base64 encoding.
        /// </summary>
        private static string MakeBytesUrlSafe(byte[] bytes)
        {
            return Convert.ToBase64String(bytes).Replace('+', '-').Replace('=', '_').Replace('/', '~');
        }
        
        /// <summary>
        /// Converts the given string to be safe for use in signed URLs for a private distribution.
        /// </summary>
        private static String MakeStringUrlSafe(string str)
        {
            return MakeBytesUrlSafe(UTF8Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// Returns the resource path for the given distribution, object, and protocol.
        /// </summary>
        private static string GenerateResourcePath(Protocol protocol,
                                                   string distributionDomain,
                                                   string s3ObjectKey) 
        {

            if ( protocol == Protocol.http || protocol == Protocol.https ) 
            {
                return protocol.ToString() + "://" + distributionDomain + "/" + s3ObjectKey;
            } else 
            {
                return s3ObjectKey;
            }
        }

        /// <summary>
        /// Signs the data given with the private key given, using the SHA1withRSA
        /// algorithm provided by bouncy castle.
        /// </summary>
        private static byte[] SignWithSha1RSA(byte[] dataToSign, RSAParameters rsaParameters)
        {
            using (SHA1CryptoServiceProvider cryptoSHA1 = new SHA1CryptoServiceProvider())
            {
                RSACryptoServiceProvider providerRSA = new RSACryptoServiceProvider();
                providerRSA.ImportParameters(rsaParameters);

                byte[] hashedData = cryptoSHA1.ComputeHash(dataToSign);

                // Format the RSACryptoServiceProvider providerRSA and create the signature.
                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(providerRSA);
                rsaFormatter.SetHashAlgorithm("SHA1");
                byte[] signedPolicyHash = rsaFormatter.CreateSignature(hashedData);
                return signedPolicyHash;
            }
        }

        private static RSAParameters ConvertPEMToRSAParameters(string pathToPrivateKey)
        {
            using (StreamReader reader = new StreamReader(pathToPrivateKey))
            {
                return ConvertPEMToRSAParameters(reader);
            }
        }

        private static RSAParameters ConvertPEMToRSAParameters(StreamReader privateKeyReader)
        {
            RSAParameters rsaParams;
            try
            {
                rsaParams = new PemReader(privateKeyReader).ReadPrivatekey();
            }
            catch (Exception e)
            {
                throw new AmazonClientException("Invalid RSA Private Key", e);
            }

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsaParams);

            return rsaParams;
        }
    }
}
