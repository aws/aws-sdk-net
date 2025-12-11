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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains information about files that are requested for registered
    /// user during a <c>StartDashboardSnapshotJob</c> API call.
    /// </summary>
    public partial class RegisteredUserSnapshotJobResult
    {
        private List<SnapshotJobResultFileGroup> _fileGroups = AWSConfigs.InitializeCollections ? new List<SnapshotJobResultFileGroup>() : null;

        /// <summary>
        /// Gets and sets the property FileGroups. 
        /// <para>
        /// A list of <c>SnapshotJobResultFileGroup</c> objects that contain information on the
        /// files that are requested for registered user during a <c>StartDashboardSnapshotJob</c>
        /// API call. If the job succeeds, these objects contain the location where the snapshot
        /// artifacts are stored. If the job fails, the objects contain information about the
        /// error that caused the job to fail.
        /// </para>
        /// </summary>
        public List<SnapshotJobResultFileGroup> FileGroups
        {
            get { return this._fileGroups; }
            set { this._fileGroups = value; }
        }

        // Check to see if FileGroups property is set
        internal bool IsSetFileGroups()
        {
            return this._fileGroups != null && (this._fileGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}