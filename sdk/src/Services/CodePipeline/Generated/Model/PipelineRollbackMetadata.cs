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
    /// The metadata for the stage execution to be rolled back.
    /// </summary>
    public partial class PipelineRollbackMetadata
    {
        private string _rollbackTargetPipelineExecutionId;

        /// <summary>
        /// Gets and sets the property RollbackTargetPipelineExecutionId. 
        /// <para>
        /// The pipeline execution ID to which the stage will be rolled back.
        /// </para>
        /// </summary>
        public string RollbackTargetPipelineExecutionId
        {
            get { return this._rollbackTargetPipelineExecutionId; }
            set { this._rollbackTargetPipelineExecutionId = value; }
        }

        // Check to see if RollbackTargetPipelineExecutionId property is set
        internal bool IsSetRollbackTargetPipelineExecutionId()
        {
            return this._rollbackTargetPipelineExecutionId != null;
        }

    }
}