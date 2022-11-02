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
    /// PutBucketLifecycleConfiguration Request Marshaller
    /// </summary>       
    public class PutBucketLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketLifecycleConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
                    if (publicRequestLifecycleConfigurationRules != null && publicRequestLifecycleConfigurationRules.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Rules", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                        foreach (var publicRequestLifecycleConfigurationRulesValue in publicRequestLifecycleConfigurationRules) 
                        {
                        
                        if (publicRequestLifecycleConfigurationRulesValue != null) 
                        {
                            xmlWriter.WriteStartElement("Rule", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            
                            if (publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload != null) 
                            {
                                xmlWriter.WriteStartElement("AbortIncompleteMultipartUpload", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload.IsSetDaysAfterInitiation())
                                    xmlWriter.WriteElementString("DaysAfterInitiation", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.AbortIncompleteMultipartUpload.DaysAfterInitiation));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequestLifecycleConfigurationRulesValue.Expiration != null) 
                            {
                                xmlWriter.WriteStartElement("Expiration", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetDate())
                                    xmlWriter.WriteElementString("Date", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequestLifecycleConfigurationRulesValue.Expiration.Date));                 
                
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetDays())
                                    xmlWriter.WriteElementString("Days", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.Expiration.Days));                 
                
                                if(publicRequestLifecycleConfigurationRulesValue.Expiration.IsSetExpiredObjectDeleteMarker())
                                    xmlWriter.WriteElementString("ExpiredObjectDeleteMarker", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequestLifecycleConfigurationRulesValue.Expiration.ExpiredObjectDeleteMarker));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequestLifecycleConfigurationRulesValue.Filter != null) 
                            {
                                xmlWriter.WriteStartElement("Filter", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                
                                if (publicRequestLifecycleConfigurationRulesValue.Filter.And != null) 
                                {
                                    xmlWriter.WriteStartElement("And", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetObjectSizeGreaterThan())
                                        xmlWriter.WriteElementString("ObjectSizeGreaterThan", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.And.ObjectSizeGreaterThan));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetObjectSizeLessThan())
                                        xmlWriter.WriteElementString("ObjectSizeLessThan", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.And.ObjectSizeLessThan));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.And.IsSetPrefix())
                                        xmlWriter.WriteElementString("Prefix", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.And.Prefix));                 
                    
                                    var publicRequestLifecycleConfigurationRulesValueFilterAndTags = publicRequestLifecycleConfigurationRulesValue.Filter.And.Tags;
                                    if (publicRequestLifecycleConfigurationRulesValueFilterAndTags != null && publicRequestLifecycleConfigurationRulesValueFilterAndTags.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Tags", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                        foreach (var publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue in publicRequestLifecycleConfigurationRulesValueFilterAndTags) 
                                        {
                                        
                                        if (publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                            if(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                                xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.Key));                 
                            
                                            if(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueFilterAndTagsValue.Value));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetObjectSizeGreaterThan())
                                    xmlWriter.WriteElementString("ObjectSizeGreaterThan", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.ObjectSizeGreaterThan));                 
                
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetObjectSizeLessThan())
                                    xmlWriter.WriteElementString("ObjectSizeLessThan", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromLong(publicRequestLifecycleConfigurationRulesValue.Filter.ObjectSizeLessThan));                 
                
                                if(publicRequestLifecycleConfigurationRulesValue.Filter.IsSetPrefix())
                                    xmlWriter.WriteElementString("Prefix", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Prefix));                 
                
                                
                                if (publicRequestLifecycleConfigurationRulesValue.Filter.Tag != null) 
                                {
                                    xmlWriter.WriteStartElement("Tag", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.IsSetKey())
                                        xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.Key));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.IsSetValue())
                                        xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Filter.Tag.Value));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestLifecycleConfigurationRulesValue.IsSetID())
                                xmlWriter.WriteElementString("ID", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.ID));                 
            
                            
                            if (publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration != null) 
                            {
                                xmlWriter.WriteStartElement("NoncurrentVersionExpiration", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNewerNoncurrentVersions())
                                    xmlWriter.WriteElementString("NewerNoncurrentVersions", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.NewerNoncurrentVersions));                 
                
                                if(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNoncurrentDays())
                                    xmlWriter.WriteElementString("NoncurrentDays", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionExpiration.NoncurrentDays));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions = publicRequestLifecycleConfigurationRulesValue.NoncurrentVersionTransitions;
                            if (publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions != null && publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("NoncurrentVersionTransitions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                foreach (var publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue in publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitions) 
                                {
                                
                                if (publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("NoncurrentVersionTransition", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetNoncurrentDays())
                                        xmlWriter.WriteElementString("NoncurrentDays", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.NoncurrentDays));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueNoncurrentVersionTransitionsValue.StorageClass));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequestLifecycleConfigurationRulesValue.IsSetStatus())
                                xmlWriter.WriteElementString("Status", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValue.Status));                 
            
                            var publicRequestLifecycleConfigurationRulesValueTransitions = publicRequestLifecycleConfigurationRulesValue.Transitions;
                            if (publicRequestLifecycleConfigurationRulesValueTransitions != null && publicRequestLifecycleConfigurationRulesValueTransitions.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Transitions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                foreach (var publicRequestLifecycleConfigurationRulesValueTransitionsValue in publicRequestLifecycleConfigurationRulesValueTransitions) 
                                {
                                
                                if (publicRequestLifecycleConfigurationRulesValueTransitionsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("Transition", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetDate())
                                        xmlWriter.WriteElementString("Date", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequestLifecycleConfigurationRulesValueTransitionsValue.Date));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetDays())
                                        xmlWriter.WriteElementString("Days", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestLifecycleConfigurationRulesValueTransitionsValue.Days));                 
                    
                                    if(publicRequestLifecycleConfigurationRulesValueTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestLifecycleConfigurationRulesValueTransitionsValue.StorageClass));                 
                    
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
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetRequestChecksumMD5(request);
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

    }    
}