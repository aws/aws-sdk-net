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
 * Do not modify this file. This file is generated from the geo-maps-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoMaps.Model;
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
namespace Amazon.GeoMaps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetStyleDescriptor Request Marshaller
    /// </summary>       
    public class GetStyleDescriptorRequestMarshaller : IMarshaller<IRequest, GetStyleDescriptorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetStyleDescriptorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetStyleDescriptorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoMaps");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetStyle())
                throw new AmazonGeoMapsException("Request object does not have required field Style set");
            request.AddPathResource("{Style}", StringUtils.FromString(publicRequest.Style));
            
            if (publicRequest.IsSetColorScheme())
                request.Parameters.Add("color-scheme", StringUtils.FromString(publicRequest.ColorScheme));
            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetPoliticalView())
                request.Parameters.Add("political-view", StringUtils.FromString(publicRequest.PoliticalView));
            request.ResourcePath = "/styles/{Style}/descriptor";
            request.UseQueryString = true;

            return request;
        }
        private static GetStyleDescriptorRequestMarshaller _instance = new GetStyleDescriptorRequestMarshaller();        

        internal static GetStyleDescriptorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetStyleDescriptorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}