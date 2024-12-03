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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FailureConditions Object
    /// </summary>  
    public class FailureConditionsUnmarshaller : IUnmarshaller<FailureConditions, XmlUnmarshallerContext>, IUnmarshaller<FailureConditions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FailureConditions IUnmarshaller<FailureConditions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FailureConditions Unmarshall(JsonUnmarshallerContext context)
        {
            FailureConditions unmarshalledObject = new FailureConditions();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("conditions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Condition, ConditionUnmarshaller>(ConditionUnmarshaller.Instance);
                    unmarshalledObject.Conditions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("result", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Result = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retryConfiguration", targetDepth))
                {
                    var unmarshaller = RetryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RetryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FailureConditionsUnmarshaller _instance = new FailureConditionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FailureConditionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}