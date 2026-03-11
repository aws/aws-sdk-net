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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private List<AutomatedReasoningLogicStatement> _claims = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;
        private double? _confidence;
        private List<AutomatedReasoningLogicStatement> _premises = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;
        private List<AutomatedReasoningCheckInputTextReference> _untranslatedClaims = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckInputTextReference>() : null;
        private List<AutomatedReasoningCheckInputTextReference> _untranslatedPremises = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckInputTextReference>() : null;

        /// <summary>
        /// Gets and sets the property Claims. 
        /// <para>
        /// The logical statements that are being validated against the premises and policy rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningLogicStatement> Claims
        {
            get { return this._claims; }
            set { this._claims = value; }
        }

        // Check to see if Claims property is set
        internal bool IsSetClaims()
        {
            return this._claims != null && (this._claims.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// A confidence score between 0 and 1 indicating how certain the system is about the
        /// logical translation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Premises. 
        /// <para>
        /// The logical statements that serve as the foundation or assumptions for the claims.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningLogicStatement> Premises
        {
            get { return this._premises; }
            set { this._premises = value; }
        }

        // Check to see if Premises property is set
        internal bool IsSetPremises()
        {
            return this._premises != null && (this._premises.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UntranslatedClaims. 
        /// <para>
        /// References to portions of the original input text that correspond to the claims but
        /// could not be fully translated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckInputTextReference> UntranslatedClaims
        {
            get { return this._untranslatedClaims; }
            set { this._untranslatedClaims = value; }
        }

        // Check to see if UntranslatedClaims property is set
        internal bool IsSetUntranslatedClaims()
        {
            return this._untranslatedClaims != null && (this._untranslatedClaims.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UntranslatedPremises. 
        /// <para>
        /// References to portions of the original input text that correspond to the premises
        /// but could not be fully translated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningCheckInputTextReference> UntranslatedPremises
        {
            get { return this._untranslatedPremises; }
            set { this._untranslatedPremises = value; }
        }

        // Check to see if UntranslatedPremises property is set
        internal bool IsSetUntranslatedPremises()
        {
            return this._untranslatedPremises != null && (this._untranslatedPremises.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}