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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Indicates whether DataSync created a complete <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">task
    /// report</a> for your transfer.
    /// </summary>
    public partial class ReportResult
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Indicates the code associated with the error if DataSync can't create a complete report.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Provides details about issues creating a report.
        /// </para>
        /// </summary>
        public string ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether DataSync is still working on your report, created a report, or can't
        /// create a complete report.
        /// </para>
        /// </summary>
        public PhaseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
