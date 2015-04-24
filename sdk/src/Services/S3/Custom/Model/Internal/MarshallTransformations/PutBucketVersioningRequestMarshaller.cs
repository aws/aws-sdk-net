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
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Versioning Request Marshaller
    /// </summary>       
    public class PutBucketVersioningRequestMarshaller : IMarshaller<IRequest, PutBucketVersioningRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketVersioningRequest)input);
		}

        public IRequest Marshall(PutBucketVersioningRequest putBucketVersioningRequest)
        {
            IRequest request = new DefaultRequest(putBucketVersioningRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketVersioningRequest.IsSetMfaCodes())
                request.Headers.Add(HeaderKeys.XAmzMfaHeader, putBucketVersioningRequest.MfaCodes.FormattedMfaCodes);

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketVersioningRequest.BucketName));

            request.AddSubResource("versioning");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                var versioningConfigurationVersioningConfiguration = putBucketVersioningRequest.VersioningConfig;
                if (versioningConfigurationVersioningConfiguration != null)
                {
                    xmlWriter.WriteStartElement("VersioningConfiguration", "");
                    if (versioningConfigurationVersioningConfiguration.IsSetEnableMfaDelete())
                    {
                        xmlWriter.WriteElementString("MfaDelete", "", versioningConfigurationVersioningConfiguration.EnableMfaDelete ? "Enabled" : "Disabled");
                    }
                    if (versioningConfigurationVersioningConfiguration.IsSetStatus())
                    {
                        xmlWriter.WriteElementString("Status", "", S3Transforms.ToXmlStringValue(versioningConfigurationVersioningConfiguration.Status));
                    }
                    xmlWriter.WriteEndElement();
                }
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

