/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains manual snapshot limit information for a directory.
    /// </summary>
    public partial class SnapshotLimits
    {
        private int? _manualSnapshotsCurrentCount;
        private int? _manualSnapshotsLimit;
        private bool? _manualSnapshotsLimitReached;

        /// <summary>
        /// Gets and sets the property ManualSnapshotsCurrentCount. 
        /// <para>
        /// The current number of manual snapshots of the directory.
        /// </para>
        /// </summary>
        public int ManualSnapshotsCurrentCount
        {
            get { return this._manualSnapshotsCurrentCount.GetValueOrDefault(); }
            set { this._manualSnapshotsCurrentCount = value; }
        }

        // Check to see if ManualSnapshotsCurrentCount property is set
        internal bool IsSetManualSnapshotsCurrentCount()
        {
            return this._manualSnapshotsCurrentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotsLimit. 
        /// <para>
        /// The maximum number of manual snapshots allowed.
        /// </para>
        /// </summary>
        public int ManualSnapshotsLimit
        {
            get { return this._manualSnapshotsLimit.GetValueOrDefault(); }
            set { this._manualSnapshotsLimit = value; }
        }

        // Check to see if ManualSnapshotsLimit property is set
        internal bool IsSetManualSnapshotsLimit()
        {
            return this._manualSnapshotsLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotsLimitReached. 
        /// <para>
        /// Indicates if the manual snapshot limit has been reached.
        /// </para>
        /// </summary>
        public bool ManualSnapshotsLimitReached
        {
            get { return this._manualSnapshotsLimitReached.GetValueOrDefault(); }
            set { this._manualSnapshotsLimitReached = value; }
        }

        // Check to see if ManualSnapshotsLimitReached property is set
        internal bool IsSetManualSnapshotsLimitReached()
        {
            return this._manualSnapshotsLimitReached.HasValue; 
        }

    }
}