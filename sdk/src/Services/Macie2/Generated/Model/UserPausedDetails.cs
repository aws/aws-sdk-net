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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about when a classification job was paused. For a one-time job,
    /// this object also specifies when the job will expire and be cancelled if it isn't resumed.
    /// For a recurring job, this object also specifies when the paused job run will expire
    /// and be cancelled if it isn't resumed. This object is present only if a job's current
    /// status (jobStatus) is USER_PAUSED. The information in this object applies only to
    /// a job that was paused while it had a status of RUNNING.
    /// </summary>
    public partial class UserPausedDetails
    {
        private DateTime? _jobExpiresAt;
        private string _jobImminentExpirationHealthEventArn;
        private DateTime? _jobPausedAt;

        /// <summary>
        /// Gets and sets the property JobExpiresAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job or job run will
        /// expire and be cancelled if you don't resume it first.
        /// </para>
        /// </summary>
        public DateTime? JobExpiresAt
        {
            get { return this._jobExpiresAt; }
            set { this._jobExpiresAt = value; }
        }

        // Check to see if JobExpiresAt property is set
        internal bool IsSetJobExpiresAt()
        {
            return this._jobExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobImminentExpirationHealthEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Health event that Amazon Macie sent to notify
        /// you of the job or job run's pending expiration and cancellation. This value is null
        /// if a job has been paused for less than 23 days.
        /// </para>
        /// </summary>
        public string JobImminentExpirationHealthEventArn
        {
            get { return this._jobImminentExpirationHealthEventArn; }
            set { this._jobImminentExpirationHealthEventArn = value; }
        }

        // Check to see if JobImminentExpirationHealthEventArn property is set
        internal bool IsSetJobImminentExpirationHealthEventArn()
        {
            return this._jobImminentExpirationHealthEventArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobPausedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when you paused the job.
        /// </para>
        /// </summary>
        public DateTime? JobPausedAt
        {
            get { return this._jobPausedAt; }
            set { this._jobPausedAt = value; }
        }

        // Check to see if JobPausedAt property is set
        internal bool IsSetJobPausedAt()
        {
            return this._jobPausedAt.HasValue; 
        }

    }
}