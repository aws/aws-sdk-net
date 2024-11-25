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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeliveryStreams operation.
    /// Lists your Firehose streams in alphabetical order of their names.
    /// 
    ///  
    /// <para>
    /// The number of Firehose streams might be too large to return using a single call to
    /// <c>ListDeliveryStreams</c>. You can limit the number of Firehose streams returned,
    /// using the <c>Limit</c> parameter. To determine whether there are more delivery streams
    /// to list, check the value of <c>HasMoreDeliveryStreams</c> in the output. If there
    /// are more Firehose streams to list, you can request them by calling this operation
    /// again and setting the <c>ExclusiveStartDeliveryStreamName</c> parameter to the name
    /// of the last Firehose stream returned in the last call.
    /// </para>
    /// </summary>
    public partial class ListDeliveryStreamsRequest : AmazonKinesisFirehoseRequest
    {
        private DeliveryStreamType _deliveryStreamType;
        private string _exclusiveStartDeliveryStreamName;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property DeliveryStreamType. 
        /// <para>
        /// The Firehose stream type. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DirectPut</c>: Provider applications access the Firehose stream directly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KinesisStreamAsSource</c>: The Firehose stream uses a Kinesis data stream as a
        /// source.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is optional. If this parameter is omitted, Firehose streams of all
        /// types are returned.
        /// </para>
        /// </summary>
        public DeliveryStreamType DeliveryStreamType
        {
            get { return this._deliveryStreamType; }
            set { this._deliveryStreamType = value; }
        }

        // Check to see if DeliveryStreamType property is set
        internal bool IsSetDeliveryStreamType()
        {
            return this._deliveryStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusiveStartDeliveryStreamName. 
        /// <para>
        /// The list of Firehose streams returned by this call to <c>ListDeliveryStreams</c> will
        /// start with the Firehose stream whose name comes alphabetically immediately after the
        /// name you specify in <c>ExclusiveStartDeliveryStreamName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ExclusiveStartDeliveryStreamName
        {
            get { return this._exclusiveStartDeliveryStreamName; }
            set { this._exclusiveStartDeliveryStreamName = value; }
        }

        // Check to see if ExclusiveStartDeliveryStreamName property is set
        internal bool IsSetExclusiveStartDeliveryStreamName()
        {
            return this._exclusiveStartDeliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of Firehose streams to list. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}