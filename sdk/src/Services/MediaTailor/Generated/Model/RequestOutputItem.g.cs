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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The output configuration for this channel.
    /// </summary>
    public partial class RequestOutputItem
    {
        /// <summary>
        /// Gets and sets the property DashPlaylistSettings. 
        /// <para>
        /// DASH manifest configuration parameters.
        /// </para>
        /// </summary>
        public DashPlaylistSettings DashPlaylistSettings { get; set; }

        /// <summary>
        /// Checks to see if the DashPlaylistSettings property is set.
        /// </summary>
        internal bool IsSetDashPlaylistSettings() => this.DashPlaylistSettings != null;

        /// <summary>
        /// Gets and sets the property HlsPlaylistSettings. 
        /// <para>
        /// HLS playlist configuration parameters.
        /// </para>
        /// </summary>
        public HlsPlaylistSettings HlsPlaylistSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsPlaylistSettings property is set.
        /// </summary>
        internal bool IsSetHlsPlaylistSettings() => this.HlsPlaylistSettings != null;

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// The name of the manifest for the channel. The name appears in the <c>PlaybackUrl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property SourceGroup. 
        /// <para>
        /// A string used to match which <c>HttpPackageConfiguration</c> is used for each <c>VodSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceGroup { get; set; }

        /// <summary>
        /// Checks to see if the SourceGroup property is set.
        /// </summary>
        internal bool IsSetSourceGroup() => this.SourceGroup != null;
    }
}
