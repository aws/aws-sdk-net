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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the StartTaskExecution operation.
    /// Starts an DataSync task. For each task, you can only run one task execution at a time.
    /// 
    ///  
    /// <para>
    /// There are several phases to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
    /// execution statuses</a>.
    /// </para>
    /// </summary>
    public partial class StartTaskExecutionRequest : AmazonDataSyncRequest
    {
        private List<FilterRule> _excludes = new List<FilterRule>();
        private List<FilterRule> _includes = new List<FilterRule>();
        private Options _overrideOptions;
        private List<TagListEntry> _tags = new List<TagListEntry>();
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// Specifies a list of filter rules that determines which files to exclude from a task.
        /// The list contains a single filter string that consists of the patterns to exclude.
        /// The patterns are delimited by "|" (that is, a pipe), for example, <code>"/folder1|/folder2"</code>.
        /// 
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
            return this._excludes != null && this._excludes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// Specifies a list of filter rules that determines which files to include when running
        /// a task. The pattern should contain a single filter string that consists of the patterns
        /// to include. The patterns are delimited by "|" (that is, a pipe), for example, <code>"/folder1|/folder2"</code>.
        /// 
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
            return this._includes != null && this._includes.Count > 0; 
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
            return this._tags != null && this._tags.Count > 0; 
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

    }
}