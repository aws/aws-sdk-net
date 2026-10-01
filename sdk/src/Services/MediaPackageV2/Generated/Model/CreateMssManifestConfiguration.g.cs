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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Configuration parameters for creating a Microsoft Smooth Streaming (MSS) manifest.
    /// MSS is a streaming media format developed by Microsoft that delivers adaptive bitrate
    /// streaming content to compatible players and devices.
    /// </summary>
    public partial class CreateMssManifestConfiguration
    {
        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManifestLayout. 
        /// <para>
        /// Determines the layout format of the MSS manifest. This controls how the manifest is
        /// structured and presented to client players, affecting compatibility with different
        /// MSS-compatible devices and applications.
        /// </para>
        /// </summary>
        public MssManifestLayout ManifestLayout { get; set; }

        /// <summary>
        /// Checks to see if the ManifestLayout property is set.
        /// </summary>
        internal bool IsSetManifestLayout() => this.ManifestLayout != null;

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL to create a unique path to this
        /// MSS manifest. The manifest name must be unique within the origin endpoint and can
        /// contain letters, numbers, hyphens, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest window. This determines how much content
        /// is available in the manifest at any given time. The manifest window slides forward
        /// as new segments become available, maintaining a consistent duration of content. The
        /// minimum value is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30)]
        public int? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ManifestWindowSeconds property is set.
        /// </summary>
        internal bool IsSetManifestWindowSeconds() => this.ManifestWindowSeconds.HasValue;
    }
}
