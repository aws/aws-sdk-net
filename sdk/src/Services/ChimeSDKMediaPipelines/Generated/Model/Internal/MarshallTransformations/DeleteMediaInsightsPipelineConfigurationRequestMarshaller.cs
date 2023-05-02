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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMediaInsightsPipelineConfiguration Request Marshaller
    /// </summary>       
    public class DeleteMediaInsightsPipelineConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteMediaInsightsPipelineConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMediaInsightsPipelineConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteMediaInsightsPipelineConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonChimeSDKMediaPipelinesException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/media-insights-pipeline-configurations/{identifier}";

            return request;
        }
        private static DeleteMediaInsightsPipelineConfigurationRequestMarshaller _instance = new DeleteMediaInsightsPipelineConfigurationRequestMarshaller();        

        internal static DeleteMediaInsightsPipelineConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteMediaInsightsPipelineConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}