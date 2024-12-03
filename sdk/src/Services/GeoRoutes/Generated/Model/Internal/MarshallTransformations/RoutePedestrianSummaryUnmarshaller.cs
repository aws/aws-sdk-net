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
using System.Net;
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
    /// Response Unmarshaller for RoutePedestrianSummary Object
    /// </summary>  
    public class RoutePedestrianSummaryUnmarshaller : IUnmarshaller<RoutePedestrianSummary, XmlUnmarshallerContext>, IUnmarshaller<RoutePedestrianSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RoutePedestrianSummary IUnmarshaller<RoutePedestrianSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RoutePedestrianSummary Unmarshall(JsonUnmarshallerContext context)
        {
            RoutePedestrianSummary unmarshalledObject = new RoutePedestrianSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Overview", targetDepth))
                {
                    var unmarshaller = RoutePedestrianOverviewSummaryUnmarshaller.Instance;
                    unmarshalledObject.Overview = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TravelOnly", targetDepth))
                {
                    var unmarshaller = RoutePedestrianTravelOnlySummaryUnmarshaller.Instance;
                    unmarshalledObject.TravelOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RoutePedestrianSummaryUnmarshaller _instance = new RoutePedestrianSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RoutePedestrianSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}