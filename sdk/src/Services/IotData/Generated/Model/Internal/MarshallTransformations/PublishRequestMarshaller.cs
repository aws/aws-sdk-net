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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IotData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.IotData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Publish Request Marshaller
    /// </summary>       
    public class PublishRequestMarshaller : IMarshaller<IRequest, PublishRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PublishRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IotData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetTopic())
                throw new AmazonIotDataException("Request object does not have required field Topic set");
            request.AddPathResource("{topic}", StringUtils.FromString(publicRequest.Topic));
            
            if (publicRequest.IsSetContentType())
                request.Parameters.Add("contentType", StringUtils.FromString(publicRequest.ContentType));
            
            if (publicRequest.IsSetMessageExpiry())
                request.Parameters.Add("messageExpiry", StringUtils.FromLong(publicRequest.MessageExpiry));
            
            if (publicRequest.IsSetQos())
                request.Parameters.Add("qos", StringUtils.FromInt(publicRequest.Qos));
            
            if (publicRequest.IsSetResponseTopic())
                request.Parameters.Add("responseTopic", StringUtils.FromString(publicRequest.ResponseTopic));
            
            if (publicRequest.IsSetRetain())
                request.Parameters.Add("retain", StringUtils.FromBool(publicRequest.Retain));
            request.ResourcePath = "/topics/{topic}";
            request.ContentStream =  publicRequest.Payload ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetCorrelationData()) 
            {
                request.Headers["x-amz-mqtt5-correlation-data"] = publicRequest.CorrelationData;
            }
        
            if (publicRequest.IsSetPayloadFormatIndicator()) 
            {
                request.Headers["x-amz-mqtt5-payload-format-indicator"] = publicRequest.PayloadFormatIndicator;
            }
        
            if (publicRequest.IsSetUserProperties()) 
            {
                request.Headers["x-amz-mqtt5-user-properties"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicRequest.UserProperties));
            }
            request.UseQueryString = true;

            return request;
        }
        private static PublishRequestMarshaller _instance = new PublishRequestMarshaller();        

        internal static PublishRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PublishRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}