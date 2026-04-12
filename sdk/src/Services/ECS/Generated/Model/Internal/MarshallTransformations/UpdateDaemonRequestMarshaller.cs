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
    /// UpdateDaemon Request Marshaller
    /// </summary>       
    public class UpdateDaemonRequestMarshaller : IMarshaller<IRequest, UpdateDaemonRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDaemonRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDaemonRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.UpdateDaemon";
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
            if(publicRequest.IsSetCapacityProviderArns())
            {
                context.Writer.WritePropertyName("capacityProviderArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapacityProviderArnsListValue in publicRequest.CapacityProviderArns)
                {
                        context.Writer.WriteStringValue(publicRequestCapacityProviderArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDaemonArn())
            {
                context.Writer.WritePropertyName("daemonArn");
                context.Writer.WriteStringValue(publicRequest.DaemonArn);
            }

            if(publicRequest.IsSetDaemonTaskDefinitionArn())
            {
                context.Writer.WritePropertyName("daemonTaskDefinitionArn");
                context.Writer.WriteStringValue(publicRequest.DaemonTaskDefinitionArn);
            }

            if(publicRequest.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("deploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DaemonDeploymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnableECSManagedTags())
            {
                context.Writer.WritePropertyName("enableECSManagedTags");
                context.Writer.WriteBooleanValue(publicRequest.EnableECSManagedTags.Value);
            }

            if(publicRequest.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("enableExecuteCommand");
                context.Writer.WriteBooleanValue(publicRequest.EnableExecuteCommand.Value);
            }

            if(publicRequest.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("propagateTags");
                context.Writer.WriteStringValue(publicRequest.PropagateTags);
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
        private static UpdateDaemonRequestMarshaller _instance = new UpdateDaemonRequestMarshaller();        

        internal static UpdateDaemonRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDaemonRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}