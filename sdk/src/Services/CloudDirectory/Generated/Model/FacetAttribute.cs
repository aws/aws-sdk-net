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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
    /// An attribute that is associated with the <a>Facet</a>.
    /// </summary>
    public partial class FacetAttribute
    {
        private FacetAttributeDefinition _attributeDefinition;
        private FacetAttributeReference _attributeReference;
        private string _name;
        private RequiredAttributeBehavior _requiredBehavior;

        /// <summary>
        /// Gets and sets the property AttributeDefinition. 
        /// <para>
        /// A facet attribute consists of either a definition or a reference. This structure contains
        /// the attribute definition. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_attributereferences.html">Attribute
        /// References</a> for more information.
        /// </para>
        /// </summary>
        public FacetAttributeDefinition AttributeDefinition
        {
            get { return this._attributeDefinition; }
            set { this._attributeDefinition = value; }
        }

        // Check to see if AttributeDefinition property is set
        internal bool IsSetAttributeDefinition()
        {
            return this._attributeDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeReference. 
        /// <para>
        /// An attribute reference that is associated with the attribute. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_attributereferences.html">Attribute
        /// References</a> for more information.
        /// </para>
        /// </summary>
        public FacetAttributeReference AttributeReference
        {
            get { return this._attributeReference; }
            set { this._attributeReference = value; }
        }

        // Check to see if AttributeReference property is set
        internal bool IsSetAttributeReference()
        {
            return this._attributeReference != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the facet attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=230)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredBehavior. 
        /// <para>
        /// The required behavior of the <c>FacetAttribute</c>.
        /// </para>
        /// </summary>
        public RequiredAttributeBehavior RequiredBehavior
        {
            get { return this._requiredBehavior; }
            set { this._requiredBehavior = value; }
        }

        // Check to see if RequiredBehavior property is set
        internal bool IsSetRequiredBehavior()
        {
            return this._requiredBehavior != null;
        }

    }
}