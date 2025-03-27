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
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Objects Request Marshaller
    /// </summary>       
    public class DeleteObjectsRequestMarshaller : IMarshaller<IRequest, DeleteObjectsRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((DeleteObjectsRequest)input);
		}

        public IRequest Marshall(DeleteObjectsRequest deleteObjectsRequest)
        {
            IRequest request = new DefaultRequest(deleteObjectsRequest, "AmazonS3");

            request.HttpMethod = "POST";

			if (deleteObjectsRequest.IsSetBypassGovernanceRetention())
                request.Headers.Add("x-amz-bypass-governance-retention", S3Transforms.ToStringValue(deleteObjectsRequest.BypassGovernanceRetention.Value));
            if (deleteObjectsRequest.IsSetMfaCodes())
                request.Headers.Add(HeaderKeys.XAmzMfaHeader, deleteObjectsRequest.MfaCodes.FormattedMfaCodes);
            if (deleteObjectsRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(deleteObjectsRequest.RequestPayer.ToString()));
            if (deleteObjectsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(deleteObjectsRequest.ExpectedBucketOwner));
            if (deleteObjectsRequest.IsSetChecksumAlgorithm())
                request.Headers[S3Constants.AmzHeaderSdkChecksumAlgorithm] = S3Transforms.ToStringValue(deleteObjectsRequest.ChecksumAlgorithm);

            if (string.IsNullOrEmpty(deleteObjectsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteObjectsRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("delete");

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                xmlWriter.WriteStartElement("Delete", S3Constants.S3RequestXmlNamespace);

                var deleteDeleteobjectsList = deleteObjectsRequest.Objects;
                if (deleteDeleteobjectsList != null && deleteDeleteobjectsList.Count > 0)
                {
                    foreach (var deleteDeleteobjectsListValue in deleteDeleteobjectsList)
                    {
                        xmlWriter.WriteStartElement("Object", "");
                        if (deleteDeleteobjectsListValue.IsSetKey())
                        {
                            xmlWriter.WriteElementString("Key", "", S3Transforms.ToXmlStringValue(deleteDeleteobjectsListValue.Key));
                        }
                        if (deleteDeleteobjectsListValue.IsSetVersionId())
                        {
                            xmlWriter.WriteElementString("VersionId", "", S3Transforms.ToXmlStringValue(deleteDeleteobjectsListValue.VersionId));
                        }

                        if (deleteDeleteobjectsListValue.IsSetETag())
                        {
                            xmlWriter.WriteElementString("ETag", "", S3Transforms.ToXmlStringValue(deleteDeleteobjectsListValue.ETag));
                        }
                        if (deleteDeleteobjectsListValue.IsSetLastModifiedTime())
                        {
                            xmlWriter.WriteElementString("LastModifiedTime", "", S3Transforms.ToXmlStringValue(deleteDeleteobjectsListValue.LastModifiedTime.Value));
                        }
                        if (deleteDeleteobjectsListValue.IsSetSize())
                        {
                            xmlWriter.WriteElementString("Size", "", S3Transforms.ToXmlStringValue(deleteDeleteobjectsListValue.Size.Value));
                        }

                        xmlWriter.WriteEndElement();
                    }
                }
                if (deleteObjectsRequest.IsSetQuiet())
                {
                    xmlWriter.WriteElementString("Quiet", "", S3Transforms.ToXmlStringValue(deleteObjectsRequest.Quiet.Value));
                }
                xmlWriter.WriteEndElement();
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request, 
                    deleteObjectsRequest.ChecksumAlgorithm, 
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

	    private static DeleteObjectsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static DeleteObjectsRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new DeleteObjectsRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

