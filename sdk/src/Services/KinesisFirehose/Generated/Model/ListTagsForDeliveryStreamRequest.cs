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
    /// Container for the parameters to the ListTagsForDeliveryStream operation.
    /// Lists the tags for the specified delivery stream. This operation has a limit of five
    /// transactions per second per account.
    /// </summary>
    public partial class ListTagsForDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private string _exclusiveStartTagKey;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream whose tags you want to list.
        /// </para>
        /// </summary>
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusiveStartTagKey. 
        /// <para>
        /// The key to use as the starting point for the list of tags. If you set this parameter,
        /// <code>ListTagsForDeliveryStream</code> gets all tags that occur after <code>ExclusiveStartTagKey</code>.
        /// </para>
        /// </summary>
        public string ExclusiveStartTagKey
        {
            get { return this._exclusiveStartTagKey; }
            set { this._exclusiveStartTagKey = value; }
        }

        // Check to see if ExclusiveStartTagKey property is set
        internal bool IsSetExclusiveStartTagKey()
        {
            return this._exclusiveStartTagKey != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of tags to return. If this number is less than the total number of tags
        /// associated with the delivery stream, <code>HasMoreTags</code> is set to <code>true</code>
        /// in the response. To list additional tags, set <code>ExclusiveStartTagKey</code> to
        /// the last key in the response. 
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