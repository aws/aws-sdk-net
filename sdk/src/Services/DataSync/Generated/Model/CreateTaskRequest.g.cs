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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTask operation. Configures a <i>task</i>,
    /// which defines where and how DataSync transfers your data. <para> A task includes a
    /// source location, destination location, and transfer options (such as bandwidth limits,
    /// scheduling, and more). </para> <important> <para> If you're planning to transfer data
    /// to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
    /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
    /// pricing page</a> before you begin. </para> </important>
    /// </summary>
    public partial class CreateTaskRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of an Amazon CloudWatch log group for monitoring
        /// your task.
        /// </para>
        ///  
        /// <para>
        /// For Enhanced mode tasks, you don't need to specify anything. DataSync automatically
        /// sends logs to a CloudWatch log group named <c>/aws/datasync</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 562)]
        public string CloudWatchLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupArn() => this.CloudWatchLogGroupArn != null;

        /// <summary>
        /// Gets and sets the property DestinationLocationArn. 
        /// <para>
        /// Specifies the ARN of your transfer's destination location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string DestinationLocationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationLocationArn property is set.
        /// </summary>
        internal bool IsSetDestinationLocationArn() => this.DestinationLocationArn != null;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// Specifies exclude filters that define the files, objects, and folders in your source
        /// location that you don't want DataSync to transfer. For more information and examples,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FilterRule> Excludes { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;

        /// <summary>
        /// Checks to see if the Excludes property is set.
        /// </summary>
        internal bool IsSetExcludes() => this.Excludes != null && (this.Excludes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// Specifies include filters that define the files, objects, and folders in your source
        /// location that you want DataSync to transfer. For more information and examples, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FilterRule> Includes { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;

        /// <summary>
        /// Checks to see if the Includes property is set.
        /// </summary>
        internal bool IsSetIncludes() => this.Includes != null && (this.Includes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManifestConfig. 
        /// <para>
        /// Configures a manifest, which is a list of files or objects that you want DataSync
        /// to transfer. For more information and configuration examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
        /// what DataSync transfers by using a manifest</a>.
        /// </para>
        ///  
        /// <para>
        /// When using this parameter, your caller identity (the role that you're using DataSync
        /// with) must have the <c>iam:PassRole</c> permission. The <a href="https://docs.aws.amazon.com/datasync/latest/userguide/security-iam-awsmanpol.html#security-iam-awsmanpol-awsdatasyncfullaccess">AWSDataSyncFullAccess</a>
        /// policy includes this permission.
        /// </para>
        /// </summary>
        public ManifestConfig ManifestConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManifestConfig property is set.
        /// </summary>
        internal bool IsSetManifestConfig() => this.ManifestConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of your task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Specifies your task's settings, such as preserving file metadata, verifying data integrity,
        /// among other options.
        /// </para>
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Specifies a schedule for when you want your task to run. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">Scheduling
        /// your task</a>.
        /// </para>
        /// </summary>
        public TaskSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// Specifies the ARN of your transfer's source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string SourceLocationArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationArn property is set.
        /// </summary>
        internal bool IsSetSourceLocationArn() => this.SourceLocationArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags that you want to apply to your task.
        /// </para>
        ///  
        /// <para>
        ///  <i>Tags</i> are key-value pairs that help you manage, filter, and search for your
        /// DataSync resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TagListEntry> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskMode. 
        /// <para>
        /// Specifies one of the following task modes for your data transfer:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENHANCED</c> - Transfer virtually unlimited numbers of objects with higher performance
        /// than Basic mode. Enhanced mode tasks optimize the data transfer process by listing,
        /// preparing, transferring, and verifying data in parallel. Enhanced mode is currently
        /// available for transfers between Amazon S3 locations, transfers between Azure Blob
        /// and Amazon S3 without an agent, and transfers between other clouds and Amazon S3 without
        /// an agent.
        /// </para>
        ///  <note> 
        /// <para>
        /// To create an Enhanced mode task, the IAM role that you use to call the <c>CreateTask</c>
        /// operation must have the <c>iam:CreateServiceLinkedRole</c> permission.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>BASIC</c> (default) - Transfer files or objects between Amazon Web Services storage
        /// and all other supported DataSync locations. Basic mode tasks are subject to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-limits.html">quotas</a>
        /// on the number of files, objects, and directories in a dataset. Basic mode sequentially
        /// prepares, transfers, and verifies data, making it slower than Enhanced mode for most
        /// workloads.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html#task-mode-differences">Understanding
        /// task mode differences</a>.
        /// </para>
        /// </summary>
        public TaskMode TaskMode { get; set; }

        /// <summary>
        /// Checks to see if the TaskMode property is set.
        /// </summary>
        internal bool IsSetTaskMode() => this.TaskMode != null;

        /// <summary>
        /// Gets and sets the property TaskReportConfig. 
        /// <para>
        /// Specifies how you want to configure a task report, which provides detailed information
        /// about your DataSync transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Monitoring
        /// your DataSync transfers with task reports</a>.
        /// </para>
        ///  
        /// <para>
        /// When using this parameter, your caller identity (the role that you're using DataSync
        /// with) must have the <c>iam:PassRole</c> permission. The <a href="https://docs.aws.amazon.com/datasync/latest/userguide/security-iam-awsmanpol.html#security-iam-awsmanpol-awsdatasyncfullaccess">AWSDataSyncFullAccess</a>
        /// policy includes this permission.
        /// </para>
        /// </summary>
        public TaskReportConfig TaskReportConfig { get; set; }

        /// <summary>
        /// Checks to see if the TaskReportConfig property is set.
        /// </summary>
        internal bool IsSetTaskReportConfig() => this.TaskReportConfig != null;
    }
}
