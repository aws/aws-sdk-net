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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatabase operation.
    /// Updates an existing database definition in a Data Catalog.
    /// </summary>
    public partial class UpdateDatabaseRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private DatabaseInput _databaseInput;
        private string _name;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the metadata database resides. If none is supplied,
        /// the AWS account ID is used by default.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DatabaseInput. 
        /// <para>
        /// A <code>DatabaseInput</code> object specifying the new definition of the metadata
        /// database in the catalog.
        /// </para>
        /// </summary>
        public DatabaseInput DatabaseInput
        {
            get { return this._databaseInput; }
            set { this._databaseInput = value; }
        }

        // Check to see if DatabaseInput property is set
        internal bool IsSetDatabaseInput()
        {
            return this._databaseInput != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metadata database to update in the catalog.
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