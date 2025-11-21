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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDashboards.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDashboards.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryParameters Marshaller
    /// </summary>
    public class QueryParametersMarshaller : IRequestMarshaller<QueryParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QueryParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCostAndUsage())
            {
                context.Writer.WritePropertyName("costAndUsage");
                context.Writer.WriteStartObject();

                var marshaller = CostAndUsageQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.CostAndUsage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReservationCoverage())
            {
                context.Writer.WritePropertyName("reservationCoverage");
                context.Writer.WriteStartObject();

                var marshaller = ReservationCoverageQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.ReservationCoverage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReservationUtilization())
            {
                context.Writer.WritePropertyName("reservationUtilization");
                context.Writer.WriteStartObject();

                var marshaller = ReservationUtilizationQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.ReservationUtilization, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSavingsPlansCoverage())
            {
                context.Writer.WritePropertyName("savingsPlansCoverage");
                context.Writer.WriteStartObject();

                var marshaller = SavingsPlansCoverageQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.SavingsPlansCoverage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSavingsPlansUtilization())
            {
                context.Writer.WritePropertyName("savingsPlansUtilization");
                context.Writer.WriteStartObject();

                var marshaller = SavingsPlansUtilizationQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.SavingsPlansUtilization, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QueryParametersMarshaller Instance = new QueryParametersMarshaller();

    }
}