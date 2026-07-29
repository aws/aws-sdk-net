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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePipeline Request Marshaller
    /// </summary>       
    public class UpdatePipelineRequestMarshaller : IMarshaller<IRequest, UpdatePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetPipelineName())
                throw new AmazonIoTSiteWiseException("Request object does not have required field PipelineName set");
            request.AddPathResource("{pipelineName}", StringUtils.FromString(publicRequest.PipelineName));
            if (!publicRequest.IsSetWorkspaceName())
                throw new AmazonIoTSiteWiseException("Request object does not have required field WorkspaceName set");
            request.AddPathResource("{workspaceName}", StringUtils.FromString(publicRequest.WorkspaceName));
            request.ResourcePath = "/workspaces/{workspaceName}/pipelines/{pipelineName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComputations())
            {
                context.Writer.WritePropertyName("computations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestComputationsListValue in publicRequest.Computations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComputeNodeMarshaller.Instance;
                    marshaller.Marshall(publicRequestComputationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                    var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdatePipelineRequestMarshaller _instance = new UpdatePipelineRequestMarshaller();        

        internal static UpdatePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}