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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectWisdomService.Model;
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
namespace Amazon.ConnectWisdomService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteImportJob Request Marshaller
    /// </summary>       
    public class DeleteImportJobRequestMarshaller : IMarshaller<IRequest, DeleteImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetImportJobId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field ImportJobId set");
            request.AddPathResource("{importJobId}", StringUtils.FromString(publicRequest.ImportJobId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/importJobs/{importJobId}";

            return request;
        }
        private static DeleteImportJobRequestMarshaller _instance = new DeleteImportJobRequestMarshaller();        

        internal static DeleteImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}