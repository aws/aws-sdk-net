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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBridge Request Marshaller
    /// </summary>       
    public class UpdateBridgeRequestMarshaller : IMarshaller<IRequest, UpdateBridgeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBridgeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBridgeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBridgeArn())
                throw new AmazonMediaConnectException("Request object does not have required field BridgeArn set");
            request.AddPathResource("{BridgeArn}", StringUtils.FromString(publicRequest.BridgeArn));
            request.ResourcePath = "/v1/bridges/{BridgeArn}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEgressGatewayBridge())
                {
                    context.Writer.WritePropertyName("egressGatewayBridge");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEgressGatewayBridgeRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EgressGatewayBridge, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIngressGatewayBridge())
                {
                    context.Writer.WritePropertyName("ingressGatewayBridge");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateIngressGatewayBridgeRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IngressGatewayBridge, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceFailoverConfig())
                {
                    context.Writer.WritePropertyName("sourceFailoverConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateFailoverConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceFailoverConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBridgeRequestMarshaller _instance = new UpdateBridgeRequestMarshaller();        

        internal static UpdateBridgeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBridgeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}