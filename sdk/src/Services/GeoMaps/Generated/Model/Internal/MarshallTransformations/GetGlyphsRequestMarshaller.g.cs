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

using Amazon.GeoMaps.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GeoMaps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGlyphs Request Marshaller
    /// </summary>
    public partial class GetGlyphsRequestMarshaller : IMarshaller<IRequest, GetGlyphsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGlyphsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetGlyphsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoMaps");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFontStack())
            {
                throw new AmazonGeoMapsException("Request object does not have required field FontStack set");
            }
            request.AddPathResource("{FontStack}", StringUtils.FromString(publicRequest.FontStack));

            if (!publicRequest.IsSetFontUnicodeRange())
            {
                throw new AmazonGeoMapsException("Request object does not have required field FontUnicodeRange set");
            }
            request.AddPathResource("{FontUnicodeRange}", StringUtils.FromString(publicRequest.FontUnicodeRange));

            request.ResourcePath = "/v2/glyphs/{FontStack}/{FontUnicodeRange}";

            return request;
        }

        private static readonly GetGlyphsRequestMarshaller _instance = new();

        internal static GetGlyphsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetGlyphsRequestMarshaller Instance => _instance;
    }
}
