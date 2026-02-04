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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.EKS.Model;
using Amazon.EKS.Model.Internal.MarshallTransformations;
using Amazon.EKS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.EKS
{
    /// <summary>
    /// <para>Implementation for accessing EKS</para>
    ///
    /// Amazon Elastic Kubernetes Service (Amazon EKS) is a managed service that makes it
    /// easy for you to run Kubernetes on Amazon Web Services without needing to setup or
    /// maintain your own Kubernetes control plane. Kubernetes is an open-source system for
    /// automating the deployment, scaling, and management of containerized applications.
    /// 
    ///  
    /// <para>
    /// Amazon EKS runs up-to-date versions of the open-source Kubernetes software, so you
    /// can use all the existing plugins and tooling from the Kubernetes community. Applications
    /// running on Amazon EKS are fully compatible with applications running on any standard
    /// Kubernetes environment, whether running in on-premises data centers or public clouds.
    /// This means that you can easily migrate any standard Kubernetes application to Amazon
    /// EKS without any code modification required.
    /// </para>
    /// </summary>
    public partial class AmazonEKSClient : AmazonServiceClient, IAmazonEKS
    {
        private static IServiceMetadata serviceMetadata = new AmazonEKSMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IEKSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEKSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EKSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
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
        public AmazonEKSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEKSConfig()) { }

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
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
        public AmazonEKSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEKSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEKSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(AmazonEKSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEKSClient(AWSCredentials credentials)
            : this(credentials, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEKSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Credentials and an
        /// AmazonEKSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(AWSCredentials credentials, AmazonEKSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEKSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEKSClient Configuration Object</param>
        public AmazonEKSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEKSConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEKSEndpointResolver());
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


        #region  AssociateAccessPolicy

        /// <summary>
        /// Associates an access policy and its scope to an access entry. For more information
        /// about associating access policies, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-policies.html">Associating
        /// and disassociating access policies to and from access entries</a> in the <i>Amazon
        /// EKS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the AssociateAccessPolicy service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateAccessPolicy">REST API Reference for AssociateAccessPolicy Operation</seealso>
        public virtual AssociateAccessPolicyResponse AssociateAccessPolicy(AssociateAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<AssociateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccessPolicy operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateAccessPolicy">REST API Reference for AssociateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginAssociateAccessPolicy(AssociateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  AssociateAccessPolicyResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateAccessPolicy">REST API Reference for AssociateAccessPolicy Operation</seealso>
        public virtual AssociateAccessPolicyResponse EndAssociateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateEncryptionConfig

        /// <summary>
        /// Associates an encryption configuration to an existing cluster.
        /// 
        ///  
        /// <para>
        /// Use this API to enable encryption on existing clusters that don't already have encryption
        /// enabled. This allows you to implement a defense-in-depth security strategy without
        /// migrating applications to new Amazon EKS clusters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the AssociateEncryptionConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateEncryptionConfig">REST API Reference for AssociateEncryptionConfig Operation</seealso>
        public virtual AssociateEncryptionConfigResponse AssociateEncryptionConfig(AssociateEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateEncryptionConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEncryptionConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateEncryptionConfig">REST API Reference for AssociateEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginAssociateEncryptionConfig(AssociateEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  AssociateEncryptionConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateEncryptionConfig">REST API Reference for AssociateEncryptionConfig Operation</seealso>
        public virtual AssociateEncryptionConfigResponse EndAssociateEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateIdentityProviderConfig

        /// <summary>
        /// Associates an identity provider configuration to a cluster.
        /// 
        ///  
        /// <para>
        /// If you want to authenticate identities using an identity provider, you can create
        /// an identity provider configuration and associate it to your cluster. After configuring
        /// authentication to your cluster you can create Kubernetes <c>Role</c> and <c>ClusterRole</c>
        /// objects, assign permissions to them, and then bind them to the identities using Kubernetes
        /// <c>RoleBinding</c> and <c>ClusterRoleBinding</c> objects. For more information see
        /// <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Using RBAC
        /// Authorization</a> in the Kubernetes documentation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIdentityProviderConfig service method.</param>
        /// 
        /// <returns>The response from the AssociateIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateIdentityProviderConfig">REST API Reference for AssociateIdentityProviderConfig Operation</seealso>
        public virtual AssociateIdentityProviderConfigResponse AssociateIdentityProviderConfig(AssociateIdentityProviderConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateIdentityProviderConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIdentityProviderConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIdentityProviderConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateIdentityProviderConfig">REST API Reference for AssociateIdentityProviderConfig Operation</seealso>
        public virtual IAsyncResult BeginAssociateIdentityProviderConfig(AssociateIdentityProviderConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIdentityProviderConfig.</param>
        /// 
        /// <returns>Returns a  AssociateIdentityProviderConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateIdentityProviderConfig">REST API Reference for AssociateIdentityProviderConfig Operation</seealso>
        public virtual AssociateIdentityProviderConfigResponse EndAssociateIdentityProviderConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateIdentityProviderConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessEntry

        /// <summary>
        /// Creates an access entry.
        /// 
        ///  
        /// <para>
        /// An access entry allows an IAM principal to access your cluster. Access entries can
        /// replace the need to maintain entries in the <c>aws-auth</c> <c>ConfigMap</c> for authentication.
        /// You have the following options for authorizing an IAM principal to access Kubernetes
        /// objects on your cluster: Kubernetes role-based access control (RBAC), Amazon EKS,
        /// or both. Kubernetes RBAC authorization requires you to create and manage Kubernetes
        /// <c>Role</c>, <c>ClusterRole</c>, <c>RoleBinding</c>, and <c>ClusterRoleBinding</c>
        /// objects, in addition to managing access entries. If you use Amazon EKS authorization
        /// exclusively, you don't need to create and manage Kubernetes <c>Role</c>, <c>ClusterRole</c>,
        /// <c>RoleBinding</c>, and <c>ClusterRoleBinding</c> objects.
        /// </para>
        ///  
        /// <para>
        /// For more information about access entries, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html">Access
        /// entries</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessEntry service method.</param>
        /// 
        /// <returns>The response from the CreateAccessEntry service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAccessEntry">REST API Reference for CreateAccessEntry Operation</seealso>
        public virtual CreateAccessEntryResponse CreateAccessEntry(CreateAccessEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessEntryResponseUnmarshaller.Instance;

            return Invoke<CreateAccessEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessEntry operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAccessEntry">REST API Reference for CreateAccessEntry Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessEntry(CreateAccessEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessEntry.</param>
        /// 
        /// <returns>Returns a  CreateAccessEntryResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAccessEntry">REST API Reference for CreateAccessEntry Operation</seealso>
        public virtual CreateAccessEntryResponse EndCreateAccessEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAddon

        /// <summary>
        /// Creates an Amazon EKS add-on.
        /// 
        ///  
        /// <para>
        /// Amazon EKS add-ons help to automate the provisioning and lifecycle management of common
        /// operational software for Amazon EKS clusters. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html">Amazon
        /// EKS add-ons</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddon service method.</param>
        /// 
        /// <returns>The response from the CreateAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAddon">REST API Reference for CreateAddon Operation</seealso>
        public virtual CreateAddonResponse CreateAddon(CreateAddonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonResponseUnmarshaller.Instance;

            return Invoke<CreateAddonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddon operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAddon">REST API Reference for CreateAddon Operation</seealso>
        public virtual IAsyncResult BeginCreateAddon(CreateAddonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddon.</param>
        /// 
        /// <returns>Returns a  CreateAddonResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAddon">REST API Reference for CreateAddon Operation</seealso>
        public virtual CreateAddonResponse EndCreateAddon(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAddonResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCapability

        /// <summary>
        /// Creates a managed capability resource for an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// Capabilities provide fully managed capabilities to build and scale with Kubernetes.
        /// When you create a capability, Amazon EKSprovisions and manages the infrastructure
        /// required to run the capability outside of your cluster. This approach reduces operational
        /// overhead and preserves cluster resources.
        /// </para>
        ///  
        /// <para>
        /// You can only create one Capability of each type on a given Amazon EKS cluster. Valid
        /// types are Argo CD for declarative GitOps deployment, Amazon Web Services Controllers
        /// for Kubernetes (ACK) for resource management, and Kube Resource Orchestrator (KRO)
        /// for Kubernetes custom resource orchestration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/capabilities.html">EKS
        /// Capabilities</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability service method.</param>
        /// 
        /// <returns>The response from the CreateCapability service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual CreateCapabilityResponse CreateCapability(CreateCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return Invoke<CreateCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual IAsyncResult BeginCreateCapability(CreateCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCapability.</param>
        /// 
        /// <returns>Returns a  CreateCapabilityResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual CreateCapabilityResponse EndCreateCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCluster

        /// <summary>
        /// Creates an Amazon EKS control plane.
        /// 
        ///  
        /// <para>
        /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
        /// software, such as <c>etcd</c> and the API server. The control plane runs in an account
        /// managed by Amazon Web Services, and the Kubernetes API is exposed by the Amazon EKS
        /// API server endpoint. Each Amazon EKS cluster control plane is single tenant and unique.
        /// It runs on its own set of Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// The cluster control plane is provisioned across multiple Availability Zones and fronted
        /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
        /// network interfaces in your VPC subnets to provide connectivity from the control plane
        /// instances to the nodes (for example, to support <c>kubectl exec</c>, <c>logs</c>,
        /// and <c>proxy</c> data flows).
        /// </para>
        ///  
        /// <para>
        /// Amazon EKS nodes run in your Amazon Web Services account and connect to your cluster's
        /// control plane over the Kubernetes API server endpoint and a certificate file that
        /// is created for your cluster.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>endpointPublicAccess</c> and <c>endpointPrivateAccess</c> parameters
        /// to enable or disable public and private access to your cluster's Kubernetes API server
        /// endpoint. By default, public access is enabled, and private access is disabled. The
        /// endpoint domain name and IP address family depends on the value of the <c>ipFamily</c>
        /// for the cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>logging</c> parameter to enable or disable exporting the Kubernetes
        /// control plane logs for your cluster to CloudWatch Logs. By default, cluster control
        /// plane logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// In most cases, it takes several minutes to create a cluster. After you create an Amazon
        /// EKS cluster, you must configure your Kubernetes tooling to communicate with the API
        /// server and launch nodes into your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-auth.html">Allowing
        /// users to access your cluster</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
        /// Amazon EKS nodes</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.UnsupportedAvailabilityZoneException">
        /// At least one of your specified cluster subnets is in an Availability Zone that does
        /// not support Amazon EKS. The exception output specifies the supported Availability
        /// Zones for your account, from which you can choose subnets for your cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEksAnywhereSubscription

        /// <summary>
        /// Creates an EKS Anywhere subscription. When a subscription is created, it is a contract
        /// agreement for the length of the term specified in the request. Licenses that are used
        /// to validate support are provisioned in Amazon Web Services License Manager and the
        /// caller account is granted access to EKS Anywhere Curated Packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEksAnywhereSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEksAnywhereSubscription service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateEksAnywhereSubscription">REST API Reference for CreateEksAnywhereSubscription Operation</seealso>
        public virtual CreateEksAnywhereSubscriptionResponse CreateEksAnywhereSubscription(CreateEksAnywhereSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEksAnywhereSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEksAnywhereSubscription operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEksAnywhereSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateEksAnywhereSubscription">REST API Reference for CreateEksAnywhereSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEksAnywhereSubscription(CreateEksAnywhereSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEksAnywhereSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEksAnywhereSubscriptionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateEksAnywhereSubscription">REST API Reference for CreateEksAnywhereSubscription Operation</seealso>
        public virtual CreateEksAnywhereSubscriptionResponse EndCreateEksAnywhereSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEksAnywhereSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFargateProfile

        /// <summary>
        /// Creates an Fargate profile for your Amazon EKS cluster. You must have at least one
        /// Fargate profile in a cluster to be able to run pods on Fargate.
        /// 
        ///  
        /// <para>
        /// The Fargate profile allows an administrator to declare which pods run on Fargate and
        /// specify which pods run on which Fargate profile. This declaration is done through
        /// the profile's selectors. Each profile can have up to five selectors that contain a
        /// namespace and labels. A namespace is required for every selector. The label field
        /// consists of multiple optional key-value pairs. Pods that match the selectors are scheduled
        /// on Fargate. If a to-be-scheduled pod matches any of the selectors in the Fargate profile,
        /// then that pod is run on Fargate.
        /// </para>
        ///  
        /// <para>
        /// When you create a Fargate profile, you must specify a pod execution role to use with
        /// the pods that are scheduled with the profile. This role is added to the cluster's
        /// Kubernetes <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Role
        /// Based Access Control</a> (RBAC) for authorization so that the <c>kubelet</c> that
        /// is running on the Fargate infrastructure can register with your Amazon EKS cluster
        /// so that it can appear in your cluster as a node. The pod execution role also provides
        /// IAM permissions to the Fargate infrastructure to allow read access to Amazon ECR image
        /// repositories. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">Pod
        /// Execution Role</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Fargate profiles are immutable. However, you can create a new updated profile to replace
        /// an existing profile and then delete the original after the updated profile has finished
        /// creating.
        /// </para>
        ///  
        /// <para>
        /// If any Fargate profiles in a cluster are in the <c>DELETING</c> status, you must wait
        /// for that Fargate profile to finish deleting before you can create any other profiles
        /// in that cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/fargate-profile.html">Fargate
        /// profile</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFargateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.UnsupportedAvailabilityZoneException">
        /// At least one of your specified cluster subnets is in an Availability Zone that does
        /// not support Amazon EKS. The exception output specifies the supported Availability
        /// Zones for your account, from which you can choose subnets for your cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateFargateProfile">REST API Reference for CreateFargateProfile Operation</seealso>
        public virtual CreateFargateProfileResponse CreateFargateProfile(CreateFargateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFargateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFargateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFargateProfile operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFargateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateFargateProfile">REST API Reference for CreateFargateProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateFargateProfile(CreateFargateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFargateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFargateProfile.</param>
        /// 
        /// <returns>Returns a  CreateFargateProfileResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateFargateProfile">REST API Reference for CreateFargateProfile Operation</seealso>
        public virtual CreateFargateProfileResponse EndCreateFargateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFargateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNodegroup

        /// <summary>
        /// Creates a managed node group for an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// You can only create a node group for your cluster that is equal to the current Kubernetes
        /// version for the cluster. All node groups are created with the latest AMI release version
        /// for the respective minor Kubernetes version of the cluster, unless you deploy a custom
        /// AMI using a launch template.
        /// </para>
        ///  
        /// <para>
        /// For later updates, you will only be able to update a node group using a launch template
        /// only if it was originally deployed with a launch template. Additionally, the launch
        /// template ID or name must match what was used when the node group was created. You
        /// can update the launch template version with necessary changes. For more information
        /// about using launch templates, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a>.
        /// </para>
        ///  
        /// <para>
        /// An Amazon EKS managed node group is an Amazon EC2 Auto Scaling group and associated
        /// Amazon EC2 instances that are managed by Amazon Web Services for an Amazon EKS cluster.
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html">Managed
        /// node groups</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Windows AMI types are only supported for commercial Amazon Web Services Regions that
        /// support Windows on Amazon EKS.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodegroup service method.</param>
        /// 
        /// <returns>The response from the CreateNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateNodegroup">REST API Reference for CreateNodegroup Operation</seealso>
        public virtual CreateNodegroupResponse CreateNodegroup(CreateNodegroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodegroupResponseUnmarshaller.Instance;

            return Invoke<CreateNodegroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNodegroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNodegroup operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNodegroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateNodegroup">REST API Reference for CreateNodegroup Operation</seealso>
        public virtual IAsyncResult BeginCreateNodegroup(CreateNodegroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodegroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNodegroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNodegroup.</param>
        /// 
        /// <returns>Returns a  CreateNodegroupResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateNodegroup">REST API Reference for CreateNodegroup Operation</seealso>
        public virtual CreateNodegroupResponse EndCreateNodegroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNodegroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePodIdentityAssociation

        /// <summary>
        /// Creates an EKS Pod Identity association between a service account in an Amazon EKS
        /// cluster and an IAM role with <i>EKS Pod Identity</i>. Use EKS Pod Identity to give
        /// temporary IAM credentials to Pods and the credentials are rotated automatically.
        /// 
        ///  
        /// <para>
        /// Amazon EKS Pod Identity associations provide the ability to manage credentials for
        /// your applications, similar to the way that Amazon EC2 instance profiles provide credentials
        /// to Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// If a Pod uses a service account that has an association, Amazon EKS sets environment
        /// variables in the containers of the Pod. The environment variables configure the Amazon
        /// Web Services SDKs, including the Command Line Interface, to use the EKS Pod Identity
        /// credentials.
        /// </para>
        ///  
        /// <para>
        /// EKS Pod Identity is a simpler method than <i>IAM roles for service accounts</i>, as
        /// this method doesn't use OIDC identity providers. Additionally, you can configure a
        /// role for EKS Pod Identity once, and reuse it across clusters.
        /// </para>
        ///  
        /// <para>
        /// Similar to Amazon Web Services IAM behavior, EKS Pod Identity associations are eventually
        /// consistent, and may take several seconds to be effective after the initial API call
        /// returns successfully. You must design your applications to account for these potential
        /// delays. We recommend that you don’t include association create/updates in the critical,
        /// high-availability code paths of your application. Instead, make changes in a separate
        /// initialization or setup routine that you run less frequently.
        /// </para>
        ///  
        /// <para>
        /// You can set a <i>target IAM role</i> in the same or a different account for advanced
        /// scenarios. With a target role, EKS Pod Identity automatically performs two role assumptions
        /// in sequence: first assuming the role in the association that is in this account, then
        /// using those credentials to assume the target IAM role. This process provides your
        /// Pod with temporary credentials that have the permissions defined in the target role,
        /// allowing secure access to resources in another Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePodIdentityAssociation service method.</param>
        /// 
        /// <returns>The response from the CreatePodIdentityAssociation service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreatePodIdentityAssociation">REST API Reference for CreatePodIdentityAssociation Operation</seealso>
        public virtual CreatePodIdentityAssociationResponse CreatePodIdentityAssociation(CreatePodIdentityAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePodIdentityAssociationResponseUnmarshaller.Instance;

            return Invoke<CreatePodIdentityAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePodIdentityAssociation operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePodIdentityAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreatePodIdentityAssociation">REST API Reference for CreatePodIdentityAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreatePodIdentityAssociation(CreatePodIdentityAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePodIdentityAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePodIdentityAssociation.</param>
        /// 
        /// <returns>Returns a  CreatePodIdentityAssociationResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreatePodIdentityAssociation">REST API Reference for CreatePodIdentityAssociation Operation</seealso>
        public virtual CreatePodIdentityAssociationResponse EndCreatePodIdentityAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePodIdentityAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessEntry

        /// <summary>
        /// Deletes an access entry.
        /// 
        ///  
        /// <para>
        /// Deleting an access entry of a type other than <c>Standard</c> can cause your cluster
        /// to function improperly. If you delete an access entry in error, you can recreate it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessEntry service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAccessEntry">REST API Reference for DeleteAccessEntry Operation</seealso>
        public virtual DeleteAccessEntryResponse DeleteAccessEntry(DeleteAccessEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessEntry operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAccessEntry">REST API Reference for DeleteAccessEntry Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessEntry(DeleteAccessEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessEntry.</param>
        /// 
        /// <returns>Returns a  DeleteAccessEntryResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAccessEntry">REST API Reference for DeleteAccessEntry Operation</seealso>
        public virtual DeleteAccessEntryResponse EndDeleteAccessEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAddon

        /// <summary>
        /// Deletes an Amazon EKS add-on.
        /// 
        ///  
        /// <para>
        /// When you remove an add-on, it's deleted from the cluster. You can always manually
        /// start an add-on on the cluster using the Kubernetes API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddon service method.</param>
        /// 
        /// <returns>The response from the DeleteAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAddon">REST API Reference for DeleteAddon Operation</seealso>
        public virtual DeleteAddonResponse DeleteAddon(DeleteAddonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddon operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAddon">REST API Reference for DeleteAddon Operation</seealso>
        public virtual IAsyncResult BeginDeleteAddon(DeleteAddonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddon.</param>
        /// 
        /// <returns>Returns a  DeleteAddonResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAddon">REST API Reference for DeleteAddon Operation</seealso>
        public virtual DeleteAddonResponse EndDeleteAddon(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAddonResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCapability

        /// <summary>
        /// Deletes a managed capability from your Amazon EKS cluster. When you delete a capability,
        /// Amazon EKS removes the capability infrastructure but retains all resources that were
        /// managed by the capability.
        /// 
        ///  
        /// <para>
        /// Before deleting a capability, you should delete all Kubernetes resources that were
        /// created by the capability. After the capability is deleted, these resources become
        /// difficult to manage because the controller that managed them is no longer available.
        /// To delete resources before removing the capability, use <c>kubectl delete</c> or remove
        /// them through your GitOps workflow.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability service method.</param>
        /// 
        /// <returns>The response from the DeleteCapability service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual DeleteCapabilityResponse DeleteCapability(DeleteCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return Invoke<DeleteCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual IAsyncResult BeginDeleteCapability(DeleteCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCapability.</param>
        /// 
        /// <returns>Returns a  DeleteCapabilityResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual DeleteCapabilityResponse EndDeleteCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Deletes an Amazon EKS cluster control plane.
        /// 
        ///  
        /// <para>
        /// If you have active services and ingress resources in your cluster that are associated
        /// with a load balancer, you must delete those services before deleting the cluster so
        /// that the load balancers are deleted properly. Otherwise, you can have orphaned resources
        /// in your VPC that prevent you from being able to delete the VPC. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/delete-cluster.html">Deleting
        /// a cluster</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you have managed node groups or Fargate profiles attached to the cluster, you must
        /// delete them first. For more information, see <c>DeleteNodgroup</c> and <c>DeleteFargateProfile</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEksAnywhereSubscription

        /// <summary>
        /// Deletes an expired or inactive subscription. Deleting inactive subscriptions removes
        /// them from the Amazon Web Services Management Console view and from list/describe API
        /// responses. Subscriptions can only be cancelled within 7 days of creation and are cancelled
        /// by creating a ticket in the Amazon Web Services Support Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEksAnywhereSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEksAnywhereSubscription service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteEksAnywhereSubscription">REST API Reference for DeleteEksAnywhereSubscription Operation</seealso>
        public virtual DeleteEksAnywhereSubscriptionResponse DeleteEksAnywhereSubscription(DeleteEksAnywhereSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEksAnywhereSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEksAnywhereSubscription operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEksAnywhereSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteEksAnywhereSubscription">REST API Reference for DeleteEksAnywhereSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEksAnywhereSubscription(DeleteEksAnywhereSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEksAnywhereSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEksAnywhereSubscriptionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteEksAnywhereSubscription">REST API Reference for DeleteEksAnywhereSubscription Operation</seealso>
        public virtual DeleteEksAnywhereSubscriptionResponse EndDeleteEksAnywhereSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEksAnywhereSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFargateProfile

        /// <summary>
        /// Deletes an Fargate profile.
        /// 
        ///  
        /// <para>
        /// When you delete a Fargate profile, any <c>Pod</c> running on Fargate that was created
        /// with the profile is deleted. If the <c>Pod</c> matches another Fargate profile, then
        /// it is scheduled on Fargate with that profile. If it no longer matches any Fargate
        /// profiles, then it's not scheduled on Fargate and may remain in a pending state.
        /// </para>
        ///  
        /// <para>
        /// Only one Fargate profile in a cluster can be in the <c>DELETING</c> status at a time.
        /// You must wait for a Fargate profile to finish deleting before you can delete any other
        /// profiles in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFargateProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteFargateProfile">REST API Reference for DeleteFargateProfile Operation</seealso>
        public virtual DeleteFargateProfileResponse DeleteFargateProfile(DeleteFargateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFargateProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFargateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFargateProfile operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFargateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteFargateProfile">REST API Reference for DeleteFargateProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteFargateProfile(DeleteFargateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFargateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFargateProfile.</param>
        /// 
        /// <returns>Returns a  DeleteFargateProfileResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteFargateProfile">REST API Reference for DeleteFargateProfile Operation</seealso>
        public virtual DeleteFargateProfileResponse EndDeleteFargateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFargateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNodegroup

        /// <summary>
        /// Deletes a managed node group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNodegroup service method.</param>
        /// 
        /// <returns>The response from the DeleteNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteNodegroup">REST API Reference for DeleteNodegroup Operation</seealso>
        public virtual DeleteNodegroupResponse DeleteNodegroup(DeleteNodegroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodegroupResponseUnmarshaller.Instance;

            return Invoke<DeleteNodegroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNodegroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNodegroup operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNodegroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteNodegroup">REST API Reference for DeleteNodegroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteNodegroup(DeleteNodegroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodegroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNodegroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNodegroup.</param>
        /// 
        /// <returns>Returns a  DeleteNodegroupResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteNodegroup">REST API Reference for DeleteNodegroup Operation</seealso>
        public virtual DeleteNodegroupResponse EndDeleteNodegroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNodegroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePodIdentityAssociation

        /// <summary>
        /// Deletes a EKS Pod Identity association.
        /// 
        ///  
        /// <para>
        /// The temporary Amazon Web Services credentials from the previous IAM role session might
        /// still be valid until the session expiry. If you need to immediately revoke the temporary
        /// session credentials, then go to the role in the IAM console.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePodIdentityAssociation service method.</param>
        /// 
        /// <returns>The response from the DeletePodIdentityAssociation service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeletePodIdentityAssociation">REST API Reference for DeletePodIdentityAssociation Operation</seealso>
        public virtual DeletePodIdentityAssociationResponse DeletePodIdentityAssociation(DeletePodIdentityAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePodIdentityAssociationResponseUnmarshaller.Instance;

            return Invoke<DeletePodIdentityAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePodIdentityAssociation operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePodIdentityAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeletePodIdentityAssociation">REST API Reference for DeletePodIdentityAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeletePodIdentityAssociation(DeletePodIdentityAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePodIdentityAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePodIdentityAssociation.</param>
        /// 
        /// <returns>Returns a  DeletePodIdentityAssociationResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeletePodIdentityAssociation">REST API Reference for DeletePodIdentityAssociation Operation</seealso>
        public virtual DeletePodIdentityAssociationResponse EndDeletePodIdentityAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePodIdentityAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterCluster

        /// <summary>
        /// Deregisters a connected cluster to remove it from the Amazon EKS control plane.
        /// 
        ///  
        /// <para>
        /// A connected cluster is a Kubernetes cluster that you've connected to your control
        /// plane using the <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-connector.html">Amazon
        /// EKS Connector</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCluster service method.</param>
        /// 
        /// <returns>The response from the DeregisterCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeregisterCluster">REST API Reference for DeregisterCluster Operation</seealso>
        public virtual DeregisterClusterResponse DeregisterCluster(DeregisterClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterClusterResponseUnmarshaller.Instance;

            return Invoke<DeregisterClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeregisterCluster">REST API Reference for DeregisterCluster Operation</seealso>
        public virtual IAsyncResult BeginDeregisterCluster(DeregisterClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterCluster.</param>
        /// 
        /// <returns>Returns a  DeregisterClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeregisterCluster">REST API Reference for DeregisterCluster Operation</seealso>
        public virtual DeregisterClusterResponse EndDeregisterCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccessEntry

        /// <summary>
        /// Describes an access entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessEntry service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessEntry service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAccessEntry">REST API Reference for DescribeAccessEntry Operation</seealso>
        public virtual DescribeAccessEntryResponse DescribeAccessEntry(DescribeAccessEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessEntryResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessEntry operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccessEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAccessEntry">REST API Reference for DescribeAccessEntry Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccessEntry(DescribeAccessEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccessEntry.</param>
        /// 
        /// <returns>Returns a  DescribeAccessEntryResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAccessEntry">REST API Reference for DescribeAccessEntry Operation</seealso>
        public virtual DescribeAccessEntryResponse EndDescribeAccessEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccessEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAddon

        /// <summary>
        /// Describes an Amazon EKS add-on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddon service method.</param>
        /// 
        /// <returns>The response from the DescribeAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddon">REST API Reference for DescribeAddon Operation</seealso>
        public virtual DescribeAddonResponse DescribeAddon(DescribeAddonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddon operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddon">REST API Reference for DescribeAddon Operation</seealso>
        public virtual IAsyncResult BeginDescribeAddon(DescribeAddonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddon.</param>
        /// 
        /// <returns>Returns a  DescribeAddonResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddon">REST API Reference for DescribeAddon Operation</seealso>
        public virtual DescribeAddonResponse EndDescribeAddon(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAddonResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAddonConfiguration

        /// <summary>
        /// Returns configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAddonConfiguration service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonConfiguration">REST API Reference for DescribeAddonConfiguration Operation</seealso>
        public virtual DescribeAddonConfigurationResponse DescribeAddonConfiguration(DescribeAddonConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddonConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonConfiguration operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddonConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonConfiguration">REST API Reference for DescribeAddonConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeAddonConfiguration(DescribeAddonConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddonConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddonConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAddonConfigurationResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonConfiguration">REST API Reference for DescribeAddonConfiguration Operation</seealso>
        public virtual DescribeAddonConfigurationResponse EndDescribeAddonConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAddonConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAddonVersions

        /// <summary>
        /// Describes the versions for an add-on.
        /// 
        ///  
        /// <para>
        /// Information such as the Kubernetes versions that you can use the add-on with, the
        /// <c>owner</c>, <c>publisher</c>, and the <c>type</c> of the add-on are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeAddonVersions service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonVersions">REST API Reference for DescribeAddonVersions Operation</seealso>
        public virtual DescribeAddonVersionsResponse DescribeAddonVersions(DescribeAddonVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddonVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonVersions operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddonVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonVersions">REST API Reference for DescribeAddonVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeAddonVersions(DescribeAddonVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAddonVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddonVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddonVersions.</param>
        /// 
        /// <returns>Returns a  DescribeAddonVersionsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonVersions">REST API Reference for DescribeAddonVersions Operation</seealso>
        public virtual DescribeAddonVersionsResponse EndDescribeAddonVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAddonVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCapability

        /// <summary>
        /// Returns detailed information about a specific managed capability in your Amazon EKS
        /// cluster, including its current status, configuration, health information, and any
        /// issues that may be affecting its operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapability service method.</param>
        /// 
        /// <returns>The response from the DescribeCapability service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCapability">REST API Reference for DescribeCapability Operation</seealso>
        public virtual DescribeCapabilityResponse DescribeCapability(DescribeCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapability operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCapability">REST API Reference for DescribeCapability Operation</seealso>
        public virtual IAsyncResult BeginDescribeCapability(DescribeCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCapability.</param>
        /// 
        /// <returns>Returns a  DescribeCapabilityResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCapability">REST API Reference for DescribeCapability Operation</seealso>
        public virtual DescribeCapabilityResponse EndDescribeCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Describes an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// The API server endpoint and certificate authority data returned by this operation
        /// are required for <c>kubelet</c> and <c>kubectl</c> to communicate with your Kubernetes
        /// API server. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Creating
        /// or updating a <c>kubeconfig</c> file for an Amazon EKS cluster</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The API server endpoint and certificate authority data aren't available until the
        /// cluster reaches the <c>ACTIVE</c> state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterVersions

        /// <summary>
        /// Lists available Kubernetes versions for Amazon EKS clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterVersions(DescribeClusterVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterVersions.</param>
        /// 
        /// <returns>Returns a  DescribeClusterVersionsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual DescribeClusterVersionsResponse EndDescribeClusterVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEksAnywhereSubscription

        /// <summary>
        /// Returns descriptive information about a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEksAnywhereSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeEksAnywhereSubscription service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeEksAnywhereSubscription">REST API Reference for DescribeEksAnywhereSubscription Operation</seealso>
        public virtual DescribeEksAnywhereSubscriptionResponse DescribeEksAnywhereSubscription(DescribeEksAnywhereSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeEksAnywhereSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEksAnywhereSubscription operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEksAnywhereSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeEksAnywhereSubscription">REST API Reference for DescribeEksAnywhereSubscription Operation</seealso>
        public virtual IAsyncResult BeginDescribeEksAnywhereSubscription(DescribeEksAnywhereSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEksAnywhereSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeEksAnywhereSubscriptionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeEksAnywhereSubscription">REST API Reference for DescribeEksAnywhereSubscription Operation</seealso>
        public virtual DescribeEksAnywhereSubscriptionResponse EndDescribeEksAnywhereSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEksAnywhereSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFargateProfile

        /// <summary>
        /// Describes an Fargate profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFargateProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeFargateProfile">REST API Reference for DescribeFargateProfile Operation</seealso>
        public virtual DescribeFargateProfileResponse DescribeFargateProfile(DescribeFargateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFargateProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeFargateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFargateProfile operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFargateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeFargateProfile">REST API Reference for DescribeFargateProfile Operation</seealso>
        public virtual IAsyncResult BeginDescribeFargateProfile(DescribeFargateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFargateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFargateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFargateProfile.</param>
        /// 
        /// <returns>Returns a  DescribeFargateProfileResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeFargateProfile">REST API Reference for DescribeFargateProfile Operation</seealso>
        public virtual DescribeFargateProfileResponse EndDescribeFargateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFargateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityProviderConfig

        /// <summary>
        /// Describes an identity provider configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeIdentityProviderConfig">REST API Reference for DescribeIdentityProviderConfig Operation</seealso>
        public virtual DescribeIdentityProviderConfigResponse DescribeIdentityProviderConfig(DescribeIdentityProviderConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityProviderConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeIdentityProviderConfig">REST API Reference for DescribeIdentityProviderConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeIdentityProviderConfig(DescribeIdentityProviderConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProviderConfig.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeIdentityProviderConfig">REST API Reference for DescribeIdentityProviderConfig Operation</seealso>
        public virtual DescribeIdentityProviderConfigResponse EndDescribeIdentityProviderConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityProviderConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInsight

        /// <summary>
        /// Returns details about an insight that you specify using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight service method.</param>
        /// 
        /// <returns>The response from the DescribeInsight service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual DescribeInsightResponse DescribeInsight(DescribeInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;

            return Invoke<DescribeInsightResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual IAsyncResult BeginDescribeInsight(DescribeInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInsight.</param>
        /// 
        /// <returns>Returns a  DescribeInsightResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual DescribeInsightResponse EndDescribeInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInsightsRefresh

        /// <summary>
        /// Returns the status of the latest on-demand cluster insights refresh operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsightsRefresh service method.</param>
        /// 
        /// <returns>The response from the DescribeInsightsRefresh service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsightsRefresh">REST API Reference for DescribeInsightsRefresh Operation</seealso>
        public virtual DescribeInsightsRefreshResponse DescribeInsightsRefresh(DescribeInsightsRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightsRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightsRefreshResponseUnmarshaller.Instance;

            return Invoke<DescribeInsightsRefreshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInsightsRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsightsRefresh operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInsightsRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsightsRefresh">REST API Reference for DescribeInsightsRefresh Operation</seealso>
        public virtual IAsyncResult BeginDescribeInsightsRefresh(DescribeInsightsRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightsRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightsRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInsightsRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInsightsRefresh.</param>
        /// 
        /// <returns>Returns a  DescribeInsightsRefreshResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeInsightsRefresh">REST API Reference for DescribeInsightsRefresh Operation</seealso>
        public virtual DescribeInsightsRefreshResponse EndDescribeInsightsRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInsightsRefreshResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNodegroup

        /// <summary>
        /// Describes a managed node group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodegroup service method.</param>
        /// 
        /// <returns>The response from the DescribeNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeNodegroup">REST API Reference for DescribeNodegroup Operation</seealso>
        public virtual DescribeNodegroupResponse DescribeNodegroup(DescribeNodegroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodegroupResponseUnmarshaller.Instance;

            return Invoke<DescribeNodegroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodegroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodegroup operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNodegroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeNodegroup">REST API Reference for DescribeNodegroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeNodegroup(DescribeNodegroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodegroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNodegroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNodegroup.</param>
        /// 
        /// <returns>Returns a  DescribeNodegroupResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeNodegroup">REST API Reference for DescribeNodegroup Operation</seealso>
        public virtual DescribeNodegroupResponse EndDescribeNodegroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNodegroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePodIdentityAssociation

        /// <summary>
        /// Returns descriptive information about an EKS Pod Identity association.
        /// 
        ///  
        /// <para>
        /// This action requires the ID of the association. You can get the ID from the response
        /// to the <c>CreatePodIdentityAssocation</c> for newly created associations. Or, you
        /// can list the IDs for associations with <c>ListPodIdentityAssociations</c> and filter
        /// the list by namespace or service account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePodIdentityAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribePodIdentityAssociation service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribePodIdentityAssociation">REST API Reference for DescribePodIdentityAssociation Operation</seealso>
        public virtual DescribePodIdentityAssociationResponse DescribePodIdentityAssociation(DescribePodIdentityAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePodIdentityAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribePodIdentityAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePodIdentityAssociation operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePodIdentityAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribePodIdentityAssociation">REST API Reference for DescribePodIdentityAssociation Operation</seealso>
        public virtual IAsyncResult BeginDescribePodIdentityAssociation(DescribePodIdentityAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePodIdentityAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePodIdentityAssociation.</param>
        /// 
        /// <returns>Returns a  DescribePodIdentityAssociationResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribePodIdentityAssociation">REST API Reference for DescribePodIdentityAssociation Operation</seealso>
        public virtual DescribePodIdentityAssociationResponse EndDescribePodIdentityAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePodIdentityAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUpdate

        /// <summary>
        /// Describes an update to an Amazon EKS resource.
        /// 
        ///  
        /// <para>
        /// When the status of the update is <c>Successful</c>, the update is complete. If an
        /// update fails, the status is <c>Failed</c>, and an error detail explains the reason
        /// for the failure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdate service method.</param>
        /// 
        /// <returns>The response from the DescribeUpdate service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual DescribeUpdateResponse DescribeUpdate(DescribeUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return Invoke<DescribeUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdate operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual IAsyncResult BeginDescribeUpdate(DescribeUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUpdate.</param>
        /// 
        /// <returns>Returns a  DescribeUpdateResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual DescribeUpdateResponse EndDescribeUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAccessPolicy

        /// <summary>
        /// Disassociates an access policy from an access entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DisassociateAccessPolicy service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateAccessPolicy">REST API Reference for DisassociateAccessPolicy Operation</seealso>
        public virtual DisassociateAccessPolicyResponse DisassociateAccessPolicy(DisassociateAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DisassociateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccessPolicy operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateAccessPolicy">REST API Reference for DisassociateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAccessPolicy(DisassociateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DisassociateAccessPolicyResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateAccessPolicy">REST API Reference for DisassociateAccessPolicy Operation</seealso>
        public virtual DisassociateAccessPolicyResponse EndDisassociateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateIdentityProviderConfig

        /// <summary>
        /// Disassociates an identity provider configuration from a cluster.
        /// 
        ///  
        /// <para>
        /// If you disassociate an identity provider from your cluster, users included in the
        /// provider can no longer access the cluster. However, you can still access the cluster
        /// with IAM principals.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIdentityProviderConfig service method.</param>
        /// 
        /// <returns>The response from the DisassociateIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateIdentityProviderConfig">REST API Reference for DisassociateIdentityProviderConfig Operation</seealso>
        public virtual DisassociateIdentityProviderConfigResponse DisassociateIdentityProviderConfig(DisassociateIdentityProviderConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<DisassociateIdentityProviderConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIdentityProviderConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIdentityProviderConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateIdentityProviderConfig">REST API Reference for DisassociateIdentityProviderConfig Operation</seealso>
        public virtual IAsyncResult BeginDisassociateIdentityProviderConfig(DisassociateIdentityProviderConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIdentityProviderConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIdentityProviderConfig.</param>
        /// 
        /// <returns>Returns a  DisassociateIdentityProviderConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateIdentityProviderConfig">REST API Reference for DisassociateIdentityProviderConfig Operation</seealso>
        public virtual DisassociateIdentityProviderConfigResponse EndDisassociateIdentityProviderConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateIdentityProviderConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessEntries

        /// <summary>
        /// Lists the access entries for your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessEntries service method.</param>
        /// 
        /// <returns>The response from the ListAccessEntries service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessEntries">REST API Reference for ListAccessEntries Operation</seealso>
        public virtual ListAccessEntriesResponse ListAccessEntries(ListAccessEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessEntriesResponseUnmarshaller.Instance;

            return Invoke<ListAccessEntriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessEntries operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessEntries">REST API Reference for ListAccessEntries Operation</seealso>
        public virtual IAsyncResult BeginListAccessEntries(ListAccessEntriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessEntriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessEntries.</param>
        /// 
        /// <returns>Returns a  ListAccessEntriesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessEntries">REST API Reference for ListAccessEntries Operation</seealso>
        public virtual ListAccessEntriesResponse EndListAccessEntries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessEntriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessPolicies

        /// <summary>
        /// Lists the available access policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAccessPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual IAsyncResult BeginListAccessPolicies(ListAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPolicies.</param>
        /// 
        /// <returns>Returns a  ListAccessPoliciesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse EndListAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAddons

        /// <summary>
        /// Lists the installed add-ons.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddons service method.</param>
        /// 
        /// <returns>The response from the ListAddons service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAddons">REST API Reference for ListAddons Operation</seealso>
        public virtual ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonsResponseUnmarshaller.Instance;

            return Invoke<ListAddonsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddons operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddons operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddons
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAddons">REST API Reference for ListAddons Operation</seealso>
        public virtual IAsyncResult BeginListAddons(ListAddonsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddons operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddons.</param>
        /// 
        /// <returns>Returns a  ListAddonsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAddons">REST API Reference for ListAddons Operation</seealso>
        public virtual ListAddonsResponse EndListAddons(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAddonsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedAccessPolicies

        /// <summary>
        /// Lists the access policies associated with an access entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedAccessPolicies service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAssociatedAccessPolicies">REST API Reference for ListAssociatedAccessPolicies Operation</seealso>
        public virtual ListAssociatedAccessPoliciesResponse ListAssociatedAccessPolicies(ListAssociatedAccessPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedAccessPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAccessPolicies operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAssociatedAccessPolicies">REST API Reference for ListAssociatedAccessPolicies Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedAccessPolicies(ListAssociatedAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedAccessPolicies.</param>
        /// 
        /// <returns>Returns a  ListAssociatedAccessPoliciesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAssociatedAccessPolicies">REST API Reference for ListAssociatedAccessPolicies Operation</seealso>
        public virtual ListAssociatedAccessPoliciesResponse EndListAssociatedAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCapabilities

        /// <summary>
        /// Lists all managed capabilities in your Amazon EKS cluster. You can use this operation
        /// to get an overview of all capabilities and their current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities service method.</param>
        /// 
        /// <returns>The response from the ListCapabilities service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual ListCapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return Invoke<ListCapabilitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCapabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual IAsyncResult BeginListCapabilities(ListCapabilitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCapabilities.</param>
        /// 
        /// <returns>Returns a  ListCapabilitiesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual ListCapabilitiesResponse EndListCapabilities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCapabilitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Lists the Amazon EKS clusters in your Amazon Web Services account in the specified
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEksAnywhereSubscriptions

        /// <summary>
        /// Displays the full description of the subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEksAnywhereSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListEksAnywhereSubscriptions service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListEksAnywhereSubscriptions">REST API Reference for ListEksAnywhereSubscriptions Operation</seealso>
        public virtual ListEksAnywhereSubscriptionsResponse ListEksAnywhereSubscriptions(ListEksAnywhereSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEksAnywhereSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEksAnywhereSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEksAnywhereSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEksAnywhereSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEksAnywhereSubscriptions operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEksAnywhereSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListEksAnywhereSubscriptions">REST API Reference for ListEksAnywhereSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListEksAnywhereSubscriptions(ListEksAnywhereSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEksAnywhereSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEksAnywhereSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEksAnywhereSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEksAnywhereSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListEksAnywhereSubscriptionsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListEksAnywhereSubscriptions">REST API Reference for ListEksAnywhereSubscriptions Operation</seealso>
        public virtual ListEksAnywhereSubscriptionsResponse EndListEksAnywhereSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEksAnywhereSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFargateProfiles

        /// <summary>
        /// Lists the Fargate profiles associated with the specified cluster in your Amazon Web
        /// Services account in the specified Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFargateProfiles service method.</param>
        /// 
        /// <returns>The response from the ListFargateProfiles service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListFargateProfiles">REST API Reference for ListFargateProfiles Operation</seealso>
        public virtual ListFargateProfilesResponse ListFargateProfiles(ListFargateProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFargateProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFargateProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFargateProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFargateProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFargateProfiles operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFargateProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListFargateProfiles">REST API Reference for ListFargateProfiles Operation</seealso>
        public virtual IAsyncResult BeginListFargateProfiles(ListFargateProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFargateProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFargateProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFargateProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFargateProfiles.</param>
        /// 
        /// <returns>Returns a  ListFargateProfilesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListFargateProfiles">REST API Reference for ListFargateProfiles Operation</seealso>
        public virtual ListFargateProfilesResponse EndListFargateProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFargateProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityProviderConfigs

        /// <summary>
        /// Lists the identity provider configurations for your cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviderConfigs service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviderConfigs service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListIdentityProviderConfigs">REST API Reference for ListIdentityProviderConfigs Operation</seealso>
        public virtual ListIdentityProviderConfigsResponse ListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityProviderConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProviderConfigsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProviderConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviderConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviderConfigs operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityProviderConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListIdentityProviderConfigs">REST API Reference for ListIdentityProviderConfigs Operation</seealso>
        public virtual IAsyncResult BeginListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityProviderConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProviderConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviderConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviderConfigs.</param>
        /// 
        /// <returns>Returns a  ListIdentityProviderConfigsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListIdentityProviderConfigs">REST API Reference for ListIdentityProviderConfigs Operation</seealso>
        public virtual ListIdentityProviderConfigsResponse EndListIdentityProviderConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityProviderConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInsights

        /// <summary>
        /// Returns a list of all insights checked for against the specified cluster. You can
        /// filter which insights are returned by category, associated Kubernetes version, and
        /// status. The default filter lists all categories and every status.
        /// 
        ///  
        /// <para>
        /// The following lists the available categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UPGRADE_READINESS</c>: Amazon EKS identifies issues that could impact your ability
        /// to upgrade to new versions of Kubernetes. These are called upgrade insights.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURATION</c>: Amazon EKS identifies misconfiguration in your EKS Hybrid
        /// Nodes setup that could impair functionality of your cluster or workloads. These are
        /// called configuration insights.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsights service method.</param>
        /// 
        /// <returns>The response from the ListInsights service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual ListInsightsResponse ListInsights(ListInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;

            return Invoke<ListInsightsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInsights operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual IAsyncResult BeginListInsights(ListInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInsights.</param>
        /// 
        /// <returns>Returns a  ListInsightsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual ListInsightsResponse EndListInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNodegroups

        /// <summary>
        /// Lists the managed node groups associated with the specified cluster in your Amazon
        /// Web Services account in the specified Amazon Web Services Region. Self-managed node
        /// groups aren't listed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodegroups service method.</param>
        /// 
        /// <returns>The response from the ListNodegroups service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListNodegroups">REST API Reference for ListNodegroups Operation</seealso>
        public virtual ListNodegroupsResponse ListNodegroups(ListNodegroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNodegroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodegroupsResponseUnmarshaller.Instance;

            return Invoke<ListNodegroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodegroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodegroups operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodegroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListNodegroups">REST API Reference for ListNodegroups Operation</seealso>
        public virtual IAsyncResult BeginListNodegroups(ListNodegroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNodegroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodegroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodegroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodegroups.</param>
        /// 
        /// <returns>Returns a  ListNodegroupsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListNodegroups">REST API Reference for ListNodegroups Operation</seealso>
        public virtual ListNodegroupsResponse EndListNodegroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNodegroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPodIdentityAssociations

        /// <summary>
        /// List the EKS Pod Identity associations in a cluster. You can filter the list by the
        /// namespace that the association is in or the service account that the association uses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPodIdentityAssociations service method.</param>
        /// 
        /// <returns>The response from the ListPodIdentityAssociations service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListPodIdentityAssociations">REST API Reference for ListPodIdentityAssociations Operation</seealso>
        public virtual ListPodIdentityAssociationsResponse ListPodIdentityAssociations(ListPodIdentityAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPodIdentityAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPodIdentityAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListPodIdentityAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPodIdentityAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPodIdentityAssociations operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPodIdentityAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListPodIdentityAssociations">REST API Reference for ListPodIdentityAssociations Operation</seealso>
        public virtual IAsyncResult BeginListPodIdentityAssociations(ListPodIdentityAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPodIdentityAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPodIdentityAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPodIdentityAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPodIdentityAssociations.</param>
        /// 
        /// <returns>Returns a  ListPodIdentityAssociationsResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListPodIdentityAssociations">REST API Reference for ListPodIdentityAssociations Operation</seealso>
        public virtual ListPodIdentityAssociationsResponse EndListPodIdentityAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPodIdentityAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for an Amazon EKS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUpdates

        /// <summary>
        /// Lists the updates associated with an Amazon EKS resource in your Amazon Web Services
        /// account, in the specified Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUpdates service method.</param>
        /// 
        /// <returns>The response from the ListUpdates service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual ListUpdatesResponse ListUpdates(ListUpdatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListUpdatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUpdates operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual IAsyncResult BeginListUpdates(ListUpdatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUpdates.</param>
        /// 
        /// <returns>Returns a  ListUpdatesResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual ListUpdatesResponse EndListUpdates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUpdatesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterCluster

        /// <summary>
        /// Connects a Kubernetes cluster to the Amazon EKS control plane. 
        /// 
        ///  
        /// <para>
        /// Any Kubernetes cluster can be connected to the Amazon EKS control plane to view current
        /// information about the cluster and its nodes. 
        /// </para>
        ///  
        /// <para>
        /// Cluster connection requires two steps. First, send a <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_RegisterClusterRequest.html">
        /// <c>RegisterClusterRequest</c> </a> to add it to the Amazon EKS control plane.
        /// </para>
        ///  
        /// <para>
        /// Second, a <a href="https://amazon-eks.s3.us-west-2.amazonaws.com/eks-connector/manifests/eks-connector/latest/eks-connector.yaml">Manifest</a>
        /// containing the <c>activationID</c> and <c>activationCode</c> must be applied to the
        /// Kubernetes cluster through it's native provider to provide visibility.
        /// </para>
        ///  
        /// <para>
        /// After the manifest is updated and applied, the connected cluster is visible to the
        /// Amazon EKS control plane. If the manifest isn't applied within three days, the connected
        /// cluster will no longer be visible and must be deregistered using <c>DeregisterCluster</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCluster service method.</param>
        /// 
        /// <returns>The response from the RegisterCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourcePropagationDelayException">
        /// Required resources (such as service-linked roles) were created and are still propagating.
        /// Retry later.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/RegisterCluster">REST API Reference for RegisterCluster Operation</seealso>
        public virtual RegisterClusterResponse RegisterCluster(RegisterClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClusterResponseUnmarshaller.Instance;

            return Invoke<RegisterClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCluster operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/RegisterCluster">REST API Reference for RegisterCluster Operation</seealso>
        public virtual IAsyncResult BeginRegisterCluster(RegisterClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCluster.</param>
        /// 
        /// <returns>Returns a  RegisterClusterResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/RegisterCluster">REST API Reference for RegisterCluster Operation</seealso>
        public virtual RegisterClusterResponse EndRegisterCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  StartInsightsRefresh

        /// <summary>
        /// Initiates an on-demand refresh operation for cluster insights, getting the latest
        /// analysis outside of the standard refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInsightsRefresh service method.</param>
        /// 
        /// <returns>The response from the StartInsightsRefresh service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/StartInsightsRefresh">REST API Reference for StartInsightsRefresh Operation</seealso>
        public virtual StartInsightsRefreshResponse StartInsightsRefresh(StartInsightsRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInsightsRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInsightsRefreshResponseUnmarshaller.Instance;

            return Invoke<StartInsightsRefreshResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInsightsRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInsightsRefresh operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInsightsRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/StartInsightsRefresh">REST API Reference for StartInsightsRefresh Operation</seealso>
        public virtual IAsyncResult BeginStartInsightsRefresh(StartInsightsRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInsightsRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInsightsRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInsightsRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInsightsRefresh.</param>
        /// 
        /// <returns>Returns a  StartInsightsRefreshResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/StartInsightsRefresh">REST API Reference for StartInsightsRefresh Operation</seealso>
        public virtual StartInsightsRefreshResponse EndStartInsightsRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInsightsRefreshResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to an Amazon EKS resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted. Tags that you create for Amazon EKS resources don't propagate to any other
        /// resources associated with the cluster. For example, if you tag a cluster with this
        /// operation, that tag doesn't automatically propagate to the subnets and nodes associated
        /// with the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from an Amazon EKS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessEntry

        /// <summary>
        /// Updates an access entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessEntry service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAccessEntry">REST API Reference for UpdateAccessEntry Operation</seealso>
        public virtual UpdateAccessEntryResponse UpdateAccessEntry(UpdateAccessEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessEntry operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAccessEntry">REST API Reference for UpdateAccessEntry Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessEntry(UpdateAccessEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessEntry.</param>
        /// 
        /// <returns>Returns a  UpdateAccessEntryResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAccessEntry">REST API Reference for UpdateAccessEntry Operation</seealso>
        public virtual UpdateAccessEntryResponse EndUpdateAccessEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAddon

        /// <summary>
        /// Updates an Amazon EKS add-on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddon service method.</param>
        /// 
        /// <returns>The response from the UpdateAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAddon">REST API Reference for UpdateAddon Operation</seealso>
        public virtual UpdateAddonResponse UpdateAddon(UpdateAddonRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddonResponseUnmarshaller.Instance;

            return Invoke<UpdateAddonResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAddon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddon operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAddon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAddon">REST API Reference for UpdateAddon Operation</seealso>
        public virtual IAsyncResult BeginUpdateAddon(UpdateAddonRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddonResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAddon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAddon.</param>
        /// 
        /// <returns>Returns a  UpdateAddonResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAddon">REST API Reference for UpdateAddon Operation</seealso>
        public virtual UpdateAddonResponse EndUpdateAddon(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAddonResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCapability

        /// <summary>
        /// Updates the configuration of a managed capability in your Amazon EKS cluster. You
        /// can update the IAM role, configuration settings, and delete propagation policy for
        /// a capability.
        /// 
        ///  
        /// <para>
        /// When you update a capability, Amazon EKS applies the changes and may restart capability
        /// components as needed. The capability remains available during the update process,
        /// but some operations may be temporarily unavailable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability service method.</param>
        /// 
        /// <returns>The response from the UpdateCapability service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual UpdateCapabilityResponse UpdateCapability(UpdateCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return Invoke<UpdateCapabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual IAsyncResult BeginUpdateCapability(UpdateCapabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCapability.</param>
        /// 
        /// <returns>Returns a  UpdateCapabilityResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual UpdateCapabilityResponse EndUpdateCapability(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCapabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterConfig

        /// <summary>
        /// Updates an Amazon EKS cluster configuration. Your cluster continues to function during
        /// the update. The response output includes an update ID that you can use to track the
        /// status of your cluster update with <c>DescribeUpdate</c>.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use this API operation to enable or disable exporting the Kubernetes control
        /// plane logs for your cluster to CloudWatch Logs. By default, cluster control plane
        /// logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster control plane logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// You can also use this API operation to enable or disable public and private access
        /// to your cluster's Kubernetes API server endpoint. By default, public access is enabled,
        /// and private access is disabled. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">
        /// Cluster API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can also use this API operation to choose different subnets and security groups
        /// for the cluster. You must specify at least two subnets that are in different Availability
        /// Zones. You can't change which VPC the subnets are from, the subnets must be in the
        /// same VPC as the subnets that the cluster was created with. For more information about
        /// the VPC requirements, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html</a>
        /// in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can also use this API operation to enable or disable ARC zonal shift. If zonal
        /// shift is enabled, Amazon Web Services configures zonal autoshift for the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can also use this API operation to add, change, or remove the configuration in
        /// the cluster for EKS Hybrid Nodes. To remove the configuration, use the <c>remoteNetworkConfig</c>
        /// key with an object containing both subkeys with empty arrays for each. Here is an
        /// inline example: <c>"remoteNetworkConfig": { "remoteNodeNetworks": [], "remotePodNetworks":
        /// [] }</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <c>UPDATING</c> (this status transition is
        /// eventually consistent). When the update is complete (either <c>Failed</c> or <c>Successful</c>),
        /// the cluster status moves to <c>Active</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual UpdateClusterConfigResponse UpdateClusterConfig(UpdateClusterConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterConfig(UpdateClusterConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterConfig.</param>
        /// 
        /// <returns>Returns a  UpdateClusterConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual UpdateClusterConfigResponse EndUpdateClusterConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterVersion

        /// <summary>
        /// Updates an Amazon EKS cluster to the specified Kubernetes version. Your cluster continues
        /// to function during the update. The response output includes an update ID that you
        /// can use to track the status of your cluster update with the <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeUpdate.html">
        /// <c>DescribeUpdate</c> </a> API operation.
        /// 
        ///  
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <c>UPDATING</c> (this status transition is
        /// eventually consistent). When the update is complete (either <c>Failed</c> or <c>Successful</c>),
        /// the cluster status moves to <c>Active</c>.
        /// </para>
        ///  
        /// <para>
        /// If your cluster has managed node groups attached to it, all of your node groups' Kubernetes
        /// versions must match the cluster's Kubernetes version in order to update the cluster
        /// to a new Kubernetes version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterVersion service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidStateException">
        /// Amazon EKS detected upgrade readiness issues. Call the <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListInsights.html">
        /// <c>ListInsights</c> </a> API to view detected upgrade blocking issues. Pass the <a
        /// href="https://docs.aws.amazon.com/eks/latest/APIReference/API_UpdateClusterVersion.html#API_UpdateClusterVersion_RequestBody">
        /// <c>force</c> </a> flag when updating to override upgrade readiness errors.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual UpdateClusterVersionResponse UpdateClusterVersion(UpdateClusterVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterVersion operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterVersion(UpdateClusterVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterVersion.</param>
        /// 
        /// <returns>Returns a  UpdateClusterVersionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual UpdateClusterVersionResponse EndUpdateClusterVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEksAnywhereSubscription

        /// <summary>
        /// Update an EKS Anywhere Subscription. Only auto renewal and tags can be updated after
        /// subscription creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEksAnywhereSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateEksAnywhereSubscription service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateEksAnywhereSubscription">REST API Reference for UpdateEksAnywhereSubscription Operation</seealso>
        public virtual UpdateEksAnywhereSubscriptionResponse UpdateEksAnywhereSubscription(UpdateEksAnywhereSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateEksAnywhereSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEksAnywhereSubscription operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEksAnywhereSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateEksAnywhereSubscription">REST API Reference for UpdateEksAnywhereSubscription Operation</seealso>
        public virtual IAsyncResult BeginUpdateEksAnywhereSubscription(UpdateEksAnywhereSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEksAnywhereSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEksAnywhereSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEksAnywhereSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEksAnywhereSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateEksAnywhereSubscriptionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateEksAnywhereSubscription">REST API Reference for UpdateEksAnywhereSubscription Operation</seealso>
        public virtual UpdateEksAnywhereSubscriptionResponse EndUpdateEksAnywhereSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEksAnywhereSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNodegroupConfig

        /// <summary>
        /// Updates an Amazon EKS managed node group configuration. Your node group continues
        /// to function during the update. The response output includes an update ID that you
        /// can use to track the status of your node group update with the <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeUpdate.html">
        /// <c>DescribeUpdate</c> </a> API operation. You can update the Kubernetes labels and
        /// taints for a node group and the scaling and version update configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateNodegroupConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupConfig">REST API Reference for UpdateNodegroupConfig Operation</seealso>
        public virtual UpdateNodegroupConfigResponse UpdateNodegroupConfig(UpdateNodegroupConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateNodegroupConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNodegroupConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupConfig operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNodegroupConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupConfig">REST API Reference for UpdateNodegroupConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateNodegroupConfig(UpdateNodegroupConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNodegroupConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNodegroupConfig.</param>
        /// 
        /// <returns>Returns a  UpdateNodegroupConfigResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupConfig">REST API Reference for UpdateNodegroupConfig Operation</seealso>
        public virtual UpdateNodegroupConfigResponse EndUpdateNodegroupConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNodegroupConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNodegroupVersion

        /// <summary>
        /// Updates the Kubernetes version or AMI version of an Amazon EKS managed node group.
        /// 
        ///  
        /// <para>
        /// You can update a node group using a launch template only if the node group was originally
        /// deployed with a launch template. Additionally, the launch template ID or name must
        /// match what was used when the node group was created. You can update the launch template
        /// version with necessary changes.
        /// </para>
        ///  
        /// <para>
        /// If you need to update a custom AMI in a node group that was deployed with a launch
        /// template, then update your custom AMI, specify the new ID in a new version of the
        /// launch template, and then update the node group to the new version of the launch template.
        /// </para>
        ///  
        /// <para>
        /// If you update without a launch template, then you can update to the latest available
        /// AMI version of a node group's current Kubernetes version by not specifying a Kubernetes
        /// version in the request. You can update to the latest AMI version of your cluster's
        /// current Kubernetes version by specifying your cluster's Kubernetes version in the
        /// request. For information about Linux versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html">Amazon
        /// EKS optimized Amazon Linux AMI versions</a> in the <i>Amazon EKS User Guide</i>. For
        /// information about Windows versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-ami-versions-windows.html">Amazon
        /// EKS optimized Windows AMI versions</a> in the <i>Amazon EKS User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You cannot roll back a node group to an earlier Kubernetes version or AMI version.
        /// </para>
        ///  
        /// <para>
        /// When a node in a managed node group is terminated due to a scaling action or update,
        /// every <c>Pod</c> on that node is drained first. Amazon EKS attempts to drain the nodes
        /// gracefully and will fail if it is unable to do so. You can <c>force</c> the update
        /// if Amazon EKS is unable to drain the nodes as a result of a <c>Pod</c> disruption
        /// budget issue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateNodegroupVersion service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
        /// principal</a> that doesn't have permissions to use the action or resource or specifying
        /// an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupVersion">REST API Reference for UpdateNodegroupVersion Operation</seealso>
        public virtual UpdateNodegroupVersionResponse UpdateNodegroupVersion(UpdateNodegroupVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateNodegroupVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNodegroupVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupVersion operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNodegroupVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupVersion">REST API Reference for UpdateNodegroupVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateNodegroupVersion(UpdateNodegroupVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNodegroupVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNodegroupVersion.</param>
        /// 
        /// <returns>Returns a  UpdateNodegroupVersionResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupVersion">REST API Reference for UpdateNodegroupVersion Operation</seealso>
        public virtual UpdateNodegroupVersionResponse EndUpdateNodegroupVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNodegroupVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePodIdentityAssociation

        /// <summary>
        /// Updates a EKS Pod Identity association. In an update, you can change the IAM role,
        /// the target IAM role, or <c>disableSessionTags</c>. You must change at least one of
        /// these in an update. An association can't be moved between clusters, namespaces, or
        /// service accounts. If you need to edit the namespace or service account, you need to
        /// delete the association and then create a new association with your desired settings.
        /// 
        ///  
        /// <para>
        /// Similar to Amazon Web Services IAM behavior, EKS Pod Identity associations are eventually
        /// consistent, and may take several seconds to be effective after the initial API call
        /// returns successfully. You must design your applications to account for these potential
        /// delays. We recommend that you don’t include association create/updates in the critical,
        /// high-availability code paths of your application. Instead, make changes in a separate
        /// initialization or setup routine that you run less frequently.
        /// </para>
        ///  
        /// <para>
        /// You can set a <i>target IAM role</i> in the same or a different account for advanced
        /// scenarios. With a target role, EKS Pod Identity automatically performs two role assumptions
        /// in sequence: first assuming the role in the association that is in this account, then
        /// using those credentials to assume the target IAM role. This process provides your
        /// Pod with temporary credentials that have the permissions defined in the target role,
        /// allowing secure access to resources in another Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePodIdentityAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdatePodIdentityAssociation service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidRequestException">
        /// The request is invalid given the state of the cluster. Check the state of the cluster
        /// and the associated operations.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <c>ListClusters</c>. You can view your available managed node groups with <c>ListNodegroups</c>.
        /// Amazon EKS clusters and node groups are Amazon Web Services Region specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdatePodIdentityAssociation">REST API Reference for UpdatePodIdentityAssociation Operation</seealso>
        public virtual UpdatePodIdentityAssociationResponse UpdatePodIdentityAssociation(UpdatePodIdentityAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePodIdentityAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdatePodIdentityAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePodIdentityAssociation operation on AmazonEKSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePodIdentityAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdatePodIdentityAssociation">REST API Reference for UpdatePodIdentityAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdatePodIdentityAssociation(UpdatePodIdentityAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePodIdentityAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePodIdentityAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePodIdentityAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePodIdentityAssociation.</param>
        /// 
        /// <returns>Returns a  UpdatePodIdentityAssociationResult from EKS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdatePodIdentityAssociation">REST API Reference for UpdatePodIdentityAssociation Operation</seealso>
        public virtual UpdatePodIdentityAssociationResponse EndUpdatePodIdentityAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePodIdentityAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonEKSEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}