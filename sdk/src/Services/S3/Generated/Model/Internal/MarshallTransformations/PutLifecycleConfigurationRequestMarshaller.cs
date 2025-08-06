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
    /// PutLifecycleConfiguration Request Marshaller
    /// </summary>       
    public partial class PutLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutLifecycleConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutLifecycleConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutLifecycleConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("lifecycle");
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetTransitionDefaultMinimumObjectSize()) 
            {
                request.Headers["x-amz-transition-default-minimum-object-size"] = publicRequest.TransitionDefaultMinimumObjectSize;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutLifecycleConfigurationRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetConfiguration())
                {
                    xmlWriter.WriteStartElement("LifecycleConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    var publicRequestConfigurationRules = publicRequest.Configuration.Rules;
                    if (publicRequestConfigurationRules != null && (publicRequestConfigurationRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestConfigurationRulesValue in publicRequestConfigurationRules) 
                        {
                        if (publicRequestConfigurationRulesValue != null)
                        {
                            xmlWriter.WriteStartElement("Rule");
                            if (publicRequestConfigurationRulesValue.AbortIncompleteMultipartUpload != null)
                            {
                                xmlWriter.WriteStartElement("AbortIncompleteMultipartUpload");
                                if(publicRequestConfigurationRulesValue.AbortIncompleteMultipartUpload.IsSetDaysAfterInitiation())
                                    xmlWriter.WriteElementString("DaysAfterInitiation", StringUtils.FromInt(publicRequestConfigurationRulesValue.AbortIncompleteMultipartUpload.DaysAfterInitiation.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestConfigurationRulesValue.Expiration != null)
                            {
                                xmlWriter.WriteStartElement("Expiration");
                                if(publicRequestConfigurationRulesValue.Expiration.IsSetDate())
                                    xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestConfigurationRulesValue.Expiration.Date.Value));
                                if(publicRequestConfigurationRulesValue.Expiration.IsSetDays())
                                    xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequestConfigurationRulesValue.Expiration.Days.Value));
                                if(publicRequestConfigurationRulesValue.Expiration.IsSetExpiredObjectDeleteMarker())
                                    xmlWriter.WriteElementString("ExpiredObjectDeleteMarker", StringUtils.FromBool(publicRequestConfigurationRulesValue.Expiration.ExpiredObjectDeleteMarker.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequestConfigurationRulesValue.Filter != null)
                            {
                                if (publicRequestConfigurationRulesValue.Filter.LifecycleFilterPredicate != null)
                                {
                                    xmlWriter.WriteStartElement("Filter");
                                    publicRequestConfigurationRulesValue.Filter.LifecycleFilterPredicate.Accept(new LifecycleFilterPredicateMarshallVisitor(xmlWriter));
                                    xmlWriter.WriteEndElement();
                                }
                                else
                                {
                                    if (publicRequestConfigurationRulesValue.Filter != null)
                                    {
                                        xmlWriter.WriteStartElement("Filter");
                                        if (publicRequestConfigurationRulesValue.Filter.And != null)
                                        {
                                            xmlWriter.WriteStartElement("And");
                                            if(publicRequestConfigurationRulesValue.Filter.And.IsSetObjectSizeGreaterThan())
                                                xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.And.ObjectSizeGreaterThan.Value));
                                            if(publicRequestConfigurationRulesValue.Filter.And.IsSetObjectSizeLessThan())
                                                xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.And.ObjectSizeLessThan.Value));
                                            if(publicRequestConfigurationRulesValue.Filter.And.IsSetPrefix())
                                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.And.Prefix));
                                            var publicRequestConfigurationRulesValueFilterAndTags = publicRequestConfigurationRulesValue.Filter.And.Tags;
                                            if (publicRequestConfigurationRulesValueFilterAndTags != null && (publicRequestConfigurationRulesValueFilterAndTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                            {
                                                foreach (var publicRequestConfigurationRulesValueFilterAndTagsValue in publicRequestConfigurationRulesValueFilterAndTags) 
                                                {
                                                if (publicRequestConfigurationRulesValueFilterAndTagsValue != null)
                                                {
                                                    xmlWriter.WriteStartElement("Tag");
                                                    if(publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetKey())
                                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Key));
                                                    if(publicRequestConfigurationRulesValueFilterAndTagsValue.IsSetValue())
                                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValueFilterAndTagsValue.Value));
                                                    xmlWriter.WriteEndElement();
                                                }
                                                }            
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestConfigurationRulesValue.Filter.IsSetObjectSizeGreaterThan())
                                            xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.ObjectSizeGreaterThan.Value));
                                        if(publicRequestConfigurationRulesValue.Filter.IsSetObjectSizeLessThan())
                                            xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(publicRequestConfigurationRulesValue.Filter.ObjectSizeLessThan.Value));
                                        if(publicRequestConfigurationRulesValue.Filter.IsSetPrefix())
                                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Prefix));
                                        if (publicRequestConfigurationRulesValue.Filter.Tag != null)
                                        {
                                            xmlWriter.WriteStartElement("Tag");
                                            if(publicRequestConfigurationRulesValue.Filter.Tag.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Key));
                                            if(publicRequestConfigurationRulesValue.Filter.Tag.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestConfigurationRulesValue.Filter.Tag.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                        }

                                    }
                            if(publicRequestConfigurationRulesValue.IsSetId())
                                xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequestConfigurationRulesValue.Id));
                            if (publicRequestConfigurationRulesValue.NoncurrentVersionExpiration != null)
                            {
                                xmlWriter.WriteStartElement("NoncurrentVersionExpiration");
                                if(publicRequestConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNewerNoncurrentVersions())
                                    xmlWriter.WriteElementString("NewerNoncurrentVersions", StringUtils.FromInt(publicRequestConfigurationRulesValue.NoncurrentVersionExpiration.NewerNoncurrentVersions.Value));
                                if(publicRequestConfigurationRulesValue.NoncurrentVersionExpiration.IsSetNoncurrentDays())
                                    xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(publicRequestConfigurationRulesValue.NoncurrentVersionExpiration.NoncurrentDays.Value));
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestConfigurationRulesValueNoncurrentVersionTransitions = publicRequestConfigurationRulesValue.NoncurrentVersionTransitions;
                            if (publicRequestConfigurationRulesValueNoncurrentVersionTransitions != null && (publicRequestConfigurationRulesValueNoncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue in publicRequestConfigurationRulesValueNoncurrentVersionTransitions) 
                                {
                                if (publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue != null)
                                {
                                    xmlWriter.WriteStartElement("NoncurrentVersionTransition");
                                    if(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetNewerNoncurrentVersions())
                                        xmlWriter.WriteElementString("NewerNoncurrentVersions", StringUtils.FromInt(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.NewerNoncurrentVersions.Value));
                                    if(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetNoncurrentDays())
                                        xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.NoncurrentDays.Value));
                                    if(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestConfigurationRulesValueNoncurrentVersionTransitionsValue.StorageClass));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                            }
                            if(publicRequestConfigurationRulesValue.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequestConfigurationRulesValue.Prefix));
                            if(publicRequestConfigurationRulesValue.IsSetStatus())
                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequestConfigurationRulesValue.Status));
                            var publicRequestConfigurationRulesValueTransitions = publicRequestConfigurationRulesValue.Transitions;
                            if (publicRequestConfigurationRulesValueTransitions != null && (publicRequestConfigurationRulesValueTransitions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestConfigurationRulesValueTransitionsValue in publicRequestConfigurationRulesValueTransitions) 
                                {
                                if (publicRequestConfigurationRulesValueTransitionsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Transition");
                                    if(publicRequestConfigurationRulesValueTransitionsValue.IsSetDate())
                                        xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestConfigurationRulesValueTransitionsValue.Date.Value));
                                    if(publicRequestConfigurationRulesValueTransitionsValue.IsSetDays())
                                        xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequestConfigurationRulesValueTransitionsValue.Days.Value));
                                    if(publicRequestConfigurationRulesValueTransitionsValue.IsSetStorageClass())
                                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequestConfigurationRulesValueTransitionsValue.StorageClass));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
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
                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: true,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static PutLifecycleConfigurationRequestMarshaller _instance = new PutLifecycleConfigurationRequestMarshaller();        

        internal static PutLifecycleConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutLifecycleConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutLifecycleConfigurationRequest publicRequest);
    }    
}