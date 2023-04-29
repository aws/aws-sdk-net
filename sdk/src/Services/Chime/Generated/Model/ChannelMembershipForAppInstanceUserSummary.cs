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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Summary of the channel membership details of an <code>AppInstanceUser</code>.
    /// </summary>
    public partial class ChannelMembershipForAppInstanceUserSummary
    {
        private AppInstanceUserMembershipSummary _appInstanceUserMembershipSummary;
        private ChannelSummary _channelSummary;

        /// <summary>
        /// Gets and sets the property AppInstanceUserMembershipSummary. 
        /// <para>
        /// Summary of the membership details of an <code>AppInstanceUser</code>.
        /// </para>
        /// </summary>
        public AppInstanceUserMembershipSummary AppInstanceUserMembershipSummary
        {
            get { return this._appInstanceUserMembershipSummary; }
            set { this._appInstanceUserMembershipSummary = value; }
        }

        // Check to see if AppInstanceUserMembershipSummary property is set
        internal bool IsSetAppInstanceUserMembershipSummary()
        {
            return this._appInstanceUserMembershipSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelSummary. 
        /// <para>
        /// Summary of the details of a <code>Channel</code>.
        /// </para>
        /// </summary>
        public ChannelSummary ChannelSummary
        {
            get { return this._channelSummary; }
            set { this._channelSummary = value; }
        }

        // Check to see if ChannelSummary property is set
        internal bool IsSetChannelSummary()
        {
            return this._channelSummary != null;
        }

    }
}