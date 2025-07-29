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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeofenceGeometry Marshaller
    /// </summary>
    public class GeofenceGeometryMarshaller : IRequestMarshaller<GeofenceGeometry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeofenceGeometry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCircle())
            {
                context.Writer.WritePropertyName("Circle");
                context.Writer.WriteObjectStart();

                var marshaller = CircleMarshaller.Instance;
                marshaller.Marshall(requestObject.Circle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGeobuf())
            {
                context.Writer.WritePropertyName("Geobuf");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.Geobuf));
            }

            if(requestObject.IsSetMultiPolygon())
            {
                context.Writer.WritePropertyName("MultiPolygon");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMultiPolygonListValue in requestObject.MultiPolygon)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectMultiPolygonListValueListValue in requestObjectMultiPolygonListValue)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var requestObjectMultiPolygonListValueListValueListValue in requestObjectMultiPolygonListValueListValue)
                        {
                            context.Writer.WriteArrayStart();
                            foreach(var requestObjectMultiPolygonListValueListValueListValueListValue in requestObjectMultiPolygonListValueListValueListValue)
                            {
                                    context.Writer.Write(requestObjectMultiPolygonListValueListValueListValueListValue);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPolygon())
            {
                context.Writer.WritePropertyName("Polygon");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPolygonListValue in requestObject.Polygon)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectPolygonListValueListValue in requestObjectPolygonListValue)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var requestObjectPolygonListValueListValueListValue in requestObjectPolygonListValueListValue)
                        {
                                context.Writer.Write(requestObjectPolygonListValueListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeofenceGeometryMarshaller Instance = new GeofenceGeometryMarshaller();

    }
}