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
    /// Archive Group Settings
    /// </summary>
    public partial class ArchiveGroupSettings
    {
        private ArchiveCdnSettings _archiveCdnSettings;
        private OutputLocationRef _destination;
        private int? _rolloverInterval;

        /// <summary>
        /// Gets and sets the property ArchiveCdnSettings. Parameters that control interactions
        /// with the CDN.
        /// </summary>
        public ArchiveCdnSettings ArchiveCdnSettings
        {
            get { return this._archiveCdnSettings; }
            set { this._archiveCdnSettings = value; }
        }

        // Check to see if ArchiveCdnSettings property is set
        internal bool IsSetArchiveCdnSettings()
        {
            return this._archiveCdnSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. A directory and base filename where archive
        /// files should be written.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property RolloverInterval. Number of seconds to write to archive
        /// file before closing and starting a new one.
        /// </summary>
        [AWSProperty(Min=1)]
        public int? RolloverInterval
        {
            get { return this._rolloverInterval; }
            set { this._rolloverInterval = value; }
        }

        // Check to see if RolloverInterval property is set
        internal bool IsSetRolloverInterval()
        {
            return this._rolloverInterval.HasValue; 
        }

    }
}