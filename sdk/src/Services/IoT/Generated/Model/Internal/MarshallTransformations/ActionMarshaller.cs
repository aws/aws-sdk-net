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
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Action Marshaller
    /// </summary>       
    public class ActionMarshaller : IRequestMarshaller<Action, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Action requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCloudwatchAlarm())
            {
                context.Writer.WritePropertyName("cloudwatchAlarm");
                context.Writer.WriteObjectStart();

                var marshaller = CloudwatchAlarmActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchAlarm, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCloudwatchLogs())
            {
                context.Writer.WritePropertyName("cloudwatchLogs");
                context.Writer.WriteObjectStart();

                var marshaller = CloudwatchLogsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchLogs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCloudwatchMetric())
            {
                context.Writer.WritePropertyName("cloudwatchMetric");
                context.Writer.WriteObjectStart();

                var marshaller = CloudwatchMetricActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchMetric, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamoDB())
            {
                context.Writer.WritePropertyName("dynamoDB");
                context.Writer.WriteObjectStart();

                var marshaller = DynamoDBActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamoDBv2())
            {
                context.Writer.WritePropertyName("dynamoDBv2");
                context.Writer.WriteObjectStart();

                var marshaller = DynamoDBv2ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBv2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetElasticsearch())
            {
                context.Writer.WritePropertyName("elasticsearch");
                context.Writer.WriteObjectStart();

                var marshaller = ElasticsearchActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Elasticsearch, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFirehose())
            {
                context.Writer.WritePropertyName("firehose");
                context.Writer.WriteObjectStart();

                var marshaller = FirehoseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Firehose, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttp())
            {
                context.Writer.WritePropertyName("http");
                context.Writer.WriteObjectStart();

                var marshaller = HttpActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Http, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotAnalytics())
            {
                context.Writer.WritePropertyName("iotAnalytics");
                context.Writer.WriteObjectStart();

                var marshaller = IotAnalyticsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotAnalytics, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotEvents())
            {
                context.Writer.WritePropertyName("iotEvents");
                context.Writer.WriteObjectStart();

                var marshaller = IotEventsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotEvents, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotSiteWise())
            {
                context.Writer.WritePropertyName("iotSiteWise");
                context.Writer.WriteObjectStart();

                var marshaller = IotSiteWiseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotSiteWise, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKafka())
            {
                context.Writer.WritePropertyName("kafka");
                context.Writer.WriteObjectStart();

                var marshaller = KafkaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Kafka, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesis())
            {
                context.Writer.WritePropertyName("kinesis");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Kinesis, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRepublish())
            {
                context.Writer.WritePropertyName("republish");
                context.Writer.WriteObjectStart();

                var marshaller = RepublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Republish, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("s3");
                context.Writer.WriteObjectStart();

                var marshaller = S3ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.S3, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("salesforce");
                context.Writer.WriteObjectStart();

                var marshaller = SalesforceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Salesforce, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSns())
            {
                context.Writer.WritePropertyName("sns");
                context.Writer.WriteObjectStart();

                var marshaller = SnsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sns, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqs())
            {
                context.Writer.WritePropertyName("sqs");
                context.Writer.WriteObjectStart();

                var marshaller = SqsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sqs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStepFunctions())
            {
                context.Writer.WritePropertyName("stepFunctions");
                context.Writer.WriteObjectStart();

                var marshaller = StepFunctionsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.StepFunctions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimestream())
            {
                context.Writer.WritePropertyName("timestream");
                context.Writer.WriteObjectStart();

                var marshaller = TimestreamActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Timestream, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ActionMarshaller Instance = new ActionMarshaller();

    }
}