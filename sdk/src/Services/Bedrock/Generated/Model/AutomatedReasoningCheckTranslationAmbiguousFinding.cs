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
    /// Indicates that the input has multiple valid logical interpretations, requiring additional
    /// context or clarification.
    /// </summary>
    public partial class AutomatedReasoningCheckTranslationAmbiguousFinding
    {
        private List<AutomatedReasoningCheckScenario> _differenceScenarios = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckScenario>() : null;
        private List<AutomatedReasoningCheckTranslationOption> _options = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckTranslationOption>() : null;

        /// <summary>
        /// Gets and sets the property DifferenceScenarios. 
        /// <para>
        /// Scenarios showing how the different translation options differ in meaning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<AutomatedReasoningCheckScenario> DifferenceScenarios
        {
            get { return this._differenceScenarios; }
            set { this._differenceScenarios = value; }
        }

        // Check to see if DifferenceScenarios property is set
        internal bool IsSetDifferenceScenarios()
        {
            return this._differenceScenarios != null && (this._differenceScenarios.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Different logical interpretations that were detected during translation of the input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<AutomatedReasoningCheckTranslationOption> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}