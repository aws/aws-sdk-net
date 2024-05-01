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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains the unmodified data for the report. For more information, see .
    /// </summary>
    public partial class ReportWithRawData
    {
        private string _data;
        private string _reportArn;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The value of the requested data field from the report.
        /// </para>
        /// </summary>
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property ReportArn. 
        /// <para>
        /// The ARN of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReportArn
        {
            get { return this._reportArn; }
            set { this._reportArn = value; }
        }

        // Check to see if ReportArn property is set
        internal bool IsSetReportArn()
        {
            return this._reportArn != null;
        }

    }
}