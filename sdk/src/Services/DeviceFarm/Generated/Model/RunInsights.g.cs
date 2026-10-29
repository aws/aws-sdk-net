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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Contains insights for a run, including report status, and job-level aggregated metrics
    /// such as per job execution time and median job execution time.
    /// </summary>
    public partial class RunInsights
    {
        /// <summary>
        /// Gets and sets the property JobReport. 
        /// <para>
        /// The job-level aggregated report for the run.
        /// </para>
        /// </summary>
        public JobReport JobReport { get; set; }

        /// <summary>
        /// Checks to see if the JobReport property is set.
        /// </summary>
        internal bool IsSetJobReport() => this.JobReport != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the insights report for the run.
        /// </para>
        /// </summary>
        public ReportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
