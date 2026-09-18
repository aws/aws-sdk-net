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
    /// Filter configuration includes settings for manifest filtering, start and end times,
    /// and time delay that apply to all of your egress requests for this manifest.
    /// </summary>
    public partial class FilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClipStartTime. 
        /// <para>
        /// Optionally specify the clip start time for all of your manifest egress requests. When
        /// you include clip start time, note that you cannot use clip start time query parameters
        /// for this manifest's endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? ClipStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ClipStartTime property is set.
        /// </summary>
        internal bool IsSetClipStartTime() => this.ClipStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DrmSettings. 
        /// <para>
        /// Optionally specify one or more DRM settings for all of your manifest egress requests.
        /// When you include a DRM setting, note that you cannot use an identical DRM setting
        /// query parameter for this manifest's endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DrmSettings { get; set; }

        /// <summary>
        /// Checks to see if the DrmSettings property is set.
        /// </summary>
        internal bool IsSetDrmSettings() => this.DrmSettings != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// Optionally specify the end time for all of your manifest egress requests. When you
        /// include end time, note that you cannot use end time query parameters for this manifest's
        /// endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property ManifestFilter. 
        /// <para>
        /// Optionally specify one or more manifest filters for all of your manifest egress requests.
        /// When you include a manifest filter, note that you cannot use an identical manifest
        /// filter query parameter for this manifest's endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ManifestFilter { get; set; }

        /// <summary>
        /// Checks to see if the ManifestFilter property is set.
        /// </summary>
        internal bool IsSetManifestFilter() => this.ManifestFilter != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Optionally specify the start time for all of your manifest egress requests. When you
        /// include start time, note that you cannot use start time query parameters for this
        /// manifest's endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;

        /// <summary>
        /// Gets and sets the property TimeDelaySeconds. 
        /// <para>
        /// Optionally specify the time delay for all of your manifest egress requests. Enter
        /// a value that is smaller than your endpoint's startover window. When you include time
        /// delay, note that you cannot use time delay query parameters for this manifest's endpoint
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1209600)]
        public int? TimeDelaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeDelaySeconds property is set.
        /// </summary>
        internal bool IsSetTimeDelaySeconds() => this.TimeDelaySeconds.HasValue;
    }
}
