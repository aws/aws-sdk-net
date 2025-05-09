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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Object Acl Request Marshaller
    /// </summary>       
    public class PutACLRequestMarshaller : IMarshaller<IRequest, PutACLRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutACLRequest)input);
		}

        public IRequest Marshall(PutACLRequest putObjectAclRequest)
        {
            IRequest request = new DefaultRequest(putObjectAclRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putObjectAclRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(putObjectAclRequest.CannedACL));

            if (putObjectAclRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putObjectAclRequest.ExpectedBucketOwner));

            if (putObjectAclRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putObjectAclRequest.ChecksumAlgorithm));

            if (string.IsNullOrEmpty(putObjectAclRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutACLRequest.BucketName");
            //Not checking if Key is null or empty because PutAcl allows to put an ACL for both a Bucket or an Object.

            // if we are putting the acl onto the bucket, the keyname component will collapse to empty string
            request.ResourcePath = "/{Key+}";
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(putObjectAclRequest.Key));

            request.AddSubResource("acl");
            if (putObjectAclRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(putObjectAclRequest.VersionId));

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (
                var xmlWriter = XmlWriter.Create(stringWriter,
                                                 new XmlWriterSettings()
                                                     {
                                                         Encoding = Encoding.UTF8,
                                                         OmitXmlDeclaration = true,
                                                         NewLineHandling = NewLineHandling.Entitize
                                                     }))
            {
                var accessControlPolicyAccessControlPolicy = putObjectAclRequest.AccessControlList;
                if (accessControlPolicyAccessControlPolicy != null)
                {
                    xmlWriter.WriteStartElement("AccessControlPolicy", S3Constants.S3RequestXmlNamespace);

                    var accessControlPolicyAccessControlPolicygrantsList = accessControlPolicyAccessControlPolicy.Grants;
                    if (accessControlPolicyAccessControlPolicygrantsList != null &&
                        accessControlPolicyAccessControlPolicygrantsList.Count > 0)
                    {
                        accessControlPolicyAccessControlPolicy.Marshall("AccessControlList", xmlWriter);

                        var ownerOwner = accessControlPolicyAccessControlPolicy.Owner;
                        if (ownerOwner != null)
                        {
                            xmlWriter.WriteStartElement("Owner");
                            if (ownerOwner.IsSetDisplayName())
                            {
                                xmlWriter.WriteElementString("DisplayName", 
                                                             S3Transforms.ToXmlStringValue(ownerOwner.DisplayName));
                            }
                            if (ownerOwner.IsSetId())
                            {
                                xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(ownerOwner.Id));
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }

                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request, 
                    putObjectAclRequest.ChecksumAlgorithm, 
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

	    private static PutACLRequestMarshaller _instance;

	    public static PutACLRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutACLRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

