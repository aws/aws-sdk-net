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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer.Internal;
using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.Glacier.Transfer
{
    /// <summary>
    /// Provides a high level API for managing transfers to and from Amazon Glacier. This removes 
    /// complexities such as breaking files into parts and computing check sums.
    /// </summary>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("ArchiveTransferManager has not been updated to support Native AOT compilations.")]
#endif
    public partial class ArchiveTransferManager : IDisposable
    {
        #region Private/internal members

        // Threshold for when to use multipart upload operations
        internal const long MULTIPART_UPLOAD_SIZE_THRESHOLD = 1024L * 1024L * 10L;
        private bool shouldDispose;
        private bool disposed;
        private IAmazonGlacier glacierClient;

        /// <summary>
        /// The Glacier client used by the ArchiveTransferManager.
        /// </summary>
        internal AmazonGlacierClient GlacierClient
        {
            get { return this.glacierClient as AmazonGlacierClient; }
        }

        #endregion

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing && glacierClient != null)
                {
                    if (shouldDispose)
                    {
                        glacierClient.Dispose();
                    }
                    glacierClient = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~ArchiveTransferManager()
        {
            this.Dispose(false);
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs an ArchiveTransferManager object for the specified Amazon Glacier region endpoint using the credentials
        /// loaded from the application's default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(RegionEndpoint region)
        {
            this.glacierClient = new AmazonGlacierClient(region);
            this.shouldDispose = true;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object using an existing Amazon Glacier client.
        /// </summary>
        /// <param name="glacier">An AmazonGlacier client that used to make service calls.</param>
        public ArchiveTransferManager(IAmazonGlacier glacier)
        {
            this.glacierClient = glacier;
            this.shouldDispose = false;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object using the specified AWS credentials and Amazon Glacier region endpoint.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(AWSCredentials credentials, RegionEndpoint region)
            : this(new AmazonGlacierClient(credentials, region))
        {
            this.shouldDispose = true;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object with the specified AWS Access Key ID, AWS Secret Key, and Amazon Glacier region endpoint.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new AmazonGlacierClient(awsAccessKeyId, awsSecretAccessKey, region))
        {
            this.shouldDispose = true;
        }

        #endregion


        internal class UserAgentPostFix
        {
            string operation;

            internal UserAgentPostFix(string operation)
            {
                this.operation = operation;
            }

            internal void UserAgentRequestEventHandlerSync(object sender, RequestEventArgs args)
            {
                WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
                if (wsArgs != null)
                {
                    ((Runtime.Internal.IAmazonWebServiceRequest)wsArgs.Request).UserAgentDetails.AddUserAgentComponent("ft/ArchiveTransferManager md/" + this.operation);
                }
            }
        }
    }
}
