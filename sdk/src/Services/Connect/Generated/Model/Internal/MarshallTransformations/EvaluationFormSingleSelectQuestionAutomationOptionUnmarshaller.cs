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

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationFormSingleSelectQuestionAutomationOption Object
    /// </summary>  
    public class EvaluationFormSingleSelectQuestionAutomationOptionUnmarshaller : IUnmarshaller<EvaluationFormSingleSelectQuestionAutomationOption, XmlUnmarshallerContext>, IUnmarshaller<EvaluationFormSingleSelectQuestionAutomationOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EvaluationFormSingleSelectQuestionAutomationOption IUnmarshaller<EvaluationFormSingleSelectQuestionAutomationOption, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EvaluationFormSingleSelectQuestionAutomationOption Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EvaluationFormSingleSelectQuestionAutomationOption unmarshalledObject = new EvaluationFormSingleSelectQuestionAutomationOption();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RuleCategory", targetDepth))
                {
                    var unmarshaller = SingleSelectQuestionRuleCategoryAutomationUnmarshaller.Instance;
                    unmarshalledObject.RuleCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EvaluationFormSingleSelectQuestionAutomationOptionUnmarshaller _instance = new EvaluationFormSingleSelectQuestionAutomationOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationFormSingleSelectQuestionAutomationOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}