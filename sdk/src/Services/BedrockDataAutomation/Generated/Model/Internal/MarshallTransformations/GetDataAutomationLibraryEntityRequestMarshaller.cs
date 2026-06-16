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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
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
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDataAutomationLibraryEntity Request Marshaller
    /// </summary>       
    public class GetDataAutomationLibraryEntityRequestMarshaller : IMarshaller<IRequest, GetDataAutomationLibraryEntityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDataAutomationLibraryEntityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDataAutomationLibraryEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEntityId())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field EntityId set");
            request.AddPathResource("{entityId}", StringUtils.FromString(publicRequest.EntityId));
            if (!publicRequest.IsSetEntityType())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field EntityType set");
            request.AddPathResource("{entityType}", StringUtils.FromString(publicRequest.EntityType));
            if (!publicRequest.IsSetLibraryArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field LibraryArn set");
            request.AddPathResource("{libraryArn}", StringUtils.FromString(publicRequest.LibraryArn));
            request.ResourcePath = "/data-automation-libraries/{libraryArn}/entityType/{entityType}/entities/{entityId}";

            return request;
        }
        private static GetDataAutomationLibraryEntityRequestMarshaller _instance = new GetDataAutomationLibraryEntityRequestMarshaller();        

        internal static GetDataAutomationLibraryEntityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDataAutomationLibraryEntityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}