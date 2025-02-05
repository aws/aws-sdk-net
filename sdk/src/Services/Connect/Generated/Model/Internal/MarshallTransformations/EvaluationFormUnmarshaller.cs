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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationForm Object
    /// </summary>  
    public class EvaluationFormUnmarshaller : IJsonUnmarshaller<EvaluationForm, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluationForm Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EvaluationForm unmarshalledObject = new EvaluationForm();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationFormArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationFormId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationFormVersion", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Items", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EvaluationFormItem, EvaluationFormItemUnmarshaller>(EvaluationFormItemUnmarshaller.Instance);
                    unmarshalledObject.Items = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Locked", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Locked = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScoringStrategy", targetDepth))
                {
                    var unmarshaller = EvaluationFormScoringStrategyUnmarshaller.Instance;
                    unmarshalledObject.ScoringStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationFormUnmarshaller _instance = new EvaluationFormUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationFormUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}