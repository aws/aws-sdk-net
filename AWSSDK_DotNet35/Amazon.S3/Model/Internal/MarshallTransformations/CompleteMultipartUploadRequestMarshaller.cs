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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Complete Multipart Upload Request Marshaller
    /// </summary>       
    public class CompleteMultipartUploadRequestMarshaller : IMarshaller<IRequest, CompleteMultipartUploadRequest>
    {
        public IRequest Marshall(CompleteMultipartUploadRequest completeMultipartUploadRequest)
        {
            IRequest request = new DefaultRequest(completeMultipartUploadRequest, "AmazonS3");

            request.HttpMethod = "POST";

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(completeMultipartUploadRequest.BucketName),
                                                S3Transforms.ToStringValue(completeMultipartUploadRequest.Key));

            request.Parameters.Add("uploadId", S3Transforms.ToStringValue(completeMultipartUploadRequest.UploadId));

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("CompleteMultipartUpload", "");
                var multipartUploadMultipartUploadpartsList = completeMultipartUploadRequest.PartETags;
                multipartUploadMultipartUploadpartsList.Sort();

                if (multipartUploadMultipartUploadpartsList != null && multipartUploadMultipartUploadpartsList.Count > 0)
                {
                    foreach (var multipartUploadMultipartUploadpartsListValue in multipartUploadMultipartUploadpartsList)
                    {
                        xmlWriter.WriteStartElement("Part", "");
                        if (multipartUploadMultipartUploadpartsListValue.IsSetETag())
                        {
                            xmlWriter.WriteElementString("ETag", "",
                                                         S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.ETag));
                        }
                        if (multipartUploadMultipartUploadpartsListValue.IsSetPartNumber())
                        {
                            xmlWriter.WriteElementString("PartNumber", "",
                                                         S3Transforms.ToXmlStringValue(multipartUploadMultipartUploadpartsListValue.PartNumber));
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";

                request.Parameters[S3QueryParameter.ContentType.ToString()] = "application/xml";
                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[Amazon.Util.AWSSDKUtils.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            if (!request.UseQueryString)
            {
                var queryString = Amazon.Util.AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    request.ResourcePath = string.Concat(request.ResourcePath, request.ResourcePath.Contains("?") ? "&" : "?", queryString);
                }
            }

            return request;
        }
    }
}

