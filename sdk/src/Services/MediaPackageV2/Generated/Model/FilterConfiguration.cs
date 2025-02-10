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
    /// Filter configuration includes settings for manifest filtering, start and end times,
    /// and time delay that apply to all of your egress requests for this manifest.
    /// </summary>
    public partial class FilterConfiguration
    {
        private DateTime? _clipStartTime;
        private DateTime? _end;
        private string _manifestFilter;
        private DateTime? _start;
        private int? _timeDelaySeconds;

        /// <summary>
        /// Gets and sets the property ClipStartTime. 
        /// <para>
        /// Optionally specify the clip start time for all of your manifest egress requests. When
        /// you include clip start time, note that you cannot use clip start time query parameters
        /// for this manifest's endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? ClipStartTime
        {
            get { return this._clipStartTime; }
            set { this._clipStartTime = value; }
        }

        // Check to see if ClipStartTime property is set
        internal bool IsSetClipStartTime()
        {
            return this._clipStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// Optionally specify the end time for all of your manifest egress requests. When you
        /// include end time, note that you cannot use end time query parameters for this manifest's
        /// endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManifestFilter. 
        /// <para>
        /// Optionally specify one or more manifest filters for all of your manifest egress requests.
        /// When you include a manifest filter, note that you cannot use an identical manifest
        /// filter query parameter for this manifest's endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ManifestFilter
        {
            get { return this._manifestFilter; }
            set { this._manifestFilter = value; }
        }

        // Check to see if ManifestFilter property is set
        internal bool IsSetManifestFilter()
        {
            return this._manifestFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Optionally specify the start time for all of your manifest egress requests. When you
        /// include start time, note that you cannot use start time query parameters for this
        /// manifest's endpoint URL.
        /// </para>
        /// </summary>
        public DateTime? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDelaySeconds. 
        /// <para>
        /// Optionally specify the time delay for all of your manifest egress requests. Enter
        /// a value that is smaller than your endpoint's startover window. When you include time
        /// delay, note that you cannot use time delay query parameters for this manifest's endpoint
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1209600)]
        public int? TimeDelaySeconds
        {
            get { return this._timeDelaySeconds; }
            set { this._timeDelaySeconds = value; }
        }

        // Check to see if TimeDelaySeconds property is set
        internal bool IsSetTimeDelaySeconds()
        {
            return this._timeDelaySeconds.HasValue; 
        }

    }
}