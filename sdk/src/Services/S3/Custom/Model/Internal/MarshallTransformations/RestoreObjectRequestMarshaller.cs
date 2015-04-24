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
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Restore Object Request Marshaller
    /// </summary>       
    public class RestoreObjectRequestMarshaller : IMarshaller<IRequest, RestoreObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((RestoreObjectRequest)input);
		}

        public IRequest Marshall(RestoreObjectRequest restoreObjectRequest)
        {
            IRequest request = new DefaultRequest(restoreObjectRequest, "AmazonS3");

            request.HttpMethod = "POST";

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(restoreObjectRequest.BucketName),
                                                 S3Transforms.ToStringValue(restoreObjectRequest.Key));

            request.AddSubResource("restore");
            if (restoreObjectRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(restoreObjectRequest.VersionId));

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                    xmlWriter.WriteStartElement("RestoreRequest", "");
                    xmlWriter.WriteElementString("Days", "", S3Transforms.ToXmlStringValue(restoreObjectRequest.Days));
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

