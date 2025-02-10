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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchTextFilter Marshaller
    /// </summary>
    public class SearchTextFilterMarshaller : IRequestMarshaller<SearchTextFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchTextFilter requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetCircle())
            {
                context.Writer.WritePropertyName("Circle");
                context.Writer.WriteStartObject();

                var marshaller = FilterCircleMarshaller.Instance;
                marshaller.Marshall(requestObject.Circle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIncludeCountries())
            {
                context.Writer.WritePropertyName("IncludeCountries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludeCountriesListValue in requestObject.IncludeCountries)
                {
                        context.Writer.WriteStringValue(requestObjectIncludeCountriesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchTextFilterMarshaller Instance = new SearchTextFilterMarshaller();

    }
}