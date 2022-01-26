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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The prediction explanations that provide insight into how each event variable impacted
    /// the model version's fraud prediction score.
    /// </summary>
    public partial class PredictionExplanations
    {
        private List<VariableImpactExplanation> _variableImpactExplanations = new List<VariableImpactExplanation>();

        /// <summary>
        /// Gets and sets the property VariableImpactExplanations. 
        /// <para>
        ///  The details of the event variable's impact on the prediction score. 
        /// </para>
        /// </summary>
        public List<VariableImpactExplanation> VariableImpactExplanations
        {
            get { return this._variableImpactExplanations; }
            set { this._variableImpactExplanations = value; }
        }

        // Check to see if VariableImpactExplanations property is set
        internal bool IsSetVariableImpactExplanations()
        {
            return this._variableImpactExplanations != null && this._variableImpactExplanations.Count > 0; 
        }

    }
}