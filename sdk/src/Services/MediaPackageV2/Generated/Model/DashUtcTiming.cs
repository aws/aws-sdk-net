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
    /// Determines the type of UTC timing included in the DASH Media Presentation Description
    /// (MPD).
    /// </summary>
    public partial class DashUtcTiming
    {
        private DashUtcTimingMode _timingMode;
        private string _timingSource;

        /// <summary>
        /// Gets and sets the property TimingMode. 
        /// <para>
        /// The UTC timing mode.
        /// </para>
        /// </summary>
        public DashUtcTimingMode TimingMode
        {
            get { return this._timingMode; }
            set { this._timingMode = value; }
        }

        // Check to see if TimingMode property is set
        internal bool IsSetTimingMode()
        {
            return this._timingMode != null;
        }

        /// <summary>
        /// Gets and sets the property TimingSource. 
        /// <para>
        /// The the method that the player uses to synchronize to coordinated universal time (UTC)
        /// wall clock time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TimingSource
        {
            get { return this._timingSource; }
            set { this._timingSource = value; }
        }

        // Check to see if TimingSource property is set
        internal bool IsSetTimingSource()
        {
            return this._timingSource != null;
        }

    }
}