/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Combines the execution state and configuration of a step.</para>
    /// </summary>
    public class StepDetail  
    {
        
        private StepConfig stepConfig;
        private StepExecutionStatusDetail executionStatusDetail;

        /// <summary>
        /// The step configuration.
        ///  
        /// </summary>
        public StepConfig StepConfig
        {
            get { return this.stepConfig; }
            set { this.stepConfig = value; }
        }

        /// <summary>
        /// Sets the StepConfig property
        /// </summary>
        /// <param name="stepConfig">The value to set for the StepConfig property </param>
        /// <returns>this instance</returns>
        public StepDetail WithStepConfig(StepConfig stepConfig)
        {
            this.stepConfig = stepConfig;
            return this;
        }
            
        // Check to see if StepConfig property is set
        internal bool IsSetStepConfig()
        {
            return this.stepConfig != null;         
        }

        /// <summary>
        /// The description of the step status.
        ///  
        /// </summary>
        public StepExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this.executionStatusDetail; }
            set { this.executionStatusDetail = value; }
        }

        /// <summary>
        /// Sets the ExecutionStatusDetail property
        /// </summary>
        /// <param name="executionStatusDetail">The value to set for the ExecutionStatusDetail property </param>
        /// <returns>this instance</returns>
        public StepDetail WithExecutionStatusDetail(StepExecutionStatusDetail executionStatusDetail)
        {
            this.executionStatusDetail = executionStatusDetail;
            return this;
        }
            
        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this.executionStatusDetail != null;      
        }
    }
}
