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
    public class PutBucketAccelerateConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketAccelerateConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketAccelerateConfigurationRequest)input);
        }

        public IRequest Marshall(PutBucketAccelerateConfigurationRequest putBucketAccelerateRequest)
        {
            IRequest request = new DefaultRequest(putBucketAccelerateRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketAccelerateRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketAccelerateRequest.ChecksumAlgorithm));

            if (putBucketAccelerateRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketAccelerateRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putBucketAccelerateRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketAccelerateConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("accelerate");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter,
            new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    OmitXmlDeclaration = true,
                    NewLineHandling = NewLineHandling.Entitize
                }))
            {
                var accelerateConfiguration = putBucketAccelerateRequest.AccelerateConfiguration;
                if (accelerateConfiguration != null)
                {
                    xmlWriter.WriteStartElement("AccelerateConfiguration", S3Constants.S3RequestXmlNamespace);

                    var accelerateConfigurationStatus = accelerateConfiguration.Status;
                    if (accelerateConfiguration.IsSetBucketAccelerateStatus() && accelerateConfigurationStatus != null)
                    {
                        xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(accelerateConfiguration.Status));
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
                    putBucketAccelerateRequest.ChecksumAlgorithm, 
                    fallbackToMD5: false, 
                    isRequestChecksumRequired: false,
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }

        private static PutBucketAccelerateConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketAccelerateConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketAccelerateConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}

