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
    /// Response Unmarshaller for ReviewTemplateAnswer Object
    /// </summary>  
    public class ReviewTemplateAnswerUnmarshaller : IUnmarshaller<ReviewTemplateAnswer, XmlUnmarshallerContext>, IUnmarshaller<ReviewTemplateAnswer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReviewTemplateAnswer IUnmarshaller<ReviewTemplateAnswer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReviewTemplateAnswer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReviewTemplateAnswer unmarshalledObject = new ReviewTemplateAnswer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnswerStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnswerStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChoiceAnswers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChoiceAnswer, ChoiceAnswerUnmarshaller>(ChoiceAnswerUnmarshaller.Instance);
                    unmarshalledObject.ChoiceAnswers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Choices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Choice, ChoiceUnmarshaller>(ChoiceUnmarshaller.Instance);
                    unmarshalledObject.Choices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HelpfulResourceDisplayText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HelpfulResourceDisplayText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HelpfulResourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HelpfulResourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImprovementPlanUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImprovementPlanUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsApplicable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsApplicable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Notes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Notes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PillarId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PillarId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionDescription = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("Reason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
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


        private static ReviewTemplateAnswerUnmarshaller _instance = new ReviewTemplateAnswerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReviewTemplateAnswerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}