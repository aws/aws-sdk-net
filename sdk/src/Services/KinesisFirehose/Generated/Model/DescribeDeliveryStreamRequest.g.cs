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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeDeliveryStream operation. Describes the
    /// specified Firehose stream and its status. For example, after your Firehose stream
    /// is created, call <c>DescribeDeliveryStream</c> to see whether the Firehose stream
    /// is <c>ACTIVE</c> and therefore ready for data to be sent to it. <para> If the status
    /// of a Firehose stream is <c>CREATING_FAILED</c>, this status doesn't change, and you
    /// can't invoke <a>CreateDeliveryStream</a> again on it. However, you can invoke the
    /// <a>DeleteDeliveryStream</a> operation to delete it. If the status is <c>DELETING_FAILED</c>,
    /// you can force deletion by invoking <a>DeleteDeliveryStream</a> again but with <a>DeleteDeliveryStreamInput$AllowForceDelete</a>
    /// set to true. </para>
    /// </summary>
    public partial class DescribeDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DeliveryStreamName { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamName property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamName() => this.DeliveryStreamName != null;

        /// <summary>
        /// Gets and sets the property ExclusiveStartDestinationId. 
        /// <para>
        /// The ID of the destination to start returning the destination information. Firehose
        /// supports one destination per Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ExclusiveStartDestinationId { get; set; }

        /// <summary>
        /// Checks to see if the ExclusiveStartDestinationId property is set.
        /// </summary>
        internal bool IsSetExclusiveStartDestinationId() => this.ExclusiveStartDestinationId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The limit on the number of destinations to return. You can have one destination per
        /// Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;
    }
}
