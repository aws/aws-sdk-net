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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WellArchitected.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnswerSummary Object
    /// </summary>
    public partial class AnswerSummaryUnmarshaller : IJsonUnmarshaller<AnswerSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AnswerSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AnswerSummary();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ChoiceAnswerSummaries", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ChoiceAnswerSummary, ChoiceAnswerSummaryUnmarshaller>(ChoiceAnswerSummaryUnmarshaller.Instance);
                    unmarshalledObject.ChoiceAnswerSummaries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Choices", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Choice, ChoiceUnmarshaller>(ChoiceUnmarshaller.Instance);
                    unmarshalledObject.Choices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("IsApplicable", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsApplicable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("JiraConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = JiraConfigurationUnmarshaller.Instance;
                    unmarshalledObject.JiraConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PillarId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PillarId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("QuestionId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("QuestionTitle", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionTitle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("QuestionType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Reason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Risk", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Risk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SelectedChoices", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SelectedChoices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AnswerSummaryUnmarshaller _instance = new AnswerSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AnswerSummaryUnmarshaller Instance => _instance;
    }
}
