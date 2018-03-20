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
    /// Response Unmarshaller for ReservationPurchaseRecommendation Object
    /// </summary>  
    public class ReservationPurchaseRecommendationUnmarshaller : IUnmarshaller<ReservationPurchaseRecommendation, XmlUnmarshallerContext>, IUnmarshaller<ReservationPurchaseRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReservationPurchaseRecommendation IUnmarshaller<ReservationPurchaseRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReservationPurchaseRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReservationPurchaseRecommendation unmarshalledObject = new ReservationPurchaseRecommendation();
        
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
                if (context.TestExpression("RecommendationDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReservationPurchaseRecommendationDetail, ReservationPurchaseRecommendationDetailUnmarshaller>(ReservationPurchaseRecommendationDetailUnmarshaller.Instance);
                    unmarshalledObject.RecommendationDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecommendationSummary", targetDepth))
                {
                    var unmarshaller = ReservationPurchaseRecommendationSummaryUnmarshaller.Instance;
                    unmarshalledObject.RecommendationSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceSpecification", targetDepth))
                {
                    var unmarshaller = ServiceSpecificationUnmarshaller.Instance;
                    unmarshalledObject.ServiceSpecification = unmarshaller.Unmarshall(context);
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


        private static ReservationPurchaseRecommendationUnmarshaller _instance = new ReservationPurchaseRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservationPurchaseRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}