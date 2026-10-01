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
    /// Identifies logical issues in the translated statements that exist independent of any
    /// policy rules, such as statements that are always true or always false.
    /// </summary>
    public partial class AutomatedReasoningCheckLogicWarning
    {
        /// <summary>
        /// Gets and sets the property Claims. 
        /// <para>
        /// The logical statements that are validated while assuming the policy and premises.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedReasoningLogicStatement> Claims { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;

        /// <summary>
        /// Checks to see if the Claims property is set.
        /// </summary>
        internal bool IsSetClaims() => this.Claims != null && (this.Claims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Premises. 
        /// <para>
        /// The logical statements that serve as premises under which the claims are validated.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The category of the detected logical issue, such as statements that are always true
        /// or always false.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckLogicWarningType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
