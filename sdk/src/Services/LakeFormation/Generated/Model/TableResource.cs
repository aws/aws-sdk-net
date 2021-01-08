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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure for the table object. A table is a metadata definition that represents
    /// your data. You can Grant and Revoke table privileges to a principal.
    /// </summary>
    public partial class TableResource
    {
        private string _catalogId;
        private string _databaseName;
        private string _name;
        private TableWildcard _tableWildcard;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, it is the account ID of the caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The name of the database for the table. Unique to a Data Catalog. A database is a
        /// set of associated table definitions organized into a logical group. You can Grant
        /// and Revoke database privileges to a principal. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property TableWildcard. 
        /// <para>
        /// A wildcard object representing every table under a database.
        /// </para>
        ///  
        /// <para>
        /// At least one of <code>TableResource$Name</code> or <code>TableResource$TableWildcard</code>
        /// is required.
        /// </para>
        /// </summary>
        public TableWildcard TableWildcard
        {
            get { return this._tableWildcard; }
            set { this._tableWildcard = value; }
        }

        // Check to see if TableWildcard property is set
        internal bool IsSetTableWildcard()
        {
            return this._tableWildcard != null;
        }

    }
}