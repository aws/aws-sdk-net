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
    /// Response Unmarshaller for SavingsPlansPurchaseRecommendation Object
    /// </summary>  
    public class SavingsPlansPurchaseRecommendationUnmarshaller : IUnmarshaller<SavingsPlansPurchaseRecommendation, XmlUnmarshallerContext>, IUnmarshaller<SavingsPlansPurchaseRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SavingsPlansPurchaseRecommendation IUnmarshaller<SavingsPlansPurchaseRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SavingsPlansPurchaseRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SavingsPlansPurchaseRecommendation unmarshalledObject = new SavingsPlansPurchaseRecommendation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LookbackPeriodInDays", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LookbackPeriodInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaymentOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaymentOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SavingsPlansPurchaseRecommendationDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SavingsPlansPurchaseRecommendationDetail, SavingsPlansPurchaseRecommendationDetailUnmarshaller>(SavingsPlansPurchaseRecommendationDetailUnmarshaller.Instance);
                    unmarshalledObject.SavingsPlansPurchaseRecommendationDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SavingsPlansPurchaseRecommendationSummary", targetDepth))
                {
                    var unmarshaller = SavingsPlansPurchaseRecommendationSummaryUnmarshaller.Instance;
                    unmarshalledObject.SavingsPlansPurchaseRecommendationSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SavingsPlansType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SavingsPlansType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TermInYears", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TermInYears = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SavingsPlansPurchaseRecommendationUnmarshaller _instance = new SavingsPlansPurchaseRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlansPurchaseRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}