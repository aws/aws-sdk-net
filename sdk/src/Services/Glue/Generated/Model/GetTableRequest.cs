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
    /// Container for the parameters to the GetTable operation.
    /// Retrieves the <c>Table</c> definition in a Data Catalog for a specified table.
    /// </summary>
    public partial class GetTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private bool? _includeStatusDetails;
        private string _name;
        private DateTime? _queryAsOfTime;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is provided, the Amazon
        /// Web Services account ID is used by default.
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
        /// The name of the database in the catalog in which the table resides. For Hive compatibility,
        /// this name is entirely lowercase.
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
        /// Gets and sets the property IncludeStatusDetails. 
        /// <para>
        /// Specifies whether to include status details related to a request to create or update
        /// an Glue Data Catalog view.
        /// </para>
        /// </summary>
        public bool? IncludeStatusDetails
        {
            get { return this._includeStatusDetails; }
            set { this._includeStatusDetails = value; }
        }

        // Check to see if IncludeStatusDetails property is set
        internal bool IsSetIncludeStatusDetails()
        {
            return this._includeStatusDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table for which to retrieve the definition. For Hive compatibility,
        /// this name is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the table contents. If not set, the most recent transaction
        /// commit time will be used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime
        {
            get { return this._queryAsOfTime; }
            set { this._queryAsOfTime = value; }
        }

        // Check to see if QueryAsOfTime property is set
        internal bool IsSetQueryAsOfTime()
        {
            return this._queryAsOfTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the table contents. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}