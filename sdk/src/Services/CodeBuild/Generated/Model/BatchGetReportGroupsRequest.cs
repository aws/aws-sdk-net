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
    /// Container for the parameters to the BatchGetReportGroups operation.
    /// Returns an array of report groups.
    /// </summary>
    public partial class BatchGetReportGroupsRequest : AmazonCodeBuildRequest
    {
        private List<string> _reportGroupArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ReportGroupArns. 
        /// <para>
        ///  An array of report group ARNs that identify the report groups to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ReportGroupArns
        {
            get { return this._reportGroupArns; }
            set { this._reportGroupArns = value; }
        }

        // Check to see if ReportGroupArns property is set
        internal bool IsSetReportGroupArns()
        {
            return this._reportGroupArns != null && this._reportGroupArns.Count > 0; 
        }

    }
}