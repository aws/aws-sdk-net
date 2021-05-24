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
    /// Response Unmarshaller for RightsizingRecommendation Object
    /// </summary>  
    public class RightsizingRecommendationUnmarshaller : IUnmarshaller<RightsizingRecommendation, XmlUnmarshallerContext>, IUnmarshaller<RightsizingRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RightsizingRecommendation IUnmarshaller<RightsizingRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RightsizingRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RightsizingRecommendation unmarshalledObject = new RightsizingRecommendation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentInstance", targetDepth))
                {
                    var unmarshaller = CurrentInstanceUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingReasonCodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FindingReasonCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModifyRecommendationDetail", targetDepth))
                {
                    var unmarshaller = ModifyRecommendationDetailUnmarshaller.Instance;
                    unmarshalledObject.ModifyRecommendationDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RightsizingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RightsizingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TerminateRecommendationDetail", targetDepth))
                {
                    var unmarshaller = TerminateRecommendationDetailUnmarshaller.Instance;
                    unmarshalledObject.TerminateRecommendationDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RightsizingRecommendationUnmarshaller _instance = new RightsizingRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RightsizingRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}