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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
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
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTaskSet Request Marshaller
    /// </summary>       
    public class CreateTaskSetRequestMarshaller : IMarshaller<IRequest, CreateTaskSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTaskSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTaskSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.CreateTaskSet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("capacityProviderStrategy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapacityProviderStrategyListValue in publicRequest.CapacityProviderStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestCapacityProviderStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetCluster())
            {
                context.Writer.WritePropertyName("cluster");
                context.Writer.WriteStringValue(publicRequest.Cluster);
            }

            if(publicRequest.IsSetExternalId())
            {
                context.Writer.WritePropertyName("externalId");
                context.Writer.WriteStringValue(publicRequest.ExternalId);
            }

            if(publicRequest.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("launchType");
                context.Writer.WriteStringValue(publicRequest.LaunchType);
            }

            if(publicRequest.IsSetLoadBalancers())
            {
                context.Writer.WritePropertyName("loadBalancers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLoadBalancersListValue in publicRequest.LoadBalancers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LoadBalancerMarshaller.Instance;
                    marshaller.Marshall(publicRequestLoadBalancersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("platformVersion");
                context.Writer.WriteStringValue(publicRequest.PlatformVersion);
            }

            if(publicRequest.IsSetScale())
            {
                context.Writer.WritePropertyName("scale");
                context.Writer.WriteStartObject();

                var marshaller = ScaleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Scale, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetService())
            {
                context.Writer.WritePropertyName("service");
                context.Writer.WriteStringValue(publicRequest.Service);
            }

            if(publicRequest.IsSetServiceRegistries())
            {
                context.Writer.WritePropertyName("serviceRegistries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestServiceRegistriesListValue in publicRequest.ServiceRegistries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ServiceRegistryMarshaller.Instance;
                    marshaller.Marshall(publicRequestServiceRegistriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskDefinition())
            {
                context.Writer.WritePropertyName("taskDefinition");
                context.Writer.WriteStringValue(publicRequest.TaskDefinition);
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
        private static CreateTaskSetRequestMarshaller _instance = new CreateTaskSetRequestMarshaller();        

        internal static CreateTaskSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTaskSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}