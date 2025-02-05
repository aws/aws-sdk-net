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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetLocation Object
    /// </summary>  
    public class TargetLocationUnmarshaller : IJsonUnmarshaller<TargetLocation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TargetLocation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TargetLocation unmarshalledObject = new TargetLocation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Accounts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Accounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExcludeAccounts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludeAccounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExecutionRoleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IncludeChildOrganizationUnits", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeChildOrganizationUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Regions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Regions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetLocationAlarmConfiguration", targetDepth))
                {
                    var unmarshaller = AlarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TargetLocationAlarmConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetLocationMaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetLocationMaxConcurrency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetLocationMaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetLocationMaxErrors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetsMaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetsMaxConcurrency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetsMaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetsMaxErrors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TargetLocationUnmarshaller _instance = new TargetLocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetLocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}