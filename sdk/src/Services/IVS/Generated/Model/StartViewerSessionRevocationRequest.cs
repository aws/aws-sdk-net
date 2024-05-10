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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the StartViewerSessionRevocation operation.
    /// Starts the process of revoking the viewer session associated with a specified channel
    /// ARN and viewer ID. Optionally, you can provide a version to revoke viewer sessions
    /// less than and including that version. For instructions on associating a viewer ID
    /// with a viewer session, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
    /// Up Private Channels</a>.
    /// </summary>
    public partial class StartViewerSessionRevocationRequest : AmazonIVSRequest
    {
        private string _channelArn;
        private string _viewerId;
        private int? _viewerSessionVersionsLessThanOrEqualTo;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel associated with the viewer session to revoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerId. 
        /// <para>
        /// The ID of the viewer associated with the viewer session to revoke. Do not use this
        /// field for personally identifying, confidential, or sensitive information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ViewerId
        {
            get { return this._viewerId; }
            set { this._viewerId = value; }
        }

        // Check to see if ViewerId property is set
        internal bool IsSetViewerId()
        {
            return this._viewerId != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerSessionVersionsLessThanOrEqualTo. 
        /// <para>
        /// An optional filter on which versions of the viewer session to revoke. All versions
        /// less than or equal to the specified version will be revoked. Default: 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ViewerSessionVersionsLessThanOrEqualTo
        {
            get { return this._viewerSessionVersionsLessThanOrEqualTo; }
            set { this._viewerSessionVersionsLessThanOrEqualTo = value; }
        }

        // Check to see if ViewerSessionVersionsLessThanOrEqualTo property is set
        internal bool IsSetViewerSessionVersionsLessThanOrEqualTo()
        {
            return this._viewerSessionVersionsLessThanOrEqualTo.HasValue; 
        }

    }
}