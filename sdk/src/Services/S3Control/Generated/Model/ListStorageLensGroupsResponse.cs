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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the ListStorageLensGroups operation.
    /// </summary>
    public partial class ListStorageLensGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListStorageLensGroupEntry> _storageLensGroupList = AWSConfigs.InitializeCollections ? new List<ListStorageLensGroupEntry>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If <c>NextToken</c> is returned, there are more Storage Lens groups results available.
        /// The value of <c>NextToken</c> is a unique pagination token for each page. Make the
        /// call again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StorageLensGroupList. 
        /// <para>
        ///  The list of Storage Lens groups that exist in the specified home Region. 
        /// </para>
        /// </summary>
        public List<ListStorageLensGroupEntry> StorageLensGroupList
        {
            get { return this._storageLensGroupList; }
            set { this._storageLensGroupList = value; }
        }

        // Check to see if StorageLensGroupList property is set
        internal bool IsSetStorageLensGroupList()
        {
            return this._storageLensGroupList != null && (this._storageLensGroupList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}