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

using Amazon.MediaStore.Model;
using Amazon.MediaStore.Model.Internal.MarshallTransformations;
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
            var marshaller = CreateContainerRequestMarshaller.Instance;
            var unmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return Invoke<CreateContainerRequest,CreateContainerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateContainerRequestMarshaller.Instance;
            var unmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerRequest,CreateContainerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainer

        internal virtual DeleteContainerResponse DeleteContainer(DeleteContainerRequest request)
        {
            var marshaller = DeleteContainerRequestMarshaller.Instance;
            var unmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerRequest,DeleteContainerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteContainerRequestMarshaller.Instance;
            var unmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerRequest,DeleteContainerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainerPolicy

        internal virtual DeleteContainerPolicyResponse DeleteContainerPolicy(DeleteContainerPolicyRequest request)
        {
            var marshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerPolicyRequest,DeleteContainerPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerPolicyRequest,DeleteContainerPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCorsPolicy

        internal virtual DeleteCorsPolicyResponse DeleteCorsPolicy(DeleteCorsPolicyRequest request)
        {
            var marshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsPolicyRequest,DeleteCorsPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCorsPolicyRequest,DeleteCorsPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainer

        internal virtual DescribeContainerResponse DescribeContainer(DescribeContainerRequest request)
        {
            var marshaller = DescribeContainerRequestMarshaller.Instance;
            var unmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerRequest,DescribeContainerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeContainerRequestMarshaller.Instance;
            var unmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerRequest,DescribeContainerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContainerPolicy

        internal virtual GetContainerPolicyResponse GetContainerPolicy(GetContainerPolicyRequest request)
        {
            var marshaller = GetContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerPolicyRequest,GetContainerPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerPolicyRequest,GetContainerPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCorsPolicy

        internal virtual GetCorsPolicyResponse GetCorsPolicy(GetCorsPolicyRequest request)
        {
            var marshaller = GetCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<GetCorsPolicyRequest,GetCorsPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetCorsPolicyRequest,GetCorsPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListContainers

        internal virtual ListContainersResponse ListContainers(ListContainersRequest request)
        {
            var marshaller = ListContainersRequestMarshaller.Instance;
            var unmarshaller = ListContainersResponseUnmarshaller.Instance;

            return Invoke<ListContainersRequest,ListContainersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListContainersRequestMarshaller.Instance;
            var unmarshaller = ListContainersResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainersRequest,ListContainersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutContainerPolicy

        internal virtual PutContainerPolicyResponse PutContainerPolicy(PutContainerPolicyRequest request)
        {
            var marshaller = PutContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerPolicyRequest,PutContainerPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutContainerPolicyRequestMarshaller.Instance;
            var unmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutContainerPolicyRequest,PutContainerPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutCorsPolicy

        internal virtual PutCorsPolicyResponse PutCorsPolicy(PutCorsPolicyRequest request)
        {
            var marshaller = PutCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<PutCorsPolicyRequest,PutCorsPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutCorsPolicyRequestMarshaller.Instance;
            var unmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutCorsPolicyRequest,PutCorsPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}