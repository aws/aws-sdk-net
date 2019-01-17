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
    /// Creates a mapping between an event source and an AWS Lambda function. Lambda reads
    /// items from the event source and triggers the function.
    /// 
    ///  
    /// <para>
    /// For details about each event source type, see the following topics.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html">Using AWS
    /// Lambda with Amazon Kinesis</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html">Using AWS Lambda
    /// with Amazon SQS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html">Using AWS Lambda
    /// with Amazon DynamoDB</a> 
    /// </para>
    ///  </li> </ul>
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
        ///  <b>Amazon Simple Queue Service</b> - Default 10. Max 10.
        /// </para>
        ///  </li> </ul>
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
        /// Disables the event source mapping to pause polling and invocation.
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
        /// The position in a stream from which to start reading. Required for Amazon Kinesis
        /// and Amazon DynamoDB Streams sources. <code>AT_TIMESTAMP</code> is only supported for
        /// Amazon Kinesis streams.
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

    }
}