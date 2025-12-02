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
    /// ListActs Request Marshaller
    /// </summary>       
    public class ListActsRequestMarshaller : IMarshaller<IRequest, ListActsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListActsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListActsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NovaAct");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-22";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetWorkflowDefinitionName())
                throw new AmazonNovaActException("Request object does not have required field WorkflowDefinitionName set");
            request.AddPathResource("{workflowDefinitionName}", StringUtils.FromString(publicRequest.WorkflowDefinitionName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSessionId())
                request.Parameters.Add("sessionId", StringUtils.FromString(publicRequest.SessionId));
            
            if (publicRequest.IsSetWorkflowRunId())
                request.Parameters.Add("workflowRunId", StringUtils.FromString(publicRequest.WorkflowRunId));
            request.ResourcePath = "/workflow-definitions/{workflowDefinitionName}/acts";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("sortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static ListActsRequestMarshaller _instance = new ListActsRequestMarshaller();        

        internal static ListActsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListActsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}