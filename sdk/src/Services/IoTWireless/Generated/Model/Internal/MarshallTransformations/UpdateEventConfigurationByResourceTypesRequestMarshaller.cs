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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventConfigurationByResourceTypes Request Marshaller
    /// </summary>       
    public class UpdateEventConfigurationByResourceTypesRequestMarshaller : IMarshaller<IRequest, UpdateEventConfigurationByResourceTypesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventConfigurationByResourceTypesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventConfigurationByResourceTypesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/event-configurations-resource-types";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectionStatus())
                {
                    context.Writer.WritePropertyName("ConnectionStatus");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectionStatusResourceTypeEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConnectionStatus, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeviceRegistrationState())
                {
                    context.Writer.WritePropertyName("DeviceRegistrationState");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceRegistrationStateResourceTypeEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceRegistrationState, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJoin())
                {
                    context.Writer.WritePropertyName("Join");
                    context.Writer.WriteObjectStart();

                    var marshaller = JoinResourceTypeEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Join, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMessageDeliveryStatus())
                {
                    context.Writer.WritePropertyName("MessageDeliveryStatus");
                    context.Writer.WriteObjectStart();

                    var marshaller = MessageDeliveryStatusResourceTypeEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MessageDeliveryStatus, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProximity())
                {
                    context.Writer.WritePropertyName("Proximity");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProximityResourceTypeEventConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Proximity, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEventConfigurationByResourceTypesRequestMarshaller _instance = new UpdateEventConfigurationByResourceTypesRequestMarshaller();        

        internal static UpdateEventConfigurationByResourceTypesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventConfigurationByResourceTypesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}