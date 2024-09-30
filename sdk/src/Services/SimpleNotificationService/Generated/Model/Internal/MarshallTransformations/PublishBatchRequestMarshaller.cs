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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublishBatch Request Marshaller
    /// </summary>       
    public class PublishBatchRequestMarshaller : IMarshaller<IRequest, PublishBatchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishBatchRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PublishBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.Parameters.Add("Action", "PublishBatch");
            request.Parameters.Add("Version", "2010-03-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetPublishBatchRequestEntries())
                {
                    if (publicRequest.PublishBatchRequestEntries.Count == 0)
                        request.Parameters.Add("PublishBatchRequestEntries", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PublishBatchRequestEntries)
                         {
                            if(publicRequestlistValue.IsSetId())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                            }
                            if(publicRequestlistValue.IsSetMessage())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Message", StringUtils.FromString(publicRequestlistValue.Message));
                            }
                            if(publicRequestlistValue.IsSetMessageAttributes())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.MessageAttributes.Keys)
                                {
                                    MessageAttributeValue value;
                                    bool hasValue = publicRequestlistValue.MessageAttributes.TryGetValue(key, out value);
                                    request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Name", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        if(value.IsSetBinaryValue())
                                        {
                                            request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "BinaryValue", StringUtils.FromMemoryStream(value.BinaryValue));
                                        }
                                        if(value.IsSetDataType())
                                        {
                                            request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "DataType", StringUtils.FromString(value.DataType));
                                        }
                                        if(value.IsSetStringValue())
                                        {
                                            request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageAttributes" + "." + "entry" + "." + mapIndex + "." + "Value" + "." + "StringValue", StringUtils.FromString(value.StringValue));
                                        }
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.IsSetMessageDeduplicationId())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageDeduplicationId", StringUtils.FromString(publicRequestlistValue.MessageDeduplicationId));
                            }
                            if(publicRequestlistValue.IsSetMessageGroupId())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageGroupId", StringUtils.FromString(publicRequestlistValue.MessageGroupId));
                            }
                            if(publicRequestlistValue.IsSetMessageStructure())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MessageStructure", StringUtils.FromString(publicRequestlistValue.MessageStructure));
                            }
                            if(publicRequestlistValue.IsSetSubject())
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Subject", StringUtils.FromString(publicRequestlistValue.Subject));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTopicArn())
                {
                    request.Parameters.Add("TopicArn", StringUtils.FromString(publicRequest.TopicArn));
                }
            }
            return request;
        }
                    private static PublishBatchRequestMarshaller _instance = new PublishBatchRequestMarshaller();        

        internal static PublishBatchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PublishBatchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}