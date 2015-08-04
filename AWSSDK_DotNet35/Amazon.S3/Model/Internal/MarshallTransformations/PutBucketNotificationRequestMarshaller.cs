/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

#pragma warning disable 0618

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Notification Request Marshaller
    /// </summary>       
    public class PutBucketNotificationRequestMarshaller : IMarshaller<IRequest, PutBucketNotificationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketNotificationRequest)input);
		}

        public IRequest Marshall(PutBucketNotificationRequest putBucketNotificationRequest)
        {
            IRequest request = new DefaultRequest(putBucketNotificationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketNotificationRequest.BucketName));

            request.AddSubResource("notification");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("NotificationConfiguration", "");

                if (putBucketNotificationRequest.IsSetTopicConfigurations())
                {
                    foreach (var topicConfiguration in putBucketNotificationRequest.TopicConfigurations)
                    {
                        if (topicConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("TopicConfiguration", "");
                            if (topicConfiguration.IsSetId())
                            {
                                xmlWriter.WriteElementString("Id", "", S3Transforms.ToXmlStringValue(topicConfiguration.Id));
                            }
                            if (topicConfiguration.IsSetTopic())
                            {
                                xmlWriter.WriteElementString("Topic", "", S3Transforms.ToXmlStringValue(topicConfiguration.Topic));
                            }

                            WriteConfigurationCommon(xmlWriter, topicConfiguration);

                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                if (putBucketNotificationRequest.IsSetQueueConfigurations())
                {
                    foreach (var queueConfiguration in putBucketNotificationRequest.QueueConfigurations)
                    {
                        if (queueConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("QueueConfiguration", "");
                            if (queueConfiguration.IsSetId())
                            {
                                xmlWriter.WriteElementString("Id", "", S3Transforms.ToXmlStringValue(queueConfiguration.Id));
                            }
                            if (queueConfiguration.IsSetQueue())
                            {
                                xmlWriter.WriteElementString("Queue", "", S3Transforms.ToXmlStringValue(queueConfiguration.Queue));
                            }

                            WriteConfigurationCommon(xmlWriter, queueConfiguration);
                            
                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                if (putBucketNotificationRequest.IsSetCloudFunctionConfigurations())
                {
                    foreach (var cloudFunctionConfiguration in putBucketNotificationRequest.CloudFunctionConfigurations)
                    {
                        if (cloudFunctionConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("CloudFunctionConfiguration", "");
                            if (cloudFunctionConfiguration.IsSetId())
                            {
                                xmlWriter.WriteElementString("Id", "", S3Transforms.ToXmlStringValue(cloudFunctionConfiguration.Id));
                            }
                            if (cloudFunctionConfiguration.IsSetCloudFunction())
                            {
                                xmlWriter.WriteElementString("CloudFunction", "", S3Transforms.ToXmlStringValue(cloudFunctionConfiguration.CloudFunction));
                            }
                            if (cloudFunctionConfiguration.IsSetInvocationRole())
                            {
                                xmlWriter.WriteElementString("InvocationRole", "", S3Transforms.ToXmlStringValue(cloudFunctionConfiguration.InvocationRole));
                            }

                            WriteConfigurationCommon(xmlWriter, cloudFunctionConfiguration);

                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                if (putBucketNotificationRequest.IsSetLambdaFunctionConfigurations())
                {
                    foreach (var lambdaFunctionConfiguration in putBucketNotificationRequest.LambdaFunctionConfigurations)
                    {
                        if (lambdaFunctionConfiguration != null)
                        {
                            xmlWriter.WriteStartElement("CloudFunctionConfiguration", "");
                            if (lambdaFunctionConfiguration.IsSetId())
                            {
                                xmlWriter.WriteElementString("Id", "", S3Transforms.ToXmlStringValue(lambdaFunctionConfiguration.Id));
                            }
                            if (lambdaFunctionConfiguration.IsSetFunctionArn())
                            {
                                xmlWriter.WriteElementString("CloudFunction", "", S3Transforms.ToXmlStringValue(lambdaFunctionConfiguration.FunctionArn));
                            }

                            WriteConfigurationCommon(xmlWriter, lambdaFunctionConfiguration);

                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                xmlWriter.WriteEndElement();
            }
    
            try 
            {
                var content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";
                
                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;
                
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
        
            return request;
        }

        private static void WriteConfigurationCommon(XmlWriter xmlWriter, NotificationConfiguration notificationConfiguration)
        {
            if (notificationConfiguration.IsSetEvents())
            {
                foreach (var evnt in notificationConfiguration.Events)
                {
                    xmlWriter.WriteElementString("Event", "", S3Transforms.ToXmlStringValue(evnt));
                }
            }

            if (notificationConfiguration.IsSetFilter())
            {
                xmlWriter.WriteStartElement("Filter", "");
                var filter = notificationConfiguration.Filter;
                if (filter.IsSetS3KeyFilter())
                {
                    xmlWriter.WriteStartElement("S3Key", "");
                    var s3key = filter.S3KeyFilter;
                    if (s3key.IsSetFilterRules())
                    {
                        var filterRules = s3key.FilterRules;
                        foreach (var filterRule in filterRules)
                        {
                            if (filterRule != null)
                            {
                                xmlWriter.WriteStartElement("FilterRule", "");
                                xmlWriter.WriteElementString("Name", filterRule.Name);
                                xmlWriter.WriteElementString("Value", filterRule.Value);
                                xmlWriter.WriteEndElement();
                            }
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }
    }
}
    
