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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReportGroup operation.
    /// <code>DeleteReportGroup</code>: Deletes a report group. Before you delete a report
    /// group, you must delete its reports. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_ListReportsForReportGroup.html">ListReportsForReportGroup</a>
    /// to get the reports in a report group. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_DeleteReport.html">DeleteReport</a>
    /// to delete the reports. If you call <code>DeleteReportGroup</code> for a report group
    /// that contains one or more reports, an exception is thrown.
    /// </summary>
    public partial class DeleteReportGroupRequest : AmazonCodeBuildRequest
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the report group to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

    }
}