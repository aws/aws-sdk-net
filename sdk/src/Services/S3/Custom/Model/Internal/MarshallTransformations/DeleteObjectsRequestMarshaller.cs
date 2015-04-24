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

            if (deleteObjectsRequest.IsSetMfaCodes())
                request.Headers.Add(HeaderKeys.XAmzMfaHeader, deleteObjectsRequest.MfaCodes.FormattedMfaCodes);

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(deleteObjectsRequest.BucketName));

            request.AddSubResource("delete");

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("Delete", "");

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
                        xmlWriter.WriteEndElement();
                    }
                }
                if (deleteObjectsRequest.IsSetQuiet())
                {
                    xmlWriter.WriteElementString("Quiet", "", deleteObjectsRequest.Quiet.ToString().ToLowerInvariant());
                }
                xmlWriter.WriteEndElement();
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
    }
}

