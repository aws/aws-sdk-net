/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Defines the typed links structure and its attributes. To create a typed link facet,
    /// use the <a>CreateTypedLinkFacet</a> API.
    /// </summary>
    public partial class TypedLinkFacet
    {
        private List<TypedLinkAttributeDefinition> _attributes = new List<TypedLinkAttributeDefinition>();
        private List<string> _identityAttributeOrder = new List<string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A set of key-value pairs associated with the typed link. Typed link attributes are
        /// used when you have data values that are related to the link itself, and not to one
        /// of the two objects being linked. Identity attributes also serve to distinguish the
        /// link from others of the same type between the same objects.
        /// </para>
        /// </summary>
        public List<TypedLinkAttributeDefinition> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdentityAttributeOrder. 
        /// <para>
        /// The set of attributes that distinguish links made from this facet from each other,
        /// in the order of significance. Listing typed links can filter on the values of these
        /// attributes. See <a>ListOutgoingTypedLinks</a> and <a>ListIncomingTypeLinks</a> for
        /// details.
        /// </para>
        /// </summary>
        public List<string> IdentityAttributeOrder
        {
            get { return this._identityAttributeOrder; }
            set { this._identityAttributeOrder = value; }
        }

        // Check to see if IdentityAttributeOrder property is set
        internal bool IsSetIdentityAttributeOrder()
        {
            return this._identityAttributeOrder != null && this._identityAttributeOrder.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the typed link facet.
        /// </para>
        /// </summary>
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

    }
}