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
    /// Starts a specific invocation of a task. A <code>TaskExecution</code> value represents
    /// an individual run of a task. Each task can have at most one <code>TaskExecution</code>
    /// at a time.
    /// 
    ///  
    /// <para>
    ///  <code>TaskExecution</code> has the following transition phases: INITIALIZING | PREPARING
    /// | TRANSFERRING | VERIFYING | SUCCESS/FAILURE. 
    /// </para>
    ///  
    /// <para>
    /// For detailed information, see the Task Execution section in the Components and Terminology
    /// topic in the <i>DataSync User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartTaskExecutionRequest : AmazonDataSyncRequest
    {
        private List<FilterRule> _excludes = new List<FilterRule>();
        private List<FilterRule> _includes = new List<FilterRule>();
        private Options _overrideOptions;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// A list of filter rules that determines which files to exclude from a task. The list
        /// should contain a single filter string that consists of the patterns to exclude. The
        /// patterns are delimited by "|" (that is, a pipe), for example, <code>"/folder1|/folder2"</code>.
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
        /// A list of filter rules that determines which files to include when running a task.
        /// The pattern should contain a single filter string that consists of the patterns to
        /// include. The patterns are delimited by "|" (that is, a pipe). For example: <code>"/folder1|/folder2"</code>
        /// 
        /// </para>
        ///  
        /// <para>
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task to start.
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