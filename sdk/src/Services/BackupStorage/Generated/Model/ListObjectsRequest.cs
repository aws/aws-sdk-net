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
    /// Container for the parameters to the ListObjects operation.
    /// List all Objects in a given Backup.
    /// </summary>
    public partial class ListObjectsRequest : AmazonBackupStorageRequest
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private int? _maxResults;
        private string _nextToken;
        private string _startingObjectName;
        private string _startingObjectPrefix;
        private string _storageJobId;

        /// <summary>
        /// Gets and sets the property CreatedAfter. (Optional) Created after filter
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. (Optional) Created before filter
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. Maximum objects count
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
        /// Gets and sets the property StartingObjectName. Optional, specifies the starting Object
        /// name to list from. Ignored if NextToken is not NULL
        /// </summary>
        public string StartingObjectName
        {
            get { return this._startingObjectName; }
            set { this._startingObjectName = value; }
        }

        // Check to see if StartingObjectName property is set
        internal bool IsSetStartingObjectName()
        {
            return this._startingObjectName != null;
        }

        /// <summary>
        /// Gets and sets the property StartingObjectPrefix. Optional, specifies the starting
        /// Object prefix to list from. Ignored if NextToken is not NULL
        /// </summary>
        public string StartingObjectPrefix
        {
            get { return this._startingObjectPrefix; }
            set { this._startingObjectPrefix = value; }
        }

        // Check to see if StartingObjectPrefix property is set
        internal bool IsSetStartingObjectPrefix()
        {
            return this._startingObjectPrefix != null;
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