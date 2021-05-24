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
    /// Response Unmarshaller for TargetInstance Object
    /// </summary>  
    public class TargetInstanceUnmarshaller : IUnmarshaller<TargetInstance, XmlUnmarshallerContext>, IUnmarshaller<TargetInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TargetInstance IUnmarshaller<TargetInstance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TargetInstance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TargetInstance unmarshalledObject = new TargetInstance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultTargetInstance", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DefaultTargetInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlyCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlyCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavings", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedResourceUtilization", targetDepth))
                {
                    var unmarshaller = ResourceUtilizationUnmarshaller.Instance;
                    unmarshalledObject.ExpectedResourceUtilization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlatformDifferences", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PlatformDifferences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceDetails", targetDepth))
                {
                    var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ResourceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TargetInstanceUnmarshaller _instance = new TargetInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}