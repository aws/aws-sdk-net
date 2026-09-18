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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains the logical translation of natural language input into formal logical statements,
    /// including premises, claims, and confidence scores.
    /// </summary>
    public partial class AutomatedReasoningCheckTranslation
    {
        /// <summary>
        /// Gets and sets the property Claims. 
        /// <para>
        /// The logical statements that are being validated against the premises and policy rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningLogicStatement> Claims { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;

        /// <summary>
        /// Checks to see if the Claims property is set.
        /// </summary>
        internal bool IsSetClaims() => this.Claims != null && (this.Claims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// A confidence score between 0 and 1 indicating how certain the system is about the
        /// logical translation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Premises. 
        /// <para>
        /// The logical statements that serve as the foundation or assumptions for the claims.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningLogicStatement> Premises { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;

        /// <summary>
        /// Checks to see if the Premises property is set.
        /// </summary>
        internal bool IsSetPremises() => this.Premises != null && (this.Premises.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UntranslatedClaims. 
        /// <para>
        /// References to portions of the original input text that correspond to the claims but
        /// could not be fully translated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckInputTextReference> UntranslatedClaims { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckInputTextReference>() : null;

        /// <summary>
        /// Checks to see if the UntranslatedClaims property is set.
        /// </summary>
        internal bool IsSetUntranslatedClaims() => this.UntranslatedClaims != null && (this.UntranslatedClaims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UntranslatedPremises. 
        /// <para>
        /// References to portions of the original input text that correspond to the premises
        /// but could not be fully translated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckInputTextReference> UntranslatedPremises { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckInputTextReference>() : null;

        /// <summary>
        /// Checks to see if the UntranslatedPremises property is set.
        /// </summary>
        internal bool IsSetUntranslatedPremises() => this.UntranslatedPremises != null && (this.UntranslatedPremises.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
