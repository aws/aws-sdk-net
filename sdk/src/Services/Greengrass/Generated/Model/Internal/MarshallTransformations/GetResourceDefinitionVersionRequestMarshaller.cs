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
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResourceDefinitionVersion Request Marshaller
    /// </summary>       
    public class GetResourceDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetResourceDefinitionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetResourceDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field ResourceDefinitionId set");
            request.AddPathResource("{ResourceDefinitionId}", StringUtils.FromString(publicRequest.ResourceDefinitionId));
            if (!publicRequest.IsSetResourceDefinitionVersionId())
                throw new AmazonGreengrassException("Request object does not have required field ResourceDefinitionVersionId set");
            request.AddPathResource("{ResourceDefinitionVersionId}", StringUtils.FromString(publicRequest.ResourceDefinitionVersionId));
            request.ResourcePath = "/greengrass/definition/resources/{ResourceDefinitionId}/versions/{ResourceDefinitionVersionId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetResourceDefinitionVersionRequestMarshaller _instance = new GetResourceDefinitionVersionRequestMarshaller();        

        internal static GetResourceDefinitionVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceDefinitionVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}