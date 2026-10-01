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
    /// The details of a channel member.
    /// </summary>
    public partial class ChannelMembership
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the member's channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the channel membership was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

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
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which a channel membership was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The data of the channel member.
        /// </para>
        /// </summary>
        public Identity Member { get; set; }

        /// <summary>
        /// Checks to see if the Member property is set.
        /// </summary>
        internal bool IsSetMember() => this.Member != null;

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel that a user belongs to.
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
        /// The membership type set for the channel member.
        /// </para>
        /// </summary>
        public ChannelMembershipType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
