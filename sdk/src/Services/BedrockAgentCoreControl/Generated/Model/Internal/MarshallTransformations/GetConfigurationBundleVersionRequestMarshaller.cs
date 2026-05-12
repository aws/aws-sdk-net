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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
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
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConfigurationBundleVersion Request Marshaller
    /// </summary>       
    public class GetConfigurationBundleVersionRequestMarshaller : IMarshaller<IRequest, GetConfigurationBundleVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConfigurationBundleVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetConfigurationBundleVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBundleId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field BundleId set");
            request.AddPathResource("{bundleId}", StringUtils.FromString(publicRequest.BundleId));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field VersionId set");
            request.AddPathResource("{versionId}", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/configuration-bundles/{bundleId}/versions/{versionId}";

            return request;
        }
        private static GetConfigurationBundleVersionRequestMarshaller _instance = new GetConfigurationBundleVersionRequestMarshaller();        

        internal static GetConfigurationBundleVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetConfigurationBundleVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}