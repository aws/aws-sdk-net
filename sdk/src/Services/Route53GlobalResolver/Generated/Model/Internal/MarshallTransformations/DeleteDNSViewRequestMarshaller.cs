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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDNSView Request Marshaller
    /// </summary>       
    public class DeleteDNSViewRequestMarshaller : IMarshaller<IRequest, DeleteDNSViewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDNSViewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDNSViewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53GlobalResolver");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-27";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetDnsViewId())
                throw new AmazonRoute53GlobalResolverException("Request object does not have required field DnsViewId set");
            request.AddPathResource("{dnsViewId}", StringUtils.FromString(publicRequest.DnsViewId));
            request.ResourcePath = "/dns-views/{dnsViewId}";

            return request;
        }
        private static DeleteDNSViewRequestMarshaller _instance = new DeleteDNSViewRequestMarshaller();        

        internal static DeleteDNSViewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDNSViewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}