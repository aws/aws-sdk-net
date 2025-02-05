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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
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
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteFunctionDefinition Request Marshaller
    /// </summary>       
    public class DeleteFunctionDefinitionRequestMarshaller : IMarshaller<IRequest, DeleteFunctionDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteFunctionDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteFunctionDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetFunctionDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field FunctionDefinitionId set");
            request.AddPathResource("{FunctionDefinitionId}", StringUtils.FromString(publicRequest.FunctionDefinitionId));
            request.ResourcePath = "/greengrass/definition/functions/{FunctionDefinitionId}";

            return request;
        }
        private static DeleteFunctionDefinitionRequestMarshaller _instance = new DeleteFunctionDefinitionRequestMarshaller();        

        internal static DeleteFunctionDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteFunctionDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}