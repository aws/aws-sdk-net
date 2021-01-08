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
    /// Container for the parameters to the UpdateReportGroup operation.
    /// Updates a report group.
    /// </summary>
    public partial class UpdateReportGroupRequest : AmazonCodeBuildRequest
    {
        private string _arn;
        private ReportExportConfig _exportConfig;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the report group to update. 
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

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        ///  Used to specify an updated export type. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>S3</code>: The report results are exported to an S3 bucket. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_EXPORT</code>: The report results are not exported. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportExportConfig ExportConfig
        {
            get { return this._exportConfig; }
            set { this._exportConfig = value; }
        }

        // Check to see if ExportConfig property is set
        internal bool IsSetExportConfig()
        {
            return this._exportConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  An updated list of tag key and value pairs associated with this report group. 
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by AWS services that support AWS CodeBuild report
        /// group tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}