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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeliveryStreams operation.
    /// Lists your delivery streams.
    /// 
    ///  
    /// <para>
    /// The number of delivery streams might be too large to return using a single call to
    /// <a>ListDeliveryStreams</a>. You can limit the number of delivery streams returned,
    /// using the <code>Limit</code> parameter. To determine whether there are more delivery
    /// streams to list, check the value of <code>HasMoreDeliveryStreams</code> in the output.
    /// If there are more delivery streams to list, you can request them by specifying the
    /// name of the last delivery stream returned in the call in the <code>ExclusiveStartDeliveryStreamName</code>
    /// parameter of a subsequent call.
    /// </para>
    /// </summary>
    public partial class ListDeliveryStreamsRequest : AmazonKinesisFirehoseRequest
    {
        private string _exclusiveStartDeliveryStreamName;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property ExclusiveStartDeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream to start the list with.
        /// </para>
        /// </summary>
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
        /// The maximum number of delivery streams to list.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}