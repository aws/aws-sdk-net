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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
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
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComponentConfiguration Request Marshaller
    /// </summary>       
    public class UpdateComponentConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateComponentConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComponentConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComponentConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationInsights");
            string target = "EC2WindowsBarleyService.UpdateComponentConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-25";
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
            if(publicRequest.IsSetAutoConfigEnabled())
            {
                context.Writer.WritePropertyName("AutoConfigEnabled");
                context.Writer.WriteBooleanValue(publicRequest.AutoConfigEnabled.Value);
            }

            if(publicRequest.IsSetComponentConfiguration())
            {
                context.Writer.WritePropertyName("ComponentConfiguration");
                context.Writer.WriteStringValue(publicRequest.ComponentConfiguration);
            }

            if(publicRequest.IsSetComponentName())
            {
                context.Writer.WritePropertyName("ComponentName");
                context.Writer.WriteStringValue(publicRequest.ComponentName);
            }

            if(publicRequest.IsSetMonitor())
            {
                context.Writer.WritePropertyName("Monitor");
                context.Writer.WriteBooleanValue(publicRequest.Monitor.Value);
            }

            if(publicRequest.IsSetResourceGroupName())
            {
                context.Writer.WritePropertyName("ResourceGroupName");
                context.Writer.WriteStringValue(publicRequest.ResourceGroupName);
            }

            if(publicRequest.IsSetTier())
            {
                context.Writer.WritePropertyName("Tier");
                context.Writer.WriteStringValue(publicRequest.Tier);
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
        private static UpdateComponentConfigurationRequestMarshaller _instance = new UpdateComponentConfigurationRequestMarshaller();        

        internal static UpdateComponentConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComponentConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}