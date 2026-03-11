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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Details of a primary (leader) channel in a linked pair
    /// </summary>
    public partial class DescribePrimaryChannelSettings
    {
        private List<string> _followingChannelArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LinkedChannelType _linkedChannelType;

        /// <summary>
        /// Gets and sets the property FollowingChannelArns. The ARNs of the following channels
        /// for this primary channel
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FollowingChannelArns
        {
            get { return this._followingChannelArns; }
            set { this._followingChannelArns = value; }
        }

        // Check to see if FollowingChannelArns property is set
        internal bool IsSetFollowingChannelArns()
        {
            return this._followingChannelArns != null && (this._followingChannelArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LinkedChannelType. Specifies this as a primary channel
        /// </summary>
        public LinkedChannelType LinkedChannelType
        {
            get { return this._linkedChannelType; }
            set { this._linkedChannelType = value; }
        }

        // Check to see if LinkedChannelType property is set
        internal bool IsSetLinkedChannelType()
        {
            return this._linkedChannelType != null;
        }

    }
}