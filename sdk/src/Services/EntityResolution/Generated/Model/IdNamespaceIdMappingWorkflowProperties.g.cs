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
    /// An object containing <c>idMappingType</c>, <c>providerProperties</c>, and <c>ruleBasedProperties</c>.
    /// </summary>
    public partial class IdNamespaceIdMappingWorkflowProperties
    {
        /// <summary>
        /// Gets and sets the property IdMappingType. 
        /// <para>
        /// The type of ID mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdMappingType IdMappingType { get; set; }

        /// <summary>
        /// Checks to see if the IdMappingType property is set.
        /// </summary>
        internal bool IsSetIdMappingType() => this.IdMappingType != null;

        /// <summary>
        /// Gets and sets the property ProviderProperties. 
        /// <para>
        /// An object which defines any additional configurations required by the provider service.
        /// </para>
        /// </summary>
        public NamespaceProviderProperties ProviderProperties { get; set; }

        /// <summary>
        /// Checks to see if the ProviderProperties property is set.
        /// </summary>
        internal bool IsSetProviderProperties() => this.ProviderProperties != null;

        /// <summary>
        /// Gets and sets the property RuleBasedProperties. 
        /// <para>
        ///  An object which defines any additional configurations required by rule-based matching.
        /// </para>
        /// </summary>
        public NamespaceRuleBasedProperties RuleBasedProperties { get; set; }

        /// <summary>
        /// Checks to see if the RuleBasedProperties property is set.
        /// </summary>
        internal bool IsSetRuleBasedProperties() => this.RuleBasedProperties != null;
    }
}
