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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A Top level guardrail trace object. For more information, see <a>ConverseTrace</a>.
    /// </summary>
    public partial class GuardrailTraceAssessment
    {
        private string _actionReason;
        private Dictionary<string, GuardrailAssessment> _inputAssessment = AWSConfigs.InitializeCollections ? new Dictionary<string, GuardrailAssessment>() : null;
        private List<string> _modelOutput = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, List<GuardrailAssessment>> _outputAssessments = AWSConfigs.InitializeCollections ? new Dictionary<string, List<GuardrailAssessment>>() : null;

        /// <summary>
        /// Gets and sets the property ActionReason. 
        /// <para>
        /// Provides the reason for the action taken when harmful content is detected.
        /// </para>
        /// </summary>
        public string ActionReason
        {
            get { return this._actionReason; }
            set { this._actionReason = value; }
        }

        // Check to see if ActionReason property is set
        internal bool IsSetActionReason()
        {
            return this._actionReason != null;
        }

        /// <summary>
        /// Gets and sets the property InputAssessment. 
        /// <para>
        /// The input assessment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GuardrailAssessment> InputAssessment
        {
            get { return this._inputAssessment; }
            set { this._inputAssessment = value; }
        }

        // Check to see if InputAssessment property is set
        internal bool IsSetInputAssessment()
        {
            return this._inputAssessment != null && (this._inputAssessment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelOutput. 
        /// <para>
        /// The output from the model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ModelOutput
        {
            get { return this._modelOutput; }
            set { this._modelOutput = value; }
        }

        // Check to see if ModelOutput property is set
        internal bool IsSetModelOutput()
        {
            return this._modelOutput != null && (this._modelOutput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputAssessments. 
        /// <para>
        /// the output assessments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<GuardrailAssessment>> OutputAssessments
        {
            get { return this._outputAssessments; }
            set { this._outputAssessments = value; }
        }

        // Check to see if OutputAssessments property is set
        internal bool IsSetOutputAssessments()
        {
            return this._outputAssessments != null && (this._outputAssessments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}