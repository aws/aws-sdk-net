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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetReports operation.
    /// Returns an array of reports.
    /// </summary>
    public partial class BatchGetReportsRequest : AmazonCodeBuildRequest
    {
        private List<string> _reportArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ReportArns. 
        /// <para>
        ///  An array of ARNs that identify the <code>Report</code> objects to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ReportArns
        {
            get { return this._reportArns; }
            set { this._reportArns = value; }
        }

        // Check to see if ReportArns property is set
        internal bool IsSetReportArns()
        {
            return this._reportArns != null && this._reportArns.Count > 0; 
        }

    }
}