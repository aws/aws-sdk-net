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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies whether any one-time or recurring classification jobs are configured to
    /// analyze data in an S3 bucket, and, if so, the details of the job that ran most recently.
    /// </summary>
    public partial class JobDetails
    {
        private IsDefinedInJob _isDefinedInJob;
        private IsMonitoredByJob _isMonitoredByJob;
        private string _lastJobId;
        private DateTime? _lastJobRunTime;

        /// <summary>
        /// Gets and sets the property IsDefinedInJob. 
        /// <para>
        /// Specifies whether any one-time or recurring jobs are configured to analyze data in
        /// the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// TRUE - One or more jobs is configured to analyze data in the bucket, and at least
        /// one of those jobs has a status other than CANCELLED.
        /// </para>
        /// </li> <li>
        /// <para>
        /// FALSE - No jobs are configured to analyze data in the bucket, or all the jobs that
        /// are configured to analyze data in the bucket have a status of CANCELLED.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - An exception occurred when Amazon Macie attempted to retrieve job data for
        /// the bucket.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public IsDefinedInJob IsDefinedInJob
        {
            get { return this._isDefinedInJob; }
            set { this._isDefinedInJob = value; }
        }

        // Check to see if IsDefinedInJob property is set
        internal bool IsSetIsDefinedInJob()
        {
            return this._isDefinedInJob != null;
        }

        /// <summary>
        /// Gets and sets the property IsMonitoredByJob. 
        /// <para>
        /// Specifies whether any recurring jobs are configured to analyze data in the bucket.
        /// Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// TRUE - One or more recurring jobs is configured to analyze data in the bucket, and
        /// at least one of those jobs has a status other than CANCELLED.
        /// </para>
        /// </li> <li>
        /// <para>
        /// FALSE - No recurring jobs are configured to analyze data in the bucket, or all the
        /// recurring jobs that are configured to analyze data in the bucket have a status of
        /// CANCELLED.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - An exception occurred when Amazon Macie attempted to retrieve job data for
        /// the bucket.
        /// </para>
        /// </li></ul>
        /// </summary>
        public IsMonitoredByJob IsMonitoredByJob
        {
            get { return this._isMonitoredByJob; }
            set { this._isMonitoredByJob = value; }
        }

        // Check to see if IsMonitoredByJob property is set
        internal bool IsSetIsMonitoredByJob()
        {
            return this._isMonitoredByJob != null;
        }

        /// <summary>
        /// Gets and sets the property LastJobId. 
        /// <para>
        /// The unique identifier for the job that ran most recently (either the latest run of
        /// a recurring job or the only run of a one-time job) and is configured to analyze data
        /// in the bucket.
        /// </para>
        ///  
        /// <para>
        /// This value is null if the value for the isDefinedInJob property is FALSE or UNKNOWN.
        /// </para>
        /// </summary>
        public string LastJobId
        {
            get { return this._lastJobId; }
            set { this._lastJobId = value; }
        }

        // Check to see if LastJobId property is set
        internal bool IsSetLastJobId()
        {
            return this._lastJobId != null;
        }

        /// <summary>
        /// Gets and sets the property LastJobRunTime. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job (lastJobId) started.
        /// If the job is a recurring job, this value indicates when the most recent run started.
        /// </para>
        ///  
        /// <para>
        /// This value is null if the value for the isDefinedInJob property is FALSE or UNKNOWN.
        /// </para>
        /// </summary>
        public DateTime LastJobRunTime
        {
            get { return this._lastJobRunTime.GetValueOrDefault(); }
            set { this._lastJobRunTime = value; }
        }

        // Check to see if LastJobRunTime property is set
        internal bool IsSetLastJobRunTime()
        {
            return this._lastJobRunTime.HasValue; 
        }

    }
}