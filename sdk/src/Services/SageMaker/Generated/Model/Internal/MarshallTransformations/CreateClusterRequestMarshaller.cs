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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCluster Request Marshaller
    /// </summary>       
    public class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
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
            if(publicRequest.IsSetAutoScaling())
            {
                context.Writer.WritePropertyName("AutoScaling");
                context.Writer.WriteStartObject();

                var marshaller = ClusterAutoScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoScaling, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("ClusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetClusterRole())
            {
                context.Writer.WritePropertyName("ClusterRole");
                context.Writer.WriteStringValue(publicRequest.ClusterRole);
            }

            if(publicRequest.IsSetInstanceGroups())
            {
                context.Writer.WritePropertyName("InstanceGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceGroupsListValue in publicRequest.InstanceGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClusterInstanceGroupSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestInstanceGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNodeProvisioningMode())
            {
                context.Writer.WritePropertyName("NodeProvisioningMode");
                context.Writer.WriteStringValue(publicRequest.NodeProvisioningMode);
            }

            if(publicRequest.IsSetNodeRecovery())
            {
                context.Writer.WritePropertyName("NodeRecovery");
                context.Writer.WriteStringValue(publicRequest.NodeRecovery);
            }

            if(publicRequest.IsSetOrchestrator())
            {
                context.Writer.WritePropertyName("Orchestrator");
                context.Writer.WriteStartObject();

                var marshaller = ClusterOrchestratorMarshaller.Instance;
                marshaller.Marshall(publicRequest.Orchestrator, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRestrictedInstanceGroups())
            {
                context.Writer.WritePropertyName("RestrictedInstanceGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRestrictedInstanceGroupsListValue in publicRequest.RestrictedInstanceGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClusterRestrictedInstanceGroupSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestRestrictedInstanceGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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

            if(publicRequest.IsSetTieredStorageConfig())
            {
                context.Writer.WritePropertyName("TieredStorageConfig");
                context.Writer.WriteStartObject();

                var marshaller = ClusterTieredStorageConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TieredStorageConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfig, context);

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
        private static CreateClusterRequestMarshaller _instance = new CreateClusterRequestMarshaller();        

        internal static CreateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}