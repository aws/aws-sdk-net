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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnswerSummary Object
    /// </summary>  
    public class AnswerSummaryUnmarshaller : IUnmarshaller<AnswerSummary, XmlUnmarshallerContext>, IUnmarshaller<AnswerSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AnswerSummary IUnmarshaller<AnswerSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnswerSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AnswerSummary unmarshalledObject = new AnswerSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChoiceAnswerSummaries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChoiceAnswerSummary, ChoiceAnswerSummaryUnmarshaller>(ChoiceAnswerSummaryUnmarshaller.Instance);
                    unmarshalledObject.ChoiceAnswerSummaries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Choices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Choice, ChoiceUnmarshaller>(ChoiceUnmarshaller.Instance);
                    unmarshalledObject.Choices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsApplicable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsApplicable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PillarId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PillarId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionTitle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Reason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Risk", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Risk = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectedChoices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SelectedChoices = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AnswerSummaryUnmarshaller _instance = new AnswerSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnswerSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}