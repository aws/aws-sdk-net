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
        /// <summary>
        /// Gets and sets the property JobExpiresAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job or job run will
        /// expire and be cancelled if you don't resume it first.
        /// </para>
        /// </summary>
        public DateTime? JobExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the JobExpiresAt property is set.
        /// </summary>
        internal bool IsSetJobExpiresAt() => this.JobExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property JobImminentExpirationHealthEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Health event that Amazon Macie sent to notify
        /// you of the job or job run's pending expiration and cancellation. This value is null
        /// if a job has been paused for less than 23 days.
        /// </para>
        /// </summary>
        public string JobImminentExpirationHealthEventArn { get; set; }

        /// <summary>
        /// Checks to see if the JobImminentExpirationHealthEventArn property is set.
        /// </summary>
        internal bool IsSetJobImminentExpirationHealthEventArn() => this.JobImminentExpirationHealthEventArn != null;

        /// <summary>
        /// Gets and sets the property JobPausedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when you paused the job.
        /// </para>
        /// </summary>
        public DateTime? JobPausedAt { get; set; }

        /// <summary>
        /// Checks to see if the JobPausedAt property is set.
        /// </summary>
        internal bool IsSetJobPausedAt() => this.JobPausedAt.HasValue;
    }
}
