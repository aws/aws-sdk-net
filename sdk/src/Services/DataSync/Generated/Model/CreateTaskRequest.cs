/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTask operation.
    /// Creates a task. A task is a set of two locations (source and destination) and a set
    /// of default <code>OverrideOptions</code> that you use to control the behavior of a
    /// task. If you don't specify default values for <code>Options</code> when you create
    /// a task, AWS DataSync populates them with safe service defaults.
    /// 
    ///  
    /// <para>
    /// When you initially create a task, it enters the INITIALIZING status and then the CREATING
    /// status. In CREATING status, AWS DataSync attempts to mount the source Network File
    /// System (NFS) location. The task transitions to the AVAILABLE status without waiting
    /// for the destination location to mount. Instead, AWS DataSync mounts a destination
    /// before every task execution and then unmounts it after every task execution. 
    /// </para>
    ///  
    /// <para>
    /// If an agent that is associated with a source (NFS) location goes offline, the task
    /// transitions to the UNAVAILABLE status. If the status of the task remains in the CREATING
    /// status for more than a few minutes, it means that your agent might be having trouble
    /// mounting the source NFS file system. Check the task's <code>ErrorCode</code> and <code>ErrorDetail</code>.
    /// Mount issues are often caused by either a misconfigured firewall or a mistyped NFS
    /// server host name.
    /// </para>
    /// </summary>
    public partial class CreateTaskRequest : AmazonDataSyncRequest
    {
        private string _cloudWatchLogGroupArn;
        private string _destinationLocationArn;
        private string _name;
        private Options _options;
        private string _sourceLocationArn;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that is used to
        /// monitor and log events in the task. For more information on these groups, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html">Working
        /// with Log Groups and Log Streams</a> in the <i>Amazon CloudWatch User Guide. </i> 
        /// </para>
        ///  
        /// <para>
        /// For more information about how to useCloudWatchLogs with DataSync, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/monitor-datasync.html">Monitoring
        /// Your Task</a>.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of an AWS storage resource's location. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a task. This value is a text reference that is used to identify the task
        /// in the console. 
        /// </para>
        /// </summary>
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
        /// The set of configuration options that control the behavior of a single execution of
        /// the task that occurs when you call <code>StartTaskExecution</code>. You can configure
        /// these options to preserve metadata such as user ID (UID) and group ID (GID), file
        /// permissions, data integrity verification, and so on.
        /// </para>
        ///  
        /// <para>
        /// For each individual task execution, you can override these options by specifying the
        /// <code>OverrideOptions</code> before starting a the task execution. For more information,
        /// see the operation. 
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
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source location for the task.
        /// </para>
        /// </summary>
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
        /// The key-value pair that represents the tag that you want to add to the resource. The
        /// value can be an empty string. 
        /// </para>
        /// </summary>
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}