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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStreamConsumer operation.
    /// To get the description of a registered consumer, provide the ARN of the consumer.
    /// Alternatively, you can provide the ARN of the data stream and the name you gave the
    /// consumer when you registered it. You may also provide all three parameters, as long
    /// as they don't conflict with each other. If you don't know the name or ARN of the consumer
    /// that you want to describe, you can use the <a>ListStreamConsumers</a> operation to
    /// get a list of the descriptions of all the consumers that are currently registered
    /// with a given data stream.
    /// 
    ///  
    /// <para>
    /// This operation has a limit of 20 transactions per second per stream.
    /// </para>
    ///  <note> 
    /// <para>
    /// When making a cross-account call with <c>DescribeStreamConsumer</c>, make sure to
    /// provide the ARN of the consumer. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeStreamConsumerRequest : AmazonKinesisRequest
    {
        private string _consumerARN;
        private string _consumerName;
        private string _streamARN;

        /// <summary>
        /// Gets and sets the property ConsumerARN. 
        /// <para>
        /// The ARN returned by Kinesis Data Streams when you registered the consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ConsumerARN
        {
            get { return this._consumerARN; }
            set { this._consumerARN = value; }
        }

        // Check to see if ConsumerARN property is set
        internal bool IsSetConsumerARN()
        {
            return this._consumerARN != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumerName. 
        /// <para>
        /// The name that you gave to the consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConsumerName
        {
            get { return this._consumerName; }
            set { this._consumerName = value; }
        }

        // Check to see if ConsumerName property is set
        internal bool IsSetConsumerName()
        {
            return this._consumerName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the Kinesis data stream that the consumer is registered with. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

    }
}