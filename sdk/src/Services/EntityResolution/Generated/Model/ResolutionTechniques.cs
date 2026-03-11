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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
        private ProviderProperties _providerProperties;
        private ResolutionType _resolutionType;
        private RuleBasedProperties _ruleBasedProperties;
        private RuleConditionProperties _ruleConditionProperties;

        /// <summary>
        /// Gets and sets the property ProviderProperties. 
        /// <para>
        /// The properties of the provider service.
        /// </para>
        /// </summary>
        public ProviderProperties ProviderProperties
        {
            get { return this._providerProperties; }
            set { this._providerProperties = value; }
        }

        // Check to see if ProviderProperties property is set
        internal bool IsSetProviderProperties()
        {
            return this._providerProperties != null;
        }

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
        [AWSProperty(Required=true)]
        public ResolutionType ResolutionType
        {
            get { return this._resolutionType; }
            set { this._resolutionType = value; }
        }

        // Check to see if ResolutionType property is set
        internal bool IsSetResolutionType()
        {
            return this._resolutionType != null;
        }

        /// <summary>
        /// Gets and sets the property RuleBasedProperties. 
        /// <para>
        /// An object which defines the list of matching rules to run and has a field <c>rules</c>,
        /// which is a list of rule objects.
        /// </para>
        /// </summary>
        public RuleBasedProperties RuleBasedProperties
        {
            get { return this._ruleBasedProperties; }
            set { this._ruleBasedProperties = value; }
        }

        // Check to see if RuleBasedProperties property is set
        internal bool IsSetRuleBasedProperties()
        {
            return this._ruleBasedProperties != null;
        }

        /// <summary>
        /// Gets and sets the property RuleConditionProperties. 
        /// <para>
        /// An object containing the <c>rules</c> for a matching workflow.
        /// </para>
        /// </summary>
        public RuleConditionProperties RuleConditionProperties
        {
            get { return this._ruleConditionProperties; }
            set { this._ruleConditionProperties = value; }
        }

        // Check to see if RuleConditionProperties property is set
        internal bool IsSetRuleConditionProperties()
        {
            return this._ruleConditionProperties != null;
        }

    }
}