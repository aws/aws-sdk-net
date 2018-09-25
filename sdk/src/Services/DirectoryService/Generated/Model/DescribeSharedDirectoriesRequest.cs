/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSharedDirectories operation.
    /// Returns the shared directories in your account.
    /// </summary>
    public partial class DescribeSharedDirectoriesRequest : AmazonDirectoryServiceRequest
    {
        private int? _limit;
        private string _nextToken;
        private string _ownerDirectoryId;
        private List<string> _sharedDirectoryIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of shared directories to return in the response object.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>DescribeSharedDirectoriesResult.NextToken</code> value from a previous call
        /// to <a>DescribeSharedDirectories</a>. Pass null if this is the first call. 
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
        /// Gets and sets the property OwnerDirectoryId. 
        /// <para>
        /// Returns the identifier of the directory in the directory owner account. 
        /// </para>
        /// </summary>
        public string OwnerDirectoryId
        {
            get { return this._ownerDirectoryId; }
            set { this._ownerDirectoryId = value; }
        }

        // Check to see if OwnerDirectoryId property is set
        internal bool IsSetOwnerDirectoryId()
        {
            return this._ownerDirectoryId != null;
        }

        /// <summary>
        /// Gets and sets the property SharedDirectoryIds. 
        /// <para>
        /// A list of identifiers of all shared directories in your account. 
        /// </para>
        /// </summary>
        public List<string> SharedDirectoryIds
        {
            get { return this._sharedDirectoryIds; }
            set { this._sharedDirectoryIds = value; }
        }

        // Check to see if SharedDirectoryIds property is set
        internal bool IsSetSharedDirectoryIds()
        {
            return this._sharedDirectoryIds != null && this._sharedDirectoryIds.Count > 0; 
        }

    }
}