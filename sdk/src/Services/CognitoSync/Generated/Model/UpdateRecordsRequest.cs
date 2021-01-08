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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRecords operation.
    /// Posts updates to records and adds and deletes records for a dataset and user.
    /// 
    ///  
    /// <para>
    /// The sync count in the record patch is your last known sync count for that record.
    /// The server will reject an UpdateRecords request with a ResourceConflictException if
    /// you try to patch a record with a new value but a stale sync count.
    /// </para>
    ///  
    /// <para>
    /// For example, if the sync count on the server is 5 for a key called highScore and you
    /// try and submit a new highScore with sync count of 4, the request will be rejected.
    /// To obtain the current sync count for a record, call ListRecords. On a successful update
    /// of the record, the response returns the new sync count for that record. You should
    /// present that sync count the next time you try to update that same record. When the
    /// record does not exist, specify the sync count as 0.
    /// </para>
    ///  
    /// <para>
    /// This API can be called with temporary user credentials provided by Cognito Identity
    /// or with developer credentials.
    /// </para>
    /// </summary>
    public partial class UpdateRecordsRequest : AmazonCognitoSyncRequest
    {
        private string _clientContext;
        private string _datasetName;
        private string _deviceId;
        private string _identityId;
        private string _identityPoolId;
        private List<RecordPatch> _recordPatches = new List<RecordPatch>();
        private string _syncSessionToken;

        /// <summary>
        /// Gets and sets the property ClientContext. Intended to supply a device ID that will
        /// populate the lastModifiedBy field referenced in other methods. The ClientContext field
        /// is not yet implemented.
        /// </summary>
        public string ClientContext
        {
            get { return this._clientContext; }
            set { this._clientContext = value; }
        }

        // Check to see if ClientContext property is set
        internal bool IsSetClientContext()
        {
            return this._clientContext != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. A string of up to 128 characters. Allowed
        /// characters are a-z, A-Z, 0-9, '_' (underscore), '-' (dash), and '.' (dot).
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique ID generated for this device by Cognito.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
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
        /// Gets and sets the property RecordPatches. A list of patch operations.
        /// </summary>
        public List<RecordPatch> RecordPatches
        {
            get { return this._recordPatches; }
            set { this._recordPatches = value; }
        }

        // Check to see if RecordPatches property is set
        internal bool IsSetRecordPatches()
        {
            return this._recordPatches != null && this._recordPatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SyncSessionToken. The SyncSessionToken returned by a previous
        /// call to ListRecords for this dataset and identity.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SyncSessionToken
        {
            get { return this._syncSessionToken; }
            set { this._syncSessionToken = value; }
        }

        // Check to see if SyncSessionToken property is set
        internal bool IsSetSyncSessionToken()
        {
            return this._syncSessionToken != null;
        }

    }
}