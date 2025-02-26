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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;
using Amazon.Util;
using Amazon.S3.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBucketAcl Request Marshaller
    /// </summary>       
    public class PutBucketAclRequestMarshaller : IMarshaller<IRequest, PutBucketAclRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketAclRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketAclRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("acl");

            if (publicRequest.IsSetACL())
            {
                request.Headers["x-amz-acl"] = publicRequest.ACL;
            }

            if (publicRequest.IsSetChecksumAlgorithm())
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }

            if (publicRequest.IsSetContentMD5())
            {
                request.Headers["Content-MD5"] = publicRequest.ContentMD5;
            }

            if (publicRequest.IsSetExpectedBucketOwner())
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }

            if (publicRequest.IsSetGrantFullControl())
            {
                request.Headers["x-amz-grant-full-control"] = publicRequest.GrantFullControl;
            }

            if (publicRequest.IsSetGrantRead())
            {
                request.Headers["x-amz-grant-read"] = publicRequest.GrantRead;
            }

            if (publicRequest.IsSetGrantReadACP())
            {
                request.Headers["x-amz-grant-read-acp"] = publicRequest.GrantReadACP;
            }

            if (publicRequest.IsSetGrantWrite())
            {
                request.Headers["x-amz-grant-write"] = publicRequest.GrantWrite;
            }

            if (publicRequest.IsSetGrantWriteACP())
            {
                request.Headers["x-amz-grant-write-acp"] = publicRequest.GrantWriteACP;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                if (publicRequest.IsSetAccessControlPolicy())
                {
                    xmlWriter.WriteStartElement("AccessControlPolicy", S3Constants.S3RequestXmlNamespace);
                    var publicRequestAccessControlPolicyGrants = publicRequest.AccessControlPolicy.Grants;
                    if (publicRequestAccessControlPolicyGrants != null && (publicRequestAccessControlPolicyGrants.Count > 0 || !AWSConfigs.InitializeCollections))
                    {
                        xmlWriter.WriteStartElement("AccessControlList");
                        foreach (var publicRequestAccessControlPolicyGrantsValue in publicRequestAccessControlPolicyGrants)
                        {
                            xmlWriter.WriteStartElement("Grant");
                            if (publicRequestAccessControlPolicyGrantsValue != null)
                            {
                                if (publicRequestAccessControlPolicyGrantsValue.Grantee != null)
                                {
                                    xmlWriter.WriteStartElement( "xsi","Grantee", "http://www.w3.org/2001/XMLSchema-instance");
                                    if (publicRequestAccessControlPolicyGrantsValue.Grantee.IsSetType())
                                        xmlWriter.WriteAttributeString("xsi", "type", "http://www.w3.org/2001/XMLSchema-instance", S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Grantee.Type));
                                    if (publicRequestAccessControlPolicyGrantsValue.Grantee.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName",S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Grantee.DisplayName));

                                    if (publicRequestAccessControlPolicyGrantsValue.Grantee.IsSetEmailAddress())
                                        xmlWriter.WriteElementString("EmailAddress", S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Grantee.EmailAddress));

                                    if (publicRequestAccessControlPolicyGrantsValue.Grantee.IsSetCanonicalUser())
                                        xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Grantee.CanonicalUser));

                                    if (publicRequestAccessControlPolicyGrantsValue.Grantee.IsSetURI())
                                        xmlWriter.WriteElementString("URI", S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Grantee.URI));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestAccessControlPolicyGrantsValue.IsSetPermission())
                                    xmlWriter.WriteElementString("Permission", S3Transforms.ToXmlStringValue(publicRequestAccessControlPolicyGrantsValue.Permission));

                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.AccessControlPolicy.Owner != null)
                    {
                        xmlWriter.WriteStartElement("Owner");
                        if (publicRequest.AccessControlPolicy.Owner.IsSetDisplayName())
                            xmlWriter.WriteElementString("DisplayName", S3Transforms.ToXmlStringValue(publicRequest.AccessControlPolicy.Owner.DisplayName));

                        if (publicRequest.AccessControlPolicy.Owner.IsSetId())
                            xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(publicRequest.AccessControlPolicy.Owner.Id));

                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            try
            {
                string content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: true,
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static PutBucketAclRequestMarshaller _instance = new PutBucketAclRequestMarshaller();

        internal static PutBucketAclRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketAclRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}