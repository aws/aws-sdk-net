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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConditionalSplitActivity Object
    /// </summary>  
    public class ConditionalSplitActivityUnmarshaller : IUnmarshaller<ConditionalSplitActivity, XmlUnmarshallerContext>, IUnmarshaller<ConditionalSplitActivity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConditionalSplitActivity IUnmarshaller<ConditionalSplitActivity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConditionalSplitActivity Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConditionalSplitActivity unmarshalledObject = new ConditionalSplitActivity();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Condition", targetDepth))
                {
                    var unmarshaller = ConditionUnmarshaller.Instance;
                    unmarshalledObject.Condition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationWaitTime", targetDepth))
                {
                    var unmarshaller = WaitTimeUnmarshaller.Instance;
                    unmarshalledObject.EvaluationWaitTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FalseActivity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FalseActivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrueActivity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrueActivity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConditionalSplitActivityUnmarshaller _instance = new ConditionalSplitActivityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConditionalSplitActivityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}