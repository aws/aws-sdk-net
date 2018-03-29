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
    /// SendMessage Request Marshaller
    /// </summary>       
    public class SendMessageRequestMarshaller : IMarshaller<IRequest, SendMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMessageRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "SendMessage");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDelaySeconds())
                {
                    request.Parameters.Add("DelaySeconds", StringUtils.FromInt(publicRequest.DelaySeconds));
                }
                if(publicRequest.IsSetMessageAttributes())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.MessageAttributes.Keys)
                    {
                        MessageAttributeValue value;
                        bool hasValue = publicRequest.MessageAttributes.TryGetValue(key, out value);
                        request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Name", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            if(value.IsSetBinaryListValues())
                            {
                                int valuelistValueIndex = 1;
                                foreach(var valuelistValue in value.BinaryListValues)
                                {
                                    request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "BinaryListValue" + "." + "member" + "." + valuelistValueIndex, StringUtils.FromMemoryStream(valuelistValue));
                                    valuelistValueIndex++;
                                }
                            }
                            if(value.IsSetBinaryValue())
                            {
                                request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "BinaryValue", StringUtils.FromMemoryStream(value.BinaryValue));
                            }
                            if(value.IsSetDataType())
                            {
                                request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "DataType", StringUtils.FromString(value.DataType));
                            }
                            if(value.IsSetStringListValues())
                            {
                                int valuelistValueIndex = 1;
                                foreach(var valuelistValue in value.StringListValues)
                                {
                                    request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "StringListValue" + "." + "member" + "." + valuelistValueIndex, StringUtils.FromString(valuelistValue));
                                    valuelistValueIndex++;
                                }
                            }
                            if(value.IsSetStringValue())
                            {
                                request.Parameters.Add("MessageAttribute" + "." + mapIndex + "." + "Value" + "." + "StringValue", StringUtils.FromString(value.StringValue));
                            }
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetMessageBody())
                {
                    request.Parameters.Add("MessageBody", StringUtils.FromString(publicRequest.MessageBody));
                }
                if(publicRequest.IsSetMessageDeduplicationId())
                {
                    request.Parameters.Add("MessageDeduplicationId", StringUtils.FromString(publicRequest.MessageDeduplicationId));
                }
                if(publicRequest.IsSetMessageGroupId())
                {
                    request.Parameters.Add("MessageGroupId", StringUtils.FromString(publicRequest.MessageGroupId));
                }
                if(publicRequest.IsSetQueueUrl())
                {
                    request.Parameters.Add("QueueUrl", StringUtils.FromString(publicRequest.QueueUrl));
                }
            }
            return request;
        }
                    private static SendMessageRequestMarshaller _instance = new SendMessageRequestMarshaller();        

        internal static SendMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}