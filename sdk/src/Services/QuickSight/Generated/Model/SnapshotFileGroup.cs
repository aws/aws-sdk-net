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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains the information on the snapshot files.
    /// </summary>
    public partial class SnapshotFileGroup
    {
        private List<SnapshotFile> _files = new List<SnapshotFile>();

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// A list of <code>SnapshotFile</code> objects that contain the information on the snapshot
        /// files that need to be generated. This structure can hold 1 configuration at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<SnapshotFile> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && this._files.Count > 0; 
        }

    }
}