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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetMLTaskRun operation.
    /// Gets details for a specific task run on a machine learning transform. Machine learning
    /// task runs are asynchronous tasks that AWS Glue runs on your behalf as part of various
    /// machine learning workflows. You can check the stats of any task run by calling <code>GetMLTaskRun</code>
    /// with the <code>TaskRunID</code> and its parent transform's <code>TransformID</code>.
    /// </summary>
    public partial class GetMLTaskRunRequest : AmazonGlueRequest
    {
        private string _taskRunId;
        private string _transformId;

        /// <summary>
        /// Gets and sets the property TaskRunId. 
        /// <para>
        /// The unique identifier of the task run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TaskRunId
        {
            get { return this._taskRunId; }
            set { this._taskRunId = value; }
        }

        // Check to see if TaskRunId property is set
        internal bool IsSetTaskRunId()
        {
            return this._taskRunId != null;
        }

        /// <summary>
        /// Gets and sets the property TransformId. 
        /// <para>
        /// The unique identifier of the machine learning transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TransformId
        {
            get { return this._transformId; }
            set { this._transformId = value; }
        }

        // Check to see if TransformId property is set
        internal bool IsSetTransformId()
        {
            return this._transformId != null;
        }

    }
}