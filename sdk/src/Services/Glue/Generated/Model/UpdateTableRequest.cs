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
    /// Container for the parameters to the UpdateTable operation.
    /// Updates a metadata table in the Data Catalog.
    /// </summary>
    public partial class UpdateTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private bool? _skipArchive;
        private TableInput _tableInput;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the AWS account
        /// ID is used by default.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database in which the table resides. For Hive compatibility,
        /// this name is entirely lowercase.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property SkipArchive. 
        /// <para>
        /// By default, <code>UpdateTable</code> always creates an archived version of the table
        /// before updating it. If <code>skipArchive</code> is set to true, however, <code>UpdateTable</code>
        /// does not create the archived version.
        /// </para>
        /// </summary>
        public bool SkipArchive
        {
            get { return this._skipArchive.GetValueOrDefault(); }
            set { this._skipArchive = value; }
        }

        // Check to see if SkipArchive property is set
        internal bool IsSetSkipArchive()
        {
            return this._skipArchive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableInput. 
        /// <para>
        /// An updated <code>TableInput</code> object to define the metadata table in the catalog.
        /// </para>
        /// </summary>
        public TableInput TableInput
        {
            get { return this._tableInput; }
            set { this._tableInput = value; }
        }

        // Check to see if TableInput property is set
        internal bool IsSetTableInput()
        {
            return this._tableInput != null;
        }

    }
}