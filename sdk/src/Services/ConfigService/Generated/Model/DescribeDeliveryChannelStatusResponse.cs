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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The output for the <a>DescribeDeliveryChannelStatus</a> action.
    /// </summary>
    public partial class DescribeDeliveryChannelStatusResponse : AmazonWebServiceResponse
    {
        private List<DeliveryChannelStatus> _deliveryChannelsStatus = AWSConfigs.InitializeCollections ? new List<DeliveryChannelStatus>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryChannelsStatus. 
        /// <para>
        /// A list that contains the status of a specified delivery channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeliveryChannelStatus> DeliveryChannelsStatus
        {
            get { return this._deliveryChannelsStatus; }
            set { this._deliveryChannelsStatus = value; }
        }

        // Check to see if DeliveryChannelsStatus property is set
        internal bool IsSetDeliveryChannelsStatus()
        {
            return this._deliveryChannelsStatus != null && (this._deliveryChannelsStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}