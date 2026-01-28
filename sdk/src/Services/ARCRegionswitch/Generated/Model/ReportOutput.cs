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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// The output location or cause of a failure in report generation.
    /// </summary>
    public partial class ReportOutput
    {
        private FailedReportOutput _failedReportOutput;
        private S3ReportOutput _s3ReportOutput;

        /// <summary>
        /// Gets and sets the property FailedReportOutput. 
        /// <para>
        /// The details about a failed report generation.
        /// </para>
        /// </summary>
        public FailedReportOutput FailedReportOutput
        {
            get { return this._failedReportOutput; }
            set { this._failedReportOutput = value; }
        }

        // Check to see if FailedReportOutput property is set
        internal bool IsSetFailedReportOutput()
        {
            return this._failedReportOutput != null;
        }

        /// <summary>
        /// Gets and sets the property S3ReportOutput. 
        /// <para>
        /// Information about a report delivered to Amazon S3.
        /// </para>
        /// </summary>
        public S3ReportOutput S3ReportOutput
        {
            get { return this._s3ReportOutput; }
            set { this._s3ReportOutput = value; }
        }

        // Check to see if S3ReportOutput property is set
        internal bool IsSetS3ReportOutput()
        {
            return this._s3ReportOutput != null;
        }

    }
}