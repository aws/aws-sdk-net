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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleGroup Object
    /// </summary>  
    public class RuleGroupUnmarshaller : IJsonUnmarshaller<RuleGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleGroup Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RuleGroup unmarshalledObject = new RuleGroup();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailableLabels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LabelSummary, LabelSummaryUnmarshaller>(LabelSummaryUnmarshaller.Instance);
                    unmarshalledObject.AvailableLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Capacity", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Capacity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConsumedLabels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LabelSummary, LabelSummaryUnmarshaller>(LabelSummaryUnmarshaller.Instance);
                    unmarshalledObject.ConsumedLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomResponseBodies", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, CustomResponseBody, StringUnmarshaller, CustomResponseBodyUnmarshaller>(StringUnmarshaller.Instance, CustomResponseBodyUnmarshaller.Instance);
                    unmarshalledObject.CustomResponseBodies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelNamespace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Rules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Rule, RuleUnmarshaller>(RuleUnmarshaller.Instance);
                    unmarshalledObject.Rules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VisibilityConfig", targetDepth))
                {
                    var unmarshaller = VisibilityConfigUnmarshaller.Instance;
                    unmarshalledObject.VisibilityConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuleGroupUnmarshaller _instance = new RuleGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}