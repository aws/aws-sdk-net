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
    /// Container for the parameters to the DeleteDeliveryStream operation.
    /// Deletes a delivery stream and its data.
    /// 
    ///  
    /// <para>
    /// You can delete a delivery stream only if it is in <code>ACTIVE</code> or <code>DELETING</code>
    /// state, and not in the <code>CREATING</code> state. While the deletion request is in
    /// process, the delivery stream is in the <code>DELETING</code> state.
    /// </para>
    ///  
    /// <para>
    /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// While the delivery stream is <code>DELETING</code> state, the service might continue
    /// to accept the records, but it doesn't make any guarantees with respect to delivering
    /// the data. Therefore, as a best practice, you should first stop any applications that
    /// are sending records before deleting a delivery stream.
    /// </para>
    /// </summary>
    public partial class DeleteDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
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

    }
}