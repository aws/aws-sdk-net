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
    /// Defines under what conditions SageMaker creates a human loop. Used within <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateFlowDefinition.html">CreateFlowDefinition</a>.
    /// See <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HumanLoopActivationConditionsConfig.html">HumanLoopActivationConditionsConfig</a>
    /// for the required format of activation conditions.
    /// </summary>
    public partial class HumanLoopActivationConditionsConfig
    {
        private string _humanLoopActivationConditions;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConditions. 
        /// <para>
        /// JSON expressing use-case specific conditions declaratively. If any condition is matched,
        /// atomic tasks are created against the configured work team. The set of conditions is
        /// different for Rekognition and Textract. For more information about how to structure
        /// the JSON, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-human-fallback-conditions-json-schema.html">JSON
        /// Schema for Human Loop Activation Conditions in Amazon Augmented AI</a> in the <i>Amazon
        /// SageMaker Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10240)]
        public string HumanLoopActivationConditions
        {
            get { return this._humanLoopActivationConditions; }
            set { this._humanLoopActivationConditions = value; }
        }

        // Check to see if HumanLoopActivationConditions property is set
        internal bool IsSetHumanLoopActivationConditions()
        {
            return this._humanLoopActivationConditions != null;
        }

    }
}