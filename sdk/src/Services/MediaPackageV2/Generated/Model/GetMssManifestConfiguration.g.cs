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
    /// Configuration details for a Microsoft Smooth Streaming (MSS) manifest associated with
    /// an origin endpoint. This includes all the settings and properties that define how
    /// the MSS content is packaged and delivered.
    /// </summary>
    public partial class GetMssManifestConfiguration
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
        /// The layout format of the MSS manifest, which determines how the manifest is structured
        /// for client compatibility.
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
        /// The name of the MSS manifest. This name is appended to the origin endpoint URL to
        /// create the unique path for accessing this specific MSS manifest.
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
        /// The duration (in seconds) of the manifest window. This represents the total amount
        /// of content available in the manifest at any given time.
        /// </para>
        /// </summary>
        public int? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ManifestWindowSeconds property is set.
        /// </summary>
        internal bool IsSetManifestWindowSeconds() => this.ManifestWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The complete URL for accessing the MSS manifest. Client players use this URL to retrieve
        /// the manifest and begin streaming the Microsoft Smooth Streaming content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
