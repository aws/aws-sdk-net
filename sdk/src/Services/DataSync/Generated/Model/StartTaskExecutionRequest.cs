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
    /// Container for the parameters to the StartTaskExecution operation.
    /// Starts an DataSync transfer task. For each task, you can only run one task execution
    /// at a time.
    /// 
    ///  
    /// <para>
    /// There are several steps to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
    /// execution statuses</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
    /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
    /// pricing page</a> before you begin.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartTaskExecutionRequest : AmazonDataSyncRequest
    {
        private List<FilterRule> _excludes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private List<FilterRule> _includes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private ManifestConfig _manifestConfig;
        private Options _overrideOptions;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;
        private string _taskArn;
        private TaskReportConfig _taskReportConfig;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// Specifies a list of filter rules that determines which files to exclude from a task.
        /// The list contains a single filter string that consists of the patterns to exclude.
        /// The patterns are delimited by "|" (that is, a pipe), for example, <c>"/folder1|/folder2"</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Specifies a list of filter rules that determines which files to include when running
        /// a task. The pattern should contain a single filter string that consists of the patterns
        /// to include. The patterns are delimited by "|" (that is, a pipe), for example, <c>"/folder1|/folder2"</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        ///  
        /// <para>
        /// To remove a manifest configuration, specify this parameter with an empty value.
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
        /// Gets and sets the property OverrideOptions.
        /// </summary>
        public Options OverrideOptions
        {
            get { return this._overrideOptions; }
            set { this._overrideOptions = value; }
        }

        // Check to see if OverrideOptions property is set
        internal bool IsSetOverrideOptions()
        {
            return this._overrideOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags that you want to apply to the Amazon Resource Name (ARN) representing
        /// the task execution.
        /// </para>
        ///  
        /// <para>
        ///  <i>Tags</i> are key-value pairs that help you manage, filter, and search for your
        /// DataSync resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the task that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
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
        ///  
        /// <para>
        /// To remove a task report configuration, specify this parameter as empty.
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