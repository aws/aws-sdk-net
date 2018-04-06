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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterJobDefinition Request Marshaller
    /// </summary>       
    public class RegisterJobDefinitionRequestMarshaller : IMarshaller<IRequest, RegisterJobDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterJobDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterJobDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/v1/registerjobdefinition";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerProperties())
                {
                    context.Writer.WritePropertyName("containerProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContainerProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobDefinitionName())
                {
                    context.Writer.WritePropertyName("jobDefinitionName");
                    context.Writer.Write(publicRequest.JobDefinitionName);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                            context.Writer.Write(publicRequestParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRetryStrategy())
                {
                    context.Writer.WritePropertyName("retryStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetryStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetryStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("timeout");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobTimeoutMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Timeout, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterJobDefinitionRequestMarshaller _instance = new RegisterJobDefinitionRequestMarshaller();        

        internal static RegisterJobDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterJobDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}