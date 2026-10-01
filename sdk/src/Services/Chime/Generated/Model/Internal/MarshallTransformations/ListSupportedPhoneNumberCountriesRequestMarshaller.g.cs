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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Chime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSupportedPhoneNumberCountries Request Marshaller
    /// </summary>
    public partial class ListSupportedPhoneNumberCountriesRequestMarshaller : IMarshaller<IRequest, ListSupportedPhoneNumberCountriesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSupportedPhoneNumberCountriesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListSupportedPhoneNumberCountriesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.ProductType))
            {
                throw new AmazonChimeException("Request object does not have required field ProductType set");
            }

            if (publicRequest.IsSetProductType())
            {
                request.Parameters.Add("product-type", StringUtils.FromString(publicRequest.ProductType));
            }

            request.ResourcePath = "/phone-number-countries";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListSupportedPhoneNumberCountriesRequestMarshaller _instance = new();

        internal static ListSupportedPhoneNumberCountriesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListSupportedPhoneNumberCountriesRequestMarshaller Instance => _instance;
    }
}
