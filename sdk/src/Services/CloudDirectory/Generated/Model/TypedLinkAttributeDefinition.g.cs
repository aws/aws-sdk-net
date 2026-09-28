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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// A typed link attribute definition.
    /// </summary>
    public partial class TypedLinkAttributeDefinition
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the attribute (if configured).
        /// </para>
        /// </summary>
        public TypedAttributeValue DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property IsImmutable. 
        /// <para>
        /// Whether the attribute is mutable or not.
        /// </para>
        /// </summary>
        public bool? IsImmutable { get; set; }

        /// <summary>
        /// Checks to see if the IsImmutable property is set.
        /// </summary>
        internal bool IsSetIsImmutable() => this.IsImmutable.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the typed link attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 230)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequiredBehavior. 
        /// <para>
        /// The required behavior of the <c>TypedLinkAttributeDefinition</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RequiredAttributeBehavior RequiredBehavior { get; set; }

        /// <summary>
        /// Checks to see if the RequiredBehavior property is set.
        /// </summary>
        internal bool IsSetRequiredBehavior() => this.RequiredBehavior != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Validation rules that are attached to the attribute definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FacetAttributeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
