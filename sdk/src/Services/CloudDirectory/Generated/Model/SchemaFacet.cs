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
    /// A facet.
    /// </summary>
    public partial class SchemaFacet
    {
        private string _facetName;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property FacetName. 
        /// <para>
        /// The name of the facet. If this value is set, SchemaArn must also be set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FacetName
        {
            get { return this._facetName; }
            set { this._facetName = value; }
        }

        // Check to see if FacetName property is set
        internal bool IsSetFacetName()
        {
            return this._facetName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The ARN of the schema that contains the facet with no minor component. See <a>arns</a>
        /// and <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/schemas_inplaceschemaupgrade.html">In-Place
        /// Schema Upgrade</a> for a description of when to provide minor versions. If this value
        /// is set, FacetName must also be set.
        /// </para>
        /// </summary>
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

    }
}