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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteSpace Request Marshaller
    /// </summary>       
    public class DeleteSpaceRequestMarshaller : IMarshaller<IRequest, DeleteSpaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteSpaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteSpaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCatalyst");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetName())
                throw new AmazonCodeCatalystException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v1/spaces/{name}";

            return request;
        }
        private static DeleteSpaceRequestMarshaller _instance = new DeleteSpaceRequestMarshaller();        

        internal static DeleteSpaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteSpaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}