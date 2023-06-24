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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateService Request Marshaller
    /// </summary>       
    public class UpdateServiceRequestMarshaller : IMarshaller<IRequest, UpdateServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppRunner");
            string target = "AppRunner.UpdateService";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAutoScalingConfigurationArn())
                {
                    context.Writer.WritePropertyName("AutoScalingConfigurationArn");
                    context.Writer.Write(publicRequest.AutoScalingConfigurationArn);
                }

                if(publicRequest.IsSetHealthCheckConfiguration())
                {
                    context.Writer.WritePropertyName("HealthCheckConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = HealthCheckConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HealthCheckConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInstanceConfiguration())
                {
                    context.Writer.WritePropertyName("InstanceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InstanceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("NetworkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetObservabilityConfiguration())
                {
                    context.Writer.WritePropertyName("ObservabilityConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceObservabilityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ObservabilityConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceArn())
                {
                    context.Writer.WritePropertyName("ServiceArn");
                    context.Writer.Write(publicRequest.ServiceArn);
                }

                if(publicRequest.IsSetSourceConfiguration())
                {
                    context.Writer.WritePropertyName("SourceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateServiceRequestMarshaller _instance = new UpdateServiceRequestMarshaller();        

        internal static UpdateServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}