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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouteMatrixTruckOptions Marshaller
    /// </summary>
    public class RouteMatrixTruckOptionsMarshaller : IRequestMarshaller<RouteMatrixTruckOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteMatrixTruckOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAxleCount())
            {
                context.Writer.WritePropertyName("AxleCount");
                context.Writer.Write(requestObject.AxleCount);
            }

            if(requestObject.IsSetGrossWeight())
            {
                context.Writer.WritePropertyName("GrossWeight");
                context.Writer.Write(requestObject.GrossWeight);
            }

            if(requestObject.IsSetHazardousCargos())
            {
                context.Writer.WritePropertyName("HazardousCargos");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHazardousCargosListValue in requestObject.HazardousCargos)
                {
                        context.Writer.Write(requestObjectHazardousCargosListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                context.Writer.Write(requestObject.Height);
            }

            if(requestObject.IsSetKpraLength())
            {
                context.Writer.WritePropertyName("KpraLength");
                context.Writer.Write(requestObject.KpraLength);
            }

            if(requestObject.IsSetLength())
            {
                context.Writer.WritePropertyName("Length");
                context.Writer.Write(requestObject.Length);
            }

            if(requestObject.IsSetLicensePlate())
            {
                context.Writer.WritePropertyName("LicensePlate");
                context.Writer.WriteObjectStart();

                var marshaller = RouteMatrixVehicleLicensePlateMarshaller.Instance;
                marshaller.Marshall(requestObject.LicensePlate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaxSpeed())
            {
                context.Writer.WritePropertyName("MaxSpeed");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaxSpeed))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.MaxSpeed));
                }
                else
                {
                    context.Writer.Write(requestObject.MaxSpeed);
                }
            }

            if(requestObject.IsSetOccupancy())
            {
                context.Writer.WritePropertyName("Occupancy");
                context.Writer.Write(requestObject.Occupancy);
            }

            if(requestObject.IsSetPayloadCapacity())
            {
                context.Writer.WritePropertyName("PayloadCapacity");
                context.Writer.Write(requestObject.PayloadCapacity);
            }

            if(requestObject.IsSetTrailer())
            {
                context.Writer.WritePropertyName("Trailer");
                context.Writer.WriteObjectStart();

                var marshaller = RouteMatrixTrailerOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Trailer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTruckType())
            {
                context.Writer.WritePropertyName("TruckType");
                context.Writer.Write(requestObject.TruckType);
            }

            if(requestObject.IsSetTunnelRestrictionCode())
            {
                context.Writer.WritePropertyName("TunnelRestrictionCode");
                context.Writer.Write(requestObject.TunnelRestrictionCode);
            }

            if(requestObject.IsSetWeightPerAxle())
            {
                context.Writer.WritePropertyName("WeightPerAxle");
                context.Writer.Write(requestObject.WeightPerAxle);
            }

            if(requestObject.IsSetWeightPerAxleGroup())
            {
                context.Writer.WritePropertyName("WeightPerAxleGroup");
                context.Writer.WriteObjectStart();

                var marshaller = WeightPerAxleGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.WeightPerAxleGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
                context.Writer.Write(requestObject.Width);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteMatrixTruckOptionsMarshaller Instance = new RouteMatrixTruckOptionsMarshaller();

    }
}