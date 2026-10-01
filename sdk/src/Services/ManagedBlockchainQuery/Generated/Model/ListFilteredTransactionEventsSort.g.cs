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

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// Lists all the transaction events for an address on the blockchain.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is only supported on the Bitcoin blockchain networks.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListFilteredTransactionEventsSort
    {
        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Container on how the results will be sorted by?
        /// </para>
        /// </summary>
        public ListFilteredTransactionEventsSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The container for the <i>sort order</i> for <c>ListFilteredTransactionEvents</c>.
        /// The <c>SortOrder</c> field only accepts the values <c>ASCENDING</c> and <c>DESCENDING</c>.
        /// Not providing <c>SortOrder</c> will default to <c>ASCENDING</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
