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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53GlobalResolver.Model;
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
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListHostedZoneAssociations Request Marshaller
    /// </summary>       
    public class ListHostedZoneAssociationsRequestMarshaller : IMarshaller<IRequest, ListHostedZoneAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHostedZoneAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListHostedZoneAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53GlobalResolver");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetResourceArn())
                throw new AmazonRoute53GlobalResolverException("Request object does not have required field ResourceArn set");
            request.AddPathResource("{resourceArn+}", StringUtils.FromString(publicRequest.ResourceArn.TrimStart('/')));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max_results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next_token", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/hosted-zone-associations/resource-arn/{resourceArn+}";
            request.UseQueryString = true;

            return request;
        }
        private static ListHostedZoneAssociationsRequestMarshaller _instance = new ListHostedZoneAssociationsRequestMarshaller();        

        internal static ListHostedZoneAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListHostedZoneAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}