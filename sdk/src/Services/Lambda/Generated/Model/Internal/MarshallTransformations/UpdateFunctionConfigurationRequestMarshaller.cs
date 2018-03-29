/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFunctionConfiguration Request Marshaller
    /// </summary>       
    public class UpdateFunctionConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateFunctionConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFunctionConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFunctionConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/2015-03-31/functions/{FunctionName}/configuration";
            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            uriResourcePath = uriResourcePath.Replace("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeadLetterConfig())
                {
                    context.Writer.WritePropertyName("DeadLetterConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeadLetterConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeadLetterConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.WriteObjectStart();

                    var marshaller = EnvironmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Environment, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHandler())
                {
                    context.Writer.WritePropertyName("Handler");
                    context.Writer.Write(publicRequest.Handler);
                }

                if(publicRequest.IsSetKMSKeyArn())
                {
                    context.Writer.WritePropertyName("KMSKeyArn");
                    context.Writer.Write(publicRequest.KMSKeyArn);
                }

                if(publicRequest.IsSetMemorySize())
                {
                    context.Writer.WritePropertyName("MemorySize");
                    context.Writer.Write(publicRequest.MemorySize);
                }

                if(publicRequest.IsSetRevisionId())
                {
                    context.Writer.WritePropertyName("RevisionId");
                    context.Writer.Write(publicRequest.RevisionId);
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetRuntime())
                {
                    context.Writer.WritePropertyName("Runtime");
                    context.Writer.Write(publicRequest.Runtime);
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("Timeout");
                    context.Writer.Write(publicRequest.Timeout);
                }

                if(publicRequest.IsSetTracingConfig())
                {
                    context.Writer.WritePropertyName("TracingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TracingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TracingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFunctionConfigurationRequestMarshaller _instance = new UpdateFunctionConfigurationRequestMarshaller();        

        internal static UpdateFunctionConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFunctionConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}