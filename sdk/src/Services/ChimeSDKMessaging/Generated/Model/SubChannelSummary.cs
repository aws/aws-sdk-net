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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
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
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Summary of the sub-channels associated with the elastic channel.
    /// </summary>
    public partial class SubChannelSummary
    {
        private int? _membershipCount;
        private string _subChannelId;

        /// <summary>
        /// Gets and sets the property MembershipCount. 
        /// <para>
        /// The number of members in a SubChannel.
        /// </para>
        /// </summary>
        public int? MembershipCount
        {
            get { return this._membershipCount; }
            set { this._membershipCount = value; }
        }

        // Check to see if MembershipCount property is set
        internal bool IsSetMembershipCount()
        {
            return this._membershipCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The unique ID of a SubChannel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SubChannelId
        {
            get { return this._subChannelId; }
            set { this._subChannelId = value; }
        }

        // Check to see if SubChannelId property is set
        internal bool IsSetSubChannelId()
        {
            return this._subChannelId != null;
        }

    }
}