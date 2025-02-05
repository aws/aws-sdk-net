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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IAMRolesAnywhere.Model;
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
namespace Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnableTrustAnchor Request Marshaller
    /// </summary>       
    public class EnableTrustAnchorRequestMarshaller : IMarshaller<IRequest, EnableTrustAnchorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableTrustAnchorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EnableTrustAnchorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IAMRolesAnywhere");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetTrustAnchorId())
                throw new AmazonIAMRolesAnywhereException("Request object does not have required field TrustAnchorId set");
            request.AddPathResource("{trustAnchorId}", StringUtils.FromString(publicRequest.TrustAnchorId));
            request.ResourcePath = "/trustanchor/{trustAnchorId}/enable";

            return request;
        }
        private static EnableTrustAnchorRequestMarshaller _instance = new EnableTrustAnchorRequestMarshaller();        

        internal static EnableTrustAnchorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnableTrustAnchorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}