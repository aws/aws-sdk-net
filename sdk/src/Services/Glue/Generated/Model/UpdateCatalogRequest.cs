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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCatalog operation.
    /// Updates an existing catalog's properties in the Glue Data Catalog.
    /// </summary>
    public partial class UpdateCatalogRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private CatalogInput _catalogInput;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogInput. 
        /// <para>
        /// A <c>CatalogInput</c> object specifying the new properties of an existing catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogInput CatalogInput
        {
            get { return this._catalogInput; }
            set { this._catalogInput = value; }
        }

        // Check to see if CatalogInput property is set
        internal bool IsSetCatalogInput()
        {
            return this._catalogInput != null;
        }

    }
}