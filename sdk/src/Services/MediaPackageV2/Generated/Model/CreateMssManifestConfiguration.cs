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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
        private FilterConfiguration _filterConfiguration;
        private MssManifestLayout _manifestLayout;
        private string _manifestName;
        private int? _manifestWindowSeconds;

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestLayout. 
        /// <para>
        /// Determines the layout format of the MSS manifest. This controls how the manifest is
        /// structured and presented to client players, affecting compatibility with different
        /// MSS-compatible devices and applications.
        /// </para>
        /// </summary>
        public MssManifestLayout ManifestLayout
        {
            get { return this._manifestLayout; }
            set { this._manifestLayout = value; }
        }

        // Check to see if ManifestLayout property is set
        internal bool IsSetManifestLayout()
        {
            return this._manifestLayout != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL to create a unique path to this
        /// MSS manifest. The manifest name must be unique within the origin endpoint and can
        /// contain letters, numbers, hyphens, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest window. This determines how much content
        /// is available in the manifest at any given time. The manifest window slides forward
        /// as new segments become available, maintaining a consistent duration of content. The
        /// minimum value is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30)]
        public int? ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds; }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

    }
}