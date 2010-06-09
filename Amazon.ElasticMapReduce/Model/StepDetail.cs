/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    ///Additional detail about a step.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class StepDetail
    {
        private StepConfig stepConfigField;
        private StepExecutionStatusDetail executionStatusDetailField;

        /// <summary>
        /// Gets and sets the StepConfig property.
        /// Step configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "StepConfig")]
        public StepConfig StepConfig
        {
            get { return this.stepConfigField ; }
            set { this.stepConfigField = value; }
        }

        /// <summary>
        /// Sets the StepConfig property
        /// </summary>
        /// <param name="stepConfig">Step configuration.</param>
        /// <returns>this instance</returns>
        public StepDetail WithStepConfig(StepConfig stepConfig)
        {
            this.stepConfigField = stepConfig;
            return this;
        }

        /// <summary>
        /// Checks if StepConfig property is set
        /// </summary>
        /// <returns>true if StepConfig property is set</returns>
        public bool IsSetStepConfig()
        {
            return this.stepConfigField != null;
        }

        /// <summary>
        /// Gets and sets the ExecutionStatusDetail property.
        /// Description of execution status.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExecutionStatusDetail")]
        public StepExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this.executionStatusDetailField ; }
            set { this.executionStatusDetailField = value; }
        }

        /// <summary>
        /// Sets the ExecutionStatusDetail property
        /// </summary>
        /// <param name="executionStatusDetail">Description of execution status.</param>
        /// <returns>this instance</returns>
        public StepDetail WithExecutionStatusDetail(StepExecutionStatusDetail executionStatusDetail)
        {
            this.executionStatusDetailField = executionStatusDetail;
            return this;
        }

        /// <summary>
        /// Checks if ExecutionStatusDetail property is set
        /// </summary>
        /// <returns>true if ExecutionStatusDetail property is set</returns>
        public bool IsSetExecutionStatusDetail()
        {
            return this.executionStatusDetailField != null;
        }

    }
}
