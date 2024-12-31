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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;
using System.Text;
using System.Xml;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class CreateBucketMetadataTableConfigurationRequestMarshaller : IMarshaller<IRequest, CreateBucketMetadataTableConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBucketMetadataTableConfigurationRequest)input);
        }

        public IRequest Marshall(CreateBucketMetadataTableConfigurationRequest createBucketMetadataTableConfigurationRequest)
        {
            IRequest request = new DefaultRequest(createBucketMetadataTableConfigurationRequest, "AmazonS3");

            request.HttpMethod = "POST";

            if (createBucketMetadataTableConfigurationRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(createBucketMetadataTableConfigurationRequest.ChecksumAlgorithm));

            if (createBucketMetadataTableConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(createBucketMetadataTableConfigurationRequest.ExpectedBucketOwner));

            if (createBucketMetadataTableConfigurationRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(createBucketMetadataTableConfigurationRequest.ContentMD5));


            if (string.IsNullOrEmpty(createBucketMetadataTableConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "CreateBucketMetadataTableConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("metadataTable");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var metadataTableConfiguration = createBucketMetadataTableConfigurationRequest.MetadataTableConfiguration;
                if (metadataTableConfiguration != null)
                {
                    xmlWriter.WriteStartElement("MetadataTableConfiguration", S3Constants.S3RequestXmlNamespace);

                    if (metadataTableConfiguration.IsSetS3TablesDestination())
                    {
                        xmlWriter.WriteStartElement("S3TablesDestination");
                        if (metadataTableConfiguration.S3TablesDestination.IsSetTableBucketArn())
                        {
                            xmlWriter.WriteElementString("TableBucketArn", metadataTableConfiguration.S3TablesDestination.TableBucketArn);
                        }
                        if (metadataTableConfiguration.S3TablesDestination.IsSetTableName())
                        {
                            xmlWriter.WriteElementString("TableName", metadataTableConfiguration.S3TablesDestination.TableName);
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
                ChecksumUtils.SetChecksumData(request, createBucketMetadataTableConfigurationRequest.ChecksumAlgorithm);
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static CreateBucketMetadataTableConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static CreateBucketMetadataTableConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateBucketMetadataTableConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
