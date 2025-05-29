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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBucketOwnershipControls Request Marshaller
    /// </summary>
    public class PutBucketOwnershipControlsRequestMarshaller : IMarshaller<IRequest, PutBucketOwnershipControlsRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketOwnershipControlsRequest)input);
        }

        public IRequest Marshall(PutBucketOwnershipControlsRequest putBucketOwnershipControlsRequest)
        {
            IRequest request = new DefaultRequest(putBucketOwnershipControlsRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (string.IsNullOrEmpty(putBucketOwnershipControlsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketOwnershipControlsRequest.BucketName");

            if (putBucketOwnershipControlsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketOwnershipControlsRequest.ExpectedBucketOwner));

            if (putBucketOwnershipControlsRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketOwnershipControlsRequest.ChecksumAlgorithm));

            request.ResourcePath = "/";

            request.AddSubResource("ownershipControls");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var ownershipControls = putBucketOwnershipControlsRequest.OwnershipControls;

                if (ownershipControls != null)
                {
                    xmlWriter.WriteStartElement("OwnershipControls", S3Constants.S3RequestXmlNamespace);

                    if (ownershipControls.Rules != null)
                    {
                        foreach (var rule in ownershipControls.Rules)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if (rule.IsSetObjectOwnership())
                            {
                                xmlWriter.WriteElementString("ObjectOwnership", S3Transforms.ToXmlStringValue(rule.ObjectOwnership));
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
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request,
                    putBucketOwnershipControlsRequest.ChecksumAlgorithm,
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

        private static PutBucketOwnershipControlsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketOwnershipControlsRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketOwnershipControlsRequestMarshaller();
                }
                return _instance;
            }
        }

    }
}
