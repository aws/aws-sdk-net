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
#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CalculateRouteTruckModeOptions Marshaller
    /// </summary>
    public class CalculateRouteTruckModeOptionsMarshaller : IRequestMarshaller<CalculateRouteTruckModeOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CalculateRouteTruckModeOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvoidFerries())
            {
                context.Writer.WritePropertyName("AvoidFerries");
                context.Writer.WriteBooleanValue(requestObject.AvoidFerries.Value);
            }

            if(requestObject.IsSetAvoidTolls())
            {
                context.Writer.WritePropertyName("AvoidTolls");
                context.Writer.WriteBooleanValue(requestObject.AvoidTolls.Value);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartObject();

                var marshaller = TruckDimensionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimensions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWeight())
            {
                context.Writer.WritePropertyName("Weight");
                context.Writer.WriteStartObject();

                var marshaller = TruckWeightMarshaller.Instance;
                marshaller.Marshall(requestObject.Weight, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CalculateRouteTruckModeOptionsMarshaller Instance = new CalculateRouteTruckModeOptionsMarshaller();

    }
}