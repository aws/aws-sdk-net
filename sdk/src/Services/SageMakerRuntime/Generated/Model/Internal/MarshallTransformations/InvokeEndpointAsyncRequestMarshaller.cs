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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeEndpointAsync Request Marshaller
    /// </summary>       
    public class InvokeEndpointAsyncRequestMarshaller : IMarshaller<IRequest, InvokeEndpointAsyncRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeEndpointAsyncRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeEndpointAsyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-05-13";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEndpointName())
                throw new AmazonSageMakerRuntimeException("Request object does not have required field EndpointName set");
            request.AddPathResource("{EndpointName}", StringUtils.FromString(publicRequest.EndpointName));
            request.ResourcePath = "/endpoints/{EndpointName}/async-invocations";
        
            if (publicRequest.IsSetAccept()) 
            {
                request.Headers["X-Amzn-SageMaker-Accept"] = publicRequest.Accept;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["X-Amzn-SageMaker-Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetCustomAttributes()) 
            {
                request.Headers["X-Amzn-SageMaker-Custom-Attributes"] = publicRequest.CustomAttributes;
            }
        
            if (publicRequest.IsSetInferenceId()) 
            {
                request.Headers["X-Amzn-SageMaker-Inference-Id"] = publicRequest.InferenceId;
            }
        
            if (publicRequest.IsSetInputLocation()) 
            {
                request.Headers["X-Amzn-SageMaker-InputLocation"] = publicRequest.InputLocation;
            }
        
            if (publicRequest.IsSetInvocationTimeoutSeconds()) 
            {
                request.Headers["X-Amzn-SageMaker-InvocationTimeoutSeconds"] = StringUtils.FromInt(publicRequest.InvocationTimeoutSeconds);
            }
        
            if (publicRequest.IsSetRequestTTLSeconds()) 
            {
                request.Headers["X-Amzn-SageMaker-RequestTTLSeconds"] = StringUtils.FromInt(publicRequest.RequestTTLSeconds);
            }

            return request;
        }
        private static InvokeEndpointAsyncRequestMarshaller _instance = new InvokeEndpointAsyncRequestMarshaller();        

        internal static InvokeEndpointAsyncRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeEndpointAsyncRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}