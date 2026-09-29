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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the BatchGetAssetPropertyAggregates operation.
    /// </summary>
    public partial class BatchGetAssetPropertyAggregatesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        /// A list of the errors (if any) associated with the batch request. Each error entry
        /// contains the <c>entryId</c> of the entry that failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchGetAssetPropertyAggregatesErrorEntry> ErrorEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetAssetPropertyAggregatesErrorEntry>() : null;

        /// <summary>
        /// Checks to see if the ErrorEntries property is set.
        /// </summary>
        internal bool IsSetErrorEntries() => this.ErrorEntries != null && (this.ErrorEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SkippedEntries. 
        /// <para>
        /// A list of entries that were not processed by this batch request. because these entries
        /// had been completely processed by previous paginated requests. Each skipped entry contains
        /// the <c>entryId</c> of the entry that skipped.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchGetAssetPropertyAggregatesSkippedEntry> SkippedEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetAssetPropertyAggregatesSkippedEntry>() : null;

        /// <summary>
        /// Checks to see if the SkippedEntries property is set.
        /// </summary>
        internal bool IsSetSkippedEntries() => this.SkippedEntries != null && (this.SkippedEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessEntries. 
        /// <para>
        /// A list of entries that were processed successfully by this batch request. Each success
        /// entry contains the <c>entryId</c> of the entry that succeeded and the latest query
        /// result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchGetAssetPropertyAggregatesSuccessEntry> SuccessEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetAssetPropertyAggregatesSuccessEntry>() : null;

        /// <summary>
        /// Checks to see if the SuccessEntries property is set.
        /// </summary>
        internal bool IsSetSuccessEntries() => this.SuccessEntries != null && (this.SuccessEntries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
