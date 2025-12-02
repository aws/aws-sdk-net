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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NovaAct.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NovaAct.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeActStep Request Marshaller
    /// </summary>       
    public class InvokeActStepRequestMarshaller : IMarshaller<IRequest, InvokeActStepRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeActStepRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeActStepRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NovaAct");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-22";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetActId())
                throw new AmazonNovaActException("Request object does not have required field ActId set");
            request.AddPathResource("{actId}", StringUtils.FromString(publicRequest.ActId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonNovaActException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            if (!publicRequest.IsSetWorkflowDefinitionName())
                throw new AmazonNovaActException("Request object does not have required field WorkflowDefinitionName set");
            request.AddPathResource("{workflowDefinitionName}", StringUtils.FromString(publicRequest.WorkflowDefinitionName));
            if (!publicRequest.IsSetWorkflowRunId())
                throw new AmazonNovaActException("Request object does not have required field WorkflowRunId set");
            request.AddPathResource("{workflowRunId}", StringUtils.FromString(publicRequest.WorkflowRunId));
            request.ResourcePath = "/workflow-definitions/{workflowDefinitionName}/workflow-runs/{workflowRunId}/sessions/{sessionId}/acts/{actId}/invoke-step/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCallResults())
                {
                    context.Writer.WritePropertyName("callResults");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCallResultsListValue in publicRequest.CallResults)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CallResultMarshaller.Instance;
                        marshaller.Marshall(publicRequestCallResultsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPreviousStepId())
                {
                    context.Writer.WritePropertyName("previousStepId");
                    context.Writer.Write(publicRequest.PreviousStepId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static InvokeActStepRequestMarshaller _instance = new InvokeActStepRequestMarshaller();        

        internal static InvokeActStepRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeActStepRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}