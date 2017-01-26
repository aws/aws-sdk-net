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
    /// This is the response object from the GetObjectInformation operation.
    /// </summary>
    public partial class GetObjectInformationResponse : AmazonWebServiceResponse
    {
        private string _objectIdentifier;
        private List<SchemaFacet> _schemaFacets = new List<SchemaFacet>();

        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// The ObjectIdentifier of the specified object.
        /// </para>
        /// </summary>
        public string ObjectIdentifier
        {
            get { return this._objectIdentifier; }
            set { this._objectIdentifier = value; }
        }

        // Check to see if ObjectIdentifier property is set
        internal bool IsSetObjectIdentifier()
        {
            return this._objectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaFacets. 
        /// <para>
        /// The facets attached to the specified object.
        /// </para>
        /// </summary>
        public List<SchemaFacet> SchemaFacets
        {
            get { return this._schemaFacets; }
            set { this._schemaFacets = value; }
        }

        // Check to see if SchemaFacets property is set
        internal bool IsSetSchemaFacets()
        {
            return this._schemaFacets != null && this._schemaFacets.Count > 0; 
        }

    }
}