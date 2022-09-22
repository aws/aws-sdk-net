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
    /// PutPublicAccessBlock Request Marshaller
    /// </summary>       
    public class PutPublicAccessBlockRequestMarshaller : IMarshaller<IRequest, PutPublicAccessBlockRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPublicAccessBlockRequest)input);
        }

        public IRequest Marshall(PutPublicAccessBlockRequest putPutPublicAccessBlockRequest)
        {
            IRequest request = new DefaultRequest(putPutPublicAccessBlockRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putPutPublicAccessBlockRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putPutPublicAccessBlockRequest.ChecksumAlgorithm));

            if (putPutPublicAccessBlockRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putPutPublicAccessBlockRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putPutPublicAccessBlockRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "putPutPublicAccessBlockRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("publicAccessBlock");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings(){ Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var publicAccessBlockConfiguration = putPutPublicAccessBlockRequest.PublicAccessBlockConfiguration;
                if (publicAccessBlockConfiguration != null)
                {
                    xmlWriter.WriteStartElement("PublicAccessBlockConfiguration", S3Constants.S3RequestXmlNamespace);                    
                    if (publicAccessBlockConfiguration.IsSetBlockPublicAcls())
                    {
                        xmlWriter.WriteElementString("BlockPublicAcls", S3Transforms.ToXmlStringValue(publicAccessBlockConfiguration.BlockPublicAcls));
                    }
                    if (publicAccessBlockConfiguration.IsSetIgnorePublicAcls())
                    {
                        xmlWriter.WriteElementString("IgnorePublicAcls", S3Transforms.ToXmlStringValue(publicAccessBlockConfiguration.IgnorePublicAcls));
                    }
                    if (publicAccessBlockConfiguration.IsSetBlockPublicPolicy())
                    {
                        xmlWriter.WriteElementString("BlockPublicPolicy", S3Transforms.ToXmlStringValue(publicAccessBlockConfiguration.BlockPublicPolicy));
                    }
                    if (publicAccessBlockConfiguration.IsSetRestrictPublicBuckets())
                    {
                        xmlWriter.WriteElementString("RestrictPublicBuckets", S3Transforms.ToXmlStringValue(publicAccessBlockConfiguration.RestrictPublicBuckets));
                    }
                    xmlWriter.WriteEndElement();
                }
            }
            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetRequestChecksum(request, putPutPublicAccessBlockRequest.ChecksumAlgorithm);
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            
            return request;
        }

        private static PutPublicAccessBlockRequestMarshaller _instance;

        public static PutPublicAccessBlockRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutPublicAccessBlockRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}

