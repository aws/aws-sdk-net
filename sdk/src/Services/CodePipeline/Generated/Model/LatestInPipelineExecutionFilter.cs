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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The field that specifies to filter on the latest execution in the pipeline.
    /// 
    ///  <note> 
    /// <para>
    /// Filtering on the latest execution is available for executions run on or after February
    /// 08, 2024.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LatestInPipelineExecutionFilter
    {
        private string _pipelineExecutionId;
        private StartTimeRange _startTimeRange;

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The execution ID for the latest execution in the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeRange. 
        /// <para>
        /// The start time to filter on for the latest execution in the pipeline. Valid options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latest
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StartTimeRange StartTimeRange
        {
            get { return this._startTimeRange; }
            set { this._startTimeRange = value; }
        }

        // Check to see if StartTimeRange property is set
        internal bool IsSetStartTimeRange()
        {
            return this._startTimeRange != null;
        }

    }
}