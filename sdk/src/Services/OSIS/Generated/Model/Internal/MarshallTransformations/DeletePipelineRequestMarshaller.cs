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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OSIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OSIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePipeline Request Marshaller
    /// </summary>       
    public class DeletePipelineRequestMarshaller : IMarshaller<IRequest, DeletePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeletePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OSIS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-01-01";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetPipelineName())
                throw new AmazonOSISException("Request object does not have required field PipelineName set");
            request.AddPathResource("{PipelineName}", StringUtils.FromString(publicRequest.PipelineName));
            request.ResourcePath = "/2022-01-01/osis/deletePipeline/{PipelineName}";

            return request;
        }
        private static DeletePipelineRequestMarshaller _instance = new DeletePipelineRequestMarshaller();        

        internal static DeletePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeletePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}