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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The summary of attributes associated with a job run.
    /// </summary>
    public partial class JobRunSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application the job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The attempt number of the job run execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Attempt { get; set; }

        /// <summary>
        /// Checks to see if the Attempt property is set.
        /// </summary>
        internal bool IsSetAttempt() => this.Attempt.HasValue;

        /// <summary>
        /// Gets and sets the property AttemptCreatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was created.
        /// </para>
        /// </summary>
        public DateTime? AttemptCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttemptCreatedAt property is set.
        /// </summary>
        internal bool IsSetAttemptCreatedAt() => this.AttemptCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AttemptUpdatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was last updated.
        /// </para>
        /// </summary>
        public DateTime? AttemptUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttemptUpdatedAt property is set.
        /// </summary>
        internal bool IsSetAttemptUpdatedAt() => this.AttemptUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the job run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job run.
        /// </para>
        /// </summary>
        public JobRunMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional job run name. This doesn't have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release associated with the application your job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job run, such as Spark or Hive.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the job run was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
