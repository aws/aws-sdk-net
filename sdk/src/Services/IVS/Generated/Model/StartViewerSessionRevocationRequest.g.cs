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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the StartViewerSessionRevocation operation. Starts
    /// the process of revoking the viewer session associated with a specified channel ARN
    /// and viewer ID. Optionally, you can provide a version to revoke viewer sessions less
    /// than and including that version. For instructions on associating a viewer ID with
    /// a viewer session, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
    /// Up Private Channels</a>.
    /// </summary>
    public partial class StartViewerSessionRevocationRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel associated with the viewer session to revoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ViewerId. 
        /// <para>
        /// The ID of the viewer associated with the viewer session to revoke. Do not use this
        /// field for personally identifying, confidential, or sensitive information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string ViewerId { get; set; }

        /// <summary>
        /// Checks to see if the ViewerId property is set.
        /// </summary>
        internal bool IsSetViewerId() => this.ViewerId != null;

        /// <summary>
        /// Gets and sets the property ViewerSessionVersionsLessThanOrEqualTo. 
        /// <para>
        /// An optional filter on which versions of the viewer session to revoke. All versions
        /// less than or equal to the specified version will be revoked. Default: 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ViewerSessionVersionsLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Checks to see if the ViewerSessionVersionsLessThanOrEqualTo property is set.
        /// </summary>
        internal bool IsSetViewerSessionVersionsLessThanOrEqualTo() => this.ViewerSessionVersionsLessThanOrEqualTo.HasValue;
    }
}
