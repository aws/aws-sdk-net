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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BillScenarioCommitmentModificationAction Object
    /// </summary>  
    public class BillScenarioCommitmentModificationActionUnmarshaller : IUnmarshaller<BillScenarioCommitmentModificationAction, XmlUnmarshallerContext>, IUnmarshaller<BillScenarioCommitmentModificationAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BillScenarioCommitmentModificationAction IUnmarshaller<BillScenarioCommitmentModificationAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BillScenarioCommitmentModificationAction Unmarshall(JsonUnmarshallerContext context)
        {
            BillScenarioCommitmentModificationAction unmarshalledObject = new BillScenarioCommitmentModificationAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addReservedInstanceAction", targetDepth))
                {
                    var unmarshaller = AddReservedInstanceActionUnmarshaller.Instance;
                    unmarshalledObject.AddReservedInstanceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("addSavingsPlanAction", targetDepth))
                {
                    var unmarshaller = AddSavingsPlanActionUnmarshaller.Instance;
                    unmarshalledObject.AddSavingsPlanAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("negateReservedInstanceAction", targetDepth))
                {
                    var unmarshaller = NegateReservedInstanceActionUnmarshaller.Instance;
                    unmarshalledObject.NegateReservedInstanceAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("negateSavingsPlanAction", targetDepth))
                {
                    var unmarshaller = NegateSavingsPlanActionUnmarshaller.Instance;
                    unmarshalledObject.NegateSavingsPlanAction = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BillScenarioCommitmentModificationActionUnmarshaller _instance = new BillScenarioCommitmentModificationActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BillScenarioCommitmentModificationActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}