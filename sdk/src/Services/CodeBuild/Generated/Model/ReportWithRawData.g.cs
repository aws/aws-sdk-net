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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The value of the requested data field from the report.
        /// </para>
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property ReportArn. 
        /// <para>
        /// The ARN of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ReportArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportArn property is set.
        /// </summary>
        internal bool IsSetReportArn() => this.ReportArn != null;
    }
}
