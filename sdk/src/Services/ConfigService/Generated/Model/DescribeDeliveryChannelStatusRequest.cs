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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
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
    /// Container for the parameters to the DescribeDeliveryChannelStatus operation.
    /// Returns the current status of the specified delivery channel. If a delivery channel
    /// is not specified, this action returns the current status of all delivery channels
    /// associated with the account. 
    /// 
    ///  <note>Currently, you can specify only one delivery channel per account.</note>
    /// </summary>
    public partial class DescribeDeliveryChannelStatusRequest : AmazonConfigServiceRequest
    {
        private List<string> _deliveryChannelNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DeliveryChannelNames. 
        /// <para>
        /// A list of delivery channel names.
        /// </para>
        /// </summary>
        public List<string> DeliveryChannelNames
        {
            get { return this._deliveryChannelNames; }
            set { this._deliveryChannelNames = value; }
        }

        // Check to see if DeliveryChannelNames property is set
        internal bool IsSetDeliveryChannelNames()
        {
            return this._deliveryChannelNames != null && this._deliveryChannelNames.Count > 0; 
        }

    }
}