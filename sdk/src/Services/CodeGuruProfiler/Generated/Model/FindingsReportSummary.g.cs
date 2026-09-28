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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Information about potential recommendations that might be created from the analysis
    /// of profiling data.
    /// </summary>
    public partial class FindingsReportSummary
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The universally unique identifier (UUID) of the recommendation report.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ProfileEndTime. 
        /// <para>
        ///  The end time of the period during which the metric is flagged as anomalous. This
        /// is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents
        /// 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? ProfileEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ProfileEndTime property is set.
        /// </summary>
        internal bool IsSetProfileEndTime() => this.ProfileEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileStartTime. 
        /// <para>
        /// The start time of the profile the analysis data is about. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        public DateTime? ProfileStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ProfileStartTime property is set.
        /// </summary>
        internal bool IsSetProfileStartTime() => this.ProfileStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group that is associated with the analysis data.
        /// </para>
        /// </summary>
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property TotalNumberOfFindings. 
        /// <para>
        /// The total number of different recommendations that were found by the analysis.
        /// </para>
        /// </summary>
        public int? TotalNumberOfFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfFindings property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfFindings() => this.TotalNumberOfFindings.HasValue;
    }
}
