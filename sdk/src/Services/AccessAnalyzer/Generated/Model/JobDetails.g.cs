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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains details about the policy generation request.
    /// </summary>
    public partial class JobDetails
    {
        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// A timestamp of when the job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property JobError. 
        /// <para>
        /// The job error for the policy generation request.
        /// </para>
        /// </summary>
        public JobError JobError { get; set; }

        /// <summary>
        /// Checks to see if the JobError property is set.
        /// </summary>
        internal bool IsSetJobError() => this.JobError != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The <c>JobId</c> that is returned by the <c>StartPolicyGeneration</c> operation. The
        /// <c>JobId</c> can be used with <c>GetGeneratedPolicy</c> to retrieve the generated
        /// policies or used with <c>CancelPolicyGeneration</c> to cancel the policy generation
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// A timestamp of when the job was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
