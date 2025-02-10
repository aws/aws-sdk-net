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
    /// IsolineTruckOptions Marshaller
    /// </summary>
    public class IsolineTruckOptionsMarshaller : IRequestMarshaller<IsolineTruckOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IsolineTruckOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAxleCount())
            {
                context.Writer.WritePropertyName("AxleCount");
                context.Writer.WriteNumberValue(requestObject.AxleCount.Value);
            }

            if(requestObject.IsSetEngineType())
            {
                context.Writer.WritePropertyName("EngineType");
                context.Writer.WriteStringValue(requestObject.EngineType);
            }

            if(requestObject.IsSetGrossWeight())
            {
                context.Writer.WritePropertyName("GrossWeight");
                context.Writer.WriteNumberValue(requestObject.GrossWeight.Value);
            }

            if(requestObject.IsSetHazardousCargos())
            {
                context.Writer.WritePropertyName("HazardousCargos");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHazardousCargosListValue in requestObject.HazardousCargos)
                {
                        context.Writer.WriteStringValue(requestObjectHazardousCargosListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                context.Writer.WriteNumberValue(requestObject.Height.Value);
            }

            if(requestObject.IsSetHeightAboveFirstAxle())
            {
                context.Writer.WritePropertyName("HeightAboveFirstAxle");
                context.Writer.WriteNumberValue(requestObject.HeightAboveFirstAxle.Value);
            }

            if(requestObject.IsSetKpraLength())
            {
                context.Writer.WritePropertyName("KpraLength");
                context.Writer.WriteNumberValue(requestObject.KpraLength.Value);
            }

            if(requestObject.IsSetLength())
            {
                context.Writer.WritePropertyName("Length");
                context.Writer.WriteNumberValue(requestObject.Length.Value);
            }

            if(requestObject.IsSetLicensePlate())
            {
                context.Writer.WritePropertyName("LicensePlate");
                context.Writer.WriteStartObject();

                var marshaller = IsolineVehicleLicensePlateMarshaller.Instance;
                marshaller.Marshall(requestObject.LicensePlate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxSpeed())
            {
                context.Writer.WritePropertyName("MaxSpeed");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaxSpeed.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MaxSpeed.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MaxSpeed.Value);
                }
            }

            if(requestObject.IsSetOccupancy())
            {
                context.Writer.WritePropertyName("Occupancy");
                context.Writer.WriteNumberValue(requestObject.Occupancy.Value);
            }

            if(requestObject.IsSetPayloadCapacity())
            {
                context.Writer.WritePropertyName("PayloadCapacity");
                context.Writer.WriteNumberValue(requestObject.PayloadCapacity.Value);
            }

            if(requestObject.IsSetTireCount())
            {
                context.Writer.WritePropertyName("TireCount");
                context.Writer.WriteNumberValue(requestObject.TireCount.Value);
            }

            if(requestObject.IsSetTrailer())
            {
                context.Writer.WritePropertyName("Trailer");
                context.Writer.WriteStartObject();

                var marshaller = IsolineTrailerOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Trailer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTruckType())
            {
                context.Writer.WritePropertyName("TruckType");
                context.Writer.WriteStringValue(requestObject.TruckType);
            }

            if(requestObject.IsSetTunnelRestrictionCode())
            {
                context.Writer.WritePropertyName("TunnelRestrictionCode");
                context.Writer.WriteStringValue(requestObject.TunnelRestrictionCode);
            }

            if(requestObject.IsSetWeightPerAxle())
            {
                context.Writer.WritePropertyName("WeightPerAxle");
                context.Writer.WriteNumberValue(requestObject.WeightPerAxle.Value);
            }

            if(requestObject.IsSetWeightPerAxleGroup())
            {
                context.Writer.WritePropertyName("WeightPerAxleGroup");
                context.Writer.WriteStartObject();

                var marshaller = WeightPerAxleGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.WeightPerAxleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
                context.Writer.WriteNumberValue(requestObject.Width.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IsolineTruckOptionsMarshaller Instance = new IsolineTruckOptionsMarshaller();

    }
}