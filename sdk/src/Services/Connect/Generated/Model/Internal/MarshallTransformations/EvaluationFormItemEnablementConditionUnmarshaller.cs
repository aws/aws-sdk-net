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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationFormItemEnablementCondition Object
    /// </summary>  
    public class EvaluationFormItemEnablementConditionUnmarshaller : IUnmarshaller<EvaluationFormItemEnablementCondition, XmlUnmarshallerContext>, IUnmarshaller<EvaluationFormItemEnablementCondition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EvaluationFormItemEnablementCondition IUnmarshaller<EvaluationFormItemEnablementCondition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluationFormItemEnablementCondition Unmarshall(JsonUnmarshallerContext context)
        {
            EvaluationFormItemEnablementCondition unmarshalledObject = new EvaluationFormItemEnablementCondition();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Operands", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluationFormItemEnablementConditionOperand, EvaluationFormItemEnablementConditionOperandUnmarshaller>(EvaluationFormItemEnablementConditionOperandUnmarshaller.Instance);
                    unmarshalledObject.Operands = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Operator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operator = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationFormItemEnablementConditionUnmarshaller _instance = new EvaluationFormItemEnablementConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationFormItemEnablementConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}