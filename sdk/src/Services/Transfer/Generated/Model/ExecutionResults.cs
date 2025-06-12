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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the steps in the workflow, as well as the steps to execute in case of any
    /// errors during workflow execution.
    /// </summary>
    public partial class ExecutionResults
    {
        private List<ExecutionStepResult> _onExceptionSteps = AWSConfigs.InitializeCollections ? new List<ExecutionStepResult>() : null;
        private List<ExecutionStepResult> _steps = AWSConfigs.InitializeCollections ? new List<ExecutionStepResult>() : null;

        /// <summary>
        /// Gets and sets the property OnExceptionSteps. 
        /// <para>
        /// Specifies the steps (actions) to take if errors are encountered during execution of
        /// the workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<ExecutionStepResult> OnExceptionSteps
        {
            get { return this._onExceptionSteps; }
            set { this._onExceptionSteps = value; }
        }

        // Check to see if OnExceptionSteps property is set
        internal bool IsSetOnExceptionSteps()
        {
            return this._onExceptionSteps != null && (this._onExceptionSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// Specifies the details for the steps that are in the specified workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<ExecutionStepResult> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}