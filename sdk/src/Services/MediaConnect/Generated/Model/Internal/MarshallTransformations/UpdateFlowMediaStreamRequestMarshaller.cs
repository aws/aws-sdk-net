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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFlowMediaStream Request Marshaller
    /// </summary>       
    public class UpdateFlowMediaStreamRequestMarshaller : IMarshaller<IRequest, UpdateFlowMediaStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowMediaStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowMediaStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            request.AddPathResource("{flowArn}", StringUtils.FromString(publicRequest.FlowArn));
            if (!publicRequest.IsSetMediaStreamName())
                throw new AmazonMediaConnectException("Request object does not have required field MediaStreamName set");
            request.AddPathResource("{mediaStreamName}", StringUtils.FromString(publicRequest.MediaStreamName));
            request.ResourcePath = "/v1/flows/{flowArn}/mediaStreams/{mediaStreamName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("attributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = MediaStreamAttributesRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Attributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClockRate())
                {
                    context.Writer.WritePropertyName("clockRate");
                    context.Writer.Write(publicRequest.ClockRate);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetMediaStreamType())
                {
                    context.Writer.WritePropertyName("mediaStreamType");
                    context.Writer.Write(publicRequest.MediaStreamType);
                }

                if(publicRequest.IsSetVideoFormat())
                {
                    context.Writer.WritePropertyName("videoFormat");
                    context.Writer.Write(publicRequest.VideoFormat);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFlowMediaStreamRequestMarshaller _instance = new UpdateFlowMediaStreamRequestMarshaller();        

        internal static UpdateFlowMediaStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowMediaStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}