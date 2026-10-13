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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The model version evalutions.
    /// </summary>
    public partial class ModelVersionEvaluation
    {
        /// <summary>
        /// Gets and sets the property EvaluationScore. 
        /// <para>
        ///  The evaluation score generated for the model version. 
        /// </para>
        /// </summary>
        public string EvaluationScore { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationScore property is set.
        /// </summary>
        internal bool IsSetEvaluationScore() => this.EvaluationScore != null;

        /// <summary>
        /// Gets and sets the property OutputVariableName. 
        /// <para>
        ///  The output variable name. 
        /// </para>
        /// </summary>
        public string OutputVariableName { get; set; }

        /// <summary>
        /// Checks to see if the OutputVariableName property is set.
        /// </summary>
        internal bool IsSetOutputVariableName() => this.OutputVariableName != null;

        /// <summary>
        /// Gets and sets the property PredictionExplanations. 
        /// <para>
        ///  The prediction explanations generated for the model version. 
        /// </para>
        /// </summary>
        public PredictionExplanations PredictionExplanations { get; set; }

        /// <summary>
        /// Checks to see if the PredictionExplanations property is set.
        /// </summary>
        internal bool IsSetPredictionExplanations() => this.PredictionExplanations != null;
    }
}
