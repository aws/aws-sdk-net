//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.CognitoIdentity;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.SyncManager
{
    public partial class CognitoSyncManager : IDisposable
    {
        private Logger _logger;
        private bool _disposed;

        protected static readonly string DATABASE_NAME = "aws_cognito_cache.db";

        protected ILocalStorage Local
        {
            get;
            set;
        }

        protected readonly CognitoSyncStorage remote;
        protected readonly CognitoAWSCredentials cognitoCredentials;

        #region Constructor

        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials) : this(cognitoCredentials, new AmazonCognitoSyncConfig()) { }

        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials, RegionEndpoint endpoint)
            : this(cognitoCredentials, new AmazonCognitoSyncConfig
            {
                RegionEndpoint = endpoint
            })
        { }

        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials, AmazonCognitoSyncConfig config)
        {
            if (cognitoCredentials == null)
            {
                throw new ArgumentNullException("cognitoCredentials");
            }

            if (string.IsNullOrEmpty(cognitoCredentials.IdentityPoolId))
            {
                throw new ArgumentNullException("cognitoCredentials.IdentityPoolId");
            }
            this.cognitoCredentials = cognitoCredentials;
#if AWSSDK_UNITY
            Local = new SQLiteLocalStorage(System.IO.Path.Combine(UnityEngine.Application.persistentDataPath, DATABASE_NAME));
#elif BCL35 || BCL45
            Local = new InMemoryStorage();
#else

#endif
            remote = new CognitoSyncStorage(cognitoCredentials, config);
            cognitoCredentials.IdentityChangedEvent += this.IdentityChanged;

            _logger = Logger.GetLogger(this.GetType());
        }

        #endregion

        #region Dispose Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                cognitoCredentials.IdentityChangedEvent -= this.IdentityChanged;
                _disposed = true;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Opens or creates a dataset. If the dataset doesn't exist, an empty one
        /// with the given name will be created. Otherwise, the dataset is loaded from
        /// local storage. If a dataset is marked as deleted but hasn't been deleted
        /// on remote via <see cref="Amazon.CognitoSync.SyncManager.CognitoSyncManager.RefreshDatasetMetadataAsync"/>, it will throw
        /// <see cref="System.InvalidOperationException"/>.
        /// </summary>
        /// <returns>Dataset loaded from local storage</returns>
        /// <param name="datasetName">DatasetName dataset name, must be [a-zA-Z0=9_.:-]+</param>
        public Dataset OpenOrCreateDataset(string datasetName)
        {
            DatasetUtils.ValidateDatasetName(datasetName);
            Local.CreateDataset(GetIdentityId(), datasetName);
            return new Dataset(datasetName, cognitoCredentials, Local, remote);
        }

        /// <summary>
        /// Retrieves a list of datasets from local storage. It may not reflects
        /// latest dataset on the remote storage until <see cref="CognitoSyncManager#RefreshDatasetMetadataAsync"/> is
        /// called.
        /// </summary>
        /// <returns>List of datasets</returns>
        public List<DatasetMetadata> ListDatasets()
        {
            return Local.GetDatasetMetadata(GetIdentityId());
        }

        /// <summary>
        /// Wipes all user data cached locally, including identity id, session
        /// credentials, dataset metadata, and all records. Any data that hasn't been
        /// synced will be lost. This method is usually used when customer logs out.
        /// </summary>
        public void WipeData()
        {
            Local.WipeData();
            _logger.InfoFormat("All data has been wiped");
        }

        #endregion

        #region Protected Methods

        protected void IdentityChanged(object sender, EventArgs e)
        {
            var identityChangedEvent = e as Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs;
            String oldIdentity = identityChangedEvent.OldIdentityId == null ? DatasetUtils.UNKNOWN_IDENTITY_ID : identityChangedEvent.OldIdentityId;
            String newIdentity = identityChangedEvent.NewIdentityId == null ? DatasetUtils.UNKNOWN_IDENTITY_ID : identityChangedEvent.NewIdentityId;
            _logger.InfoFormat("identity change detected: {0}, {1}", oldIdentity, newIdentity);
            if (oldIdentity != newIdentity) Local.ChangeIdentityId(oldIdentity, newIdentity);
        }

        protected string GetIdentityId()
        {
            return DatasetUtils.GetIdentityId(cognitoCredentials);
        }
        #endregion

        #region Helper Methods

        internal List<DatasetMetadata> RefreshDatasetMetadataHelper()
        {
            List<DatasetMetadata> response = remote.GetDatasetMetadata();
            Local.UpdateDatasetMetadata(GetIdentityId(), response);
            return response;
        }

        #endregion
    }
}
