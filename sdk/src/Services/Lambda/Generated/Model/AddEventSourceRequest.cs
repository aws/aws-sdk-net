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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
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
    /// Container for the parameters to the AddEventSource operation.
    /// Identifies a stream as an event source for an AWS Lambda function. It can be either
    /// an Amazon Kinesis stream or a Amazon DynamoDB stream. AWS Lambda invokes the specified
    /// function when records are posted to the stream.
    /// 
    ///  
    /// <para>
    /// This is the pull model, where AWS Lambda invokes the function. For more information,
    /// go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the AWS Lambda Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This association between an Amazon Kinesis stream and an AWS Lambda function is called
    /// the event source mapping. You provide the configuration information (for example,
    /// which stream to read from and which AWS Lambda function to invoke) for the event source
    /// mapping in the request body.
    /// </para>
    ///  
    /// <para>
    ///  Each event source, such as a Kinesis stream, can only be associated with one AWS
    /// Lambda function. If you call <a>AddEventSource</a> for an event source that is already
    /// mapped to another AWS Lambda function, the existing mapping is updated to call the
    /// new function instead of the old one. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>iam:PassRole</code> action for the
    /// IAM role. It also requires permission for the <code>lambda:AddEventSource</code> action.
    /// </para>
    /// </summary>
    public partial class AddEventSourceRequest : AmazonLambdaRequest
    {
        private int? _batchSize;
        private string _eventSource;
        private string _functionName;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _role;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The largest number of records that AWS Lambda will give to your function in a single
        /// event. The default is 100 records.
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
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis stream that is the event source.
        /// Any record added to this stream causes AWS Lambda to invoke your Lambda function.
        /// AWS Lambda POSTs the Amazon Kinesis event, containing records, to your Lambda function
        /// as JSON.
        /// </para>
        /// </summary>
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function to invoke when AWS Lambda detects an event on the stream.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A map (key-value pairs) defining the configuration for AWS Lambda to use when reading
        /// the event source. Currently, AWS Lambda supports only the <code>InitialPositionInStream</code>
        /// key. The valid values are: "TRIM_HORIZON" and "LATEST". The default value is "TRIM_HORIZON".
        /// For more information, go to <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetShardIterator.html#Kinesis-GetShardIterator-request-ShardIteratorType">ShardIteratorType</a>
        /// in the Amazon Kinesis Service API Reference. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the IAM role (invocation role) that AWS Lambda can assume to read from
        /// the stream and invoke the function.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}