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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PricingPlan Object
    /// </summary>  
    public class PricingPlanUnmarshaller : IUnmarshaller<PricingPlan, XmlUnmarshallerContext>, IUnmarshaller<PricingPlan, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PricingPlan IUnmarshaller<PricingPlan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PricingPlan Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PricingPlan unmarshalledObject = new PricingPlan();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("billableEntityCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BillableEntityCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bundleInformation", targetDepth))
                {
                    var unmarshaller = BundleInformationUnmarshaller.Instance;
                    unmarshalledObject.BundleInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("effectiveDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EffectiveDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pricingMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PricingMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdateDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdateReason = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PricingPlanUnmarshaller _instance = new PricingPlanUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PricingPlanUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}