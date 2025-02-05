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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
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
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEnvironment Request Marshaller
    /// </summary>       
    public class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MainframeModernization");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-28";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonMainframeModernizationException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/environments/{environmentId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApplyDuringMaintenanceWindow())
            {
                context.Writer.WritePropertyName("applyDuringMaintenanceWindow");
                context.Writer.WriteBooleanValue(publicRequest.ApplyDuringMaintenanceWindow.Value);
            }

            if(publicRequest.IsSetDesiredCapacity())
            {
                context.Writer.WritePropertyName("desiredCapacity");
                context.Writer.WriteNumberValue(publicRequest.DesiredCapacity.Value);
            }

            if(publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("engineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }

            if(publicRequest.IsSetForceUpdate())
            {
                context.Writer.WritePropertyName("forceUpdate");
                context.Writer.WriteBooleanValue(publicRequest.ForceUpdate.Value);
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("preferredMaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredMaintenanceWindow);
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
        private static UpdateEnvironmentRequestMarshaller _instance = new UpdateEnvironmentRequestMarshaller();        

        internal static UpdateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}