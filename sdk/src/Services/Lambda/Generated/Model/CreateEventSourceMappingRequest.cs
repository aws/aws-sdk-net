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
    /// Identifies a stream as an event source for a Lambda function. It can be either an
    /// Amazon Kinesis stream or an Amazon DynamoDB stream. AWS Lambda invokes the specified
    /// function when records are posted to the stream.
    /// 
    ///  
    /// <para>
    /// This association between a stream source and a Lambda function is called the event
    /// source mapping.
    /// </para>
    ///  
    /// <para>
    /// You provide mapping information (for example, which stream to read from and which
    /// Lambda function to invoke) in the request body.
    /// </para>
    ///  
    /// <para>
    /// Each event source, such as an Amazon Kinesis or a DynamoDB stream, can be associated
    /// with multiple AWS Lambda functions. A given Lambda function can be associated with
    /// multiple AWS event sources.
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
        /// retrieved records. The default is 100 records.
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
        /// Indicates whether AWS Lambda should begin polling the event source. By default, <code>Enabled</code>
        /// is true. 
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
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis or the Amazon DynamoDB stream
        /// that is the event source. Any record added to this stream could cause AWS Lambda to
        /// invoke your Lambda function, it depends on the <code>BatchSize</code>. AWS Lambda
        /// POSTs the Amazon Kinesis event, containing records, to your Lambda function as JSON.
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
        /// The Lambda function to invoke when AWS Lambda detects an event on the stream.
        /// </para>
        ///  
        /// <para>
        ///  You can specify the function name (for example, <code>Thumbnail</code>) or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>).
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If you are using versioning, you can also provide a qualified function ARN (ARN that
        /// is qualified with function version or alias name as suffix). For more information
        /// about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a> 
        /// </para>
        ///  
        /// <para>
        /// AWS Lambda also allows you to specify only the function name with the account ID qualifier
        /// (for example, <code>account-id:Thumbnail</code>). 
        /// </para>
        ///  
        /// <para>
        /// Note that the length constraint applies only to the ARN. If you specify only the function
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