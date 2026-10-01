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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The membership information, including member ARNs, the channel ARN, and membership
    /// types.
    /// </summary>
    public partial class BatchChannelMemberships
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel to which you're adding members.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property InvitedBy. 
        /// <para>
        /// The identifier of the member who invited another member.
        /// </para>
        /// </summary>
        public Identity InvitedBy { get; set; }

        /// <summary>
        /// Checks to see if the InvitedBy property is set.
        /// </summary>
        internal bool IsSetInvitedBy() => this.InvitedBy != null;

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The users successfully added to the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Identity> Members { get; set; } = AWSConfigs.InitializeCollections ? new List<Identity>() : null;

        /// <summary>
        /// Checks to see if the Members property is set.
        /// </summary>
        internal bool IsSetMembers() => this.Members != null && (this.Members.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SubChannelId { get; set; }

        /// <summary>
        /// Checks to see if the SubChannelId property is set.
        /// </summary>
        internal bool IsSetSubChannelId() => this.SubChannelId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The membership types set for the channel members.
        /// </para>
        /// </summary>
        public ChannelMembershipType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
