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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
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
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeModel Request Marshaller
    /// </summary>       
    public class InvokeModelRequestMarshaller : IMarshaller<IRequest, InvokeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelId())
                throw new AmazonBedrockRuntimeException("Request object does not have required field ModelId set");
            request.AddPathResource("{modelId}", StringUtils.FromString(publicRequest.ModelId));
            request.ResourcePath = "/model/{modelId}/invoke";
            request.ContentStream =  publicRequest.Body ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetAccept()) 
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetGuardrailIdentifier()) 
            {
                request.Headers["X-Amzn-Bedrock-GuardrailIdentifier"] = publicRequest.GuardrailIdentifier;
            }
        
            if (publicRequest.IsSetGuardrailVersion()) 
            {
                request.Headers["X-Amzn-Bedrock-GuardrailVersion"] = publicRequest.GuardrailVersion;
            }
        
            if (publicRequest.IsSetPerformanceConfigLatency()) 
            {
                request.Headers["X-Amzn-Bedrock-PerformanceConfig-Latency"] = publicRequest.PerformanceConfigLatency;
            }
        
            if (publicRequest.IsSetTrace()) 
            {
                request.Headers["X-Amzn-Bedrock-Trace"] = publicRequest.Trace;
            }

            return request;
        }
        private static InvokeModelRequestMarshaller _instance = new InvokeModelRequestMarshaller();        

        internal static InvokeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}