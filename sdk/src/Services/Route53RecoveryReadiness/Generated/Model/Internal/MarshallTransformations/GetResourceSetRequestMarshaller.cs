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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryReadiness.Model;
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
namespace Amazon.Route53RecoveryReadiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResourceSet Request Marshaller
    /// </summary>       
    public class GetResourceSetRequestMarshaller : IMarshaller<IRequest, GetResourceSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53RecoveryReadiness");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetResourceSetName())
                throw new AmazonRoute53RecoveryReadinessException("Request object does not have required field ResourceSetName set");
            request.AddPathResource("{resourceSetName}", StringUtils.FromString(publicRequest.ResourceSetName));
            request.ResourcePath = "/resourcesets/{resourceSetName}";

            return request;
        }
        private static GetResourceSetRequestMarshaller _instance = new GetResourceSetRequestMarshaller();        

        internal static GetResourceSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}