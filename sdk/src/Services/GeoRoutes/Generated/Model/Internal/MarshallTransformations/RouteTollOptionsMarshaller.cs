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
    /// RouteTollOptions Marshaller
    /// </summary>
    public class RouteTollOptionsMarshaller : IRequestMarshaller<RouteTollOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteTollOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllTransponders())
            {
                context.Writer.WritePropertyName("AllTransponders");
                context.Writer.Write(requestObject.AllTransponders);
            }

            if(requestObject.IsSetAllVignettes())
            {
                context.Writer.WritePropertyName("AllVignettes");
                context.Writer.Write(requestObject.AllVignettes);
            }

            if(requestObject.IsSetCurrency())
            {
                context.Writer.WritePropertyName("Currency");
                context.Writer.Write(requestObject.Currency);
            }

            if(requestObject.IsSetEmissionType())
            {
                context.Writer.WritePropertyName("EmissionType");
                context.Writer.WriteObjectStart();

                var marshaller = RouteEmissionTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.EmissionType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVehicleCategory())
            {
                context.Writer.WritePropertyName("VehicleCategory");
                context.Writer.Write(requestObject.VehicleCategory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteTollOptionsMarshaller Instance = new RouteTollOptionsMarshaller();

    }
}