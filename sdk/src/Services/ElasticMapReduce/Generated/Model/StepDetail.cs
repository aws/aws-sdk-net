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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Combines the execution state and configuration of a step.
    /// </summary>
    public partial class StepDetail
    {
        private StepExecutionStatusDetail _executionStatusDetail;
        private StepConfig _stepConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StepDetail() { }

        /// <summary>
        /// Instantiates StepDetail with the parameterized properties
        /// </summary>
        /// <param name="stepConfig">The step configuration.</param>
        /// <param name="executionStatusDetail">The description of the step status.</param>
        public StepDetail(StepConfig stepConfig, StepExecutionStatusDetail executionStatusDetail)
        {
            _stepConfig = stepConfig;
            _executionStatusDetail = executionStatusDetail;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatusDetail. 
        /// <para>
        /// The description of the step status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StepExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this._executionStatusDetail; }
            set { this._executionStatusDetail = value; }
        }

        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this._executionStatusDetail != null;
        }

        /// <summary>
        /// Gets and sets the property StepConfig. 
        /// <para>
        /// The step configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StepConfig StepConfig
        {
            get { return this._stepConfig; }
            set { this._stepConfig = value; }
        }

        // Check to see if StepConfig property is set
        internal bool IsSetStepConfig()
        {
            return this._stepConfig != null;
        }

    }
}