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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComplianceDrift Object
    /// </summary>  
    public class ComplianceDriftUnmarshaller : IJsonUnmarshaller<ComplianceDrift, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ComplianceDrift Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ComplianceDrift unmarshalledObject = new ComplianceDrift();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actualReferenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActualReferenceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("actualValue", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, DisruptionCompliance, StringUnmarshaller, DisruptionComplianceUnmarshaller>(StringUnmarshaller.Instance, DisruptionComplianceUnmarshaller.Instance);
                    unmarshalledObject.ActualValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("appId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("appVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("diffType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DiffType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("driftType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DriftType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("entityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("entityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expectedReferenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedReferenceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expectedValue", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, DisruptionCompliance, StringUnmarshaller, DisruptionComplianceUnmarshaller>(StringUnmarshaller.Instance, DisruptionComplianceUnmarshaller.Instance);
                    unmarshalledObject.ExpectedValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComplianceDriftUnmarshaller _instance = new ComplianceDriftUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComplianceDriftUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}