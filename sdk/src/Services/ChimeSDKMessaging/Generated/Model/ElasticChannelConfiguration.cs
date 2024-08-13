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
    /// The attributes required to configure and create an elastic channel. An elastic channel
    /// can support a maximum of 1-million members.
    /// </summary>
    public partial class ElasticChannelConfiguration
    {
        private int? _maximumSubChannels;
        private int? _minimumMembershipPercentage;
        private int? _targetMembershipsPerSubChannel;

        /// <summary>
        /// Gets and sets the property MaximumSubChannels. 
        /// <para>
        /// The maximum number of SubChannels that you want to allow in the elastic channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2)]
        public int? MaximumSubChannels
        {
            get { return this._maximumSubChannels; }
            set { this._maximumSubChannels = value; }
        }

        // Check to see if MaximumSubChannels property is set
        internal bool IsSetMaximumSubChannels()
        {
            return this._maximumSubChannels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumMembershipPercentage. 
        /// <para>
        /// The minimum allowed percentage of TargetMembershipsPerSubChannel users. Ceil of the
        /// calculated value is used in balancing members among SubChannels of the elastic channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public int? MinimumMembershipPercentage
        {
            get { return this._minimumMembershipPercentage; }
            set { this._minimumMembershipPercentage = value; }
        }

        // Check to see if MinimumMembershipPercentage property is set
        internal bool IsSetMinimumMembershipPercentage()
        {
            return this._minimumMembershipPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetMembershipsPerSubChannel. 
        /// <para>
        /// The maximum number of members allowed in a SubChannel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2)]
        public int? TargetMembershipsPerSubChannel
        {
            get { return this._targetMembershipsPerSubChannel; }
            set { this._targetMembershipsPerSubChannel = value; }
        }

        // Check to see if TargetMembershipsPerSubChannel property is set
        internal bool IsSetTargetMembershipsPerSubChannel()
        {
            return this._targetMembershipsPerSubChannel.HasValue; 
        }

    }
}