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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutStorageLensConfiguration Request Marshaller
    /// </summary>       
    public partial class PutStorageLensConfigurationRequestMarshaller : IMarshaller<IRequest, PutStorageLensConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            PreMarshallCustomization(request, publicRequest);
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
                if (publicRequest.IsSetStorageLensConfiguration())
                {
                    xmlWriter.WriteStartElement("StorageLensConfiguration");
                    if (publicRequest.StorageLensConfiguration.IsSetAccountLevel())
                    {
                        xmlWriter.WriteStartElement("AccountLevel");
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetActivityMetrics())
                        {
                            xmlWriter.WriteStartElement("ActivityMetrics");
                            if(publicRequest.StorageLensConfiguration.AccountLevel.ActivityMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.ActivityMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetAdvancedCostOptimizationMetrics())
                        {
                            xmlWriter.WriteStartElement("AdvancedCostOptimizationMetrics");
                            if(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedCostOptimizationMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedCostOptimizationMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetAdvancedDataProtectionMetrics())
                        {
                            xmlWriter.WriteStartElement("AdvancedDataProtectionMetrics");
                            if(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedDataProtectionMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedDataProtectionMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetAdvancedPerformanceMetrics())
                        {
                            xmlWriter.WriteStartElement("AdvancedPerformanceMetrics");
                            if(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedPerformanceMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.AdvancedPerformanceMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetBucketLevel())
                        {
                            xmlWriter.WriteStartElement("BucketLevel");
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetActivityMetrics())
                            {
                                xmlWriter.WriteStartElement("ActivityMetrics");
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.ActivityMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.ActivityMetrics.IsEnabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetAdvancedCostOptimizationMetrics())
                            {
                                xmlWriter.WriteStartElement("AdvancedCostOptimizationMetrics");
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedCostOptimizationMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedCostOptimizationMetrics.IsEnabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetAdvancedDataProtectionMetrics())
                            {
                                xmlWriter.WriteStartElement("AdvancedDataProtectionMetrics");
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedDataProtectionMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedDataProtectionMetrics.IsEnabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetAdvancedPerformanceMetrics())
                            {
                                xmlWriter.WriteStartElement("AdvancedPerformanceMetrics");
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedPerformanceMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.AdvancedPerformanceMetrics.IsEnabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetDetailedStatusCodesMetrics())
                            {
                                xmlWriter.WriteStartElement("DetailedStatusCodesMetrics");
                                if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.DetailedStatusCodesMetrics.IsSetIsEnabled())
                                    xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.DetailedStatusCodesMetrics.IsEnabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.IsSetPrefixLevel())
                            {
                                xmlWriter.WriteStartElement("PrefixLevel");
                                if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.IsSetStorageMetrics())
                                {
                                    xmlWriter.WriteStartElement("StorageMetrics");
                                    if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.IsSetIsEnabled())
                                        xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.IsEnabled.Value));
                                    if (publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.IsSetSelectionCriteria())
                                    {
                                        xmlWriter.WriteStartElement("SelectionCriteria");
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetDelimiter())
                                            xmlWriter.WriteElementString("Delimiter", StringUtils.FromString(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.Delimiter));
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetMaxDepth())
                                            xmlWriter.WriteElementString("MaxDepth", StringUtils.FromInt(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.MaxDepth.Value));
                                        if(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.IsSetMinStorageBytesPercentage())
                                            xmlWriter.WriteElementString("MinStorageBytesPercentage", StringUtils.FromDouble(publicRequest.StorageLensConfiguration.AccountLevel.BucketLevel.PrefixLevel.StorageMetrics.SelectionCriteria.MinStorageBytesPercentage.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetDetailedStatusCodesMetrics())
                        {
                            xmlWriter.WriteStartElement("DetailedStatusCodesMetrics");
                            if(publicRequest.StorageLensConfiguration.AccountLevel.DetailedStatusCodesMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.AccountLevel.DetailedStatusCodesMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.AccountLevel.IsSetStorageLensGroupLevel())
                        {
                            xmlWriter.WriteStartElement("StorageLensGroupLevel");
                            if (publicRequest.StorageLensConfiguration.AccountLevel.StorageLensGroupLevel.IsSetSelectionCriteria())
                            {
                                xmlWriter.WriteStartElement("SelectionCriteria");
                                var publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExclude = publicRequest.StorageLensConfiguration.AccountLevel.StorageLensGroupLevel.SelectionCriteria.Exclude;
                                if (publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExclude != null && (publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExclude.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("Exclude");
                                    foreach (var publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExcludeValue in publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExclude) 
                                    {
                                        xmlWriter.WriteStartElement("Arn");
                                        xmlWriter.WriteValue(publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaExcludeValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                var publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaInclude = publicRequest.StorageLensConfiguration.AccountLevel.StorageLensGroupLevel.SelectionCriteria.Include;
                                if (publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaInclude != null && (publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaInclude.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("Include");
                                    foreach (var publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaIncludeValue in publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaInclude) 
                                    {
                                        xmlWriter.WriteStartElement("Arn");
                                        xmlWriter.WriteValue(publicRequestStorageLensConfigurationAccountLevelStorageLensGroupLevelSelectionCriteriaIncludeValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StorageLensConfiguration.IsSetAwsOrg())
                    {
                        xmlWriter.WriteStartElement("AwsOrg");
                        if(publicRequest.StorageLensConfiguration.AwsOrg.IsSetArn())
                            xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.StorageLensConfiguration.AwsOrg.Arn));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StorageLensConfiguration.IsSetDataExport())
                    {
                        xmlWriter.WriteStartElement("DataExport");
                        if (publicRequest.StorageLensConfiguration.DataExport.IsSetCloudWatchMetrics())
                        {
                            xmlWriter.WriteStartElement("CloudWatchMetrics");
                            if(publicRequest.StorageLensConfiguration.DataExport.CloudWatchMetrics.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.DataExport.CloudWatchMetrics.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.DataExport.IsSetS3BucketDestination())
                        {
                            xmlWriter.WriteStartElement("S3BucketDestination");
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetAccountId())
                                xmlWriter.WriteElementString("AccountId", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.AccountId));
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetArn())
                                xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Arn));
                            if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetEncryption())
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.IsSetSSEKMS())
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Encryption.IsSetSSES3())
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetFormat())
                                xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Format));
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetOutputSchemaVersion())
                                xmlWriter.WriteElementString("OutputSchemaVersion", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.OutputSchemaVersion));
                            if(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.S3BucketDestination.Prefix));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.DataExport.IsSetStorageLensTableDestination())
                        {
                            xmlWriter.WriteStartElement("StorageLensTableDestination");
                            if (publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.IsSetEncryption())
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if (publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.Encryption.IsSetSSEKMS())
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.Encryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.Encryption.IsSetSSES3())
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.DataExport.StorageLensTableDestination.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StorageLensConfiguration.IsSetExclude())
                    {
                        xmlWriter.WriteStartElement("Exclude");
                        var publicRequestStorageLensConfigurationExcludeBuckets = publicRequest.StorageLensConfiguration.Exclude.Buckets;
                        if (publicRequestStorageLensConfigurationExcludeBuckets != null && (publicRequestStorageLensConfigurationExcludeBuckets.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Buckets");
                            foreach (var publicRequestStorageLensConfigurationExcludeBucketsValue in publicRequestStorageLensConfigurationExcludeBuckets) 
                            {
                                xmlWriter.WriteStartElement("Arn");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationExcludeBucketsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensConfigurationExcludeRegions = publicRequest.StorageLensConfiguration.Exclude.Regions;
                        if (publicRequestStorageLensConfigurationExcludeRegions != null && (publicRequestStorageLensConfigurationExcludeRegions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Regions");
                            foreach (var publicRequestStorageLensConfigurationExcludeRegionsValue in publicRequestStorageLensConfigurationExcludeRegions) 
                            {
                                xmlWriter.WriteStartElement("Region");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationExcludeRegionsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.StorageLensConfiguration.IsSetExpandedPrefixesDataExport())
                    {
                        xmlWriter.WriteStartElement("ExpandedPrefixesDataExport");
                        if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.IsSetS3BucketDestination())
                        {
                            xmlWriter.WriteStartElement("S3BucketDestination");
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetAccountId())
                                xmlWriter.WriteElementString("AccountId", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.AccountId));
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetArn())
                                xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Arn));
                            if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetEncryption())
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Encryption.IsSetSSEKMS())
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Encryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Encryption.IsSetSSES3())
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetFormat())
                                xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Format));
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetOutputSchemaVersion())
                                xmlWriter.WriteElementString("OutputSchemaVersion", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.OutputSchemaVersion));
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.S3BucketDestination.Prefix));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.IsSetStorageLensTableDestination())
                        {
                            xmlWriter.WriteStartElement("StorageLensTableDestination");
                            if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.IsSetEncryption())
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.Encryption.IsSetSSEKMS())
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.Encryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.Encryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.Encryption.IsSetSSES3())
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.IsSetIsEnabled())
                                xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.ExpandedPrefixesDataExport.StorageLensTableDestination.IsEnabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StorageLensConfiguration.IsSetId())
                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.StorageLensConfiguration.Id));
                    if (publicRequest.StorageLensConfiguration.IsSetInclude())
                    {
                        xmlWriter.WriteStartElement("Include");
                        var publicRequestStorageLensConfigurationIncludeBuckets = publicRequest.StorageLensConfiguration.Include.Buckets;
                        if (publicRequestStorageLensConfigurationIncludeBuckets != null && (publicRequestStorageLensConfigurationIncludeBuckets.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Buckets");
                            foreach (var publicRequestStorageLensConfigurationIncludeBucketsValue in publicRequestStorageLensConfigurationIncludeBuckets) 
                            {
                                xmlWriter.WriteStartElement("Arn");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationIncludeBucketsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        var publicRequestStorageLensConfigurationIncludeRegions = publicRequest.StorageLensConfiguration.Include.Regions;
                        if (publicRequestStorageLensConfigurationIncludeRegions != null && (publicRequestStorageLensConfigurationIncludeRegions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Regions");
                            foreach (var publicRequestStorageLensConfigurationIncludeRegionsValue in publicRequestStorageLensConfigurationIncludeRegions) 
                            {
                                xmlWriter.WriteStartElement("Region");
                                xmlWriter.WriteValue(publicRequestStorageLensConfigurationIncludeRegionsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.StorageLensConfiguration.IsSetIsEnabled())
                        xmlWriter.WriteElementString("IsEnabled", StringUtils.FromBool(publicRequest.StorageLensConfiguration.IsEnabled.Value));
                    if(publicRequest.StorageLensConfiguration.IsSetPrefixDelimiter())
                        xmlWriter.WriteElementString("PrefixDelimiter", StringUtils.FromString(publicRequest.StorageLensConfiguration.PrefixDelimiter));
                    if(publicRequest.StorageLensConfiguration.IsSetStorageLensArn())
                        xmlWriter.WriteElementString("StorageLensArn", StringUtils.FromString(publicRequest.StorageLensConfiguration.StorageLensArn));
                    xmlWriter.WriteEndElement();
                }
                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && (publicRequestTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    if (publicRequestTagsValue != null)
                    {
                        xmlWriter.WriteStartElement("Tag");
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsValue.Key));
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsValue.Value));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutStorageLensConfigurationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutStorageLensConfigurationRequest publicRequest);
    }    
}