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
    public class PutBucketNotificationRequestMarshaller : IMarshaller<IRequest, PutBucketNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetNotificationConfiguration())
                {
                    xmlWriter.WriteStartElement("NotificationConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.NotificationConfiguration.EventBridgeConfiguration != null)
                    {
                        xmlWriter.WriteStartElement("EventBridgeConfiguration");
                        xmlWriter.WriteEndElement();
                    }
                    var publicRequestNotificationConfigurationLambdaFunctionConfigurations = publicRequest.NotificationConfiguration.LambdaFunctionConfigurations;
                    if (publicRequestNotificationConfigurationLambdaFunctionConfigurations != null && (publicRequestNotificationConfigurationLambdaFunctionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("CloudFunctionConfiguration");
                        foreach (var publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue in publicRequestNotificationConfigurationLambdaFunctionConfigurations) 
                        {
                        if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            var publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEvents = publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.Events;
                            if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEvents != null && (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Event");
                                foreach (var publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEventsValue in publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.Filter.Key != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRules = publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.Filter.Key.FilterRules;
                                    if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRules != null && (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("FilterRule");
                                        foreach (var publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue in publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRules) 
                                        {
                                        if (publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("member");
                                            if(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue.Name));
                                            if(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValueFilterKeyFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.Id));
                            if(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.IsSetLambdaFunctionArn())
                                xmlWriter.WriteElementString("CloudFunction", StringUtils.FromString(publicRequestNotificationConfigurationLambdaFunctionConfigurationsValue.LambdaFunctionArn));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    var publicRequestNotificationConfigurationQueueConfigurations = publicRequest.NotificationConfiguration.QueueConfigurations;
                    if (publicRequestNotificationConfigurationQueueConfigurations != null && (publicRequestNotificationConfigurationQueueConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("QueueConfiguration");
                        foreach (var publicRequestNotificationConfigurationQueueConfigurationsValue in publicRequestNotificationConfigurationQueueConfigurations) 
                        {
                        if (publicRequestNotificationConfigurationQueueConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            var publicRequestNotificationConfigurationQueueConfigurationsValueEvents = publicRequestNotificationConfigurationQueueConfigurationsValue.Events;
                            if (publicRequestNotificationConfigurationQueueConfigurationsValueEvents != null && (publicRequestNotificationConfigurationQueueConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Event");
                                foreach (var publicRequestNotificationConfigurationQueueConfigurationsValueEventsValue in publicRequestNotificationConfigurationQueueConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestNotificationConfigurationQueueConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequestNotificationConfigurationQueueConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestNotificationConfigurationQueueConfigurationsValue.Filter.Key != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRules = publicRequestNotificationConfigurationQueueConfigurationsValue.Filter.Key.FilterRules;
                                    if (publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRules != null && (publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("FilterRule");
                                        foreach (var publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue in publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRules) 
                                        {
                                        if (publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("member");
                                            if(publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue.Name));
                                            if(publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestNotificationConfigurationQueueConfigurationsValueFilterKeyFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestNotificationConfigurationQueueConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestNotificationConfigurationQueueConfigurationsValue.Id));
                            if(publicRequestNotificationConfigurationQueueConfigurationsValue.IsSetQueueArn())
                                xmlWriter.WriteElementString("Queue", StringUtils.FromString(publicRequestNotificationConfigurationQueueConfigurationsValue.QueueArn));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    var publicRequestNotificationConfigurationTopicConfigurations = publicRequest.NotificationConfiguration.TopicConfigurations;
                    if (publicRequestNotificationConfigurationTopicConfigurations != null && (publicRequestNotificationConfigurationTopicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("TopicConfiguration");
                        foreach (var publicRequestNotificationConfigurationTopicConfigurationsValue in publicRequestNotificationConfigurationTopicConfigurations) 
                        {
                        if (publicRequestNotificationConfigurationTopicConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            var publicRequestNotificationConfigurationTopicConfigurationsValueEvents = publicRequestNotificationConfigurationTopicConfigurationsValue.Events;
                            if (publicRequestNotificationConfigurationTopicConfigurationsValueEvents != null && (publicRequestNotificationConfigurationTopicConfigurationsValueEvents.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Event");
                                foreach (var publicRequestNotificationConfigurationTopicConfigurationsValueEventsValue in publicRequestNotificationConfigurationTopicConfigurationsValueEvents) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestNotificationConfigurationTopicConfigurationsValueEventsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequestNotificationConfigurationTopicConfigurationsValue.Filter != null)
                            {
                                xmlWriter.WriteStartElement("Filter");
                                if (publicRequestNotificationConfigurationTopicConfigurationsValue.Filter.Key != null)
                                {
                                    xmlWriter.WriteStartElement("S3Key");
                                    var publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRules = publicRequestNotificationConfigurationTopicConfigurationsValue.Filter.Key.FilterRules;
                                    if (publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRules != null && (publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRules.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("FilterRule");
                                        foreach (var publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue in publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRules) 
                                        {
                                        if (publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue != null)
                                        {
                                            xmlWriter.WriteStartElement("member");
                                            if(publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue.IsSetName())
                                                xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue.Name));
                                            if(publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestNotificationConfigurationTopicConfigurationsValueFilterKeyFilterRulesValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestNotificationConfigurationTopicConfigurationsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestNotificationConfigurationTopicConfigurationsValue.Id));
                            if(publicRequestNotificationConfigurationTopicConfigurationsValue.IsSetTopicArn())
                                xmlWriter.WriteElementString("Topic", StringUtils.FromString(publicRequestNotificationConfigurationTopicConfigurationsValue.TopicArn));
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

    }    
}