/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMessageBatch Request Marshaller
    /// </summary>       
    public class SendMessageBatchRequestMarshaller : IMarshaller<IRequest, SendMessageBatchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMessageBatchRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendMessageBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "SendMessageBatch");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEntries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Entries)
                    {
                        if(publicRequestlistValue.IsSetDelaySeconds())
                        {
                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "DelaySeconds", StringUtils.FromInt(publicRequestlistValue.DelaySeconds));
                        }
                        if(publicRequestlistValue.IsSetId())
                        {
                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                        }
                        if(publicRequestlistValue.IsSetMessageAttributes())
                        {
                            int mapIndex = 1;
                            foreach(var key in publicRequestlistValue.MessageAttributes.Keys)
                            {
                                MessageAttributeValue value;
                                bool hasValue = publicRequestlistValue.MessageAttributes.TryGetValue(key, out value);
                                request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Name", StringUtils.FromString(key));
                                if (hasValue)
                                {
                                    if(value.IsSetBinaryListValues())
                                    {
                                        int valuelistValueIndex = 1;
                                        foreach(var valuelistValue in value.BinaryListValues)
                                        {
                                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "BinaryListValue" + "." + "member" + "." + valuelistValueIndex, StringUtils.FromMemoryStream(valuelistValue));
                                            valuelistValueIndex++;
                                        }
                                    }
                                    if(value.IsSetBinaryValue())
                                    {
                                        request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "BinaryValue", StringUtils.FromMemoryStream(value.BinaryValue));
                                    }
                                    if(value.IsSetDataType())
                                    {
                                        request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "DataType", StringUtils.FromString(value.DataType));
                                    }
                                    if(value.IsSetStringListValues())
                                    {
                                        int valuelistValueIndex = 1;
                                        foreach(var valuelistValue in value.StringListValues)
                                        {
                                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "StringListValue" + "." + "member" + "." + valuelistValueIndex, StringUtils.FromString(valuelistValue));
                                            valuelistValueIndex++;
                                        }
                                    }
                                    if(value.IsSetStringValue())
                                    {
                                        request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "StringValue", StringUtils.FromString(value.StringValue));
                                    }
                                }
                                mapIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetMessageBody())
                        {
                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageBody", StringUtils.FromString(publicRequestlistValue.MessageBody));
                        }
                        if(publicRequestlistValue.IsSetMessageDeduplicationId())
                        {
                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageDeduplicationId", StringUtils.FromString(publicRequestlistValue.MessageDeduplicationId));
                        }
                        if(publicRequestlistValue.IsSetMessageGroupId())
                        {
                            request.Parameters.Add("SendMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "MessageGroupId", StringUtils.FromString(publicRequestlistValue.MessageGroupId));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetQueueUrl())
                {
                    request.Parameters.Add("QueueUrl", StringUtils.FromString(publicRequest.QueueUrl));
                }
            }
            return request;
        }
                    private static SendMessageBatchRequestMarshaller _instance = new SendMessageBatchRequestMarshaller();        

        internal static SendMessageBatchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageBatchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}