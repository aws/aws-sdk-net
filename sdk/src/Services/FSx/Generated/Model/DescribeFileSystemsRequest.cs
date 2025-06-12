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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileSystems operation.
    /// Returns the description of specific Amazon FSx file systems, if a <c>FileSystemIds</c>
    /// value is provided for that file system. Otherwise, it returns descriptions of all
    /// file systems owned by your Amazon Web Services account in the Amazon Web Services
    /// Region of the endpoint that you're calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all file system descriptions, you can optionally specify the <c>MaxResults</c>
    /// parameter to limit the number of descriptions in a response. If more file system descriptions
    /// remain, Amazon FSx returns a <c>NextToken</c> value in the response. In this case,
    /// send a later request with the <c>NextToken</c> request parameter set to the value
    /// of <c>NextToken</c> from the last response.
    /// </para>
    ///  
    /// <para>
    /// This operation is used in an iterative process to retrieve a list of your file system
    /// descriptions. <c>DescribeFileSystems</c> is called first without a <c>NextToken</c>value.
    /// Then the operation continues to be called with the <c>NextToken</c> parameter set
    /// to the value of the last <c>NextToken</c> value until a response has no <c>NextToken</c>.
    /// </para>
    ///  
    /// <para>
    /// When using this operation, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The implementation might return fewer than <c>MaxResults</c> file system descriptions
    /// while still including a <c>NextToken</c> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of file systems returned in the response of one <c>DescribeFileSystems</c>
    /// call and the order of file systems returned across the responses of a multicall iteration
    /// is unspecified.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeFileSystemsRequest : AmazonFSxRequest
    {
        private List<string> _fileSystemIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FileSystemIds. 
        /// <para>
        /// IDs of the file systems whose descriptions you want to retrieve (String).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> FileSystemIds
        {
            get { return this._fileSystemIds; }
            set { this._fileSystemIds = value; }
        }

        // Check to see if FileSystemIds property is set
        internal bool IsSetFileSystemIds()
        {
            return this._fileSystemIds != null && (this._fileSystemIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of file systems to return in the response (integer). This parameter
        /// value must be greater than 0. The number of items that Amazon FSx returns is the minimum
        /// of the <c>MaxResults</c> parameter specified in the request and the service's internal
        /// maximum number of items per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        /// Opaque pagination token returned from a previous <c>DescribeFileSystems</c> operation
        /// (String). If a token present, the operation continues the list from where the returning
        /// call left off.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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