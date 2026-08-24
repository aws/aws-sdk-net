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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Resiliencehubv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TestRun Object
    /// </summary>  
    public class TestRunUnmarshaller : IJsonUnmarshaller<TestRun, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TestRun Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TestRun unmarshalledObject = new TestRun();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountTargeting", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountTargeting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EventCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("experiments", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ExperimentDetails, ExperimentDetailsUnmarshaller>(ExperimentDetailsUnmarshaller.Instance);
                    unmarshalledObject.Experiments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("loggingConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = LoggingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LoggingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parameters", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<string>, StringUnmarshaller, JsonListUnmarshaller<string,StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("permissionModel", targetDepth, ref reader))
                {
                    var unmarshaller = PermissionModelUnmarshaller.Instance;
                    unmarshalledObject.PermissionModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("policy", targetDepth, ref reader))
                {
                    var unmarshaller = TestRunPolicySnapshotUnmarshaller.Instance;
                    unmarshalledObject.Policy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("regions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Regions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("regionSwitchExecutionId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionSwitchExecutionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("regionSwitchPlanArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionSwitchPlanArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reportConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = TestRunReportConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ReportConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reportOutput", targetDepth, ref reader))
                {
                    var unmarshaller = ReportGenerationResultUnmarshaller.Instance;
                    unmarshalledObject.ReportOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("roleName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stopConditions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<StopCondition, StopConditionUnmarshaller>(StopConditionUnmarshaller.Instance);
                    unmarshalledObject.StopConditions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("testId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TestId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("testRunId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TestRunId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("testTemplateArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TestTemplateArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TestRunUnmarshaller _instance = new TestRunUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestRunUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}