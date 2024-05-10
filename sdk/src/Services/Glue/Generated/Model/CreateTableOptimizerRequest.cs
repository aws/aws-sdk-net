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
    /// Container for the parameters to the CreateTableOptimizer operation.
    /// Creates a new table optimizer for a specific function. <c>compaction</c> is the only
    /// currently supported optimizer type.
    /// </summary>
    public partial class CreateTableOptimizerRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private string _tableName;
        private TableOptimizerConfiguration _tableOptimizerConfiguration;
        private TableOptimizerType _type;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The Catalog ID of the table.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database in the catalog in which the table resides.
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableOptimizerConfiguration. 
        /// <para>
        /// A <c>TableOptimizerConfiguration</c> object representing the configuration of a table
        /// optimizer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableOptimizerConfiguration TableOptimizerConfiguration
        {
            get { return this._tableOptimizerConfiguration; }
            set { this._tableOptimizerConfiguration = value; }
        }

        // Check to see if TableOptimizerConfiguration property is set
        internal bool IsSetTableOptimizerConfiguration()
        {
            return this._tableOptimizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of table optimizer. Currently, the only valid value is <c>compaction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableOptimizerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}