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
    /// UpdateEndpointGroup Request Marshaller
    /// </summary>       
    public class UpdateEndpointGroupRequestMarshaller : IMarshaller<IRequest, UpdateEndpointGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEndpointGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEndpointGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlobalAccelerator");
            string target = "GlobalAccelerator_V20180706.UpdateEndpointGroup";
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

                if(publicRequest.IsSetEndpointGroupArn())
                {
                    context.Writer.WritePropertyName("EndpointGroupArn");
                    context.Writer.Write(publicRequest.EndpointGroupArn);
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

                if(publicRequest.IsSetPortOverrides())
                {
                    context.Writer.WritePropertyName("PortOverrides");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPortOverridesListValue in publicRequest.PortOverrides)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PortOverrideMarshaller.Instance;
                        marshaller.Marshall(publicRequestPortOverridesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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
        private static UpdateEndpointGroupRequestMarshaller _instance = new UpdateEndpointGroupRequestMarshaller();        

        internal static UpdateEndpointGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEndpointGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}