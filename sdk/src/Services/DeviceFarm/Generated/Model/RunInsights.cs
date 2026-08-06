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
    /// Contains insights for a run, including report status, and job-level aggregated metrics
    /// such as per job execution time and median job execution time.
    /// </summary>
    public partial class RunInsights
    {
        private JobReport _jobReport;
        private ReportStatus _status;

        /// <summary>
        /// Gets and sets the property JobReport. 
        /// <para>
        /// The job-level aggregated report for the run.
        /// </para>
        /// </summary>
        public JobReport JobReport
        {
            get { return this._jobReport; }
            set { this._jobReport = value; }
        }

        // Check to see if JobReport property is set
        internal bool IsSetJobReport()
        {
            return this._jobReport != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the insights report for the run.
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

    }
}