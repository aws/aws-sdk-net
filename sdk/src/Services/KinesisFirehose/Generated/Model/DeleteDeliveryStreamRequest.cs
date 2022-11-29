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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDeliveryStream operation.
    /// Deletes a delivery stream and its data.
    /// 
    ///  
    /// <para>
    /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>. You can
    /// delete a delivery stream only if it is in one of the following states: <code>ACTIVE</code>,
    /// <code>DELETING</code>, <code>CREATING_FAILED</code>, or <code>DELETING_FAILED</code>.
    /// You can't delete a delivery stream that is in the <code>CREATING</code> state. While
    /// the deletion request is in process, the delivery stream is in the <code>DELETING</code>
    /// state.
    /// </para>
    ///  
    /// <para>
    /// While the delivery stream is in the <code>DELETING</code> state, the service might
    /// continue to accept records, but it doesn't make any guarantees with respect to delivering
    /// the data. Therefore, as a best practice, first stop any applications that are sending
    /// records before you delete a delivery stream.
    /// </para>
    /// </summary>
    public partial class DeleteDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private bool? _allowForceDelete;
        private string _deliveryStreamName;

        /// <summary>
        /// Gets and sets the property AllowForceDelete. 
        /// <para>
        /// Set this to true if you want to delete the delivery stream even if Kinesis Data Firehose
        /// is unable to retire the grant for the CMK. Kinesis Data Firehose might be unable to
        /// retire the grant due to a customer error, such as when the CMK or the grant are in
        /// an invalid state. If you force deletion, you can then use the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
        /// operation to revoke the grant you gave to Kinesis Data Firehose. If a failure to retire
        /// the grant happens due to an Amazon Web Services KMS issue, Kinesis Data Firehose keeps
        /// retrying the delete operation.
        /// </para>
        ///  
        /// <para>
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool AllowForceDelete
        {
            get { return this._allowForceDelete.GetValueOrDefault(); }
            set { this._allowForceDelete = value; }
        }

        // Check to see if AllowForceDelete property is set
        internal bool IsSetAllowForceDelete()
        {
            return this._allowForceDelete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}