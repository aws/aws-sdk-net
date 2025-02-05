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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudwatchAlarm())
            {
                context.Writer.WritePropertyName("cloudwatchAlarm");
                context.Writer.WriteStartObject();

                var marshaller = CloudwatchAlarmActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchAlarm, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudwatchLogs())
            {
                context.Writer.WritePropertyName("cloudwatchLogs");
                context.Writer.WriteStartObject();

                var marshaller = CloudwatchLogsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudwatchMetric())
            {
                context.Writer.WritePropertyName("cloudwatchMetric");
                context.Writer.WriteStartObject();

                var marshaller = CloudwatchMetricActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudwatchMetric, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDB())
            {
                context.Writer.WritePropertyName("dynamoDB");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDBv2())
            {
                context.Writer.WritePropertyName("dynamoDBv2");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBv2ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBv2, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetElasticsearch())
            {
                context.Writer.WritePropertyName("elasticsearch");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Elasticsearch, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirehose())
            {
                context.Writer.WritePropertyName("firehose");
                context.Writer.WriteStartObject();

                var marshaller = FirehoseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Firehose, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHttp())
            {
                context.Writer.WritePropertyName("http");
                context.Writer.WriteStartObject();

                var marshaller = HttpActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Http, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotAnalytics())
            {
                context.Writer.WritePropertyName("iotAnalytics");
                context.Writer.WriteStartObject();

                var marshaller = IotAnalyticsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotAnalytics, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotEvents())
            {
                context.Writer.WritePropertyName("iotEvents");
                context.Writer.WriteStartObject();

                var marshaller = IotEventsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotEvents, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotSiteWise())
            {
                context.Writer.WritePropertyName("iotSiteWise");
                context.Writer.WriteStartObject();

                var marshaller = IotSiteWiseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotSiteWise, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKafka())
            {
                context.Writer.WritePropertyName("kafka");
                context.Writer.WriteStartObject();

                var marshaller = KafkaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Kafka, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesis())
            {
                context.Writer.WritePropertyName("kinesis");
                context.Writer.WriteStartObject();

                var marshaller = KinesisActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Kinesis, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteStartObject();

                var marshaller = LambdaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteStartObject();

                var marshaller = LocationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Location, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOpenSearch())
            {
                context.Writer.WritePropertyName("openSearch");
                context.Writer.WriteStartObject();

                var marshaller = OpenSearchActionMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenSearch, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRepublish())
            {
                context.Writer.WritePropertyName("republish");
                context.Writer.WriteStartObject();

                var marshaller = RepublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Republish, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("s3");
                context.Writer.WriteStartObject();

                var marshaller = S3ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.S3, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("salesforce");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Salesforce, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSns())
            {
                context.Writer.WritePropertyName("sns");
                context.Writer.WriteStartObject();

                var marshaller = SnsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sns, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqs())
            {
                context.Writer.WritePropertyName("sqs");
                context.Writer.WriteStartObject();

                var marshaller = SqsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sqs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStepFunctions())
            {
                context.Writer.WritePropertyName("stepFunctions");
                context.Writer.WriteStartObject();

                var marshaller = StepFunctionsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.StepFunctions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestream())
            {
                context.Writer.WritePropertyName("timestream");
                context.Writer.WriteStartObject();

                var marshaller = TimestreamActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Timestream, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActionMarshaller Instance = new ActionMarshaller();

    }
}