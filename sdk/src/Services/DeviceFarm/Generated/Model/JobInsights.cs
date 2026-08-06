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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Contains insights for a job, including report status, and test-level aggregated metrics
    /// such as per test execution time and median test execution time.
    /// </summary>
    public partial class JobInsights
    {
        private ReportStatus _status;
        private TestReport _testReport;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the insights report for the job.
        /// </para>
        /// </summary>
        public ReportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TestReport. 
        /// <para>
        /// The test-level aggregated report for the job.
        /// </para>
        /// </summary>
        public TestReport TestReport
        {
            get { return this._testReport; }
            set { this._testReport = value; }
        }

        // Check to see if TestReport property is set
        internal bool IsSetTestReport()
        {
            return this._testReport != null;
        }

    }
}