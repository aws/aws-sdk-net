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
    /// The output for the <a>DescribeDeliveryChannels</a> action.
    /// </summary>
    public partial class DescribeDeliveryChannelsResponse : AmazonWebServiceResponse
    {
        private List<DeliveryChannel> _deliveryChannels = AWSConfigs.InitializeCollections ? new List<DeliveryChannel>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryChannels. 
        /// <para>
        /// A list that contains the descriptions of the specified delivery channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeliveryChannel> DeliveryChannels
        {
            get { return this._deliveryChannels; }
            set { this._deliveryChannels = value; }
        }

        // Check to see if DeliveryChannels property is set
        internal bool IsSetDeliveryChannels()
        {
            return this._deliveryChannels != null && (this._deliveryChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}