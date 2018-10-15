/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSourceMapping operation.
    /// Identifies a poll-based event source for a Lambda function. It can be either an Amazon
    /// Kinesis or DynamoDB stream. AWS Lambda invokes the specified function when records
    /// are posted to the event source.
    /// 
    ///  
    /// <para>
    /// This association between a poll-based source and a Lambda function is called the event
    /// source mapping.
    /// </para>
    ///  
    /// <para>
    /// You provide mapping information (for example, which stream or SQS queue to read from
    /// and which Lambda function to invoke) in the request body.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kinesis or DynamoDB stream event sources can be associated with multiple AWS
    /// Lambda functions and a given Lambda function can be associated with multiple AWS event
    /// sources. For Amazon SQS, you can configure multiple queues as event sources for a
    /// single Lambda function, but an SQS queue can be mapped only to a single Lambda function.
    /// </para>
    ///  
    /// <para>
    /// You can configure an SQS queue in an account separate from your Lambda function's
    /// account. Also the queue needs to reside in the same AWS region as your function. 
    /// </para>
    ///  
    /// <para>
    /// If you are using versioning, you can specify a specific function version or an alias
    /// via the function name parameter. For more information about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:CreateEventSourceMapping</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateEventSourceMappingRequest : AmazonLambdaRequest
    {
        private int? _batchSize;
        private bool? _enabled;
        private string _eventSourceArn;
        private string _functionName;
        private EventSourcePosition _startingPosition;
        private DateTime? _startingPositionTimestamp;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The largest number of records that AWS Lambda will retrieve from your event source
        /// at the time of invoking your function. Your function receives an event with all the
        /// retrieved records. The default for Amazon Kinesis and Amazon DynamoDB is 100 records.
        /// Both the default and maximum for Amazon SQS are 10 messages.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Set to false to disable the event source upon creation. 
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
        /// The name of the lambda function.
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
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in the DynamoDB or Kinesis stream where AWS Lambda should start reading.
        /// For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetShardIterator.html#Kinesis-GetShardIterator-request-ShardIteratorType">GetShardIterator</a>
        /// in the <i>Amazon Kinesis API Reference Guide</i> or <a href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_streams_GetShardIterator.html">GetShardIterator</a>
        /// in the <i>Amazon DynamoDB API Reference Guide</i>. The <code>AT_TIMESTAMP</code> value
        /// is supported only for <a href="http://docs.aws.amazon.com/streams/latest/dev/amazon-kinesis-streams.html">Kinesis
        /// streams</a>. 
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
        /// The timestamp of the data record from which to start reading. Used with <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetShardIterator.html#Kinesis-GetShardIterator-request-ShardIteratorType">shard
        /// iterator type</a> AT_TIMESTAMP. If a record with this exact timestamp does not exist,
        /// the iterator returned is for the next (later) record. If the timestamp is older than
        /// the current trim horizon, the iterator returned is for the oldest untrimmed data record
        /// (TRIM_HORIZON). Valid only for <a href="http://docs.aws.amazon.com/streams/latest/dev/amazon-kinesis-streams.html">Kinesis
        /// streams</a>. 
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

    }
}