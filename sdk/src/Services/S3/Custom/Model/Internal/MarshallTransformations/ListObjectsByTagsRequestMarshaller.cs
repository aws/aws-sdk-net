/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Util;
using Amazon.Util;

using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;


#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListObjectsByTags Request Marshaller
    /// </summary>
    public class ListObjectsByTagsRequestMarshaller : IMarshaller<IRequest, ListObjectsByTagsRequest>, IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((ListObjectsByTagsRequest)input);
        }


        public IRequest Marshall(ListObjectsByTagsRequest listObjectsByTagsRequest)
        {
            IRequest request = new DefaultRequest(listObjectsByTagsRequest, "AmazonS3");
            
            request.HttpMethod = "POST";

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, 
                                                "/{0}",
                                                S3Transforms.ToStringValue(listObjectsByTagsRequest.BucketName));
            request.AddSubResource("tag-query");

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                SerializeTagsQuery(xmlWriter, listObjectsByTagsRequest.TagQuery);
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
                throw new AmazonServiceException("Unable to marhsall request to XML", e);
            }

            return request;
        }


        private static void SerializeTagsQuery(XmlWriter xmlWriter, TagQuery tagQuery)
        {
            xmlWriter.WriteStartElement("TagQuery", "");

                if (tagQuery.IsSetMaxKeys())
                    xmlWriter.WriteElementString("MaxKeys", "", S3Transforms.ToXmlStringValue(tagQuery.MaxKeys.Value));
                
                xmlWriter.WriteElementString("IncludeTags", "", tagQuery.IncludeTags ? "true" : "false");

                if (tagQuery.IsSetContinuationToken())
                    xmlWriter.WriteElementString("ContinuationToken", "", tagQuery.ContinuationToken);

                xmlWriter.WriteStartElement("And", "");

                    foreach(TagQueryFilter filter in tagQuery.And)
                    {
                        SerializeTagQueryFilter(xmlWriter, filter);
                    }

                xmlWriter.WriteEndElement(); // And

            xmlWriter.WriteEndElement(); // TagQuery
        }


        private static void SerializeTagQueryFilter(XmlWriter xmlWriter, TagQueryFilter filter)
        {
            xmlWriter.WriteStartElement("Filter", "");

                xmlWriter.WriteElementString("Key", "", S3Transforms.ToXmlStringValue(filter.Key));

                xmlWriter.WriteStartElement("Or", "");

                    foreach(string value in filter.Or)
                    {
                        xmlWriter.WriteElementString("Value", "", S3Transforms.ToXmlStringValue(value));
                    }

                xmlWriter.WriteEndElement(); // Or

            xmlWriter.WriteEndElement(); // Filter
        }
    }
}