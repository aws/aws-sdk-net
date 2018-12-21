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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaStore.Model;
using Amazon.MediaStore.Model.Internal.MarshallTransformations;
using Amazon.MediaStore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaStore
{
    /// <summary>
    /// Implementation for accessing MediaStore
    ///
    /// An AWS Elemental MediaStore container is a namespace that holds folders and objects.
    /// You use a container endpoint to create, read, and delete objects.
    /// </summary>
    public partial class AmazonMediaStoreClient : AmazonServiceClient, IAmazonMediaStore
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaStoreMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        public AmazonMediaStoreClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        public AmazonMediaStoreClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AmazonMediaStoreConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials and an
        /// AmazonMediaStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, AmazonMediaStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaStoreConfig clientConfig)
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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


        #region  CreateContainer

        internal virtual CreateContainerResponse CreateContainer(CreateContainerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return Invoke<CreateContainerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual Task<CreateContainerResponse> CreateContainerAsync(CreateContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainer

        internal virtual DeleteContainerResponse DeleteContainer(DeleteContainerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual Task<DeleteContainerResponse> DeleteContainerAsync(DeleteContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainerPolicy

        internal virtual DeleteContainerPolicyResponse DeleteContainerPolicy(DeleteContainerPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual Task<DeleteContainerPolicyResponse> DeleteContainerPolicyAsync(DeleteContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCorsPolicy

        internal virtual DeleteCorsPolicyResponse DeleteCorsPolicy(DeleteCorsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteCorsPolicy">REST API Reference for DeleteCorsPolicy Operation</seealso>
        public virtual Task<DeleteCorsPolicyResponse> DeleteCorsPolicyAsync(DeleteCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecyclePolicy

        internal virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainer

        internal virtual DescribeContainerResponse DescribeContainer(DescribeContainerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual Task<DescribeContainerResponse> DescribeContainerAsync(DescribeContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerPolicy

        internal virtual GetContainerPolicyResponse GetContainerPolicy(GetContainerPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual Task<GetContainerPolicyResponse> GetContainerPolicyAsync(GetContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCorsPolicy

        internal virtual GetCorsPolicyResponse GetCorsPolicy(GetCorsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<GetCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetCorsPolicy">REST API Reference for GetCorsPolicy Operation</seealso>
        public virtual Task<GetCorsPolicyResponse> GetCorsPolicyAsync(GetCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicy

        internal virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContainers

        internal virtual ListContainersResponse ListContainers(ListContainersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainersResponseUnmarshaller.Instance;

            return Invoke<ListContainersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListContainers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual Task<ListContainersResponse> ListContainersAsync(ListContainersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainersResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutContainerPolicy

        internal virtual PutContainerPolicyResponse PutContainerPolicy(PutContainerPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual Task<PutContainerPolicyResponse> PutContainerPolicyAsync(PutContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCorsPolicy

        internal virtual PutCorsPolicyResponse PutCorsPolicy(PutCorsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<PutCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutCorsPolicy">REST API Reference for PutCorsPolicy Operation</seealso>
        public virtual Task<PutCorsPolicyResponse> PutCorsPolicyAsync(PutCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecyclePolicy

        internal virtual PutLifecyclePolicyResponse PutLifecyclePolicy(PutLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<PutLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutLifecyclePolicy">REST API Reference for PutLifecyclePolicy Operation</seealso>
        public virtual Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}