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
    /// An object containing <c>idMappingType</c>, <c>providerProperties</c>, and <c>ruleBasedProperties</c>.
    /// </summary>
    public partial class IdNamespaceIdMappingWorkflowProperties
    {
        private IdMappingType _idMappingType;
        private NamespaceProviderProperties _providerProperties;
        private NamespaceRuleBasedProperties _ruleBasedProperties;

        /// <summary>
        /// Gets and sets the property IdMappingType. 
        /// <para>
        /// The type of ID mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdMappingType IdMappingType
        {
            get { return this._idMappingType; }
            set { this._idMappingType = value; }
        }

        // Check to see if IdMappingType property is set
        internal bool IsSetIdMappingType()
        {
            return this._idMappingType != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderProperties. 
        /// <para>
        /// An object which defines any additional configurations required by the provider service.
        /// </para>
        /// </summary>
        public NamespaceProviderProperties ProviderProperties
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
        /// Gets and sets the property RuleBasedProperties. 
        /// <para>
        ///  An object which defines any additional configurations required by rule-based matching.
        /// </para>
        /// </summary>
        public NamespaceRuleBasedProperties RuleBasedProperties
        {
            get { return this._ruleBasedProperties; }
            set { this._ruleBasedProperties = value; }
        }

        // Check to see if RuleBasedProperties property is set
        internal bool IsSetRuleBasedProperties()
        {
            return this._ruleBasedProperties != null;
        }

    }
}