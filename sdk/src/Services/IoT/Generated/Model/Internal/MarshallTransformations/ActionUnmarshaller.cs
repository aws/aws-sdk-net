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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Action Object
    /// </summary>  
    public class ActionUnmarshaller : IJsonUnmarshaller<Action, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Action Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Action unmarshalledObject = new Action();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cloudwatchAlarm", targetDepth))
                {
                    var unmarshaller = CloudwatchAlarmActionUnmarshaller.Instance;
                    unmarshalledObject.CloudwatchAlarm = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudwatchLogs", targetDepth))
                {
                    var unmarshaller = CloudwatchLogsActionUnmarshaller.Instance;
                    unmarshalledObject.CloudwatchLogs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudwatchMetric", targetDepth))
                {
                    var unmarshaller = CloudwatchMetricActionUnmarshaller.Instance;
                    unmarshalledObject.CloudwatchMetric = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynamoDB", targetDepth))
                {
                    var unmarshaller = DynamoDBActionUnmarshaller.Instance;
                    unmarshalledObject.DynamoDB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynamoDBv2", targetDepth))
                {
                    var unmarshaller = DynamoDBv2ActionUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBv2 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("elasticsearch", targetDepth))
                {
                    var unmarshaller = ElasticsearchActionUnmarshaller.Instance;
                    unmarshalledObject.Elasticsearch = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("firehose", targetDepth))
                {
                    var unmarshaller = FirehoseActionUnmarshaller.Instance;
                    unmarshalledObject.Firehose = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("http", targetDepth))
                {
                    var unmarshaller = HttpActionUnmarshaller.Instance;
                    unmarshalledObject.Http = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iotAnalytics", targetDepth))
                {
                    var unmarshaller = IotAnalyticsActionUnmarshaller.Instance;
                    unmarshalledObject.IotAnalytics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iotEvents", targetDepth))
                {
                    var unmarshaller = IotEventsActionUnmarshaller.Instance;
                    unmarshalledObject.IotEvents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iotSiteWise", targetDepth))
                {
                    var unmarshaller = IotSiteWiseActionUnmarshaller.Instance;
                    unmarshalledObject.IotSiteWise = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kafka", targetDepth))
                {
                    var unmarshaller = KafkaActionUnmarshaller.Instance;
                    unmarshalledObject.Kafka = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kinesis", targetDepth))
                {
                    var unmarshaller = KinesisActionUnmarshaller.Instance;
                    unmarshalledObject.Kinesis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambda", targetDepth))
                {
                    var unmarshaller = LambdaActionUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = LocationActionUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("openSearch", targetDepth))
                {
                    var unmarshaller = OpenSearchActionUnmarshaller.Instance;
                    unmarshalledObject.OpenSearch = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("republish", targetDepth))
                {
                    var unmarshaller = RepublishActionUnmarshaller.Instance;
                    unmarshalledObject.Republish = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3", targetDepth))
                {
                    var unmarshaller = S3ActionUnmarshaller.Instance;
                    unmarshalledObject.S3 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("salesforce", targetDepth))
                {
                    var unmarshaller = SalesforceActionUnmarshaller.Instance;
                    unmarshalledObject.Salesforce = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sns", targetDepth))
                {
                    var unmarshaller = SnsActionUnmarshaller.Instance;
                    unmarshalledObject.Sns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sqs", targetDepth))
                {
                    var unmarshaller = SqsActionUnmarshaller.Instance;
                    unmarshalledObject.Sqs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stepFunctions", targetDepth))
                {
                    var unmarshaller = StepFunctionsActionUnmarshaller.Instance;
                    unmarshalledObject.StepFunctions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timestream", targetDepth))
                {
                    var unmarshaller = TimestreamActionUnmarshaller.Instance;
                    unmarshalledObject.Timestream = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ActionUnmarshaller _instance = new ActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}