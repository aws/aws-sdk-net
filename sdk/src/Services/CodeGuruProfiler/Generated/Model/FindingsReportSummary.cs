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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
        private string _id;
        private DateTime? _profileEndTime;
        private DateTime? _profileStartTime;
        private string _profilingGroupName;
        private int? _totalNumberOfFindings;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The universally unique identifier (UUID) of the recommendation report.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileEndTime. 
        /// <para>
        ///  The end time of the period during which the metric is flagged as anomalous. This
        /// is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents
        /// 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? ProfileEndTime
        {
            get { return this._profileEndTime; }
            set { this._profileEndTime = value; }
        }

        // Check to see if ProfileEndTime property is set
        internal bool IsSetProfileEndTime()
        {
            return this._profileEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileStartTime. 
        /// <para>
        /// The start time of the profile the analysis data is about. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        public DateTime? ProfileStartTime
        {
            get { return this._profileStartTime; }
            set { this._profileStartTime = value; }
        }

        // Check to see if ProfileStartTime property is set
        internal bool IsSetProfileStartTime()
        {
            return this._profileStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group that is associated with the analysis data.
        /// </para>
        /// </summary>
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfFindings. 
        /// <para>
        /// The total number of different recommendations that were found by the analysis.
        /// </para>
        /// </summary>
        public int? TotalNumberOfFindings
        {
            get { return this._totalNumberOfFindings; }
            set { this._totalNumberOfFindings = value; }
        }

        // Check to see if TotalNumberOfFindings property is set
        internal bool IsSetTotalNumberOfFindings()
        {
            return this._totalNumberOfFindings.HasValue; 
        }

    }
}