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
    /// GetStaticMap Request Marshaller
    /// </summary>       
    public class GetStaticMapRequestMarshaller : IMarshaller<IRequest, GetStaticMapRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetStaticMapRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetStaticMapRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoMaps");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFileName())
                throw new AmazonGeoMapsException("Request object does not have required field FileName set");
            request.AddPathResource("{FileName}", StringUtils.FromString(publicRequest.FileName));
            
            if (publicRequest.IsSetBoundedPositions())
                request.Parameters.Add("bounded-positions", StringUtils.FromString(publicRequest.BoundedPositions));
            
            if (publicRequest.IsSetBoundingBox())
                request.Parameters.Add("bounding-box", StringUtils.FromString(publicRequest.BoundingBox));
            
            if (publicRequest.IsSetCenter())
                request.Parameters.Add("center", StringUtils.FromString(publicRequest.Center));
            
            if (publicRequest.IsSetColorScheme())
                request.Parameters.Add("color-scheme", StringUtils.FromString(publicRequest.ColorScheme));
            
            if (publicRequest.IsSetCompactOverlay())
                request.Parameters.Add("compact-overlay", StringUtils.FromString(publicRequest.CompactOverlay));
            
            if (publicRequest.IsSetCropLabels())
                request.Parameters.Add("crop-labels", StringUtils.FromBool(publicRequest.CropLabels));
            
            if (publicRequest.IsSetGeoJsonOverlay())
                request.Parameters.Add("geojson-overlay", StringUtils.FromString(publicRequest.GeoJsonOverlay));
            
            if (publicRequest.IsSetHeight())
                request.Parameters.Add("height", StringUtils.FromInt(publicRequest.Height));
            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetLabelSize())
                request.Parameters.Add("label-size", StringUtils.FromString(publicRequest.LabelSize));
            
            if (publicRequest.IsSetLanguage())
                request.Parameters.Add("lang", StringUtils.FromString(publicRequest.Language));
            
            if (publicRequest.IsSetPadding())
                request.Parameters.Add("padding", StringUtils.FromInt(publicRequest.Padding));
            
            if (publicRequest.IsSetPointsOfInterests())
                request.Parameters.Add("pois", StringUtils.FromString(publicRequest.PointsOfInterests));
            
            if (publicRequest.IsSetPoliticalView())
                request.Parameters.Add("political-view", StringUtils.FromString(publicRequest.PoliticalView));
            
            if (publicRequest.IsSetRadius())
                request.Parameters.Add("radius", StringUtils.FromLong(publicRequest.Radius));
            
            if (publicRequest.IsSetScaleBarUnit())
                request.Parameters.Add("scale-unit", StringUtils.FromString(publicRequest.ScaleBarUnit));
            
            if (publicRequest.IsSetStyle())
                request.Parameters.Add("style", StringUtils.FromString(publicRequest.Style));
            
            if (publicRequest.IsSetWidth())
                request.Parameters.Add("width", StringUtils.FromInt(publicRequest.Width));
            
            if (publicRequest.IsSetZoom())
                request.Parameters.Add("zoom", StringUtils.FromFloat(publicRequest.Zoom));
            request.ResourcePath = "/static/{FileName}";
            request.UseQueryString = true;

            return request;
        }
        private static GetStaticMapRequestMarshaller _instance = new GetStaticMapRequestMarshaller();        

        internal static GetStaticMapRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetStaticMapRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}