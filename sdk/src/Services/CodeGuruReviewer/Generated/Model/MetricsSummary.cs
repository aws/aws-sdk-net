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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about metrics summaries.
    /// </summary>
    public partial class MetricsSummary
    {
        private long? _findingsCount;
        private long? _meteredLinesOfCodeCount;

        /// <summary>
        /// Gets and sets the property FindingsCount. 
        /// <para>
        ///  Total number of recommendations found in the code review. 
        /// </para>
        /// </summary>
        public long FindingsCount
        {
            get { return this._findingsCount.GetValueOrDefault(); }
            set { this._findingsCount = value; }
        }

        // Check to see if FindingsCount property is set
        internal bool IsSetFindingsCount()
        {
            return this._findingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MeteredLinesOfCodeCount. 
        /// <para>
        ///  Lines of code metered in the code review. For the initial code review pull request
        /// and all subsequent revisions, this includes all lines of code in the files added to
        /// the pull request. In subsequent revisions, for files that already existed in the pull
        /// request, this includes only the changed lines of code. In both cases, this does not
        /// include non-code lines such as comments and import statements. For example, if you
        /// submit a pull request containing 5 files, each with 500 lines of code, and in a subsequent
        /// revision you added a new file with 200 lines of code, and also modified a total of
        /// 25 lines across the initial 5 files, <code>MeteredLinesOfCodeCount</code> includes
        /// the first 5 files (5 * 500 = 2,500 lines), the new file (200 lines) and the 25 changed
        /// lines of code for a total of 2,725 lines of code. 
        /// </para>
        /// </summary>
        public long MeteredLinesOfCodeCount
        {
            get { return this._meteredLinesOfCodeCount.GetValueOrDefault(); }
            set { this._meteredLinesOfCodeCount = value; }
        }

        // Check to see if MeteredLinesOfCodeCount property is set
        internal bool IsSetMeteredLinesOfCodeCount()
        {
            return this._meteredLinesOfCodeCount.HasValue; 
        }

    }
}