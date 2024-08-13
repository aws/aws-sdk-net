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
    /// An object that represents the details of a registered consumer. This type of object
    /// is returned by <a>DescribeStreamConsumer</a>.
    /// </summary>
    public partial class ConsumerDescription
    {
        private string _consumerARN;
        private DateTime? _consumerCreationTimestamp;
        private string _consumerName;
        private ConsumerStatus _consumerStatus;
        private string _streamARN;

        /// <summary>
        /// Gets and sets the property ConsumerARN. 
        /// <para>
        /// When you register a consumer, Kinesis Data Streams generates an ARN for it. You need
        /// this ARN to be able to call <a>SubscribeToShard</a>.
        /// </para>
        ///  
        /// <para>
        /// If you delete a consumer and then create a new one with the same name, it won't have
        /// the same ARN. That's because consumer ARNs contain the creation timestamp. This is
        /// important to keep in mind if you have IAM policies that reference consumer ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property ConsumerCreationTimestamp.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ConsumerCreationTimestamp
        {
            get { return this._consumerCreationTimestamp; }
            set { this._consumerCreationTimestamp = value; }
        }

        // Check to see if ConsumerCreationTimestamp property is set
        internal bool IsSetConsumerCreationTimestamp()
        {
            return this._consumerCreationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumerName. 
        /// <para>
        /// The name of the consumer is something you choose when you register the consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ConsumerStatus. 
        /// <para>
        /// A consumer can't read data while in the <c>CREATING</c> or <c>DELETING</c> states.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConsumerStatus ConsumerStatus
        {
            get { return this._consumerStatus; }
            set { this._consumerStatus = value; }
        }

        // Check to see if ConsumerStatus property is set
        internal bool IsSetConsumerStatus()
        {
            return this._consumerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream with which you registered the consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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