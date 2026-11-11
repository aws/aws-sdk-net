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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes the actions associated with a rule.
    /// </summary>
    public partial class Action
    {
        /// <summary>
        /// Gets and sets the property CloudwatchAlarm. 
        /// <para>
        /// Change the state of a CloudWatch alarm.
        /// </para>
        /// </summary>
        public CloudwatchAlarmAction CloudwatchAlarm { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchAlarm property is set.
        /// </summary>
        internal bool IsSetCloudwatchAlarm() => this.CloudwatchAlarm != null;

        /// <summary>
        /// Gets and sets the property CloudwatchLogs. 
        /// <para>
        /// Send data to CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudwatchLogsAction CloudwatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudwatchLogs() => this.CloudwatchLogs != null;

        /// <summary>
        /// Gets and sets the property CloudwatchMetric. 
        /// <para>
        /// Capture a CloudWatch metric.
        /// </para>
        /// </summary>
        public CloudwatchMetricAction CloudwatchMetric { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchMetric property is set.
        /// </summary>
        internal bool IsSetCloudwatchMetric() => this.CloudwatchMetric != null;

        /// <summary>
        /// Gets and sets the property DynamoDB. 
        /// <para>
        /// Write to a DynamoDB table.
        /// </para>
        /// </summary>
        public DynamoDBAction DynamoDB { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDB property is set.
        /// </summary>
        internal bool IsSetDynamoDB() => this.DynamoDB != null;

        /// <summary>
        /// Gets and sets the property DynamoDBv2. 
        /// <para>
        /// Write to a DynamoDB table. This is a new version of the DynamoDB action. It allows
        /// you to write each attribute in an MQTT message payload into a separate DynamoDB column.
        /// </para>
        /// </summary>
        public DynamoDBv2Action DynamoDBv2 { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDBv2 property is set.
        /// </summary>
        internal bool IsSetDynamoDBv2() => this.DynamoDBv2 != null;

        /// <summary>
        /// Gets and sets the property Elasticsearch. 
        /// <para>
        /// Write data to an Amazon OpenSearch Service domain.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Elasticsearch</c> action can only be used by existing rule actions. To create
        /// a new rule action or to update an existing rule action, use the <c>OpenSearch</c>
        /// rule action instead. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_OpenSearchAction.html">OpenSearchAction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public ElasticsearchAction Elasticsearch { get; set; }

        /// <summary>
        /// Checks to see if the Elasticsearch property is set.
        /// </summary>
        internal bool IsSetElasticsearch() => this.Elasticsearch != null;

        /// <summary>
        /// Gets and sets the property Firehose. 
        /// <para>
        /// Write to an Amazon Kinesis Firehose stream.
        /// </para>
        /// </summary>
        public FirehoseAction Firehose { get; set; }

        /// <summary>
        /// Checks to see if the Firehose property is set.
        /// </summary>
        internal bool IsSetFirehose() => this.Firehose != null;

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// Send data to an HTTPS endpoint.
        /// </para>
        /// </summary>
        public HttpAction Http { get; set; }

        /// <summary>
        /// Checks to see if the Http property is set.
        /// </summary>
        internal bool IsSetHttp() => this.Http != null;

        /// <summary>
        /// Gets and sets the property InfluxDB. 
        /// <para>
        /// Write data to an InfluxDB database.
        /// </para>
        /// </summary>
        public InfluxDBAction InfluxDB { get; set; }

        /// <summary>
        /// Checks to see if the InfluxDB property is set.
        /// </summary>
        internal bool IsSetInfluxDB() => this.InfluxDB != null;

        /// <summary>
        /// Gets and sets the property IotAnalytics. 
        /// <para>
        /// Sends message data to an IoT Analytics channel.
        /// </para>
        /// </summary>
        public IotAnalyticsAction IotAnalytics { get; set; }

        /// <summary>
        /// Checks to see if the IotAnalytics property is set.
        /// </summary>
        internal bool IsSetIotAnalytics() => this.IotAnalytics != null;

        /// <summary>
        /// Gets and sets the property IotEvents. 
        /// <para>
        /// Sends an input to an IoT Events detector.
        /// </para>
        /// </summary>
        public IotEventsAction IotEvents { get; set; }

        /// <summary>
        /// Checks to see if the IotEvents property is set.
        /// </summary>
        internal bool IsSetIotEvents() => this.IotEvents != null;

        /// <summary>
        /// Gets and sets the property IotSiteWise. 
        /// <para>
        /// Sends data from the MQTT message that triggered the rule to IoT SiteWise asset properties.
        /// </para>
        /// </summary>
        public IotSiteWiseAction IotSiteWise { get; set; }

        /// <summary>
        /// Checks to see if the IotSiteWise property is set.
        /// </summary>
        internal bool IsSetIotSiteWise() => this.IotSiteWise != null;

        /// <summary>
        /// Gets and sets the property Kafka. 
        /// <para>
        /// Send messages to an Amazon Managed Streaming for Apache Kafka (Amazon MSK) or self-managed
        /// Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaAction Kafka { get; set; }

        /// <summary>
        /// Checks to see if the Kafka property is set.
        /// </summary>
        internal bool IsSetKafka() => this.Kafka != null;

        /// <summary>
        /// Gets and sets the property Kinesis. 
        /// <para>
        /// Write data to an Amazon Kinesis stream.
        /// </para>
        /// </summary>
        public KinesisAction Kinesis { get; set; }

        /// <summary>
        /// Checks to see if the Kinesis property is set.
        /// </summary>
        internal bool IsSetKinesis() => this.Kinesis != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Invoke a Lambda function.
        /// </para>
        /// </summary>
        public LambdaAction Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Location Service rule action sends device location updates from an MQTT
        /// message to an Amazon Location tracker resource.
        /// </para>
        /// </summary>
        public LocationAction Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property OpenSearch. 
        /// <para>
        /// Write data to an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public OpenSearchAction OpenSearch { get; set; }

        /// <summary>
        /// Checks to see if the OpenSearch property is set.
        /// </summary>
        internal bool IsSetOpenSearch() => this.OpenSearch != null;

        /// <summary>
        /// Gets and sets the property Republish. 
        /// <para>
        /// Publish to another MQTT topic.
        /// </para>
        /// </summary>
        public RepublishAction Republish { get; set; }

        /// <summary>
        /// Checks to see if the Republish property is set.
        /// </summary>
        internal bool IsSetRepublish() => this.Republish != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Write to an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Action S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        /// Send a message to a Salesforce IoT Cloud Input Stream.
        /// </para>
        /// </summary>
        public SalesforceAction Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// Publish to an Amazon SNS topic.
        /// </para>
        /// </summary>
        public SnsAction Sns { get; set; }

        /// <summary>
        /// Checks to see if the Sns property is set.
        /// </summary>
        internal bool IsSetSns() => this.Sns != null;

        /// <summary>
        /// Gets and sets the property Sqs. 
        /// <para>
        /// Publish to an Amazon SQS queue.
        /// </para>
        /// </summary>
        public SqsAction Sqs { get; set; }

        /// <summary>
        /// Checks to see if the Sqs property is set.
        /// </summary>
        internal bool IsSetSqs() => this.Sqs != null;

        /// <summary>
        /// Gets and sets the property StepFunctions. 
        /// <para>
        /// Starts execution of a Step Functions state machine.
        /// </para>
        /// </summary>
        public StepFunctionsAction StepFunctions { get; set; }

        /// <summary>
        /// Checks to see if the StepFunctions property is set.
        /// </summary>
        internal bool IsSetStepFunctions() => this.StepFunctions != null;

        /// <summary>
        /// Gets and sets the property Timestream. 
        /// <para>
        /// The Timestream rule action writes attributes (measures) from an MQTT message into
        /// an Amazon Timestream table. For more information, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/timestream-rule-action.html">Timestream</a>
        /// topic rule action documentation.
        /// </para>
        /// </summary>
        public TimestreamAction Timestream { get; set; }

        /// <summary>
        /// Checks to see if the Timestream property is set.
        /// </summary>
        internal bool IsSetTimestream() => this.Timestream != null;
    }
}
