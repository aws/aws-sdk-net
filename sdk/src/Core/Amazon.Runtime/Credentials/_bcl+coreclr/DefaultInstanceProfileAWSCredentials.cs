/*
 * Copyright 2011-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Globalization;
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime
{
    /// <summary>
    /// This class is exclusively used by FallbackCredentialsFactory.  InstanceProfileAWSCredentials allows 
    /// configuring Roles and every instance hits IMDS individually.  This class has a singleton timer task
    /// that caches instance profile credentials every 2 minutes.
    /// </summary>
    internal class DefaultInstanceProfileAWSCredentials : AWSCredentials, IDisposable
    {
        private static object instanceLock = new object();
        
        private Timer credentialsRetrieverTimer;
        private ImmutableCredentials lastRetrievedCredentials;
        private Logger logger;

        private static readonly TimeSpan neverTimespan = TimeSpan.FromMilliseconds(-1);
        private static readonly TimeSpan refreshRate = TimeSpan.FromMinutes(2); // EC2 refreshes credentials 5 min before expiration
        private const string FailedToGetCredentialsMessage = "Failed to retrieve credentials from EC2 Instance Metadata Service.";
        
        private static DefaultInstanceProfileAWSCredentials _instance;
        public static DefaultInstanceProfileAWSCredentials Instance
        {
            get
            {
                CheckIsIMDSEnabled();

                if (_instance == null)
                {
                    lock (instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DefaultInstanceProfileAWSCredentials();

                            // force a fetch of credentials the very first time & schedule a timer task.
                            _instance.RenewCredentials(null);
                        }
                    }
                }

                return _instance;
            }
        }

        private DefaultInstanceProfileAWSCredentials()
        {
            // if IMDS is turned off, no need to spin up the timer task
            if (!EC2InstanceMetadata.IsIMDSEnabled) return;

            logger = Logger.GetLogger(typeof(DefaultInstanceProfileAWSCredentials));

            // don't start the timer right away or periodic signalling.
            credentialsRetrieverTimer = new Timer(RenewCredentials, null, neverTimespan, neverTimespan);
        }

        #region Overrides
        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override ImmutableCredentials GetCredentials()
        {
            CheckIsIMDSEnabled();

            var credentials = lastRetrievedCredentials?.Copy();

            if (credentials == null)
            {
                throw new AmazonServiceException(FailedToGetCredentialsMessage);
            }

            return credentials;
        }

#if AWS_ASYNC_API   
        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override Task<ImmutableCredentials> GetCredentialsAsync()
        {
            return Task.FromResult<ImmutableCredentials>(GetCredentials());
        }
#endif
        #endregion
        
        #region Private members
        private void RenewCredentials(object unused)
        {
            try
            {
                ImmutableCredentials newCredentials = null;
                var securityCredentials = EC2InstanceMetadata.IAMSecurityCredentials;

                string firstRole = null;
                foreach (var role in securityCredentials.Keys)
                {
                    firstRole = role;
                    break;
                }

                if (string.IsNullOrEmpty(firstRole))
                    throw new AmazonServiceException("Unable to get EC2 instance role from EC2 Instance Metadata Service.");

                var metadata = securityCredentials[firstRole];
                if (metadata == null)
                    throw new AmazonServiceException("Unable to get credentials for role \"" + firstRole + "\" from EC2 Instance Metadata Service.");
                
                newCredentials = new ImmutableCredentials(metadata.AccessKeyId, metadata.SecretAccessKey, metadata.Token);

                // if another thread is holding onto a readlock, we don't want to cancel the refresh.
                // wait at least a few seconds until lock becomes free. with 2 min refresh rate,
                // we only get 2 tries to refresh credentials before it expires.
                Instance.lastRetrievedCredentials = newCredentials;
            }
            catch (Exception e)
            {
                Instance.lastRetrievedCredentials = null;

                // we want to suppress any exceptions from this timer task.
                Instance.logger.Error(e, FailedToGetCredentialsMessage);

            }
            finally
            {
                // re-invoke this task once after time specified by refreshRate
                Instance.credentialsRetrieverTimer.Change(refreshRate, neverTimespan);
            }
        }

        private static void CheckIsIMDSEnabled()
        {
            // keep this behavior consistent with GetObjectFromResponse case.
            if (!EC2InstanceMetadata.IsIMDSEnabled) throw new AmazonServiceException("Unable to retrieve credentials.");
        }
        #endregion

        #region IDisposable Support
        private bool isDisposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    lock (instanceLock)
                    {
                        credentialsRetrieverTimer.Dispose();
                        logger = null;
                        _instance = null;
                    }
                }

                isDisposed = true;
            }
        }

        /// <summary>
        /// Dispose this object and all related resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
