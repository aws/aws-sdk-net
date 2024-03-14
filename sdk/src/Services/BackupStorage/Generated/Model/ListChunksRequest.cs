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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Container for the parameters to the ListChunks operation.
    /// List chunks in a given Object
    /// </summary>
    public partial class ListChunksRequest : AmazonBackupStorageRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _objectToken;
        private string _storageJobId;

        /// <summary>
        /// Gets and sets the property MaxResults. Maximum number of chunks
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. Pagination token
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
        /// Gets and sets the property ObjectToken. Object token
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectToken
        {
            get { return this._objectToken; }
            set { this._objectToken = value; }
        }

        // Check to see if ObjectToken property is set
        internal bool IsSetObjectToken()
        {
            return this._objectToken != null;
        }

        /// <summary>
        /// Gets and sets the property StorageJobId. Storage job id
        /// </summary>
        [AWSProperty(Required=true)]
        public string StorageJobId
        {
            get { return this._storageJobId; }
            set { this._storageJobId = value; }
        }

        // Check to see if StorageJobId property is set
        internal bool IsSetStorageJobId()
        {
            return this._storageJobId != null;
        }

    }
}