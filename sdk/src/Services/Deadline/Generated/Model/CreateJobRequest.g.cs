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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation. Creates a job. A job is a
    /// set of instructions that Deadline Cloud uses to schedule and run work on available
    /// workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
    /// Cloud jobs</a>.
    /// </summary>
    public partial class CreateJobRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property Attachments. The attachments for the job. Attach files
        /// required for the job to run to a render job.
        /// </summary>
        public Attachments Attachments { get; set; }

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null;

        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DescriptionOverride. A custom description to override the
        /// job description derived from the job template.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string DescriptionOverride { get; set; }

        /// <summary>
        /// Checks to see if the DescriptionOverride property is set.
        /// </summary>
        internal bool IsSetDescriptionOverride() => this.DescriptionOverride != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the farm to connect to the job.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property MaxFailedTasksCount. The number of task failures before
        /// the job stops running and is marked as <c>FAILED</c>.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxFailedTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxFailedTasksCount property is set.
        /// </summary>
        internal bool IsSetMaxFailedTasksCount() => this.MaxFailedTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetriesPerTask. The maximum number of retries for each
        /// task.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxRetriesPerTask { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetriesPerTask property is set.
        /// </summary>
        internal bool IsSetMaxRetriesPerTask() => this.MaxRetriesPerTask.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. The maximum number of worker hosts that
        /// can concurrently process a job. When the <c>maxWorkerCount</c> is reached, no more
        /// workers will be assigned to process the job, even if the fleets assigned to the job's
        /// queue has available workers. You can't set the <c>maxWorkerCount</c> to 0. If you
        /// set it to -1, there is no maximum number of workers. If you don't specify the <c>maxWorkerCount</c>,
        /// Deadline Cloud won't throttle the number of workers used to process the job.
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property NameOverride. A custom name to override the job name derived
        /// from the job template.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string NameOverride { get; set; }

        /// <summary>
        /// Checks to see if the NameOverride property is set.
        /// </summary>
        internal bool IsSetNameOverride() => this.NameOverride != null;

        /// <summary>
        /// Gets and sets the property Parameters. The parameters for the job.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public Dictionary<string, JobParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, JobParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. The priority of the job. The highest priority
        /// (first scheduled) is 100. When two jobs have the same priority, the oldest job is
        /// scheduled first.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QueueId. The ID of the queue that the job is submitted
        /// to.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property SourceJobId. The job ID for the source job.
        /// </summary>
        public string SourceJobId { get; set; }

        /// <summary>
        /// Checks to see if the SourceJobId property is set.
        /// </summary>
        internal bool IsSetSourceJobId() => this.SourceJobId != null;

        /// <summary>
        /// Gets and sets the property StorageProfileId. The storage profile ID for the storage
        /// profile to connect to the job.
        /// </summary>
        public string StorageProfileId { get; set; }

        /// <summary>
        /// Checks to see if the StorageProfileId property is set.
        /// </summary>
        internal bool IsSetStorageProfileId() => this.StorageProfileId != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags to add to your job. Each tag consists of
        /// a tag key and a tag value. Tag keys and values are both required, but tag values can
        /// be empty strings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. The initial job status when it is
        /// created. Jobs that are created with a <c>SUSPENDED</c> status will not run until manually
        /// requeued.
        /// </summary>
        public CreateJobTargetTaskRunStatus TargetTaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetTaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTargetTaskRunStatus() => this.TargetTaskRunStatus != null;

        /// <summary>
        /// Gets and sets the property Template. The job template to use for this job.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000000)]
        public string Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => this.Template != null;

        /// <summary>
        /// Gets and sets the property TemplateType. The file type for the job template.
        /// </summary>
        public JobTemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;
    }
}
