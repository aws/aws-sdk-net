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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
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
namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchAvailablePhoneNumbers Request Marshaller
    /// </summary>       
    public class SearchAvailablePhoneNumbersRequestMarshaller : IMarshaller<IRequest, SearchAvailablePhoneNumbersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchAvailablePhoneNumbersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchAvailablePhoneNumbersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "GET";

            request.AddSubResource("type", "phone-numbers");
            
            if (publicRequest.IsSetAreaCode())
                request.Parameters.Add("area-code", StringUtils.FromString(publicRequest.AreaCode));
            
            if (publicRequest.IsSetCity())
                request.Parameters.Add("city", StringUtils.FromString(publicRequest.City));
            
            if (publicRequest.IsSetCountry())
                request.Parameters.Add("country", StringUtils.FromString(publicRequest.Country));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPhoneNumberType())
                request.Parameters.Add("phone-number-type", StringUtils.FromString(publicRequest.PhoneNumberType));
            
            if (publicRequest.IsSetState())
                request.Parameters.Add("state", StringUtils.FromString(publicRequest.State));
            
            if (publicRequest.IsSetTollFreePrefix())
                request.Parameters.Add("toll-free-prefix", StringUtils.FromString(publicRequest.TollFreePrefix));
            request.ResourcePath = "/search";
            request.UseQueryString = true;

            return request;
        }
        private static SearchAvailablePhoneNumbersRequestMarshaller _instance = new SearchAvailablePhoneNumbersRequestMarshaller();        

        internal static SearchAvailablePhoneNumbersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchAvailablePhoneNumbersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}