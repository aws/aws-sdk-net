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
    /// This is the response object from the ListFileTransferResults operation.
    /// </summary>
    public partial class ListFileTransferResultsResponse : AmazonWebServiceResponse
    {
        private List<ConnectorFileTransferResult> _fileTransferResults = AWSConfigs.InitializeCollections ? new List<ConnectorFileTransferResult>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FileTransferResults. 
        /// <para>
        /// Returns the details for the files transferred in the transfer identified by the <c>TransferId</c>
        /// and <c>ConnectorId</c> specified.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FilePath</c>: the filename and path to where the file was sent to or retrieved
        /// from.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StatusCode</c>: current status for the transfer. The status returned is one of
        /// the following values:<c>QUEUED</c>, <c>IN_PROGRESS</c>, <c>COMPLETED</c>, or <c>FAILED</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FailureCode</c>: for transfers that fail, this parameter contains a code indicating
        /// the reason. For example, <c>RETRIEVE_FILE_NOT_FOUND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FailureMessage</c>: for transfers that fail, this parameter describes the reason
        /// for the failure.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<ConnectorFileTransferResult> FileTransferResults
        {
            get { return this._fileTransferResults; }
            set { this._fileTransferResults = value; }
        }

        // Check to see if FileTransferResults property is set
        internal bool IsSetFileTransferResults()
        {
            return this._fileTransferResults != null && (this._fileTransferResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Returns a token that you can use to call <c>ListFileTransferResults</c> again and
        /// receive additional results, if there are any (against the same <c>TransferId</c>.
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

    }
}