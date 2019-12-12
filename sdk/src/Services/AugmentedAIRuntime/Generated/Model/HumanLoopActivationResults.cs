/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Information about the corresponding flow definition's human loop activation condition
    /// evaluation. Null if <code>StartHumanLoop</code> was invoked directly.
    /// </summary>
    public partial class HumanLoopActivationResults
    {
        private string _humanLoopActivationConditionsEvaluationResults;
        private HumanLoopActivationReason _humanLoopActivationReason;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConditionsEvaluationResults. 
        /// <para>
        /// A copy of the human loop activation conditions of the flow definition, augmented with
        /// the results of evaluating those conditions on the input provided to the <code>StartHumanLoop</code>
        /// operation.
        /// </para>
        /// </summary>
        public string HumanLoopActivationConditionsEvaluationResults
        {
            get { return this._humanLoopActivationConditionsEvaluationResults; }
            set { this._humanLoopActivationConditionsEvaluationResults = value; }
        }

        // Check to see if HumanLoopActivationConditionsEvaluationResults property is set
        internal bool IsSetHumanLoopActivationConditionsEvaluationResults()
        {
            return this._humanLoopActivationConditionsEvaluationResults != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopActivationReason. 
        /// <para>
        /// An object containing information about why a human loop was triggered.
        /// </para>
        /// </summary>
        public HumanLoopActivationReason HumanLoopActivationReason
        {
            get { return this._humanLoopActivationReason; }
            set { this._humanLoopActivationReason = value; }
        }

        // Check to see if HumanLoopActivationReason property is set
        internal bool IsSetHumanLoopActivationReason()
        {
            return this._humanLoopActivationReason != null;
        }

    }
}