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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrustedAdvisorCategorySpecificSummary Object
    /// </summary>  
    public class TrustedAdvisorCategorySpecificSummaryUnmarshaller : IUnmarshaller<TrustedAdvisorCategorySpecificSummary, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorCategorySpecificSummary, JsonUnmarshallerContext>
    {
        TrustedAdvisorCategorySpecificSummary IUnmarshaller<TrustedAdvisorCategorySpecificSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public TrustedAdvisorCategorySpecificSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TrustedAdvisorCategorySpecificSummary unmarshalledObject = new TrustedAdvisorCategorySpecificSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("costOptimizing", targetDepth))
                {
                    var unmarshaller = TrustedAdvisorCostOptimizingSummaryUnmarshaller.Instance;
                    unmarshalledObject.CostOptimizing = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TrustedAdvisorCategorySpecificSummaryUnmarshaller _instance = new TrustedAdvisorCategorySpecificSummaryUnmarshaller();        

        public static TrustedAdvisorCategorySpecificSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}