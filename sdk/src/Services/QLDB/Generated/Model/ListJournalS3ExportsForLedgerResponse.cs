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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the ListJournalS3ExportsForLedger operation.
    /// </summary>
    public partial class ListJournalS3ExportsForLedgerResponse : AmazonWebServiceResponse
    {
        private List<JournalS3ExportDescription> _journalS3Exports = AWSConfigs.InitializeCollections ? new List<JournalS3ExportDescription>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JournalS3Exports. 
        /// <para>
        /// The journal export jobs that are currently associated with the specified ledger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JournalS3ExportDescription> JournalS3Exports
        {
            get { return this._journalS3Exports; }
            set { this._journalS3Exports = value; }
        }

        // Check to see if JournalS3Exports property is set
        internal bool IsSetJournalS3Exports()
        {
            return this._journalS3Exports != null && (this._journalS3Exports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. <ul> <li> 
        /// <para>
        /// If <c>NextToken</c> is empty, then the last page of results has been processed and
        /// there are no more results to be retrieved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>NextToken</c> is <i>not</i> empty, then there are more results available. To
        /// retrieve the next page of results, use the value of <c>NextToken</c> in a subsequent
        /// <c>ListJournalS3ExportsForLedger</c> call.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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

    }
}