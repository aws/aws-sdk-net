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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
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
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeInstanceTypeLimits Request Marshaller
    /// </summary>       
    public class DescribeInstanceTypeLimitsRequestMarshaller : IMarshaller<IRequest, DescribeInstanceTypeLimitsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeInstanceTypeLimitsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeInstanceTypeLimitsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetEngineVersion())
                throw new AmazonOpenSearchServiceException("Request object does not have required field EngineVersion set");
            request.AddPathResource("{EngineVersion}", StringUtils.FromString(publicRequest.EngineVersion));
            if (!publicRequest.IsSetInstanceType())
                throw new AmazonOpenSearchServiceException("Request object does not have required field InstanceType set");
            request.AddPathResource("{InstanceType}", StringUtils.FromString(publicRequest.InstanceType));
            
            if (publicRequest.IsSetDomainName())
                request.Parameters.Add("domainName", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/2021-01-01/opensearch/instanceTypeLimits/{EngineVersion}/{InstanceType}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeInstanceTypeLimitsRequestMarshaller _instance = new DescribeInstanceTypeLimitsRequestMarshaller();        

        internal static DescribeInstanceTypeLimitsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeInstanceTypeLimitsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}