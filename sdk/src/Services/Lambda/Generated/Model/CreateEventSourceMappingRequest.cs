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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSourceMapping operation.
    /// Creates a mapping between an event source and an AWS Lambda function. Lambda reads
    /// items from the event source and triggers the function.
    /// 
    ///  
    /// <para>
    /// For details about each event source type, see the following topics.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html">Using AWS Lambda
    /// with Amazon DynamoDB</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html">Using AWS
    /// Lambda with Amazon Kinesis</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html">Using AWS Lambda
    /// with Amazon SQS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html">Using AWS Lambda
    /// with Amazon MQ</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html">Using AWS Lambda
    /// with Amazon MSK</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html">Using AWS
    /// Lambda with Self-Managed Apache Kafka</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following error handling options are only available for stream sources (DynamoDB
    /// and Kinesis):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BisectBatchOnFunctionError</code> - If the function returns an error, split
    /// the batch in two and retry.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DestinationConfig</code> - Send discarded records to an Amazon SQS queue or
    /// Amazon SNS topic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>MaximumRecordAgeInSeconds</code> - Discard records older than the specified
    /// age. The default value is infinite (-1). When set to infinite (-1), failed records
    /// are retried until the record expires
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>MaximumRetryAttempts</code> - Discard records after the specified number of
    /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
    /// are retried until the record expires.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ParallelizationFactor</code> - Process multiple batches from each shard concurrently.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateEventSourceMappingRequest : AmazonLambdaRequest
    {
        private int? _batchSize;
        private bool? _bisectBatchOnFunctionError;
        private DestinationConfig _destinationConfig;
        private bool? _enabled;
        private string _eventSourceArn;
        private string _functionName;
        private List<string> _functionResponseTypes = new List<string>();
        private int? _maximumBatchingWindowInSeconds;
        private int? _maximumRecordAgeInSeconds;
        private int? _maximumRetryAttempts;
        private int? _parallelizationFactor;
        private List<string> _queues = new List<string>();
        private SelfManagedEventSource _selfManagedEventSource;
        private List<SourceAccessConfiguration> _sourceAccessConfigurations = new List<SourceAccessConfiguration>();
        private EventSourcePosition _startingPosition;
        private DateTime? _startingPositionTimestamp;
        private List<string> _topics = new List<string>();
        private int? _tumblingWindowInSeconds;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of items to retrieve in a single batch.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Kinesis</b> - Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon DynamoDB Streams</b> - Default 100. Max 1,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Simple Queue Service</b> - Default 10. For standard queues the max is 10,000.
        /// For FIFO queues the max is 10.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Managed Streaming for Apache Kafka</b> - Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Self-Managed Apache Kafka</b> - Default 100. Max 10,000.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BisectBatchOnFunctionError. 
        /// <para>
        /// (Streams) If the function returns an error, split the batch in two and retry.
        /// </para>
        /// </summary>
        public bool BisectBatchOnFunctionError
        {
            get { return this._bisectBatchOnFunctionError.GetValueOrDefault(); }
            set { this._bisectBatchOnFunctionError = value; }
        }

        // Check to see if BisectBatchOnFunctionError property is set
        internal bool IsSetBisectBatchOnFunctionError()
        {
            return this._bisectBatchOnFunctionError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// (Streams) An Amazon SQS queue or Amazon SNS topic destination for discarded records.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig
        {
            get { return this._destinationConfig; }
            set { this._destinationConfig = value; }
        }

        // Check to see if DestinationConfig property is set
        internal bool IsSetDestinationConfig()
        {
            return this._destinationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If true, the event source mapping is active. Set to false to pause polling and invocation.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Kinesis</b> - The ARN of the data stream or a stream consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon DynamoDB Streams</b> - The ARN of the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Simple Queue Service</b> - The ARN of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Managed Streaming for Apache Kafka</b> - The ARN of the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <code>MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version or Alias ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction:PROD</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it's limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionResponseTypes. 
        /// <para>
        /// (Streams) A list of current response type enums applied to the event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> FunctionResponseTypes
        {
            get { return this._functionResponseTypes; }
            set { this._functionResponseTypes = value; }
        }

        // Check to see if FunctionResponseTypes property is set
        internal bool IsSetFunctionResponseTypes()
        {
            return this._functionResponseTypes != null && this._functionResponseTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// (Streams and SQS standard queues) The maximum amount of time to gather records before
        /// invoking the function, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds.GetValueOrDefault(); }
            set { this._maximumBatchingWindowInSeconds = value; }
        }

        // Check to see if MaximumBatchingWindowInSeconds property is set
        internal bool IsSetMaximumBatchingWindowInSeconds()
        {
            return this._maximumBatchingWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRecordAgeInSeconds. 
        /// <para>
        /// (Streams) Discard records older than the specified age. The default value is infinite
        /// (-1).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=604800)]
        public int MaximumRecordAgeInSeconds
        {
            get { return this._maximumRecordAgeInSeconds.GetValueOrDefault(); }
            set { this._maximumRecordAgeInSeconds = value; }
        }

        // Check to see if MaximumRecordAgeInSeconds property is set
        internal bool IsSetMaximumRecordAgeInSeconds()
        {
            return this._maximumRecordAgeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// (Streams) Discard records after the specified number of retries. The default value
        /// is infinite (-1). When set to infinite (-1), failed records will be retried until
        /// the record expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=10000)]
        public int MaximumRetryAttempts
        {
            get { return this._maximumRetryAttempts.GetValueOrDefault(); }
            set { this._maximumRetryAttempts = value; }
        }

        // Check to see if MaximumRetryAttempts property is set
        internal bool IsSetMaximumRetryAttempts()
        {
            return this._maximumRetryAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// (Streams) The number of batches to process from each shard concurrently.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int ParallelizationFactor
        {
            get { return this._parallelizationFactor.GetValueOrDefault(); }
            set { this._parallelizationFactor = value; }
        }

        // Check to see if ParallelizationFactor property is set
        internal bool IsSetParallelizationFactor()
        {
            return this._parallelizationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        ///  (MQ) The name of the Amazon MQ broker destination queue to consume. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelfManagedEventSource. 
        /// <para>
        /// The Self-Managed Apache Kafka cluster to send records.
        /// </para>
        /// </summary>
        public SelfManagedEventSource SelfManagedEventSource
        {
            get { return this._selfManagedEventSource; }
            set { this._selfManagedEventSource = value; }
        }

        // Check to see if SelfManagedEventSource property is set
        internal bool IsSetSelfManagedEventSource()
        {
            return this._selfManagedEventSource != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccessConfigurations. 
        /// <para>
        /// An array of the authentication protocol, or the VPC components to secure your event
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=22)]
        public List<SourceAccessConfiguration> SourceAccessConfigurations
        {
            get { return this._sourceAccessConfigurations; }
            set { this._sourceAccessConfigurations = value; }
        }

        // Check to see if SourceAccessConfigurations property is set
        internal bool IsSetSourceAccessConfigurations()
        {
            return this._sourceAccessConfigurations != null && this._sourceAccessConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading. Required for Amazon Kinesis,
        /// Amazon DynamoDB, and Amazon MSK Streams sources. <code>AT_TIMESTAMP</code> is only
        /// supported for Amazon Kinesis streams.
        /// </para>
        /// </summary>
        public EventSourcePosition StartingPosition
        {
            get { return this._startingPosition; }
            set { this._startingPosition = value; }
        }

        // Check to see if StartingPosition property is set
        internal bool IsSetStartingPosition()
        {
            return this._startingPosition != null;
        }

        /// <summary>
        /// Gets and sets the property StartingPositionTimestamp. 
        /// <para>
        /// With <code>StartingPosition</code> set to <code>AT_TIMESTAMP</code>, the time from
        /// which to start reading.
        /// </para>
        /// </summary>
        public DateTime StartingPositionTimestamp
        {
            get { return this._startingPositionTimestamp.GetValueOrDefault(); }
            set { this._startingPositionTimestamp = value; }
        }

        // Check to see if StartingPositionTimestamp property is set
        internal bool IsSetStartingPositionTimestamp()
        {
            return this._startingPositionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// The name of the Kafka topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Topics
        {
            get { return this._topics; }
            set { this._topics = value; }
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this._topics != null && this._topics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TumblingWindowInSeconds. 
        /// <para>
        /// (Streams) The duration of a processing window in seconds. The range is between 1 second
        /// up to 15 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=900)]
        public int TumblingWindowInSeconds
        {
            get { return this._tumblingWindowInSeconds.GetValueOrDefault(); }
            set { this._tumblingWindowInSeconds = value; }
        }

        // Check to see if TumblingWindowInSeconds property is set
        internal bool IsSetTumblingWindowInSeconds()
        {
            return this._tumblingWindowInSeconds.HasValue; 
        }

    }
}