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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes the actions associated with a rule.
    /// </summary>
    public partial class Action
    {
        private DynamoDBAction _dynamodb;
        private FirehoseAction _firehose;
        private KinesisAction _kinesis;
        private LambdaAction _lambda;
        private RepublishAction _republish;
        private S3Action _s3;
        private SnsAction _sns;
        private SqsAction _sqs;

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
        /// Gets and sets the property Firehose. 
        /// <para>
        /// Write to a Kinesis Firehose stream.
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
        /// Gets and sets the property Kinesis. 
        /// <para>
        /// Write data to a Kinesis stream.
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
        /// Write to an S3 bucket.
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
        /// Gets and sets the property Sns. 
        /// <para>
        /// Publish to an SNS topic.
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
        /// Publish to an SQS queue.
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

    }
}