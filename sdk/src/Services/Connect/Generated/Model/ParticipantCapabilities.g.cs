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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The configuration for the allowed video and screen sharing capabilities for participants
    /// present over the call. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/inapp-calling.html">Set
    /// up in-app, web, video calling, and screen sharing capabilities</a> in the <i>Connect
    /// Customer Administrator Guide</i>.
    /// </summary>
    public partial class ParticipantCapabilities
    {
        /// <summary>
        /// Gets and sets the property ScreenShare. 
        /// <para>
        /// The screen sharing capability that is enabled for the participant. <c>SEND</c> indicates
        /// the participant can share their screen.
        /// </para>
        /// </summary>
        public ScreenShareCapability ScreenShare { get; set; }

        /// <summary>
        /// Checks to see if the ScreenShare property is set.
        /// </summary>
        internal bool IsSetScreenShare() => this.ScreenShare != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration having the video and screen sharing capabilities for participants
        /// over the call.
        /// </para>
        /// </summary>
        public VideoCapability Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
