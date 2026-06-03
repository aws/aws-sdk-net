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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information about a job, returned by the <c>ListJobs</c> operation.
    /// Use <c>DescribeJob</c> to get full details for a specific job.
    /// </summary>
    public partial class JobSummary
    {
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _jobArn;
        private JobCategory _jobCategory;
        private string _jobName;
        private JobSecondaryStatus _jobSecondaryStatus;
        private JobStatus _jobStatus;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobCategory JobCategory
        {
            get { return this._jobCategory; }
            set { this._jobCategory = value; }
        }

        // Check to see if JobCategory property is set
        internal bool IsSetJobCategory()
        {
            return this._jobCategory != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobSecondaryStatus. 
        /// <para>
        /// The secondary status of the job, providing more granular information about the job's
        /// progress. Secondary statuses may change between releases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobSecondaryStatus JobSecondaryStatus
        {
            get { return this._jobSecondaryStatus; }
            set { this._jobSecondaryStatus = value; }
        }

        // Check to see if JobSecondaryStatus property is set
        internal bool IsSetJobSecondaryStatus()
        {
            return this._jobSecondaryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}