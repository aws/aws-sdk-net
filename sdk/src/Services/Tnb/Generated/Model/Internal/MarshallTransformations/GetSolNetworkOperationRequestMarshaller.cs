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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Tnb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Tnb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSolNetworkOperation Request Marshaller
    /// </summary>       
    public class GetSolNetworkOperationRequestMarshaller : IMarshaller<IRequest, GetSolNetworkOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSolNetworkOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSolNetworkOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Tnb");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2008-10-21";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetNsLcmOpOccId())
                throw new AmazonTnbException("Request object does not have required field NsLcmOpOccId set");
            request.AddPathResource("{nsLcmOpOccId}", StringUtils.FromString(publicRequest.NsLcmOpOccId));
            request.ResourcePath = "/sol/nslcm/v1/ns_lcm_op_occs/{nsLcmOpOccId}";

            return request;
        }
        private static GetSolNetworkOperationRequestMarshaller _instance = new GetSolNetworkOperationRequestMarshaller();        

        internal static GetSolNetworkOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSolNetworkOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}