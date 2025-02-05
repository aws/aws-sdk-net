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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Experiment Object
    /// </summary>  
    public class ExperimentUnmarshaller : IJsonUnmarshaller<Experiment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Experiment Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Experiment unmarshalledObject = new Experiment();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ExperimentAction, StringUnmarshaller, ExperimentActionUnmarshaller>(StringUnmarshaller.Instance, ExperimentActionUnmarshaller.Instance);
                    unmarshalledObject.Actions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("experimentOptions", targetDepth))
                {
                    var unmarshaller = ExperimentOptionsUnmarshaller.Instance;
                    unmarshalledObject.ExperimentOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("experimentReport", targetDepth))
                {
                    var unmarshaller = ExperimentReportUnmarshaller.Instance;
                    unmarshalledObject.ExperimentReport = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("experimentReportConfiguration", targetDepth))
                {
                    var unmarshaller = ExperimentReportConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ExperimentReportConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("experimentTemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExperimentTemplateId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logConfiguration", targetDepth))
                {
                    var unmarshaller = ExperimentLogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = ExperimentStateUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stopConditions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ExperimentStopCondition, ExperimentStopConditionUnmarshaller>(ExperimentStopConditionUnmarshaller.Instance);
                    unmarshalledObject.StopConditions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetAccountConfigurationsCount", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TargetAccountConfigurationsCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targets", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ExperimentTarget, StringUnmarshaller, ExperimentTargetUnmarshaller>(StringUnmarshaller.Instance, ExperimentTargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExperimentUnmarshaller _instance = new ExperimentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExperimentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}