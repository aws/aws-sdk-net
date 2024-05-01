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
    /// The facet attribute reference that specifies the attribute definition that contains
    /// the attribute facet name and attribute name.
    /// </summary>
    public partial class FacetAttributeReference
    {
        private string _targetAttributeName;
        private string _targetFacetName;

        /// <summary>
        /// Gets and sets the property TargetAttributeName. 
        /// <para>
        /// The target attribute name that is associated with the facet reference. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_attributereferences.html">Attribute
        /// References</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=230)]
        public string TargetAttributeName
        {
            get { return this._targetAttributeName; }
            set { this._targetAttributeName = value; }
        }

        // Check to see if TargetAttributeName property is set
        internal bool IsSetTargetAttributeName()
        {
            return this._targetAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFacetName. 
        /// <para>
        /// The target facet name that is associated with the facet reference. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_attributereferences.html">Attribute
        /// References</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TargetFacetName
        {
            get { return this._targetFacetName; }
            set { this._targetFacetName = value; }
        }

        // Check to see if TargetFacetName property is set
        internal bool IsSetTargetFacetName()
        {
            return this._targetFacetName != null;
        }

    }
}