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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Usage information for the identity pool.
    /// </summary>
    public partial class IdentityPoolUsage
    {
        private long? _dataStorage;
        private string _identityPoolId;
        private DateTime? _lastModifiedDate;
        private long? _syncSessionsCount;

        /// <summary>
        /// Gets and sets the property DataStorage. Data storage information for the identity
        /// pool.
        /// </summary>
        public long? DataStorage
        {
            get { return this._dataStorage; }
            set { this._dataStorage = value; }
        }

        // Check to see if DataStorage property is set
        internal bool IsSetDataStorage()
        {
            return this._dataStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. Date on which the identity pool was last
        /// modified.
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SyncSessionsCount. Number of sync sessions for the identity
        /// pool.
        /// </summary>
        public long? SyncSessionsCount
        {
            get { return this._syncSessionsCount; }
            set { this._syncSessionsCount = value; }
        }

        // Check to see if SyncSessionsCount property is set
        internal bool IsSetSyncSessionsCount()
        {
            return this._syncSessionsCount.HasValue; 
        }

    }
}