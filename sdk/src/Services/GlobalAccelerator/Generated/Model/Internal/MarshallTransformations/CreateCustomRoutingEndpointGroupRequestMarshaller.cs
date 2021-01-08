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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlobalAccelerator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomRoutingEndpointGroup Request Marshaller
    /// </summary>       
    public class CreateCustomRoutingEndpointGroupRequestMarshaller : IMarshaller<IRequest, CreateCustomRoutingEndpointGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomRoutingEndpointGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomRoutingEndpointGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlobalAccelerator");
            string target = "GlobalAccelerator_V20180706.CreateCustomRoutingEndpointGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-08";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationConfigurations())
                {
                    context.Writer.WritePropertyName("DestinationConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationConfigurationsListValue in publicRequest.DestinationConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CustomRoutingDestinationConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEndpointGroupRegion())
                {
                    context.Writer.WritePropertyName("EndpointGroupRegion");
                    context.Writer.Write(publicRequest.EndpointGroupRegion);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetListenerArn())
                {
                    context.Writer.WritePropertyName("ListenerArn");
                    context.Writer.Write(publicRequest.ListenerArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCustomRoutingEndpointGroupRequestMarshaller _instance = new CreateCustomRoutingEndpointGroupRequestMarshaller();        

        internal static CreateCustomRoutingEndpointGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomRoutingEndpointGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}