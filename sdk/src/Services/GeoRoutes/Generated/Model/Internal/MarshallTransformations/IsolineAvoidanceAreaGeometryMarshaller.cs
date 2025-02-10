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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IsolineAvoidanceAreaGeometry Marshaller
    /// </summary>
    public class IsolineAvoidanceAreaGeometryMarshaller : IRequestMarshaller<IsolineAvoidanceAreaGeometry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IsolineAvoidanceAreaGeometry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBoundingBox())
            {
                context.Writer.WritePropertyName("BoundingBox");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBoundingBoxListValue in requestObject.BoundingBox)
                {
                        context.Writer.WriteNumberValue(requestObjectBoundingBoxListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCorridor())
            {
                context.Writer.WritePropertyName("Corridor");
                context.Writer.WriteStartObject();

                var marshaller = CorridorMarshaller.Instance;
                marshaller.Marshall(requestObject.Corridor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPolygon())
            {
                context.Writer.WritePropertyName("Polygon");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPolygonListValue in requestObject.Polygon)
                {
                    context.Writer.WriteStartArray();
                    foreach(var requestObjectPolygonListValueListValue in requestObjectPolygonListValue)
                    {
                        context.Writer.WriteStartArray();
                        foreach(var requestObjectPolygonListValueListValueListValue in requestObjectPolygonListValueListValue)
                        {
                                context.Writer.WriteNumberValue(requestObjectPolygonListValueListValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPolylineCorridor())
            {
                context.Writer.WritePropertyName("PolylineCorridor");
                context.Writer.WriteStartObject();

                var marshaller = PolylineCorridorMarshaller.Instance;
                marshaller.Marshall(requestObject.PolylineCorridor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPolylinePolygon())
            {
                context.Writer.WritePropertyName("PolylinePolygon");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPolylinePolygonListValue in requestObject.PolylinePolygon)
                {
                        context.Writer.WriteStringValue(requestObjectPolylinePolygonListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IsolineAvoidanceAreaGeometryMarshaller Instance = new IsolineAvoidanceAreaGeometryMarshaller();

    }
}