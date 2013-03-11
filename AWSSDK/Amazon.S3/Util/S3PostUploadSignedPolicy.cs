/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

using Amazon.Runtime;
using Amazon.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Utility class for managing and exchanging HTTP POST uploads of objects to Amazon S3.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This object supports creating, marshalling, and unmarshalling of the information needed to build 
    /// an authenticated HTTP POST request to S3 for uploading objects according to a policy. 
    /// </para>
    /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
    /// </remarks>
    [XmlRootAttribute(IsNullable=false)]
    public class S3PostUploadSignedPolicy
    {
        /// <summary>
        ///  Given a policy and AWS credentials, produce a S3PostUploadSignedPolicy.
        /// </summary>
        /// <param name="policy">JSON string representing the policy to sign</param>
        /// <param name="credentials">Credentials to sign the policy with</param>
        /// <returns></returns>
        public static S3PostUploadSignedPolicy GetSignedPolicy(string policy, AWSCredentials credentials)
        {
            var policyBytes = Encoding.UTF8.GetBytes(policy.Trim().Replace("\r","").Replace("\n",""));
            var base64Policy = Convert.ToBase64String(policyBytes);
            
            string signature = null;

            if (credentials.GetCredentials().UseSecureStringForSecretKey)
                signature = AWSSDKUtils.HMACSign(Encoding.UTF8.GetBytes(base64Policy), credentials.GetCredentials().SecureSecretKey, new HMACSHA1());
            else
                signature = AWSSDKUtils.HMACSign(Encoding.UTF8.GetBytes(base64Policy), credentials.GetCredentials().ClearSecretKey, new HMACSHA1());

            return new S3PostUploadSignedPolicy
            {
                Policy = base64Policy,
                Signature = signature,
                AccessKeyId = credentials.GetCredentials().AccessKey
            };
        }

        /// <summary>
        /// The policy document which governs what uploads can be done.
        /// </summary>
        [XmlElementAttribute]
        public string Policy { get; set; }

        /// <summary>
        /// The signature for the policy.
        /// </summary>
        [XmlElementAttribute]
        public string Signature { get; set; }

        /// <summary>
        /// The AWS Access Key Id for the credential pair that produced the signature.
        /// </summary>
        [XmlElementAttribute]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Get the policy document as a human readable string.
        /// </summary>
        /// <returns>Human readable policy document.</returns>
        public string GetReadablePolicy()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(this.Policy));
        }

        private static string
            KEY_POLICY = "policy",
            KEY_SIGNATURE = "signature",
            KEY_ACCESSKEY = "access_key";

        /// <summary>
        /// JSON representation of this object
        /// </summary>
        /// <returns>JSON string</returns>
        public string ToJson()
        {
            var json = new JsonData();

            json[KEY_POLICY] = this.Policy;
            json[KEY_SIGNATURE] = this.Signature;
            json[KEY_ACCESSKEY] = this.AccessKeyId;

            return JsonMapper.ToJson(json);
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXml()
        {
            StringBuilder xml = new StringBuilder(1024);
            var serializer = new XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// Create an instance of this class from a JSON string.
        /// </summary>
        /// <param name="policyJson">JSON string</param>
        /// <returns>Instance of S3PostUploadSignedPolicy</returns>
        public static S3PostUploadSignedPolicy GetSignedPolicyFromJson(string policyJson)
        {
            JsonData json;
            try { json = JsonMapper.ToObject(policyJson); }
            catch (Exception e)  
            {
                throw new ArgumentException("Invalid JSON document", e); 
            }

            if (null == json[KEY_POLICY] || !json[KEY_POLICY].IsString)
                throw new ArgumentException(String.Format("JSON document requires '{0}' field"), KEY_POLICY);
            if (null == json[KEY_SIGNATURE] || !json[KEY_SIGNATURE].IsString)
                throw new ArgumentException(String.Format("JSON document requires '{0}' field"), KEY_SIGNATURE);
            if (null == json[KEY_ACCESSKEY] || !json[KEY_ACCESSKEY].IsString)
                throw new ArgumentException(String.Format("JSON document requires '{0}' field"), KEY_ACCESSKEY);

            return new S3PostUploadSignedPolicy
            {
                Policy = json[KEY_POLICY].ToString(),
                Signature = json[KEY_SIGNATURE].ToString(),
                AccessKeyId = json[KEY_ACCESSKEY].ToString()
            };
        }

        /// <summary>
        /// Create an instance of this class from an XML string.
        /// </summary>
        /// <param name="policyXml">XML string generated by ToXml()</param>
        /// <returns>Instance of S3PostUploadSignedPolicy</returns>
        public static S3PostUploadSignedPolicy GetSignedPolicyFromXml(string policyXml)
        {
            var reader = new StringReader(policyXml);
            XmlSerializer serializer = new XmlSerializer(typeof(S3PostUploadSignedPolicy));

            S3PostUploadSignedPolicy policy;
            try
            {
                policy = serializer.Deserialize(reader) as S3PostUploadSignedPolicy;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Could not parse XML", e);
            }

            if (String.IsNullOrEmpty(policy.AccessKeyId))
                throw new ArgumentException("XML Document requries 'AccessKeyId' field");
            if (String.IsNullOrEmpty(policy.Policy))
                throw new ArgumentException("XML Document requries 'Policy' field");
            if (String.IsNullOrEmpty(policy.Signature))
                throw new ArgumentException("XML Document requries 'Signature' field");
            
            return policy;
        }
    }
}
