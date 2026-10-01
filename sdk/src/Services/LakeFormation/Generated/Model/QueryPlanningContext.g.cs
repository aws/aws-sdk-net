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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure containing information about the query plan.
    /// </summary>
    public partial class QueryPlanningContext
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partition in question resides. If none is provided,
        /// the Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database containing the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the table contents. If not set, the most recent transaction
        /// commit time will be used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime { get; set; }

        /// <summary>
        /// Checks to see if the QueryAsOfTime property is set.
        /// </summary>
        internal bool IsSetQueryAsOfTime() => this.QueryAsOfTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// A map consisting of key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> QueryParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null && (this.QueryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the table contents. If this transaction is not
        /// committed, the read will be treated as part of that transaction and will see its writes.
        /// If this transaction has aborted, an error will be returned. If not set, defaults to
        /// the most recent committed transaction. Cannot be specified along with <c>QueryAsOfTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
