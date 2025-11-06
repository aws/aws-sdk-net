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
    /// Response Unmarshaller for Evaluation Object
    /// </summary>  
    public class EvaluationUnmarshaller : IUnmarshaller<Evaluation, XmlUnmarshallerContext>, IUnmarshaller<Evaluation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Evaluation IUnmarshaller<Evaluation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Evaluation Unmarshall(JsonUnmarshallerContext context)
        {
            Evaluation unmarshalledObject = new Evaluation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Answers", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, EvaluationAnswerOutput, StringUnmarshaller, EvaluationAnswerOutputUnmarshaller>(StringUnmarshaller.Instance, EvaluationAnswerOutputUnmarshaller.Instance);
                    unmarshalledObject.Answers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metadata", targetDepth))
                {
                    var unmarshaller = EvaluationMetadataUnmarshaller.Instance;
                    unmarshalledObject.Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Notes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, EvaluationNote, StringUnmarshaller, EvaluationNoteUnmarshaller>(StringUnmarshaller.Instance, EvaluationNoteUnmarshaller.Instance);
                    unmarshalledObject.Notes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Scores", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, EvaluationScore, StringUnmarshaller, EvaluationScoreUnmarshaller>(StringUnmarshaller.Instance, EvaluationScoreUnmarshaller.Instance);
                    unmarshalledObject.Scores = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationUnmarshaller _instance = new EvaluationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}