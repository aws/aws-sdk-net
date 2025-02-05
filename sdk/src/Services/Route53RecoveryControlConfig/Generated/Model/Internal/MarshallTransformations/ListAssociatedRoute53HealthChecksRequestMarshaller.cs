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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryControlConfig.Model;
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
namespace Amazon.Route53RecoveryControlConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAssociatedRoute53HealthChecks Request Marshaller
    /// </summary>       
    public class ListAssociatedRoute53HealthChecksRequestMarshaller : IMarshaller<IRequest, ListAssociatedRoute53HealthChecksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAssociatedRoute53HealthChecksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAssociatedRoute53HealthChecksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53RecoveryControlConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetRoutingControlArn())
                throw new AmazonRoute53RecoveryControlConfigException("Request object does not have required field RoutingControlArn set");
            request.AddPathResource("{RoutingControlArn}", StringUtils.FromString(publicRequest.RoutingControlArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/routingcontrol/{RoutingControlArn}/associatedRoute53HealthChecks";
            request.UseQueryString = true;

            return request;
        }
        private static ListAssociatedRoute53HealthChecksRequestMarshaller _instance = new ListAssociatedRoute53HealthChecksRequestMarshaller();        

        internal static ListAssociatedRoute53HealthChecksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAssociatedRoute53HealthChecksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}