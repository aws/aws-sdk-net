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
    /// PutBucketAnalyticsConfiguration Request Marshaller
    /// </summary>       
    public class PutBucketAnalyticsConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketAnalyticsConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketAnalyticsConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketAnalyticsConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("analytics");
        
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
                if (publicRequest.IsSetAnalyticsConfiguration())
                {
                    xmlWriter.WriteStartElement("AnalyticsConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.AnalyticsConfiguration.Filter != null)
                    {
                        xmlWriter.WriteStartElement("Filter");
                        if (publicRequest.AnalyticsConfiguration.Filter.And != null)
                        {
                            xmlWriter.WriteStartElement("And");
                            if(publicRequest.AnalyticsConfiguration.Filter.And.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.AnalyticsConfiguration.Filter.And.Prefix));
                            var publicRequestAnalyticsConfigurationFilterAndTags = publicRequest.AnalyticsConfiguration.Filter.And.Tags;
                            if (publicRequestAnalyticsConfigurationFilterAndTags != null && (publicRequestAnalyticsConfigurationFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestAnalyticsConfigurationFilterAndTagsValue in publicRequestAnalyticsConfigurationFilterAndTags) 
                                {
                                if (publicRequestAnalyticsConfigurationFilterAndTagsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestAnalyticsConfigurationFilterAndTagsValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestAnalyticsConfigurationFilterAndTagsValue.Key));
                                    if(publicRequestAnalyticsConfigurationFilterAndTagsValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestAnalyticsConfigurationFilterAndTagsValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.AnalyticsConfiguration.Filter.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.AnalyticsConfiguration.Filter.Prefix));
                        if (publicRequest.AnalyticsConfiguration.Filter.Tag != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequest.AnalyticsConfiguration.Filter.Tag.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.AnalyticsConfiguration.Filter.Tag.Key));
                            if(publicRequest.AnalyticsConfiguration.Filter.Tag.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequest.AnalyticsConfiguration.Filter.Tag.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.AnalyticsConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.AnalyticsConfiguration.Id));

                    if (publicRequest.AnalyticsConfiguration.StorageClassAnalysis != null)
                    {
                        xmlWriter.WriteStartElement("StorageClassAnalysis");
                        if (publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport != null)
                        {
                            xmlWriter.WriteStartElement("DataExport");
                            if (publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination != null)
                            {
                                xmlWriter.WriteStartElement("Destination");
                                if (publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination != null)
                                {
                                    xmlWriter.WriteStartElement("S3BucketDestination");
                                    if(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.IsSetBucketAccountId())
                                        xmlWriter.WriteElementString("BucketAccountId", StringUtils.FromString(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.BucketAccountId));
                                    if(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.IsSetBucketName())
                                        xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.BucketName));
                                    if(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.IsSetFormat())
                                        xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.Format));
                                    if(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination.S3BucketDestination.Prefix));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.IsSetOutputSchemaVersion())
                                xmlWriter.WriteElementString("OutputSchemaVersion", StringUtils.FromString(publicRequest.AnalyticsConfiguration.StorageClassAnalysis.DataExport.OutputSchemaVersion));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }

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
        private static PutBucketAnalyticsConfigurationRequestMarshaller _instance = new PutBucketAnalyticsConfigurationRequestMarshaller();        

        internal static PutBucketAnalyticsConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketAnalyticsConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}