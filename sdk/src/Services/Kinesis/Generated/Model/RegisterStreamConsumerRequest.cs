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
    /// Container for the parameters to the RegisterStreamConsumer operation.
    /// Registers a consumer with a Kinesis data stream. When you use this operation, the
    /// consumer you register can then call <a>SubscribeToShard</a> to receive data from the
    /// stream using enhanced fan-out, at a rate of up to 2 MiB per second for every shard
    /// you subscribe to. This rate is unaffected by the total number of consumers that read
    /// from the same stream.
    /// 
    ///  
    /// <para>
    /// You can add tags to the registered consumer when making a <c>RegisterStreamConsumer</c>
    /// request by setting the <c>Tags</c> parameter. If you pass the <c>Tags</c> parameter,
    /// in addition to having the <c>kinesis:RegisterStreamConsumer</c> permission, you must
    /// also have the <c>kinesis:TagResource</c> permission for the consumer that will be
    /// registered. Tags will take effect from the <c>CREATING</c> status of the consumer.
    /// </para>
    ///  
    /// <para>
    /// You can register up to 20 consumers per stream. A given consumer can only be registered
    /// with one stream at a time.
    /// </para>
    ///  
    /// <para>
    /// For an example of how to use this operation, see <a href="https://docs.aws.amazon.com/streams/latest/dev/building-enhanced-consumers-api.html">Enhanced
    /// Fan-Out Using the Kinesis Data Streams API</a>.
    /// </para>
    ///  
    /// <para>
    /// The use of this operation has a limit of five transactions per second per account.
    /// Also, only 5 consumers can be created simultaneously. In other words, you cannot have
    /// more than 5 consumers in a <c>CREATING</c> status at the same time. Registering a
    /// 6th consumer while there are 5 in a <c>CREATING</c> status results in a <c>LimitExceededException</c>.
    /// </para>
    /// </summary>
    public partial class RegisterStreamConsumerRequest : AmazonKinesisRequest
    {
        private string _consumerName;
        private string _streamARN;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConsumerName. 
        /// <para>
        /// For a given Kinesis data stream, each consumer must have a unique name. However, consumer
        /// names don't have to be unique across data streams.
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
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the Kinesis data stream that you want to register the consumer with. For
        /// more info, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of up to 50 key-value pairs. A tag consists of a required key and an optional
        /// value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}