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
    public class UpdateBucketMetadataJournalTableConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateBucketMetadataJournalTableConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBucketMetadataJournalTableConfigurationRequest)input);
        }

        public IRequest Marshall(UpdateBucketMetadataJournalTableConfigurationRequest updateBucketMetadataJournalTableConfigurationRequest)
        {
            IRequest request = new DefaultRequest(updateBucketMetadataJournalTableConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (updateBucketMetadataJournalTableConfigurationRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(updateBucketMetadataJournalTableConfigurationRequest.ChecksumAlgorithm));

            if (updateBucketMetadataJournalTableConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(updateBucketMetadataJournalTableConfigurationRequest.ExpectedBucketOwner));

            if (updateBucketMetadataJournalTableConfigurationRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(updateBucketMetadataJournalTableConfigurationRequest.ContentMD5));

            if (string.IsNullOrEmpty(updateBucketMetadataJournalTableConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "UpdateBucketMetadataJournalTableConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("metadataJournalTable");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var journalTableConfiguration = updateBucketMetadataJournalTableConfigurationRequest.JournalTableConfiguration;
                if (journalTableConfiguration != null)
                {
                    xmlWriter.WriteStartElement("JournalTableConfiguration", S3Constants.S3RequestXmlNamespace);

                    if (journalTableConfiguration.IsSetConfigurationState())
                    {
                        xmlWriter.WriteElementString("ConfigurationState", S3Transforms.ToXmlStringValue(journalTableConfiguration.ConfigurationState));
                    }

                    if (journalTableConfiguration.IsSetEncryptionConfiguration())
                    {
                        xmlWriter.WriteStartElement("EncryptionConfiguration");
                        if (journalTableConfiguration.EncryptionConfiguration.IsSetKmsKeyArn())
                        {
                            xmlWriter.WriteElementString("KmsKeyArn", journalTableConfiguration.EncryptionConfiguration.KmsKeyArn);
                        }
                        if (journalTableConfiguration.EncryptionConfiguration.IsSetSseAlgorithm())
                        {
                            xmlWriter.WriteElementString("SseAlgorithm", journalTableConfiguration.EncryptionConfiguration.SseAlgorithm);
                        }
                        xmlWriter.WriteEndElement();
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
                    updateBucketMetadataJournalTableConfigurationRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: true,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static UpdateBucketMetadataJournalTableConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static UpdateBucketMetadataJournalTableConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UpdateBucketMetadataJournalTableConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}