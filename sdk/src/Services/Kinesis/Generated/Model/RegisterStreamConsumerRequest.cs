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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterStreamConsumer operation.
    /// Registers a consumer with a Kinesis data stream. When you use this operation, the
    /// consumer you register can read data from the stream at a rate of up to 2 MiB per second.
    /// This rate is unaffected by the total number of consumers that read from the same stream.
    /// 
    ///  
    /// <para>
    /// You can register up to 5 consumers per stream. A given consumer can only be registered
    /// with one stream.
    /// </para>
    ///  
    /// <para>
    /// This operation has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class RegisterStreamConsumerRequest : AmazonKinesisRequest
    {
        private string _consumerName;
        private string _streamARN;

        /// <summary>
        /// Gets and sets the property ConsumerName. 
        /// <para>
        /// For a given Kinesis data stream, each consumer must have a unique name. However, consumer
        /// names don't have to be unique across data streams.
        /// </para>
        /// </summary>
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
        /// Resource Names (ARNs) and AWS Service Namespaces</a>.
        /// </para>
        /// </summary>
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