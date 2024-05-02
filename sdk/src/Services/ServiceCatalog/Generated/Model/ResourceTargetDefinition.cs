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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a change to a resource attribute.
    /// </summary>
    public partial class ResourceTargetDefinition
    {
        private ResourceAttribute _attribute;
        private string _name;
        private RequiresRecreation _requiresRecreation;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute to be changed.
        /// </para>
        /// </summary>
        public ResourceAttribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// If the attribute is <c>Properties</c>, the value is the name of the property. Otherwise,
        /// the value is null.
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

        /// <summary>
        /// Gets and sets the property RequiresRecreation. 
        /// <para>
        /// If the attribute is <c>Properties</c>, indicates whether a change to this property
        /// causes the resource to be re-created.
        /// </para>
        /// </summary>
        public RequiresRecreation RequiresRecreation
        {
            get { return this._requiresRecreation; }
            set { this._requiresRecreation = value; }
        }

        // Check to see if RequiresRecreation property is set
        internal bool IsSetRequiresRecreation()
        {
            return this._requiresRecreation != null;
        }

    }
}