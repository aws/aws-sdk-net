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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGeoLocation Request Marshaller
    /// </summary>
    public partial class GetGeoLocationRequestMarshaller : IMarshaller<IRequest, GetGeoLocationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGeoLocationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetGeoLocationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            request.ResourcePath = "/2013-04-01/geolocation";

            if (publicRequest.IsSetContinentCode())
            {
                request.Parameters.Add("continentcode", StringUtils.FromString(publicRequest.ContinentCode));
            }

            if (publicRequest.IsSetCountryCode())
            {
                request.Parameters.Add("countrycode", StringUtils.FromString(publicRequest.CountryCode));
            }

            if (publicRequest.IsSetSubdivisionCode())
            {
                request.Parameters.Add("subdivisioncode", StringUtils.FromString(publicRequest.SubdivisionCode));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly GetGeoLocationRequestMarshaller _instance = new();

        internal static GetGeoLocationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetGeoLocationRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetGeoLocationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetGeoLocationRequest publicRequest);
    }
}
