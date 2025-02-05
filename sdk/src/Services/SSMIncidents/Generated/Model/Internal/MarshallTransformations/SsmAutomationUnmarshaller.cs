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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SsmAutomation Object
    /// </summary>  
    public class SsmAutomationUnmarshaller : IJsonUnmarshaller<SsmAutomation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SsmAutomation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SsmAutomation unmarshalledObject = new SsmAutomation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("documentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("documentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynamicParameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, DynamicSsmParameterValue, StringUnmarshaller, DynamicSsmParameterValueUnmarshaller>(StringUnmarshaller.Instance, DynamicSsmParameterValueUnmarshaller.Instance);
                    unmarshalledObject.DynamicParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<string>, StringUnmarshaller, JsonListUnmarshaller<string,StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SsmAutomationUnmarshaller _instance = new SsmAutomationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SsmAutomationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}