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
    /// Container for the parameters to the UpdateTaskExecution operation.
    /// Modifies a running DataSync task.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, the only <code>Option</code> that you can modify with <code>UpdateTaskExecution</code>
    /// is <code> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
    /// </code>, which throttles bandwidth for a running or queued task.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateTaskExecutionRequest : AmazonDataSyncRequest
    {
        private Options _options;
        private string _taskExecutionArn;

        /// <summary>
        /// Gets and sets the property Options.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TaskExecutionArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the task execution that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string TaskExecutionArn
        {
            get { return this._taskExecutionArn; }
            set { this._taskExecutionArn = value; }
        }

        // Check to see if TaskExecutionArn property is set
        internal bool IsSetTaskExecutionArn()
        {
            return this._taskExecutionArn != null;
        }

    }
}