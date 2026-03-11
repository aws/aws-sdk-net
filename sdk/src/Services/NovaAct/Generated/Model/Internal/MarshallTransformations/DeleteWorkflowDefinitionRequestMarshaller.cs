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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.NovaAct.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteWorkflowDefinition Request Marshaller
    /// </summary>       
    public class DeleteWorkflowDefinitionRequestMarshaller : IMarshaller<IRequest, DeleteWorkflowDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteWorkflowDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteWorkflowDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NovaAct");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-22";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetWorkflowDefinitionName())
                throw new AmazonNovaActException("Request object does not have required field WorkflowDefinitionName set");
            request.AddPathResource("{workflowDefinitionName}", StringUtils.FromString(publicRequest.WorkflowDefinitionName));
            request.ResourcePath = "/workflow-definitions/{workflowDefinitionName}";

            return request;
        }
        private static DeleteWorkflowDefinitionRequestMarshaller _instance = new DeleteWorkflowDefinitionRequestMarshaller();        

        internal static DeleteWorkflowDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteWorkflowDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}