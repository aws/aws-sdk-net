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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
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
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSites Request Marshaller
    /// </summary>       
    public class ListSitesRequestMarshaller : IMarshaller<IRequest, ListSitesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSitesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSitesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOperatingAddressCityFilter())
                request.ParameterCollection.Add("OperatingAddressCityFilter", publicRequest.OperatingAddressCityFilter);
            
            if (publicRequest.IsSetOperatingAddressCountryCodeFilter())
                request.ParameterCollection.Add("OperatingAddressCountryCodeFilter", publicRequest.OperatingAddressCountryCodeFilter);
            
            if (publicRequest.IsSetOperatingAddressStateOrRegionFilter())
                request.ParameterCollection.Add("OperatingAddressStateOrRegionFilter", publicRequest.OperatingAddressStateOrRegionFilter);
            request.ResourcePath = "/sites";
            request.UseQueryString = true;

            return request;
        }
        private static ListSitesRequestMarshaller _instance = new ListSitesRequestMarshaller();        

        internal static ListSitesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSitesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}