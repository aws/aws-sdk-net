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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
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
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplication Request Marshaller
    /// </summary>       
    public class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArchitecture())
            {
                context.Writer.WritePropertyName("architecture");
                context.Writer.WriteStringValue(publicRequest.Architecture);
            }

            if(publicRequest.IsSetAutoStartConfiguration())
            {
                context.Writer.WritePropertyName("autoStartConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoStartConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoStartConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoStopConfiguration())
            {
                context.Writer.WritePropertyName("autoStopConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoStopConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoStopConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetIdentityCenterConfiguration())
            {
                context.Writer.WritePropertyName("identityCenterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = IdentityCenterConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityCenterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetImageConfiguration())
            {
                context.Writer.WritePropertyName("imageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ImageConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.ImageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInitialCapacity())
            {
                context.Writer.WritePropertyName("initialCapacity");
                context.Writer.WriteStartObject();
                foreach (var publicRequestInitialCapacityKvp in publicRequest.InitialCapacity)
                {
                    context.Writer.WritePropertyName(publicRequestInitialCapacityKvp.Key);
                    var publicRequestInitialCapacityValue = publicRequestInitialCapacityKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = InitialCapacityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestInitialCapacityValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInteractiveConfiguration())
            {
                context.Writer.WritePropertyName("interactiveConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InteractiveConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InteractiveConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaximumCapacity())
            {
                context.Writer.WritePropertyName("maximumCapacity");
                context.Writer.WriteStartObject();

                var marshaller = MaximumAllowedResourcesMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaximumCapacity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMonitoringConfiguration())
            {
                context.Writer.WritePropertyName("monitoringConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MonitoringConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReleaseLabel())
            {
                context.Writer.WritePropertyName("releaseLabel");
                context.Writer.WriteStringValue(publicRequest.ReleaseLabel);
            }

            if(publicRequest.IsSetRuntimeConfiguration())
            {
                context.Writer.WritePropertyName("runtimeConfiguration");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRuntimeConfigurationListValue in publicRequest.RuntimeConfiguration)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestRuntimeConfigurationListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSchedulerConfiguration())
            {
                context.Writer.WritePropertyName("schedulerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SchedulerConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SchedulerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkerTypeSpecifications())
            {
                context.Writer.WritePropertyName("workerTypeSpecifications");
                context.Writer.WriteStartObject();
                foreach (var publicRequestWorkerTypeSpecificationsKvp in publicRequest.WorkerTypeSpecifications)
                {
                    context.Writer.WritePropertyName(publicRequestWorkerTypeSpecificationsKvp.Key);
                    var publicRequestWorkerTypeSpecificationsValue = publicRequestWorkerTypeSpecificationsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = WorkerTypeSpecificationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestWorkerTypeSpecificationsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateApplicationRequestMarshaller _instance = new UpdateApplicationRequestMarshaller();        

        internal static UpdateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}