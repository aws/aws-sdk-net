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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
    /// Container for the parameters to the CreateTask operation.
    /// Configures a <i>task</i>, which defines where and how DataSync transfers your data.
    /// 
    ///  
    /// <para>
    /// A task includes a source location, destination location, and transfer options (such
    /// as bandwidth limits, scheduling, and more).
    /// </para>
    ///  <important> 
    /// <para>
    /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
    /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
    /// pricing page</a> before you begin.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateTaskRequest : AmazonDataSyncRequest
    {
        private string _cloudWatchLogGroupArn;
        private string _destinationLocationArn;
        private List<FilterRule> _excludes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private List<FilterRule> _includes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private ManifestConfig _manifestConfig;
        private string _name;
        private Options _options;
        private TaskSchedule _schedule;
        private string _sourceLocationArn;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;
        private TaskReportConfig _taskReportConfig;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of an Amazon CloudWatch log group for monitoring
        /// your task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=562)]
        public string CloudWatchLogGroupArn
        {
            get { return this._cloudWatchLogGroupArn; }
            set { this._cloudWatchLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogGroupArn property is set
        internal bool IsSetCloudWatchLogGroupArn()
        {
            return this._cloudWatchLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationLocationArn. 
        /// <para>
        /// Specifies the ARN of your transfer's destination location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string DestinationLocationArn
        {
            get { return this._destinationLocationArn; }
            set { this._destinationLocationArn = value; }
        }

        // Check to see if DestinationLocationArn property is set
        internal bool IsSetDestinationLocationArn()
        {
            return this._destinationLocationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// Specifies exclude filters that define the files, objects, and folders in your source
        /// location that you don't want DataSync to transfer. For more information and examples,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<FilterRule> Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null && (this._excludes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// Specifies include filters define the files, objects, and folders in your source location
        /// that you want DataSync to transfer. For more information and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<FilterRule> Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null && (this._includes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public ManifestConfig ManifestConfig
        {
            get { return this._manifestConfig; }
            set { this._manifestConfig = value; }
        }

        // Check to see if ManifestConfig property is set
        internal bool IsSetManifestConfig()
        {
            return this._manifestConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of your task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Specifies your task's settings, such as preserving file metadata, verifying data integrity,
        /// among other options.
        /// </para>
        /// </summary>
        public Options Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Specifies a schedule for when you want your task to run. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">Scheduling
        /// your task</a>.
        /// </para>
        /// </summary>
        public TaskSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// Specifies the ARN of your transfer's source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string SourceLocationArn
        {
            get { return this._sourceLocationArn; }
            set { this._sourceLocationArn = value; }
        }

        // Check to see if SourceLocationArn property is set
        internal bool IsSetSourceLocationArn()
        {
            return this._sourceLocationArn != null;
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public TaskReportConfig TaskReportConfig
        {
            get { return this._taskReportConfig; }
            set { this._taskReportConfig = value; }
        }

        // Check to see if TaskReportConfig property is set
        internal bool IsSetTaskReportConfig()
        {
            return this._taskReportConfig != null;
        }

    }
}