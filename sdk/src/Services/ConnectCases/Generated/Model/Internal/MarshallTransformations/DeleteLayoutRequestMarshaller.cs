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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
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
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLayout Request Marshaller
    /// </summary>       
    public class DeleteLayoutRequestMarshaller : IMarshaller<IRequest, DeleteLayoutRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLayoutRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLayoutRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCases");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-03";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectCasesException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            if (!publicRequest.IsSetLayoutId())
                throw new AmazonConnectCasesException("Request object does not have required field LayoutId set");
            request.AddPathResource("{layoutId}", StringUtils.FromString(publicRequest.LayoutId));
            request.ResourcePath = "/domains/{domainId}/layouts/{layoutId}";

            return request;
        }
        private static DeleteLayoutRequestMarshaller _instance = new DeleteLayoutRequestMarshaller();        

        internal static DeleteLayoutRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLayoutRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}