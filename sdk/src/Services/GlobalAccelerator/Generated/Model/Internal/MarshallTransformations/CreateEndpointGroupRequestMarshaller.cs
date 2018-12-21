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
    /// CreateEndpointGroup Request Marshaller
    /// </summary>       
    public class CreateEndpointGroupRequestMarshaller : IMarshaller<IRequest, CreateEndpointGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlobalAccelerator");
            string target = "GlobalAccelerator_V20180706.CreateEndpointGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-08";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndpointConfigurations())
                {
                    context.Writer.WritePropertyName("EndpointConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEndpointConfigurationsListValue in publicRequest.EndpointConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EndpointConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestEndpointConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEndpointGroupRegion())
                {
                    context.Writer.WritePropertyName("EndpointGroupRegion");
                    context.Writer.Write(publicRequest.EndpointGroupRegion);
                }

                if(publicRequest.IsSetHealthCheckIntervalSeconds())
                {
                    context.Writer.WritePropertyName("HealthCheckIntervalSeconds");
                    context.Writer.Write(publicRequest.HealthCheckIntervalSeconds);
                }

                if(publicRequest.IsSetHealthCheckPath())
                {
                    context.Writer.WritePropertyName("HealthCheckPath");
                    context.Writer.Write(publicRequest.HealthCheckPath);
                }

                if(publicRequest.IsSetHealthCheckPort())
                {
                    context.Writer.WritePropertyName("HealthCheckPort");
                    context.Writer.Write(publicRequest.HealthCheckPort);
                }

                if(publicRequest.IsSetHealthCheckProtocol())
                {
                    context.Writer.WritePropertyName("HealthCheckProtocol");
                    context.Writer.Write(publicRequest.HealthCheckProtocol);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                if(publicRequest.IsSetListenerArn())
                {
                    context.Writer.WritePropertyName("ListenerArn");
                    context.Writer.Write(publicRequest.ListenerArn);
                }

                if(publicRequest.IsSetThresholdCount())
                {
                    context.Writer.WritePropertyName("ThresholdCount");
                    context.Writer.Write(publicRequest.ThresholdCount);
                }

                if(publicRequest.IsSetTrafficDialPercentage())
                {
                    context.Writer.WritePropertyName("TrafficDialPercentage");
                    context.Writer.Write(publicRequest.TrafficDialPercentage);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEndpointGroupRequestMarshaller _instance = new CreateEndpointGroupRequestMarshaller();        

        internal static CreateEndpointGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}