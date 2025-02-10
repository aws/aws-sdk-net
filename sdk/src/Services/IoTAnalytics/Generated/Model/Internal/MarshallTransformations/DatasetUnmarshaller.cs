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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Dataset Object
    /// </summary>  
    public class DatasetUnmarshaller : IJsonUnmarshaller<Dataset, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Dataset Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Dataset unmarshalledObject = new Dataset();
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
                    var unmarshaller = new JsonListUnmarshaller<DatasetAction, DatasetActionUnmarshaller>(DatasetActionUnmarshaller.Instance);
                    unmarshalledObject.Actions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("contentDeliveryRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DatasetContentDeliveryRule, DatasetContentDeliveryRuleUnmarshaller>(DatasetContentDeliveryRuleUnmarshaller.Instance);
                    unmarshalledObject.ContentDeliveryRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastUpdateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lateDataRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LateDataRule, LateDataRuleUnmarshaller>(LateDataRuleUnmarshaller.Instance);
                    unmarshalledObject.LateDataRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("retentionPeriod", targetDepth))
                {
                    var unmarshaller = RetentionPeriodUnmarshaller.Instance;
                    unmarshalledObject.RetentionPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("triggers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DatasetTrigger, DatasetTriggerUnmarshaller>(DatasetTriggerUnmarshaller.Instance);
                    unmarshalledObject.Triggers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("versioningConfiguration", targetDepth))
                {
                    var unmarshaller = VersioningConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VersioningConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DatasetUnmarshaller _instance = new DatasetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatasetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}