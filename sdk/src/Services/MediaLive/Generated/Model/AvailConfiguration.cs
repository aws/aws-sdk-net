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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Avail Configuration
    /// </summary>
    public partial class AvailConfiguration
    {
        private AvailSettings _availSettings;
        private Scte35SegmentationScope _scte35SegmentationScope;

        /// <summary>
        /// Gets and sets the property AvailSettings. Controls how SCTE-35 messages create cues.
        /// Splice Insert mode treats all segmentation signals traditionally. With Time Signal
        /// APOS mode only Time Signal Placement Opportunity and Break messages create segment
        /// breaks. With ESAM mode, signals are forwarded to an ESAM server for possible update.
        /// </summary>
        public AvailSettings AvailSettings
        {
            get { return this._availSettings; }
            set { this._availSettings = value; }
        }

        // Check to see if AvailSettings property is set
        internal bool IsSetAvailSettings()
        {
            return this._availSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35SegmentationScope. Configures whether SCTE 35 passthrough
        /// triggers segment breaks in all output groups that use segmented outputs. Insertion
        /// of a SCTE 35 message typically results in a segment break, in addition to the regular
        /// cadence of breaks. The segment breaks appear in video outputs, audio outputs, and
        /// captions outputs (if any).ALL_OUTPUT_GROUPS: Default. Insert the segment break in
        /// in all output groups that have segmented outputs. This is the legacy behavior.SCTE35_ENABLED_OUTPUT_GROUPS:
        /// Insert the segment break only in output groups that have SCTE 35 passthrough enabled.
        /// This is the recommended value, because it reduces unnecessary segment breaks.
        /// </summary>
        public Scte35SegmentationScope Scte35SegmentationScope
        {
            get { return this._scte35SegmentationScope; }
            set { this._scte35SegmentationScope = value; }
        }

        // Check to see if Scte35SegmentationScope property is set
        internal bool IsSetScte35SegmentationScope()
        {
            return this._scte35SegmentationScope != null;
        }

    }
}