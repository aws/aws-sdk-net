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
        private CloudwatchAlarmAction _cloudwatchAlarm;
        private CloudwatchLogsAction _cloudwatchLogs;
        private CloudwatchMetricAction _cloudwatchMetric;
        private DynamoDBAction _dynamodb;
        private DynamoDBv2Action _dynamodBv2;
        private ElasticsearchAction _elasticsearch;
        private FirehoseAction _firehose;
        private HttpAction _http;
        private IotAnalyticsAction _iotAnalytics;
        private IotEventsAction _iotEvents;
        private IotSiteWiseAction _iotSiteWise;
        private KafkaAction _kafka;
        private KinesisAction _kinesis;
        private LambdaAction _lambda;
        private LocationAction _location;
        private OpenSearchAction _openSearch;
        private RepublishAction _republish;
        private S3Action _s3;
        private SalesforceAction _salesforce;
        private SnsAction _sns;
        private SqsAction _sqs;
        private StepFunctionsAction _stepFunctions;
        private TimestreamAction _timestream;

        /// <summary>
        /// Gets and sets the property CloudwatchAlarm. 
        /// <para>
        /// Change the state of a CloudWatch alarm.
        /// </para>
        /// </summary>
        public CloudwatchAlarmAction CloudwatchAlarm
        {
            get { return this._cloudwatchAlarm; }
            set { this._cloudwatchAlarm = value; }
        }

        // Check to see if CloudwatchAlarm property is set
        internal bool IsSetCloudwatchAlarm()
        {
            return this._cloudwatchAlarm != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchLogs. 
        /// <para>
        /// Send data to CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudwatchLogsAction CloudwatchLogs
        {
            get { return this._cloudwatchLogs; }
            set { this._cloudwatchLogs = value; }
        }

        // Check to see if CloudwatchLogs property is set
        internal bool IsSetCloudwatchLogs()
        {
            return this._cloudwatchLogs != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchMetric. 
        /// <para>
        /// Capture a CloudWatch metric.
        /// </para>
        /// </summary>
        public CloudwatchMetricAction CloudwatchMetric
        {
            get { return this._cloudwatchMetric; }
            set { this._cloudwatchMetric = value; }
        }

        // Check to see if CloudwatchMetric property is set
        internal bool IsSetCloudwatchMetric()
        {
            return this._cloudwatchMetric != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDB. 
        /// <para>
        /// Write to a DynamoDB table.
        /// </para>
        /// </summary>
        public DynamoDBAction DynamoDB
        {
            get { return this._dynamodb; }
            set { this._dynamodb = value; }
        }

        // Check to see if DynamoDB property is set
        internal bool IsSetDynamoDB()
        {
            return this._dynamodb != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDBv2. 
        /// <para>
        /// Write to a DynamoDB table. This is a new version of the DynamoDB action. It allows
        /// you to write each attribute in an MQTT message payload into a separate DynamoDB column.
        /// </para>
        /// </summary>
        public DynamoDBv2Action DynamoDBv2
        {
            get { return this._dynamodBv2; }
            set { this._dynamodBv2 = value; }
        }

        // Check to see if DynamoDBv2 property is set
        internal bool IsSetDynamoDBv2()
        {
            return this._dynamodBv2 != null;
        }

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
        public ElasticsearchAction Elasticsearch
        {
            get { return this._elasticsearch; }
            set { this._elasticsearch = value; }
        }

        // Check to see if Elasticsearch property is set
        internal bool IsSetElasticsearch()
        {
            return this._elasticsearch != null;
        }

        /// <summary>
        /// Gets and sets the property Firehose. 
        /// <para>
        /// Write to an Amazon Kinesis Firehose stream.
        /// </para>
        /// </summary>
        public FirehoseAction Firehose
        {
            get { return this._firehose; }
            set { this._firehose = value; }
        }

        // Check to see if Firehose property is set
        internal bool IsSetFirehose()
        {
            return this._firehose != null;
        }

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// Send data to an HTTPS endpoint.
        /// </para>
        /// </summary>
        public HttpAction Http
        {
            get { return this._http; }
            set { this._http = value; }
        }

        // Check to see if Http property is set
        internal bool IsSetHttp()
        {
            return this._http != null;
        }

        /// <summary>
        /// Gets and sets the property IotAnalytics. 
        /// <para>
        /// Sends message data to an IoT Analytics channel.
        /// </para>
        /// </summary>
        public IotAnalyticsAction IotAnalytics
        {
            get { return this._iotAnalytics; }
            set { this._iotAnalytics = value; }
        }

        // Check to see if IotAnalytics property is set
        internal bool IsSetIotAnalytics()
        {
            return this._iotAnalytics != null;
        }

        /// <summary>
        /// Gets and sets the property IotEvents. 
        /// <para>
        /// Sends an input to an IoT Events detector.
        /// </para>
        /// </summary>
        public IotEventsAction IotEvents
        {
            get { return this._iotEvents; }
            set { this._iotEvents = value; }
        }

        // Check to see if IotEvents property is set
        internal bool IsSetIotEvents()
        {
            return this._iotEvents != null;
        }

        /// <summary>
        /// Gets and sets the property IotSiteWise. 
        /// <para>
        /// Sends data from the MQTT message that triggered the rule to IoT SiteWise asset properties.
        /// </para>
        /// </summary>
        public IotSiteWiseAction IotSiteWise
        {
            get { return this._iotSiteWise; }
            set { this._iotSiteWise = value; }
        }

        // Check to see if IotSiteWise property is set
        internal bool IsSetIotSiteWise()
        {
            return this._iotSiteWise != null;
        }

        /// <summary>
        /// Gets and sets the property Kafka. 
        /// <para>
        /// Send messages to an Amazon Managed Streaming for Apache Kafka (Amazon MSK) or self-managed
        /// Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaAction Kafka
        {
            get { return this._kafka; }
            set { this._kafka = value; }
        }

        // Check to see if Kafka property is set
        internal bool IsSetKafka()
        {
            return this._kafka != null;
        }

        /// <summary>
        /// Gets and sets the property Kinesis. 
        /// <para>
        /// Write data to an Amazon Kinesis stream.
        /// </para>
        /// </summary>
        public KinesisAction Kinesis
        {
            get { return this._kinesis; }
            set { this._kinesis = value; }
        }

        // Check to see if Kinesis property is set
        internal bool IsSetKinesis()
        {
            return this._kinesis != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Invoke a Lambda function.
        /// </para>
        /// </summary>
        public LambdaAction Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Location Service rule action sends device location updates from an MQTT
        /// message to an Amazon Location tracker resource.
        /// </para>
        /// </summary>
        public LocationAction Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OpenSearch. 
        /// <para>
        /// Write data to an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public OpenSearchAction OpenSearch
        {
            get { return this._openSearch; }
            set { this._openSearch = value; }
        }

        // Check to see if OpenSearch property is set
        internal bool IsSetOpenSearch()
        {
            return this._openSearch != null;
        }

        /// <summary>
        /// Gets and sets the property Republish. 
        /// <para>
        /// Publish to another MQTT topic.
        /// </para>
        /// </summary>
        public RepublishAction Republish
        {
            get { return this._republish; }
            set { this._republish = value; }
        }

        // Check to see if Republish property is set
        internal bool IsSetRepublish()
        {
            return this._republish != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Write to an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Action S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        /// Send a message to a Salesforce IoT Cloud Input Stream.
        /// </para>
        /// </summary>
        public SalesforceAction Salesforce
        {
            get { return this._salesforce; }
            set { this._salesforce = value; }
        }

        // Check to see if Salesforce property is set
        internal bool IsSetSalesforce()
        {
            return this._salesforce != null;
        }

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// Publish to an Amazon SNS topic.
        /// </para>
        /// </summary>
        public SnsAction Sns
        {
            get { return this._sns; }
            set { this._sns = value; }
        }

        // Check to see if Sns property is set
        internal bool IsSetSns()
        {
            return this._sns != null;
        }

        /// <summary>
        /// Gets and sets the property Sqs. 
        /// <para>
        /// Publish to an Amazon SQS queue.
        /// </para>
        /// </summary>
        public SqsAction Sqs
        {
            get { return this._sqs; }
            set { this._sqs = value; }
        }

        // Check to see if Sqs property is set
        internal bool IsSetSqs()
        {
            return this._sqs != null;
        }

        /// <summary>
        /// Gets and sets the property StepFunctions. 
        /// <para>
        /// Starts execution of a Step Functions state machine.
        /// </para>
        /// </summary>
        public StepFunctionsAction StepFunctions
        {
            get { return this._stepFunctions; }
            set { this._stepFunctions = value; }
        }

        // Check to see if StepFunctions property is set
        internal bool IsSetStepFunctions()
        {
            return this._stepFunctions != null;
        }

        /// <summary>
        /// Gets and sets the property Timestream. 
        /// <para>
        /// The Timestream rule action writes attributes (measures) from an MQTT message into
        /// an Amazon Timestream table. For more information, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/timestream-rule-action.html">Timestream</a>
        /// topic rule action documentation.
        /// </para>
        /// </summary>
        public TimestreamAction Timestream
        {
            get { return this._timestream; }
            set { this._timestream = value; }
        }

        // Check to see if Timestream property is set
        internal bool IsSetTimestream()
        {
            return this._timestream != null;
        }

    }
}