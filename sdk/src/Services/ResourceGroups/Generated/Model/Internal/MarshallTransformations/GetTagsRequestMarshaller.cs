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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceGroups.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResourceGroups.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTags Request Marshaller
    /// </summary>       
    public class GetTagsRequestMarshaller : IMarshaller<IRequest, GetTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTagsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTagsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceGroups");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetArn())
                throw new AmazonResourceGroupsException("Request object does not have required field Arn set");
            request.AddPathResource("{Arn}", StringUtils.FromString(publicRequest.Arn));
            request.ResourcePath = "/resources/{Arn}/tags";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetTagsRequestMarshaller _instance = new GetTagsRequestMarshaller();        

        internal static GetTagsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTagsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}