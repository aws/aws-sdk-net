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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ListFileTransferResults operation.
    /// Returns real-time updates and detailed information on the status of each individual
    /// file being transferred in a specific file transfer operation. You specify the file
    /// transfer by providing its <c>ConnectorId</c> and its <c>TransferId</c>.
    /// 
    ///  <note> 
    /// <para>
    /// File transfer results are available up to 7 days after an operation has been requested.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListFileTransferResultsRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private int? _maxResults;
        private string _nextToken;
        private string _transferId;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// A unique identifier for a connector. This value should match the value supplied to
        /// the corresponding <c>StartFileTransfer</c> call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of files to return in a single page. Note that currently you can
        /// specify a maximum of 10 file paths in a single <a href="https://docs.aws.amazon.com/transfer/latest/APIReference/API_StartFileTransfer.html">StartFileTransfer</a>
        /// operation. Thus, the maximum number of file transfer results that can be returned
        /// in a single page is 10. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more file details than returned in this call, use this value for a subsequent
        /// call to <c>ListFileTransferResults</c> to retrieve them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
        /// Gets and sets the property TransferId. 
        /// <para>
        /// A unique identifier for a file transfer. This value should match the value supplied
        /// to the corresponding <c>StartFileTransfer</c> call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string TransferId
        {
            get { return this._transferId; }
            set { this._transferId = value; }
        }

        // Check to see if TransferId property is set
        internal bool IsSetTransferId()
        {
            return this._transferId != null;
        }

    }
}