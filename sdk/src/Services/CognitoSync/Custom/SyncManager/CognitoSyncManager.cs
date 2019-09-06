//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.CognitoIdentity;
using Logger = Amazon.Runtime.Internal.Util.Logger;
using Amazon.Util.Internal;
#if BCL45 || PCL
using System.Threading.Tasks;
#endif
using System.Threading;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>;
    /// The Cognito Sync Manager allows your application to store data 
    /// in the cloud for your users and synchronize across other devices. The library 
    /// uses the sqlite for local storage API and defaults to inmemory where sqlite 
    /// is not available to create a local cache for the data, similar to our SDK. 
    /// This allows your application to access stored data even when there is no connectivity.
    /// <code>
    /// CognitoAWSCredentials credentials = new CognitoAWSCredentials(&quot;identityPoolId&quot;,&quot;RegionEndpoint&quot;)
    /// //using default region from your app.config or awsconfig.xml
    /// CognitoSyncManager cognitoSyncManager = new CognitoSyncManager(credentials);
    /// // creating a dataset
    /// Dataset playerInfo = cognitoSyncManager.OpenOrCreateDataset(&quot;playerInfo&quot;);
    /// // add some values into your dataset
    /// playerInfo.Put(&quot;high_score&quot;, &quot;90&quot;);
    /// playerInfo.Put(&quot;name&quot;, &quot;John&quot;);
    /// // push changes to remote if needed
    /// playerInfo.Synchronize();
    /// </code>
    /// Note: Some platforms may only expose async methods such as SynchronizeAsync().
    /// </summary>
    /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html">Amazon Cognito Sync Dev. Guide - Synchronizing Data</seealso>
    public partial class CognitoSyncManager : IDisposable
    {
        private Logger _logger;

        private bool _disposed;

        private readonly ILocalStorage Local;

        private readonly CognitoSyncStorage Remote;

        private readonly CognitoAWSCredentials CognitoCredentials;

        #region Constructor

        /// <summary>
        /// Creates an instance of CognitoSyncManager using Cognito Credentials, the region is picked up from the config if it available
        /// <code>
        /// CognitoSyncManager cognitoSyncManager = new CognitoSyncManager(credentials)
        /// </code>
        /// </summary>
        /// <param name="cognitoCredentials"><see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/></param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#initializing-client">Amazon Cognito Sync Dev. Guide - Initializing Client</seealso>
        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials) : this(cognitoCredentials, new AmazonCognitoSyncConfig()) { }

        /// <summary>
        /// Creates an instance of CognitoSyncManager using cognito credentials and a specific region
        /// <code>
        /// CognitoSyncManager cognitoSyncManager = new CognitoSyncManager(credentials, RegionEndpoint.USEAST1)
        /// </code>
        /// </summary>
        /// <param name="cognitoCredentials"><see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/></param>
        /// <param name="endpoint"><see cref="Amazon.RegionEndpoint"/></param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#initializing-client">Amazon Cognito Sync Dev. Guide - Initializing Client</seealso>
        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials, RegionEndpoint endpoint)
            : this(cognitoCredentials, new AmazonCognitoSyncConfig
            {
                RegionEndpoint = endpoint
            })
        { }

        /// <summary>
        /// Creates an instance of CognitoSyncManager using cognito credentials and a configuration object
        /// <code>
        /// CognitoSyncManager cognitoSyncManager = new CognitoSyncManager(credentials,new AmazonCognitoSyncConfig { RegionEndpoint =  RegionEndpoint.USEAST1})
        /// </code>
        /// </summary>
        /// <param name="cognitoCredentials"><see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/></param>
        /// <param name="config"><see cref="Amazon.CognitoSync.AmazonCognitoSyncConfig"/></param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#initializing-client">Amazon Cognito Sync Dev. Guide - Initializing Client</seealso>
        public CognitoSyncManager(CognitoAWSCredentials cognitoCredentials, AmazonCognitoSyncConfig config)
        {
            if (cognitoCredentials == null)
            {
                throw new ArgumentNullException("cognitoCredentials");
            }

#if BCL
            ValidateParameters();
#endif

            this.CognitoCredentials = cognitoCredentials;
            Local = new SQLiteLocalStorage();
            Remote = new CognitoSyncStorage(CognitoCredentials, config);

            cognitoCredentials.IdentityChangedEvent += this.IdentityChanged;

            _logger = Logger.GetLogger(this.GetType());
        }

        #endregion

        #region Dispose Methods

        /// <summary>
        /// Releases the resources consumed by this object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the resources consumed by this object if disposing is true. 
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                Remote.Dispose();
                Local.Dispose();
                CognitoCredentials.IdentityChangedEvent -= this.IdentityChanged;
                _disposed = true;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Opens or creates a dataset. If the dataset doesn't exist, an empty one
        /// with the given name will be created. Otherwise, the dataset is loaded from
        /// local storage. If a dataset is marked as deleted but hasn't been deleted
        /// on remote via  the RefreshDatasetMetadata operation, it will throw
        /// <see cref="System.InvalidOperationException"/>.
        /// <code>
        /// Dataset dataset = cognitoSyncManager.OpenOrCreateDataset("myDatasetName");
        /// </code>
        /// </summary>
        /// <returns>Dataset loaded from local storage</returns>
        /// <param name="datasetName">DatasetName, must be [a-zA-Z0=9_.:-]+</param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#understanding-datasets">Amazon Cognito Sync Dev. Guide - Understanding Datasets</seealso>
        public Dataset OpenOrCreateDataset(string datasetName)
        {
            DatasetUtils.ValidateDatasetName(datasetName);
            Local.CreateDataset(IdentityId, datasetName);
            return new Dataset(datasetName, CognitoCredentials, Local, Remote);
        }


        /// <summary>
        /// Retrieves a list of datasets from local storage. It may not reflect the
        /// latest dataset on the remote storage until the RefreshDatasetMetadata
        /// operation is performed.
        /// </summary>
        /// <returns>List of datasets</returns>
        public List<DatasetMetadata> ListDatasets()
        {
            return Local.GetDatasetMetadata(IdentityId);
        }

        /// <summary>
        /// Wipes all user data cached locally, including dataset metadata, and all records,
        /// and optionally identity id and session credentials. Any data that hasn't been
        /// synced will be lost. This method is usually used when customer logs out.
        /// <param name="wipeCredentialsAndID">Wipe Credentials and IdentityId.</param>
        /// </summary>
        public void WipeData(bool wipeCredentialsAndID)
        {
            Local.WipeData();
            _logger.InfoFormat("All data has been wiped");
            if (wipeCredentialsAndID)
            {
                CognitoCredentials.Clear();
                _logger.InfoFormat("All datasets and records have been wiped");
            }
            else
            {
                _logger.InfoFormat("All data has been wiped");
            }
        }

        /// <summary>
        /// Wipes all user data cached locally, including identity id, session
        /// credentials, dataset metadata, and all records. Any data that hasn't been
        /// synced will be lost. This method is usually used when customer logs out.
        /// </summary>
        public void WipeData()
        {
            WipeData(true);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// This is triggered when an Identity Change event occurs. 
        /// The dataset are then remapped to the new identity id.
        /// This may happend for example when a user is working with 
        /// unauthenticated id and later decides to authenticate 
        /// himself with a public login provider
        /// </summary>
        /// <param name="sender">The object which triggered this methos</param>
        /// <param name="e">Event Arguments</param>
        protected void IdentityChanged(object sender, EventArgs e)
        {
            Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs identityChangedEvent = e as Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs;
            if (identityChangedEvent.NewIdentityId != null)
            {
                String oldIdentity = string.IsNullOrEmpty(identityChangedEvent.OldIdentityId) ? DatasetUtils.UNKNOWN_IDENTITY_ID : identityChangedEvent.OldIdentityId;
                String newIdentity = identityChangedEvent.NewIdentityId;
                _logger.InfoFormat("Identity changed from {0} to {1}", oldIdentity, newIdentity);
                Local.ChangeIdentityId(oldIdentity, newIdentity);
            }
        }

        /// <summary>
        /// Returns the IdentityId, if the application is not online then an 
        /// Unknown Identity Will be returned
        /// </summary>
        /// <returns>Identity ID</returns>
        protected string IdentityId
        {
            get
            {
                return DatasetUtils.GetIdentityId(CognitoCredentials);
            }
        }
        #endregion

        #region private methods
#if BCL
        static void ValidateParameters()
        {
            if (string.IsNullOrEmpty(AWSConfigs.ApplicationName))
            {
                throw new ArgumentException("A valid application name needs to configured to use this API." +
                    "The application name can be configured through app.config or by setting the Amazon.AWSConfigs.ApplicationName property.");
            }
        }
#endif
        #endregion

    }
}
