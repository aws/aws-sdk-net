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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ReportTaskProgress operation.
    /// Task runners call <c>ReportTaskProgress</c> when assigned a task to acknowledge that
    /// it has the task. If the web service does not receive this acknowledgement within 2
    /// minutes, it assigns the task in a subsequent <a>PollForTask</a> call. After this initial
    /// acknowledgement, the task runner only needs to report progress every 15 minutes to
    /// maintain its ownership of the task. You can change this reporting time from 15 minutes
    /// by specifying a <c>reportProgressTimeout</c> field in your pipeline.
    /// 
    ///  
    /// <para>
    /// If a task runner does not report its status after 5 minutes, AWS Data Pipeline assumes
    /// that the task runner is unable to process the task and reassigns the task in a subsequent
    /// response to <a>PollForTask</a>. Task runners should call <c>ReportTaskProgress</c>
    /// every 60 seconds.
    /// </para>
    /// </summary>
    public partial class ReportTaskProgressRequest : AmazonDataPipelineRequest
    {
        private List<Field> _fields = AWSConfigs.InitializeCollections ? new List<Field>() : null;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// Key-value pairs that define the properties of the ReportTaskProgressInput object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task assigned to the task runner. This value is provided in the response
        /// for <a>PollForTask</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}