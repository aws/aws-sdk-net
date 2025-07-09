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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A destination for events that failed processing. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations">Adding
    /// a destination</a>.
    /// </summary>
    public partial class OnFailure
    {
        private string _destination;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination resource.
        /// </para>
        ///  
        /// <para>
        /// To retain records of unsuccessful <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations">asynchronous
        /// invocations</a>, you can configure an Amazon SNS topic, Amazon SQS queue, Amazon S3
        /// bucket, Lambda function, or Amazon EventBridge event bus as the destination.
        /// </para>
        ///  
        /// <para>
        /// To retain records of failed invocations from <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html">Kinesis</a>,
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html">DynamoDB</a>,
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-smaa-onfailure-destination">self-managed
        /// Kafka</a> or <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-onfailure-destination">Amazon
        /// MSK</a>, you can configure an Amazon SNS topic, Amazon SQS queue, or Amazon S3 bucket
        /// as the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

    }
}