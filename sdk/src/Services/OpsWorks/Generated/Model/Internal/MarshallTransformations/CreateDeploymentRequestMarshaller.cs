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
    /// CreateDeployment Request Marshaller
    /// </summary>       
    public class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateDeployment";
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
            if(publicRequest.IsSetAppId())
            {
                context.Writer.WritePropertyName("AppId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }

            if(publicRequest.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentCommandMarshaller.Instance;
                marshaller.Marshall(publicRequest.Command, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComment())
            {
                context.Writer.WritePropertyName("Comment");
                context.Writer.WriteStringValue(publicRequest.Comment);
            }

            if(publicRequest.IsSetCustomJson())
            {
                context.Writer.WritePropertyName("CustomJson");
                context.Writer.WriteStringValue(publicRequest.CustomJson);
            }

            if(publicRequest.IsSetInstanceIds())
            {
                context.Writer.WritePropertyName("InstanceIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceIdsListValue);
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetStackId())
            {
                context.Writer.WritePropertyName("StackId");
                context.Writer.WriteStringValue(publicRequest.StackId);
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
        private static CreateDeploymentRequestMarshaller _instance = new CreateDeploymentRequestMarshaller();        

        internal static CreateDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}