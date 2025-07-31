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
    /// PutBucketNotification Request Marshaller
    /// </summary>       
    public partial class PutBucketNotificationRequestMarshaller : IMarshaller<IRequest, PutBucketNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketNotificationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketNotificationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
            request.AddSubResource("notification");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetSkipDestinationValidation()) 
            {
                request.Headers["x-amz-skip-destination-validation"] = StringUtils.FromBool(publicRequest.SkipDestinationValidation);
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketNotificationRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                    xmlWriter.WriteStartElement("NotificationConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.EventBridgeConfiguration != null)
                    {
                        xmlWriter.WriteStartElement("EventBridgeConfiguration");
                        xmlWriter.WriteEndElement();
                    }
                    var publicRequestLambdaFunctionConfigurations = publicRequest.LambdaFunctionConfigurations;
                    if (publicRequestLambdaFunctionConfigurations != null && (publicRequestLambdaFunctionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestLambdaFunctionConfigurationsValue in publicRequestLambdaFunctionConfigurations) 
                        {
                        if (publicRequestLambdaFunctionConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("CloudFunctionConfiguration");
                            var publicRequestLambdaFunctionConfigurationsValueEvents = publicRequestLambdaFunctionConfigurationsValue.Events;
                            if (publicRequestLambdaFunctionConfigurationsValueEvents != null && (publicRequestLambdaFunctionConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestLambdaFunctionConfigurationsValueEventsValue in publicRequestLambdaFunctionConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("Event");
                                    xmlWriter.WriteValue(publicRequestLambdaFunctionConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            if (publicRequestLambdaFunctionConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestLambdaFunctionConfigurationsValue.Filter.S3KeyFilter != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRules = publicRequestLambdaFunctionConfigurationsValue.Filter.S3KeyFilter.FilterRules;
                                    if (publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRules != null && (publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        foreach (var publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue in publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRules) 
                                        {
                                        if (publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("FilterRule");
                                            if(publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue.Name));
                                            if(publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestLambdaFunctionConfigurationsValueFilterS3KeyFilterFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestLambdaFunctionConfigurationsValue.IsSetFunctionArn())
                                xmlWriter.WriteElementString("CloudFunction", StringUtils.FromString(publicRequestLambdaFunctionConfigurationsValue.FunctionArn));
                            if(publicRequestLambdaFunctionConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestLambdaFunctionConfigurationsValue.Id));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }
                    var publicRequestQueueConfigurations = publicRequest.QueueConfigurations;
                    if (publicRequestQueueConfigurations != null && (publicRequestQueueConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestQueueConfigurationsValue in publicRequestQueueConfigurations) 
                        {
                        if (publicRequestQueueConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("QueueConfiguration");
                            var publicRequestQueueConfigurationsValueEvents = publicRequestQueueConfigurationsValue.Events;
                            if (publicRequestQueueConfigurationsValueEvents != null && (publicRequestQueueConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestQueueConfigurationsValueEventsValue in publicRequestQueueConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("Event");
                                    xmlWriter.WriteValue(publicRequestQueueConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            if (publicRequestQueueConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestQueueConfigurationsValue.Filter.S3KeyFilter != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRules = publicRequestQueueConfigurationsValue.Filter.S3KeyFilter.FilterRules;
                                    if (publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRules != null && (publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        foreach (var publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue in publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRules) 
                                        {
                                        if (publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("FilterRule");
                                            if(publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue.Name));
                                            if(publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestQueueConfigurationsValueFilterS3KeyFilterFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestQueueConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestQueueConfigurationsValue.Id));
                            if(publicRequestQueueConfigurationsValue.IsSetQueue())
                                xmlWriter.WriteElementString("Queue", StringUtils.FromString(publicRequestQueueConfigurationsValue.Queue));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }
                    var publicRequestTopicConfigurations = publicRequest.TopicConfigurations;
                    if (publicRequestTopicConfigurations != null && (publicRequestTopicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        foreach (var publicRequestTopicConfigurationsValue in publicRequestTopicConfigurations) 
                        {
                        if (publicRequestTopicConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("TopicConfiguration");
                            var publicRequestTopicConfigurationsValueEvents = publicRequestTopicConfigurationsValue.Events;
                            if (publicRequestTopicConfigurationsValueEvents != null && (publicRequestTopicConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                foreach (var publicRequestTopicConfigurationsValueEventsValue in publicRequestTopicConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("Event");
                                    xmlWriter.WriteValue(publicRequestTopicConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                            }
                            if (publicRequestTopicConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestTopicConfigurationsValue.Filter.S3KeyFilter != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRules = publicRequestTopicConfigurationsValue.Filter.S3KeyFilter.FilterRules;
                                    if (publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRules != null && (publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        foreach (var publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue in publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRules) 
                                        {
                                        if (publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("FilterRule");
                                            if(publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue.Name));
                                            if(publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTopicConfigurationsValueFilterS3KeyFilterFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestTopicConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestTopicConfigurationsValue.Id));
                            if(publicRequestTopicConfigurationsValue.IsSetTopic())
                                xmlWriter.WriteElementString("Topic", StringUtils.FromString(publicRequestTopicConfigurationsValue.Topic));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                    }

                    xmlWriter.WriteEndElement();
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
        private static PutBucketNotificationRequestMarshaller _instance = new PutBucketNotificationRequestMarshaller();        

        internal static PutBucketNotificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketNotificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketNotificationRequest publicRequest);
    }    
}