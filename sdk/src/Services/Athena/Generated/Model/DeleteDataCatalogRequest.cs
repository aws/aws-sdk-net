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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataCatalog operation.
    /// Deletes a data catalog.
    /// </summary>
    public partial class DeleteDataCatalogRequest : AmazonAthenaRequest
    {
        private bool? _deleteCatalogOnly;
        private string _name;

        /// <summary>
        /// Gets and sets the property DeleteCatalogOnly. 
        /// <para>
        /// Deletes the Athena Data Catalog. You can only use this with the <c>FEDERATED</c> catalogs.
        /// You usually perform this before registering the connector with Glue Data Catalog.
        /// After deletion, you will have to manage the Glue Connection and Lambda function. 
        /// </para>
        /// </summary>
        public bool? DeleteCatalogOnly
        {
            get { return this._deleteCatalogOnly; }
            set { this._deleteCatalogOnly = value; }
        }

        // Check to see if DeleteCatalogOnly property is set
        internal bool IsSetDeleteCatalogOnly()
        {
            return this._deleteCatalogOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data catalog to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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