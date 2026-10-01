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
    /// Container for the parameters to the ListTransactions operation. Returns metadata about
    /// transactions and their status. To prevent the response from growing indefinitely,
    /// only uncommitted transactions and those available for time-travel queries are returned.
    /// <para> This operation can help you identify uncommitted transactions or to get information
    /// about transactions. </para>
    /// </summary>
    public partial class ListTransactionsRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog for which to list transactions. Defaults to the account ID of the caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of transactions to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token if this is not the first call to retrieve transactions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        ///  A filter indicating the status of transactions to return. Options are ALL | COMPLETED
        /// | COMMITTED | ABORTED | ACTIVE. The default is <c>ALL</c>.
        /// </para>
        /// </summary>
        public TransactionStatusFilter StatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null;
    }
}
