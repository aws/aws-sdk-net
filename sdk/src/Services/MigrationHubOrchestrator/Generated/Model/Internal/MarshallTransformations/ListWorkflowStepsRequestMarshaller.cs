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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubOrchestrator.Model;
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
namespace Amazon.MigrationHubOrchestrator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListWorkflowSteps Request Marshaller
    /// </summary>       
    public class ListWorkflowStepsRequestMarshaller : IMarshaller<IRequest, ListWorkflowStepsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListWorkflowStepsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListWorkflowStepsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubOrchestrator");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-28";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetStepGroupId())
                throw new AmazonMigrationHubOrchestratorException("Request object does not have required field StepGroupId set");
            request.AddPathResource("{stepGroupId}", StringUtils.FromString(publicRequest.StepGroupId));
            if (!publicRequest.IsSetWorkflowId())
                throw new AmazonMigrationHubOrchestratorException("Request object does not have required field WorkflowId set");
            request.AddPathResource("{workflowId}", StringUtils.FromString(publicRequest.WorkflowId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/workflow/{workflowId}/workflowstepgroups/{stepGroupId}/workflowsteps";
            request.UseQueryString = true;

            return request;
        }
        private static ListWorkflowStepsRequestMarshaller _instance = new ListWorkflowStepsRequestMarshaller();        

        internal static ListWorkflowStepsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListWorkflowStepsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}