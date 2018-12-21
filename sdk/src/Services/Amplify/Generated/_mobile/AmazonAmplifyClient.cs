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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Amplify.Model;
using Amazon.Amplify.Model.Internal.MarshallTransformations;
using Amazon.Amplify.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Amplify
{
    /// <summary>
    /// Implementation for accessing Amplify
    ///
    /// Amplify is a fully managed continuous deployment and hosting service for modern web
    /// apps.
    /// </summary>
    public partial class AmazonAmplifyClient : AmazonServiceClient, IAmazonAmplify
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AmazonAmplifyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials and an
        /// AmazonAmplifyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AWSCredentials credentials, AmazonAmplifyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyConfig clientConfig)
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


        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBranch

        internal virtual CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainAssociation

        internal virtual CreateDomainAssociationResponse CreateDomainAssociation(CreateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual Task<CreateDomainAssociationResponse> CreateDomainAssociationAsync(CreateDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBranch

        internal virtual DeleteBranchResponse DeleteBranch(DeleteBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return Invoke<DeleteBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainAssociation

        internal virtual DeleteDomainAssociationResponse DeleteDomainAssociation(DeleteDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual Task<DeleteDomainAssociationResponse> DeleteDomainAssociationAsync(DeleteDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApp

        internal virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBranch

        internal virtual GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return InvokeAsync<GetBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainAssociation

        internal virtual GetDomainAssociationResponse GetDomainAssociation(GetDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<GetDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual Task<GetDomainAssociationResponse> GetDomainAssociationAsync(GetDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApps

        internal virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBranches

        internal virtual ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainAssociations

        internal virtual ListDomainAssociationsResponse ListDomainAssociations(ListDomainAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListDomainAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual Task<ListDomainAssociationsResponse> ListDomainAssociationsAsync(ListDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJob

        internal virtual StartJobResponse StartJob(StartJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return Invoke<StartJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual Task<StartJobResponse> StartJobAsync(StartJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopJob

        internal virtual StopJobResponse StopJob(StopJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return Invoke<StopJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual Task<StopJobResponse> StopJobAsync(StopJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBranch

        internal virtual UpdateBranchResponse UpdateBranch(UpdateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual Task<UpdateBranchResponse> UpdateBranchAsync(UpdateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainAssociation

        internal virtual UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual Task<UpdateDomainAssociationResponse> UpdateDomainAssociationAsync(UpdateDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}