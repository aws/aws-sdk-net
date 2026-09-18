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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object which defines the <c>resolutionType</c> and the <c>ruleBasedProperties</c>.
    /// </summary>
    public partial class ResolutionTechniques
    {
        /// <summary>
        /// Gets and sets the property EnableRealTimeMatching. 
        /// <para>
        /// Specifies whether real-time matching is enabled for the rule-based matching workflow.
        /// When you enable real-time matching, you can use the <c>GenerateMatchId</c> operation
        /// with the workflow.
        /// </para>
        /// </summary>
        public bool? EnableRealTimeMatching { get; set; }

        /// <summary>
        /// Checks to see if the EnableRealTimeMatching property is set.
        /// </summary>
        internal bool IsSetEnableRealTimeMatching() => this.EnableRealTimeMatching.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderProperties. 
        /// <para>
        /// The properties of the provider service.
        /// </para>
        /// </summary>
        public ProviderProperties ProviderProperties { get; set; }

        /// <summary>
        /// Checks to see if the ProviderProperties property is set.
        /// </summary>
        internal bool IsSetProviderProperties() => this.ProviderProperties != null;

        /// <summary>
        /// Gets and sets the property ResolutionType. 
        /// <para>
        /// The type of matching workflow to create. Specify one of the following types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RULE_MATCHING</c>: Match records using configurable rule-based criteria 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ML_MATCHING</c>: Match records using machine learning models 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVIDER</c>: Match records using a third-party matching provider
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResolutionType ResolutionType { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionType property is set.
        /// </summary>
        internal bool IsSetResolutionType() => this.ResolutionType != null;

        /// <summary>
        /// Gets and sets the property RuleBasedProperties. 
        /// <para>
        /// An object which defines the list of matching rules to run and has a field <c>rules</c>,
        /// which is a list of rule objects.
        /// </para>
        /// </summary>
        public RuleBasedProperties RuleBasedProperties { get; set; }

        /// <summary>
        /// Checks to see if the RuleBasedProperties property is set.
        /// </summary>
        internal bool IsSetRuleBasedProperties() => this.RuleBasedProperties != null;

        /// <summary>
        /// Gets and sets the property RuleConditionProperties. 
        /// <para>
        /// An object containing the <c>rules</c> for a matching workflow.
        /// </para>
        /// </summary>
        public RuleConditionProperties RuleConditionProperties { get; set; }

        /// <summary>
        /// Checks to see if the RuleConditionProperties property is set.
        /// </summary>
        internal bool IsSetRuleConditionProperties() => this.RuleConditionProperties != null;
    }
}
