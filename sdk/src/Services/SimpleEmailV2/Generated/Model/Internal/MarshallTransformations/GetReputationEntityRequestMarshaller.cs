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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
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
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReputationEntity Request Marshaller
    /// </summary>       
    public class GetReputationEntityRequestMarshaller : IMarshaller<IRequest, GetReputationEntityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReputationEntityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReputationEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetReputationEntityReference())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field ReputationEntityReference set");
            request.AddPathResource("{ReputationEntityReference}", StringUtils.FromString(publicRequest.ReputationEntityReference));
            if (!publicRequest.IsSetReputationEntityType())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field ReputationEntityType set");
            request.AddPathResource("{ReputationEntityType}", StringUtils.FromString(publicRequest.ReputationEntityType));
            request.ResourcePath = "/v2/email/reputation/entities/{ReputationEntityType}/{ReputationEntityReference}";

            return request;
        }
        private static GetReputationEntityRequestMarshaller _instance = new GetReputationEntityRequestMarshaller();        

        internal static GetReputationEntityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReputationEntityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}