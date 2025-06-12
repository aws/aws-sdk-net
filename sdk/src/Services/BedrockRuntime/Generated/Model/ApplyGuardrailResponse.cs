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
    /// This is the response object from the ApplyGuardrail operation.
    /// </summary>
    public partial class ApplyGuardrailResponse : AmazonWebServiceResponse
    {
        private GuardrailAction _action;
        private string _actionReason;
        private List<GuardrailAssessment> _assessments = AWSConfigs.InitializeCollections ? new List<GuardrailAssessment>() : null;
        private GuardrailCoverage _guardrailCoverage;
        private List<GuardrailOutputContent> _outputs = AWSConfigs.InitializeCollections ? new List<GuardrailOutputContent>() : null;
        private GuardrailUsage _usage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken in the response from the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ActionReason. 
        /// <para>
        /// The reason for the action taken when harmful content is detected.
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
        /// Gets and sets the property Assessments. 
        /// <para>
        /// The assessment details in the response from the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GuardrailAssessment> Assessments
        {
            get { return this._assessments; }
            set { this._assessments = value; }
        }

        // Check to see if Assessments property is set
        internal bool IsSetAssessments()
        {
            return this._assessments != null && (this._assessments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailCoverage. 
        /// <para>
        /// The guardrail coverage details in the apply guardrail response.
        /// </para>
        /// </summary>
        public GuardrailCoverage GuardrailCoverage
        {
            get { return this._guardrailCoverage; }
            set { this._guardrailCoverage = value; }
        }

        // Check to see if GuardrailCoverage property is set
        internal bool IsSetGuardrailCoverage()
        {
            return this._guardrailCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The output details in the response from the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GuardrailOutputContent> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The usage details in the response from the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailUsage Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}