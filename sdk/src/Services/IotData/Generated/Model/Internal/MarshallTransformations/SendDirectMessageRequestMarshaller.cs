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
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.IotData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendDirectMessage Request Marshaller
    /// </summary>       
    public class SendDirectMessageRequestMarshaller : IMarshaller<IRequest, SendDirectMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendDirectMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendDirectMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IotData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClientId())
                throw new AmazonIotDataException("Request object does not have required field ClientId set");
            request.AddPathResource("{clientId}", StringUtils.FromString(publicRequest.ClientId));
            
            if (publicRequest.IsSetConfirmation())
                request.Parameters.Add("confirmation", StringUtils.FromBool(publicRequest.Confirmation));
            
            if (publicRequest.IsSetContentType())
                request.Parameters.Add("contentType", StringUtils.FromString(publicRequest.ContentType));
            
            if (publicRequest.IsSetResponseTopic())
                request.Parameters.Add("responseTopic", StringUtils.FromString(publicRequest.ResponseTopic));
            
            if (publicRequest.IsSetTimeout())
                request.Parameters.Add("timeout", StringUtils.FromInt(publicRequest.Timeout));
            if (string.IsNullOrEmpty(publicRequest.Topic))
                throw new AmazonIotDataException("Request object does not have required field Topic set");
            
            if (publicRequest.IsSetTopic())
                request.Parameters.Add("topic", StringUtils.FromString(publicRequest.Topic));
            request.ResourcePath = "/connections/{clientId}/messages";
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
        private static SendDirectMessageRequestMarshaller _instance = new SendDirectMessageRequestMarshaller();        

        internal static SendDirectMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendDirectMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}