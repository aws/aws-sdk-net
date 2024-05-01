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
    /// A structure that contains <c>Name</c>, <c>ARN</c>, <c>Attributes</c>, <c> <a>Rule</a>s</c>,
    /// and <c>ObjectTypes</c>. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_whatarefacets.html">Facets</a>
    /// for more information.
    /// </summary>
    public partial class Facet
    {
        private FacetStyle _facetStyle;
        private string _name;
        private ObjectType _objectType;

        /// <summary>
        /// Gets and sets the property FacetStyle. 
        /// <para>
        /// There are two different styles that you can define on any given facet, <c>Static</c>
        /// and <c>Dynamic</c>. For static facets, all attributes must be defined in the schema.
        /// For dynamic facets, attributes can be defined during data plane operations.
        /// </para>
        /// </summary>
        public FacetStyle FacetStyle
        {
            get { return this._facetStyle; }
            set { this._facetStyle = value; }
        }

        // Check to see if FacetStyle property is set
        internal bool IsSetFacetStyle()
        {
            return this._facetStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>Facet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ObjectType. 
        /// <para>
        /// The object type that is associated with the facet. See <a>CreateFacetRequest$ObjectType</a>
        /// for more details.
        /// </para>
        /// </summary>
        public ObjectType ObjectType
        {
            get { return this._objectType; }
            set { this._objectType = value; }
        }

        // Check to see if ObjectType property is set
        internal bool IsSetObjectType()
        {
            return this._objectType != null;
        }

    }
}