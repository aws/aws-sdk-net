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
    /// Summary of the membership details of an <c>AppInstanceUser</c>.
    /// </summary>
    public partial class AppInstanceUserMembershipSummary
    {
        private DateTime? _readMarkerTimestamp;
        private string _subChannelId;
        private ChannelMembershipType _type;

        /// <summary>
        /// Gets and sets the property ReadMarkerTimestamp. 
        /// <para>
        /// The time at which an <c>AppInstanceUser</c> last marked a channel as read.
        /// </para>
        /// </summary>
        public DateTime? ReadMarkerTimestamp
        {
            get { return this._readMarkerTimestamp; }
            set { this._readMarkerTimestamp = value; }
        }

        // Check to see if ReadMarkerTimestamp property is set
        internal bool IsSetReadMarkerTimestamp()
        {
            return this._readMarkerTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel that the <c>AppInstanceUser</c> is a member of.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of <c>ChannelMembership</c>.
        /// </para>
        /// </summary>
        public ChannelMembershipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}