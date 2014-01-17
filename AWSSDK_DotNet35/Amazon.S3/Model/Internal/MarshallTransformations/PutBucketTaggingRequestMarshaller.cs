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
    /// Put Bucket Tagging Request Marshaller
    /// </summary>       
    public class PutBucketTaggingRequestMarshaller : IMarshaller<IRequest, PutBucketTaggingRequest>
    {
        public IRequest Marshall(PutBucketTaggingRequest putBucketTaggingRequest)
        {
            IRequest request = new DefaultRequest(putBucketTaggingRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            var uriResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketTaggingRequest.BucketName));

            request.Parameters.Add("tagging", null);

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("Tagging", "");

                var taggingTaggingtagSetList = putBucketTaggingRequest.TagSet;
                if (taggingTaggingtagSetList != null && taggingTaggingtagSetList.Count > 0)
                {
                    xmlWriter.WriteStartElement("TagSet", "");
                    foreach (var taggingTaggingtagSetListValue in taggingTaggingtagSetList)
                    {
                        xmlWriter.WriteStartElement("Tag", "");
                        if (taggingTaggingtagSetListValue.IsSetKey())
                        {
                            xmlWriter.WriteElementString("Key", "", S3Transforms.ToXmlStringValue(taggingTaggingtagSetListValue.Key));
                        }
                        if (taggingTaggingtagSetListValue.IsSetValue())
                        {
                            xmlWriter.WriteElementString("Value", "", S3Transforms.ToXmlStringValue(taggingTaggingtagSetListValue.Value));
                        }
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
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

