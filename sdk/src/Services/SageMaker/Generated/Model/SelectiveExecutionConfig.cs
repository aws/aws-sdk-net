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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The selective execution configuration applied to the pipeline run.
    /// </summary>
    public partial class SelectiveExecutionConfig
    {
        private List<SelectedStep> _selectedSteps = AWSConfigs.InitializeCollections ? new List<SelectedStep>() : null;
        private string _sourcePipelineExecutionArn;

        /// <summary>
        /// Gets and sets the property SelectedSteps. 
        /// <para>
        /// A list of pipeline steps to run. All step(s) in all path(s) between two selected steps
        /// should be included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<SelectedStep> SelectedSteps
        {
            get { return this._selectedSteps; }
            set { this._selectedSteps = value; }
        }

        // Check to see if SelectedSteps property is set
        internal bool IsSetSelectedSteps()
        {
            return this._selectedSteps != null && (this._selectedSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePipelineExecutionArn. 
        /// <para>
        /// The ARN from a reference execution of the current pipeline. Used to copy input collaterals
        /// needed for the selected steps to run. The execution status of the pipeline can be
        /// either <c>Failed</c> or <c>Success</c>.
        /// </para>
        ///  
        /// <para>
        /// This field is required if the steps you specify for <c>SelectedSteps</c> depend on
        /// output collaterals from any non-specified pipeline steps. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-selective-ex.html">Selective
        /// Execution for Pipeline Steps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SourcePipelineExecutionArn
        {
            get { return this._sourcePipelineExecutionArn; }
            set { this._sourcePipelineExecutionArn = value; }
        }

        // Check to see if SourcePipelineExecutionArn property is set
        internal bool IsSetSourcePipelineExecutionArn()
        {
            return this._sourcePipelineExecutionArn != null;
        }

    }
}