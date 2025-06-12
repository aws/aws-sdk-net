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
    /// Container for the parameters to the UpdateTask operation.
    /// Updates the configuration of a <i>task</i>, which defines where and how DataSync transfers
    /// your data.
    /// </summary>
    public partial class UpdateTaskRequest : AmazonDataSyncRequest
    {
        private string _cloudWatchLogGroupArn;
        private List<FilterRule> _excludes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private List<FilterRule> _includes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private ManifestConfig _manifestConfig;
        private string _name;
        private Options _options;
        private TaskSchedule _schedule;
        private string _taskArn;
        private TaskReportConfig _taskReportConfig;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of an Amazon CloudWatch log group for monitoring
        /// your task.
        /// </para>
        ///  
        /// <para>
        /// For Enhanced mode tasks, you must use <c>/aws/datasync</c> as your log group name.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:us-east-1:111222333444:log-group:/aws/datasync:*</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-logging.html">Monitoring
        /// data transfers with CloudWatch Logs</a>.
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
        /// Gets and sets the property Excludes. 
        /// <para>
        /// Specifies exclude filters that define the files, objects, and folders in your source
        /// location that you don't want DataSync to transfer. For more information and examples,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// Specifies include filters define the files, objects, and folders in your source location
        /// that you want DataSync to transfer. For more information and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// When using this parameter, your caller identity (the IAM role that you're using DataSync
        /// with) must have the <c>iam:PassRole</c> permission. The <a href="https://docs.aws.amazon.com/datasync/latest/userguide/security-iam-awsmanpol.html#security-iam-awsmanpol-awsdatasyncfullaccess">AWSDataSyncFullAccess</a>
        /// policy includes this permission.
        /// </para>
        ///  
        /// <para>
        /// To remove a manifest configuration, specify this parameter as empty.
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// Specifies the ARN of the task that you want to update.
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
        /// When using this parameter, your caller identity (the IAM role that you're using DataSync
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