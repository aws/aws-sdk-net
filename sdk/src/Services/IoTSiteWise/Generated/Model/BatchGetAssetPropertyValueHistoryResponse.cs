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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the BatchGetAssetPropertyValueHistory operation.
    /// </summary>
    public partial class BatchGetAssetPropertyValueHistoryResponse : AmazonWebServiceResponse
    {
        private List<BatchGetAssetPropertyValueHistoryErrorEntry> _errorEntries = new List<BatchGetAssetPropertyValueHistoryErrorEntry>();
        private string _nextToken;
        private List<BatchGetAssetPropertyValueHistorySkippedEntry> _skippedEntries = new List<BatchGetAssetPropertyValueHistorySkippedEntry>();
        private List<BatchGetAssetPropertyValueHistorySuccessEntry> _successEntries = new List<BatchGetAssetPropertyValueHistorySuccessEntry>();

        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        /// A list of the errors (if any) associated with the batch request. Each error entry
        /// contains the <code>entryId</code> of the entry that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueHistoryErrorEntry> ErrorEntries
        {
            get { return this._errorEntries; }
            set { this._errorEntries = value; }
        }

        // Check to see if ErrorEntries property is set
        internal bool IsSetErrorEntries()
        {
            return this._errorEntries != null && this._errorEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SkippedEntries. 
        /// <para>
        /// A list of entries that were not processed by this batch request. because these entries
        /// had been completely processed by previous paginated requests. Each skipped entry contains
        /// the <code>entryId</code> of the entry that skipped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueHistorySkippedEntry> SkippedEntries
        {
            get { return this._skippedEntries; }
            set { this._skippedEntries = value; }
        }

        // Check to see if SkippedEntries property is set
        internal bool IsSetSkippedEntries()
        {
            return this._skippedEntries != null && this._skippedEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessEntries. 
        /// <para>
        /// A list of entries that were processed successfully by this batch request. Each success
        /// entry contains the <code>entryId</code> of the entry that succeeded and the latest
        /// query result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueHistorySuccessEntry> SuccessEntries
        {
            get { return this._successEntries; }
            set { this._successEntries = value; }
        }

        // Check to see if SuccessEntries property is set
        internal bool IsSetSuccessEntries()
        {
            return this._successEntries != null && this._successEntries.Count > 0; 
        }

    }
}