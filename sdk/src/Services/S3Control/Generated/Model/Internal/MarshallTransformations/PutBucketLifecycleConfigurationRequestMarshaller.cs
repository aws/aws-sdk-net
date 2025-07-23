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
    /// PutBucketLifecycleConfiguration Request Marshaller
    /// </summary>       
    public partial class PutBucketLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketLifecycleConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketLifecycleConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketLifecycleConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetBucket())
                throw new AmazonS3ControlException("Request object does not have required field Bucket set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Bucket));
            request.ResourcePath = "/v20180820/bucket/{name}/lifecycleconfiguration";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetLifecycleConfiguration())
                {
                    xmlWriter.WriteStartElement("LifecycleConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    var publicRequestLifecycleConfigurationRules = publicRequest.LifecycleConfiguration.Rules;
                    if (publicRequestLifecycleConfigurationRules != null && (publicRequestLifecycleConfigurationRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Rules");
                        foreach (var publicRequestLifecycleConfigurationRulesValue in publicRequestLifecycleConfigurationRules) 
                        {
                        if (publicRequestLifecycleConfigurationRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if (publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload != null)
                            {
                                xmlWriter.WriteStartElement("AbortIncompleteMultipartUpload");
                                if(publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload.IsSetDaysAfterInitiation())
                                    xmlWriter.WriteElementString("DaysAfterInitiation", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload.DaysAfterInitiation.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestLifecycleConfigurationRulesValue.Expiration != null)
                            {
                                xmlWriter.WriteStartElement("Expiration");
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetDate())
                                    xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestLifecycleConfigurationRulesValue.Expiration.Date.Value));
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetDays())
                                    xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.Expiration.Days.Value));
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetExpiredObjectDeleteMarker())
                                    xmlWriter.WriteElementString("ExpiredObjectDeleteMarker", StringUtils.FromBool(publicRequestLifecycleConfigurationRulesValue.Expiration.ExpiredObjectDeleteMarker.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestLifecycleConfigurationRulesValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestLifecycleConfigurationRulesValue.Filter.And != null)
                                {
                                    xmlWriter.WriteStartElement("And");
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetObjectSizeGreaterThan())
                                        xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.And.ObjectSizeGreaterThan.Value));
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetObjectSizeLessThan())
                                        xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.And.ObjectSizeLessThan.Value));
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.And.Prefix));
                                    var publicRequestLifecycleConfigurationRulesValueFilterAndTags = publicRequestLifecycleConfigurationRulesValue.Filter.And.Tags;
                                    if (publicRequestLifecycleConfigurationRulesValueFilterAndTags != null && (publicRequestLifecycleConfigurationRulesValueFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Tags");
                                        foreach (var publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue in publicRequestLifecycleConfigurationRulesValueFilterAndTags) 
                                        {
                                        if (publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("member");
                                            if(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.Key));
                                            if(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetObjectSizeGreaterThan())
                                    xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.ObjectSizeGreaterThan.Value));
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetObjectSizeLessThan())
                                    xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.ObjectSizeLessThan.Value));
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetPrefix())
                                    xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Prefix));
                                if (publicRequestLifecycleConfigurationRulesValue.Filter.Tag != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.Key));
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestLifecycleConfigurationRulesValue.IsSetID())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.ID));
                            if (publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration != null)
                            {
                                xmlWriter.WriteStartElement("NoncurrentVersionExpiration");
                                if(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNewerNoncurrentVersions())
                                    xmlWriter.WriteElementString("NewerNoncurrentVersions", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.NewerNoncurrentVersions.Value));
                                if(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNoncurrentDays())
                                    xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.NoncurrentDays.Value));
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions = publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionTransitions;
                            if (publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions != null && (publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("NoncurrentVersionTransitions");
                                foreach (var publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue in publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions) 
                                {
                                if (publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue != null)
                                {
                                    xmlWriter.WriteStartElement("NoncurrentVersionTransition");
                                    if(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetNoncurrentDays())
                                        xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.NoncurrentDays.Value));
                                    if(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.StorageClass));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequestLifecycleConfigurationRulesValue.IsSetStatus())
                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Status));
                            var publicRequestLifecycleConfigurationRulesValueTransitions = publicRequestLifecycleConfigurationRulesValue.Transitions;
                            if (publicRequestLifecycleConfigurationRulesValueTransitions != null && (publicRequestLifecycleConfigurationRulesValueTransitions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Transitions");
                                foreach (var publicRequestLifecycleConfigurationRulesValueTransitionsValue in publicRequestLifecycleConfigurationRulesValueTransitions) 
                                {
                                if (publicRequestLifecycleConfigurationRulesValueTransitionsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Transition");
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetDate())
                                        xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestLifecycleConfigurationRulesValueTransitionsValue.Date.Value));
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetDays())
                                        xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValueTransitionsValue.Days.Value));
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueTransitionsValue.StorageClass));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetChecksumData(request);
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static PutBucketLifecycleConfigurationRequestMarshaller _instance = new PutBucketLifecycleConfigurationRequestMarshaller();        

        internal static PutBucketLifecycleConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketLifecycleConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketLifecycleConfigurationRequest publicRequest);
    }    
}