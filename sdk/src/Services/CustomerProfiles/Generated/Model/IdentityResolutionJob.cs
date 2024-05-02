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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Information about the Identity Resolution Job.
    /// </summary>
    public partial class IdentityResolutionJob
    {
        private string _domainName;
        private ExportingLocation _exportingLocation;
        private DateTime? _jobEndTime;
        private string _jobId;
        private DateTime? _jobStartTime;
        private JobStats _jobStats;
        private string _message;
        private IdentityResolutionJobStatus _status;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ExportingLocation. 
        /// <para>
        /// The S3 location where the Identity Resolution Job writes result files.
        /// </para>
        /// </summary>
        public ExportingLocation ExportingLocation
        {
            get { return this._exportingLocation; }
            set { this._exportingLocation = value; }
        }

        // Check to see if ExportingLocation property is set
        internal bool IsSetExportingLocation()
        {
            return this._exportingLocation != null;
        }

        /// <summary>
        /// Gets and sets the property JobEndTime. 
        /// <para>
        /// The timestamp of when the job was completed.
        /// </para>
        /// </summary>
        public DateTime? JobEndTime
        {
            get { return this._jobEndTime; }
            set { this._jobEndTime = value; }
        }

        // Check to see if JobEndTime property is set
        internal bool IsSetJobEndTime()
        {
            return this._jobEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the Identity Resolution Job.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStartTime. 
        /// <para>
        /// The timestamp of when the job was started or will be started.
        /// </para>
        /// </summary>
        public DateTime? JobStartTime
        {
            get { return this._jobStartTime; }
            set { this._jobStartTime = value; }
        }

        // Check to see if JobStartTime property is set
        internal bool IsSetJobStartTime()
        {
            return this._jobStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobStats. 
        /// <para>
        /// Statistics about an Identity Resolution Job.
        /// </para>
        /// </summary>
        public JobStats JobStats
        {
            get { return this._jobStats; }
            set { this._jobStats = value; }
        }

        // Check to see if JobStats property is set
        internal bool IsSetJobStats()
        {
            return this._jobStats != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error messages that are generated when the Identity Resolution Job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Identity Resolution Job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The Identity Resolution Job is scheduled but has not started yet.
        /// If you turn off the Identity Resolution feature in your domain, jobs in the <c>PENDING</c>
        /// state are deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PREPROCESSING</c>: The Identity Resolution Job is loading your data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIND_MATCHING</c>: The Identity Resolution Job is using the machine learning model
        /// to identify profiles that belong to the same matching group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MERGING</c>: The Identity Resolution Job is merging duplicate profiles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c>: The Identity Resolution Job completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL_SUCCESS</c>: There's a system error and not all of the data is merged.
        /// The Identity Resolution Job writes a message indicating the source of the problem.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The Identity Resolution Job did not merge any data. It writes a message
        /// indicating the source of the problem.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IdentityResolutionJobStatus Status
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