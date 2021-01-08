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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGeoLocation Request Marshaller
    /// </summary>       
    public class GetGeoLocationRequestMarshaller : IMarshaller<IRequest, GetGeoLocationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGeoLocationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetGeoLocationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            
            if (publicRequest.IsSetContinentCode())
                request.Parameters.Add("continentcode", StringUtils.FromString(publicRequest.ContinentCode));
            
            if (publicRequest.IsSetCountryCode())
                request.Parameters.Add("countrycode", StringUtils.FromString(publicRequest.CountryCode));
            
            if (publicRequest.IsSetSubdivisionCode())
                request.Parameters.Add("subdivisioncode", StringUtils.FromString(publicRequest.SubdivisionCode));
            request.ResourcePath = "/2013-04-01/geolocation";
            request.MarshallerVersion = 2;


            request.UseQueryString = true;
            return request;
        }
        private static GetGeoLocationRequestMarshaller _instance = new GetGeoLocationRequestMarshaller();        

        internal static GetGeoLocationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetGeoLocationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}