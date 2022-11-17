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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutStorageLensConfiguration Request Marshaller
    /// </summary>       
    public class PutStorageLensConfigurationRequestMarshaller : IMarshaller<IRequest, PutStorageLensConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutStorageLensConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutStorageLensConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetConfigId())
                throw new AmazonS3ControlException("Request object does not have required field ConfigId set");
            request.AddPathResource("{storagelensid}", StringUtils.FromString(publicRequest.ConfigId));
            request.ResourcePath = "/v20180820/storagelens/{storagelensid}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("PutStorageLensConfigurationRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                
                if (publicRequest.StorageLensConfiguration != null) 
                {
                    xmlWriter.WriteStartElement("StorageLensConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    
                    if (publicRequest.StorageLensConfiguration.AccountLevel != null) 
                    {
                        xmlWriter.WriteStartElement("AccountLevel", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        
                        if (publicRequest.StorageLensConfiguration.AccountLevel.ActivityMetrics != null) 
                        {
                            xmlWriter.WriteStartElement("ActivityMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.AccountLevel.ActivityMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.ActivityMetrics.IsEnabled));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.StorageLensConfiguration.AccountLevel.AdvancedCostOptimizationMetrics != null) 
                        {
                            xmlWriter.WriteStartElement("AdvancedCostOptimizationMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedCostOptimizationMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedCostOptimizationMetrics.IsEnabled));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.StorageLensConfiguration.AccountLevel.AdvancedDataProtectionMetrics != null) 
                        {
                            xmlWriter.WriteStartElement("AdvancedDataProtectionMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedDataProtectionMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedDataProtectionMetrics.IsEnabled));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel != null) 
                        {
                            xmlWriter.WriteStartElement("BucketLevel", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.ActivityMetrics != null) 
                            {
                                xmlWriter.WriteStartElement("ActivityMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.ActivityMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.ActivityMetrics.IsEnabled));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedCostOptimizationMetrics != null) 
                            {
                                xmlWriter.WriteStartElement("AdvancedCostOptimizationMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedCostOptimizationMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedCostOptimizationMetrics.IsEnabled));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedDataProtectionMetrics != null) 
                            {
                                xmlWriter.WriteStartElement("AdvancedDataProtectionMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedDataProtectionMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedDataProtectionMetrics.IsEnabled));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.DetailedStatusCodesMetrics != null) 
                            {
                                xmlWriter.WriteStartElement("DetailedStatusCodesMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.DetailedStatusCodesMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.DetailedStatusCodesMetrics.IsEnabled));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel != null) 
                            {
                                xmlWriter.WriteStartElement("PrefixLevel", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                
                                if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics != null) 
                                {
                                    xmlWriter.WriteStartElement("StorageMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.IsSetIsEnabled())
                                        xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.IsEnabled));                 
                    
                                    
                                    if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria != null) 
                                    {
                                        xmlWriter.WriteStartElement("SelectionCriteria", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetDelimiter())
                                            xmlWriter.WriteElementString("Delimiter", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.Delimiter));                 
                        
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetMaxDepth())
                                            xmlWriter.WriteElementString("MaxDepth", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.MaxDepth));                 
                        
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetMinStorageBytesPercentage())
                                            xmlWriter.WriteElementString("MinStorageBytesPercentage", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDouble(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.MinStorageBytesPercentage));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.StorageLensConfiguration.AccountLevel.DetailedStatusCodesMetrics != null) 
                        {
                            xmlWriter.WriteStartElement("DetailedStatusCodesMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.AccountLevel.DetailedStatusCodesMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.DetailedStatusCodesMetrics.IsEnabled));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.StorageLensConfiguration.AwsOrg != null) 
                    {
                        xmlWriter.WriteStartElement("AwsOrg", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.StorageLensConfiguration.AwsOrg.IsSetArn())
                            xmlWriter.WriteElementString("Arn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.AwsOrg.Arn));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.StorageLensConfiguration.DataExport != null) 
                    {
                        xmlWriter.WriteStartElement("DataExport", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        
                        if (publicRequest.StorageLensConfiguration.DataExport.CloudWatchMetrics != null) 
                        {
                            xmlWriter.WriteStartElement("CloudWatchMetrics", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.DataExport.CloudWatchMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.DataExport.CloudWatchMetrics.IsEnabled));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination != null) 
                        {
                            xmlWriter.WriteStartElement("S3BucketDestination", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetAccountId())
                                xmlWriter.WriteElementString("AccountId", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.AccountId));                 
            
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetArn())
                                xmlWriter.WriteElementString("Arn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Arn));                 
            
                            
                            if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption != null) 
                            {
                                xmlWriter.WriteStartElement("Encryption", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                
                                if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSEKMS != null) 
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSEKMS.KeyId));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSES3 != null) 
                                {
                                    xmlWriter.WriteStartElement("SSE-S3", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetFormat())
                                xmlWriter.WriteElementString("Format", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Format));                 
            
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetOutputSchemaVersion())
                                xmlWriter.WriteElementString("OutputSchemaVersion", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.OutputSchemaVersion));                 
            
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Prefix));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.StorageLensConfiguration.Exclude != null) 
                    {
                        xmlWriter.WriteStartElement("Exclude", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        var publicRequestStorageLensConfigurationExcludeBuckets = publicRequest.StorageLensConfiguration.Exclude.Buckets;
                        if (publicRequestStorageLensConfigurationExcludeBuckets != null && publicRequestStorageLensConfigurationExcludeBuckets.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Buckets", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestStorageLensConfigurationExcludeBucketsValue in publicRequestStorageLensConfigurationExcludeBuckets) 
                            {
                                xmlWriter.WriteStartElement("Arn", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationExcludeBucketsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensConfigurationExcludeRegions = publicRequest.StorageLensConfiguration.Exclude.Regions;
                        if (publicRequestStorageLensConfigurationExcludeRegions != null && publicRequestStorageLensConfigurationExcludeRegions.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Regions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestStorageLensConfigurationExcludeRegionsValue in publicRequestStorageLensConfigurationExcludeRegions) 
                            {
                                xmlWriter.WriteStartElement("Region", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationExcludeRegionsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StorageLensConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.Id));                 
    
                    
                    if (publicRequest.StorageLensConfiguration.Include != null) 
                    {
                        xmlWriter.WriteStartElement("Include", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        var publicRequestStorageLensConfigurationIncludeBuckets = publicRequest.StorageLensConfiguration.Include.Buckets;
                        if (publicRequestStorageLensConfigurationIncludeBuckets != null && publicRequestStorageLensConfigurationIncludeBuckets.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Buckets", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestStorageLensConfigurationIncludeBucketsValue in publicRequestStorageLensConfigurationIncludeBuckets) 
                            {
                                xmlWriter.WriteStartElement("Arn", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationIncludeBucketsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensConfigurationIncludeRegions = publicRequest.StorageLensConfiguration.Include.Regions;
                        if (publicRequestStorageLensConfigurationIncludeRegions != null && publicRequestStorageLensConfigurationIncludeRegions.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Regions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestStorageLensConfigurationIncludeRegionsValue in publicRequestStorageLensConfigurationIncludeRegions) 
                            {
                                xmlWriter.WriteStartElement("Region", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationIncludeRegionsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StorageLensConfiguration.IsSetIsEnabled())
                        xmlWriter.WriteElementString("IsEnabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.StorageLensConfiguration.IsEnabled));                 
    
                    if(publicRequest.StorageLensConfiguration.IsSetStorageLensArn())
                        xmlWriter.WriteElementString("StorageLensArn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.StorageLensConfiguration.StorageLensArn));                 
    
                    xmlWriter.WriteEndElement();
                }
                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && publicRequestTags.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Tags", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    
                    if (publicRequestTagsValue != null) 
                    {
                        xmlWriter.WriteStartElement("Tag", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Key));                 
        
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Value));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static PutStorageLensConfigurationRequestMarshaller _instance = new PutStorageLensConfigurationRequestMarshaller();        

        internal static PutStorageLensConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutStorageLensConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}