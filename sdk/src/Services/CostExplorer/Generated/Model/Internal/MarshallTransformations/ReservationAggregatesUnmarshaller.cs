/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservationAggregates Object
    /// </summary>  
    public class ReservationAggregatesUnmarshaller : IUnmarshaller<ReservationAggregates, XmlUnmarshallerContext>, IUnmarshaller<ReservationAggregates, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReservationAggregates IUnmarshaller<ReservationAggregates, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReservationAggregates Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReservationAggregates unmarshalledObject = new ReservationAggregates();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmortizedRecurringFee", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmortizedRecurringFee = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmortizedUpfrontFee", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmortizedUpfrontFee = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetRISavings", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetRISavings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnDemandCostOfRIHoursUsed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OnDemandCostOfRIHoursUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PurchasedHours", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PurchasedHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalActualHours", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalActualHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalAmortizedFee", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalAmortizedFee = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalPotentialRISavings", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalPotentialRISavings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnusedHours", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnusedHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UtilizationPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReservationAggregatesUnmarshaller _instance = new ReservationAggregatesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservationAggregatesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}