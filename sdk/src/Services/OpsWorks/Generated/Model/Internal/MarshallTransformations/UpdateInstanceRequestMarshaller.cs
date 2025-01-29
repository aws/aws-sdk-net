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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
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
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInstance Request Marshaller
    /// </summary>       
    public class UpdateInstanceRequestMarshaller : IMarshaller<IRequest, UpdateInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-02-18";
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
            if(publicRequest.IsSetAgentVersion())
            {
                context.Writer.WritePropertyName("AgentVersion");
                context.Writer.WriteStringValue(publicRequest.AgentVersion);
            }

            if(publicRequest.IsSetAmiId())
            {
                context.Writer.WritePropertyName("AmiId");
                context.Writer.WriteStringValue(publicRequest.AmiId);
            }

            if(publicRequest.IsSetArchitecture())
            {
                context.Writer.WritePropertyName("Architecture");
                context.Writer.WriteStringValue(publicRequest.Architecture);
            }

            if(publicRequest.IsSetAutoScalingType())
            {
                context.Writer.WritePropertyName("AutoScalingType");
                context.Writer.WriteStringValue(publicRequest.AutoScalingType);
            }

            if(publicRequest.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.WriteBooleanValue(publicRequest.EbsOptimized.Value);
            }

            if(publicRequest.IsSetHostname())
            {
                context.Writer.WritePropertyName("Hostname");
                context.Writer.WriteStringValue(publicRequest.Hostname);
            }

            if(publicRequest.IsSetInstallUpdatesOnBoot())
            {
                context.Writer.WritePropertyName("InstallUpdatesOnBoot");
                context.Writer.WriteBooleanValue(publicRequest.InstallUpdatesOnBoot.Value);
            }

            if(publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetLayerIds())
            {
                context.Writer.WritePropertyName("LayerIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLayerIdsListValue in publicRequest.LayerIds)
                {
                        context.Writer.WriteStringValue(publicRequestLayerIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOs())
            {
                context.Writer.WritePropertyName("Os");
                context.Writer.WriteStringValue(publicRequest.Os);
            }

            if(publicRequest.IsSetSshKeyName())
            {
                context.Writer.WritePropertyName("SshKeyName");
                context.Writer.WriteStringValue(publicRequest.SshKeyName);
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
        private static UpdateInstanceRequestMarshaller _instance = new UpdateInstanceRequestMarshaller();        

        internal static UpdateInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}