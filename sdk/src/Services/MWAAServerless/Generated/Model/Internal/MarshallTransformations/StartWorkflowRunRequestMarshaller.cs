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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAAServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAAServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartWorkflowRun Request Marshaller
    /// </summary>       
    public class StartWorkflowRunRequestMarshaller : IMarshaller<IRequest, StartWorkflowRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartWorkflowRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartWorkflowRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAAServerless");
            string target = "AmazonMWAAServerless.StartWorkflowRun";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetOverrideParameters())
                {
                    context.Writer.WritePropertyName("OverrideParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOverrideParametersKvp in publicRequest.OverrideParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestOverrideParametersKvp.Key);
                        var publicRequestOverrideParametersValue = publicRequestOverrideParametersKvp.Value;

                        Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequestOverrideParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkflowArn())
                {
                    context.Writer.WritePropertyName("WorkflowArn");
                    context.Writer.Write(publicRequest.WorkflowArn);
                }

                if(publicRequest.IsSetWorkflowVersion())
                {
                    context.Writer.WritePropertyName("WorkflowVersion");
                    context.Writer.Write(publicRequest.WorkflowVersion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartWorkflowRunRequestMarshaller _instance = new StartWorkflowRunRequestMarshaller();        

        internal static StartWorkflowRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartWorkflowRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}