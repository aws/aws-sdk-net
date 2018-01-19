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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.TranscribeService.Model;
using Amazon.TranscribeService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Implementation for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial class AmazonTranscribeServiceClient : AmazonServiceClient, IAmazonTranscribeService
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        public AmazonTranscribeServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="config">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AmazonTranscribeServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials and an
        /// AmazonTranscribeServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, AmazonTranscribeServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  GetTranscriptionJob

        internal virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
        {
            var marshaller = new GetTranscriptionJobRequestMarshaller();
            var unmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptionJobRequest,GetTranscriptionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual Task<GetTranscriptionJobResponse> GetTranscriptionJobAsync(GetTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTranscriptionJobRequestMarshaller();
            var unmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetTranscriptionJobRequest,GetTranscriptionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTranscriptionJobs

        internal virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
        {
            var marshaller = new ListTranscriptionJobsRequestMarshaller();
            var unmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTranscriptionJobsRequest,ListTranscriptionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual Task<ListTranscriptionJobsResponse> ListTranscriptionJobsAsync(ListTranscriptionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTranscriptionJobsRequestMarshaller();
            var unmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTranscriptionJobsRequest,ListTranscriptionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTranscriptionJob

        internal virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
        {
            var marshaller = new StartTranscriptionJobRequestMarshaller();
            var unmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartTranscriptionJobRequest,StartTranscriptionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual Task<StartTranscriptionJobResponse> StartTranscriptionJobAsync(StartTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartTranscriptionJobRequestMarshaller();
            var unmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTranscriptionJobRequest,StartTranscriptionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}