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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the starting parameters for a Flink-based Kinesis Data Analytics application.
    /// </summary>
    public partial class FlinkRunConfiguration
    {
        private bool? _allowNonRestoredState;

        /// <summary>
        /// Gets and sets the property AllowNonRestoredState. 
        /// <para>
        /// When restoring from a snapshot, specifies whether the runtime is allowed to skip a
        /// state that cannot be mapped to the new program. This will happen if the program is
        /// updated between snapshots to remove stateful parameters, and state data in the snapshot
        /// no longer corresponds to valid application data. For more information, see <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/ops/state/savepoints.html#allowing-non-restored-state">
        /// Allowing Non-Restored State</a> in the <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/">Apache
        /// Flink documentation</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value defaults to <code>false</code>. If you update your application without
        /// specifying this parameter, <code>AllowNonRestoredState</code> will be set to <code>false</code>,
        /// even if it was previously set to <code>true</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool AllowNonRestoredState
        {
            get { return this._allowNonRestoredState.GetValueOrDefault(); }
            set { this._allowNonRestoredState = value; }
        }

        // Check to see if AllowNonRestoredState property is set
        internal bool IsSetAllowNonRestoredState()
        {
            return this._allowNonRestoredState.HasValue; 
        }

    }
}