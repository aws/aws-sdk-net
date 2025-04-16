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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBucketMetricsConfiguration Request Marshaller
    /// </summary>       
    public class PutBucketMetricsConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketMetricsConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketMetricsConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketMetricsConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("metrics");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            
            if (publicRequest.IsSetId())
                request.Parameters.Add("id", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetMetricsConfiguration())
                {
                    xmlWriter.WriteStartElement("MetricsConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.MetricsConfiguration.Filter != null)
                    {
                        xmlWriter.WriteStartElement("Filter");
                        if(publicRequest.MetricsConfiguration.Filter.IsSetAccessPointArn())
                            xmlWriter.WriteElementString("AccessPointArn", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.AccessPointArn));
                        if (publicRequest.MetricsConfiguration.Filter.And != null)
                        {
                            xmlWriter.WriteStartElement("And");
                            if(publicRequest.MetricsConfiguration.Filter.And.IsSetAccessPointArn())
                                xmlWriter.WriteElementString("AccessPointArn", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.And.AccessPointArn));
                            if(publicRequest.MetricsConfiguration.Filter.And.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.And.Prefix));
                            var publicRequestMetricsConfigurationFilterAndTags = publicRequest.MetricsConfiguration.Filter.And.Tags;
                            if (publicRequestMetricsConfigurationFilterAndTags != null && (publicRequestMetricsConfigurationFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestMetricsConfigurationFilterAndTagsValue in publicRequestMetricsConfigurationFilterAndTags) 
                                {
                                if (publicRequestMetricsConfigurationFilterAndTagsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestMetricsConfigurationFilterAndTagsValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestMetricsConfigurationFilterAndTagsValue.Key));
                                    if(publicRequestMetricsConfigurationFilterAndTagsValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestMetricsConfigurationFilterAndTagsValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.MetricsConfiguration.Filter.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.Prefix));
                        if (publicRequest.MetricsConfiguration.Filter.Tag != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequest.MetricsConfiguration.Filter.Tag.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.Tag.Key));
                            if(publicRequest.MetricsConfiguration.Filter.Tag.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequest.MetricsConfiguration.Filter.Tag.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.MetricsConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.MetricsConfiguration.Id));


                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            request.UseQueryString = true;
            return request;
        }
        private static PutBucketMetricsConfigurationRequestMarshaller _instance = new PutBucketMetricsConfigurationRequestMarshaller();        

        internal static PutBucketMetricsConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketMetricsConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}