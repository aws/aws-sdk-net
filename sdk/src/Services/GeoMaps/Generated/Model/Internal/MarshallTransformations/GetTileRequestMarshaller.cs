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
    /// GetTile Request Marshaller
    /// </summary>       
    public class GetTileRequestMarshaller : IMarshaller<IRequest, GetTileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoMaps");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTileset())
                throw new AmazonGeoMapsException("Request object does not have required field Tileset set");
            request.AddPathResource("{Tileset}", StringUtils.FromString(publicRequest.Tileset));
            if (!publicRequest.IsSetX())
                throw new AmazonGeoMapsException("Request object does not have required field X set");
            request.AddPathResource("{X}", StringUtils.FromString(publicRequest.X));
            if (!publicRequest.IsSetY())
                throw new AmazonGeoMapsException("Request object does not have required field Y set");
            request.AddPathResource("{Y}", StringUtils.FromString(publicRequest.Y));
            if (!publicRequest.IsSetZ())
                throw new AmazonGeoMapsException("Request object does not have required field Z set");
            request.AddPathResource("{Z}", StringUtils.FromString(publicRequest.Z));
            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/tiles/{Tileset}/{Z}/{X}/{Y}";
            request.UseQueryString = true;

            return request;
        }
        private static GetTileRequestMarshaller _instance = new GetTileRequestMarshaller();        

        internal static GetTileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}