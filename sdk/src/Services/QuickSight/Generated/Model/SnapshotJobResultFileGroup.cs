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
    /// A structure that contains information on the generated snapshot file groups.
    /// </summary>
    public partial class SnapshotJobResultFileGroup
    {
        private List<SnapshotFile> _files = new List<SnapshotFile>();
        private List<SnapshotJobS3Result> _s3Results = new List<SnapshotJobS3Result>();

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        ///  A list of <code>SnapshotFile</code> objects.
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

        /// <summary>
        /// Gets and sets the property S3Results. 
        /// <para>
        ///  A list of <code>SnapshotJobS3Result</code> objects.
        /// </para>
        /// </summary>
        public List<SnapshotJobS3Result> S3Results
        {
            get { return this._s3Results; }
            set { this._s3Results = value; }
        }

        // Check to see if S3Results property is set
        internal bool IsSetS3Results()
        {
            return this._s3Results != null && this._s3Results.Count > 0; 
        }

    }
}