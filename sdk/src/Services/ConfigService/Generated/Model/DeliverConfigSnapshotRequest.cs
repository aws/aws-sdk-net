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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeliverConfigSnapshot operation.
    /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
    /// delivery channel. After the delivery has started, AWS Config sends the following notifications
    /// using an Amazon SNS topic that you have specified.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Notification of the start of the delivery.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Notification of the completion of the delivery, if the delivery was successfully completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Notification of delivery failure, if the delivery failed.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeliverConfigSnapshotRequest : AmazonConfigServiceRequest
    {
        private string _deliveryChannelName;

        /// <summary>
        /// Gets and sets the property DeliveryChannelName. 
        /// <para>
        /// The name of the delivery channel through which the snapshot is delivered.
        /// </para>
        /// </summary>
        public string DeliveryChannelName
        {
            get { return this._deliveryChannelName; }
            set { this._deliveryChannelName = value; }
        }

        // Check to see if DeliveryChannelName property is set
        internal bool IsSetDeliveryChannelName()
        {
            return this._deliveryChannelName != null;
        }

    }
}