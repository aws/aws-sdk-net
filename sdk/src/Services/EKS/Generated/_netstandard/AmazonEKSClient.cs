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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EKS.Model;
using Amazon.EKS.Model.Internal.MarshallTransformations;
using Amazon.EKS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EKS
{
    /// <summary>
    /// Implementation for accessing EKS
    ///
    /// Amazon Elastic Kubernetes Service (Amazon EKS) is a managed service that makes it
    /// easy for you to run Kubernetes on Amazon Web Services without needing to stand up
    /// or maintain your own Kubernetes control plane. Kubernetes is an open-source system
    /// for automating the deployment, scaling, and management of containerized applications.
    /// 
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
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


        #region  AssociateEncryptionConfig

        internal virtual AssociateEncryptionConfigResponse AssociateEncryptionConfig(AssociateEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Associate encryption configuration to an existing cluster.
        /// 
        ///  
        /// <para>
        /// You can use this API to enable encryption on existing clusters which do not have encryption
        /// already enabled. This allows you to implement a defense-in-depth security strategy
        /// without migrating applications to new Amazon EKS clusters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEncryptionConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateEncryptionConfig">REST API Reference for AssociateEncryptionConfig Operation</seealso>
        public virtual Task<AssociateEncryptionConfigResponse> AssociateEncryptionConfigAsync(AssociateEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateIdentityProviderConfig

        internal virtual AssociateIdentityProviderConfigResponse AssociateIdentityProviderConfig(AssociateIdentityProviderConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateIdentityProviderConfigResponse>(request, options);
        }



        /// <summary>
        /// Associate an identity provider configuration to a cluster.
        /// 
        ///  
        /// <para>
        /// If you want to authenticate identities using an identity provider, you can create
        /// an identity provider configuration and associate it to your cluster. After configuring
        /// authentication to your cluster you can create Kubernetes <code>roles</code> and <code>clusterroles</code>
        /// to assign permissions to the roles, and then bind the roles to the identities using
        /// Kubernetes <code>rolebindings</code> and <code>clusterrolebindings</code>. For more
        /// information see <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Using
        /// RBAC Authorization</a> in the Kubernetes documentation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIdentityProviderConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/AssociateIdentityProviderConfig">REST API Reference for AssociateIdentityProviderConfig Operation</seealso>
        public virtual Task<AssociateIdentityProviderConfigResponse> AssociateIdentityProviderConfigAsync(AssociateIdentityProviderConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIdentityProviderConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAddon

        internal virtual CreateAddonResponse CreateAddon(CreateAddonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonResponseUnmarshaller.Instance;

            return Invoke<CreateAddonResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateAddon">REST API Reference for CreateAddon Operation</seealso>
        public virtual Task<CreateAddonResponse> CreateAddonAsync(CreateAddonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon EKS control plane. 
        /// 
        ///  
        /// <para>
        /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
        /// software, such as <code>etcd</code> and the API server. The control plane runs in
        /// an account managed by Amazon Web Services, and the Kubernetes API is exposed by the
        /// Amazon EKS API server endpoint. Each Amazon EKS cluster control plane is single tenant
        /// and unique. It runs on its own set of Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// The cluster control plane is provisioned across multiple Availability Zones and fronted
        /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
        /// network interfaces in your VPC subnets to provide connectivity from the control plane
        /// instances to the nodes (for example, to support <code>kubectl exec</code>, <code>logs</code>,
        /// and <code>proxy</code> data flows).
        /// </para>
        ///  
        /// <para>
        /// Amazon EKS nodes run in your Amazon Web Services account and connect to your cluster's
        /// control plane over the Kubernetes API server endpoint and a certificate file that
        /// is created for your cluster.
        /// </para>
        ///  
        /// <para>
        /// In most cases, it takes several minutes to create a cluster. After you create an Amazon
        /// EKS cluster, you must configure your Kubernetes tooling to communicate with the API
        /// server and launch nodes into your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managing-auth.html">Managing
        /// Cluster Authentication</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
        /// Amazon EKS nodes</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFargateProfile

        internal virtual CreateFargateProfileResponse CreateFargateProfile(CreateFargateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFargateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFargateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates an Fargate profile for your Amazon EKS cluster. You must have at least one
        /// Fargate profile in a cluster to be able to run pods on Fargate.
        /// 
        ///  
        /// <para>
        /// The Fargate profile allows an administrator to declare which pods run on Fargate and
        /// specify which pods run on which Fargate profile. This declaration is done through
        /// the profile’s selectors. Each profile can have up to five selectors that contain a
        /// namespace and labels. A namespace is required for every selector. The label field
        /// consists of multiple optional key-value pairs. Pods that match the selectors are scheduled
        /// on Fargate. If a to-be-scheduled pod matches any of the selectors in the Fargate profile,
        /// then that pod is run on Fargate.
        /// </para>
        ///  
        /// <para>
        /// When you create a Fargate profile, you must specify a pod execution role to use with
        /// the pods that are scheduled with the profile. This role is added to the cluster's
        /// Kubernetes <a href="https://kubernetes.io/docs/admin/authorization/rbac/">Role Based
        /// Access Control</a> (RBAC) for authorization so that the <code>kubelet</code> that
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
        /// If any Fargate profiles in a cluster are in the <code>DELETING</code> status, you
        /// must wait for that Fargate profile to finish deleting before you can create any other
        /// profiles in that cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/fargate-profile.html">Fargate
        /// Profile</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFargateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        public virtual Task<CreateFargateProfileResponse> CreateFargateProfileAsync(CreateFargateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFargateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFargateProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNodegroup

        internal virtual CreateNodegroupResponse CreateNodegroup(CreateNodegroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodegroupResponseUnmarshaller.Instance;

            return Invoke<CreateNodegroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a managed node group for an Amazon EKS cluster. You can only create a node
        /// group for your cluster that is equal to the current Kubernetes version for the cluster.
        /// All node groups are created with the latest AMI release version for the respective
        /// minor Kubernetes version of the cluster, unless you deploy a custom AMI using a launch
        /// template. For more information about using launch templates, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a>.
        /// 
        ///  
        /// <para>
        /// An Amazon EKS managed node group is an Amazon EC2 Auto Scaling group and associated
        /// Amazon EC2 instances that are managed by Amazon Web Services for an Amazon EKS cluster.
        /// Each node group uses a version of the Amazon EKS optimized Amazon Linux 2 AMI. For
        /// more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html">Managed
        /// Node Groups</a> in the <i>Amazon EKS User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodegroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        public virtual Task<CreateNodegroupResponse> CreateNodegroupAsync(CreateNodegroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodegroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNodegroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAddon

        internal virtual DeleteAddonResponse DeleteAddon(DeleteAddonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonResponse>(request, options);
        }



        /// <summary>
        /// Delete an Amazon EKS add-on.
        /// 
        ///  
        /// <para>
        /// When you remove the add-on, it will also be deleted from the cluster. You can always
        /// manually start an add-on on the cluster using the Kubernetes API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteAddon">REST API Reference for DeleteAddon Operation</seealso>
        public virtual Task<DeleteAddonResponse> DeleteAddonAsync(DeleteAddonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes the Amazon EKS cluster control plane.
        /// 
        ///  
        /// <para>
        /// If you have active services in your cluster that are associated with a load balancer,
        /// you must delete those services before deleting the cluster so that the load balancers
        /// are deleted properly. Otherwise, you can have orphaned resources in your VPC that
        /// prevent you from being able to delete the VPC. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/delete-cluster.html">Deleting
        /// a Cluster</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you have managed node groups or Fargate profiles attached to the cluster, you must
        /// delete them first. For more information, see <a>DeleteNodegroup</a> and <a>DeleteFargateProfile</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFargateProfile

        internal virtual DeleteFargateProfileResponse DeleteFargateProfile(DeleteFargateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFargateProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFargateProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Fargate profile.
        /// 
        ///  
        /// <para>
        /// When you delete a Fargate profile, any pods running on Fargate that were created with
        /// the profile are deleted. If those pods match another Fargate profile, then they are
        /// scheduled on Fargate with that profile. If they no longer match any Fargate profiles,
        /// then they are not scheduled on Fargate and they may remain in a pending state.
        /// </para>
        ///  
        /// <para>
        /// Only one Fargate profile in a cluster can be in the <code>DELETING</code> status at
        /// a time. You must wait for a Fargate profile to finish deleting before you can delete
        /// any other profiles in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFargateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteFargateProfile">REST API Reference for DeleteFargateProfile Operation</seealso>
        public virtual Task<DeleteFargateProfileResponse> DeleteFargateProfileAsync(DeleteFargateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFargateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFargateProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNodegroup

        internal virtual DeleteNodegroupResponse DeleteNodegroup(DeleteNodegroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodegroupResponseUnmarshaller.Instance;

            return Invoke<DeleteNodegroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon EKS node group for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNodegroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteNodegroup">REST API Reference for DeleteNodegroup Operation</seealso>
        public virtual Task<DeleteNodegroupResponse> DeleteNodegroupAsync(DeleteNodegroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodegroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNodegroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterCluster

        internal virtual DeregisterClusterResponse DeregisterCluster(DeregisterClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterClusterResponseUnmarshaller.Instance;

            return Invoke<DeregisterClusterResponse>(request, options);
        }



        /// <summary>
        /// Deregisters a connected cluster to remove it from the Amazon EKS control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeregisterCluster">REST API Reference for DeregisterCluster Operation</seealso>
        public virtual Task<DeregisterClusterResponse> DeregisterClusterAsync(DeregisterClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddon

        internal virtual DescribeAddonResponse DescribeAddon(DescribeAddonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonResponse>(request, options);
        }



        /// <summary>
        /// Describes an Amazon EKS add-on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddon">REST API Reference for DescribeAddon Operation</seealso>
        public virtual Task<DescribeAddonResponse> DescribeAddonAsync(DescribeAddonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddonConfiguration

        internal virtual DescribeAddonConfigurationResponse DescribeAddonConfiguration(DescribeAddonConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddonConfiguration service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonConfiguration">REST API Reference for DescribeAddonConfiguration Operation</seealso>
        public virtual Task<DescribeAddonConfigurationResponse> DescribeAddonConfigurationAsync(DescribeAddonConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddonConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddonVersions

        internal virtual DescribeAddonVersionsResponse DescribeAddonVersions(DescribeAddonVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAddonVersionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the versions for an add-on. Information such as the Kubernetes versions
        /// that you can use the add-on with, the <code>owner</code>, <code>publisher</code>,
        /// and the <code>type</code> of the add-on are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddonVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddonVersions service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeAddonVersions">REST API Reference for DescribeAddonVersions Operation</seealso>
        public virtual Task<DescribeAddonVersionsResponse> DescribeAddonVersionsAsync(DescribeAddonVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddonVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddonVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddonVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }



        /// <summary>
        /// Returns descriptive information about an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// The API server endpoint and certificate authority data returned by this operation
        /// are required for <code>kubelet</code> and <code>kubectl</code> to communicate with
        /// your Kubernetes API server. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Create
        /// a kubeconfig for Amazon EKS</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The API server endpoint and certificate authority data aren't available until the
        /// cluster reaches the <code>ACTIVE</code> state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFargateProfile

        internal virtual DescribeFargateProfileResponse DescribeFargateProfile(DescribeFargateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFargateProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeFargateProfileResponse>(request, options);
        }



        /// <summary>
        /// Returns descriptive information about an Fargate profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFargateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFargateProfile service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeFargateProfile">REST API Reference for DescribeFargateProfile Operation</seealso>
        public virtual Task<DescribeFargateProfileResponse> DescribeFargateProfileAsync(DescribeFargateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFargateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFargateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFargateProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityProviderConfig

        internal virtual DescribeIdentityProviderConfigResponse DescribeIdentityProviderConfig(DescribeIdentityProviderConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderConfigResponse>(request, options);
        }



        /// <summary>
        /// Returns descriptive information about an identity provider configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeIdentityProviderConfig">REST API Reference for DescribeIdentityProviderConfig Operation</seealso>
        public virtual Task<DescribeIdentityProviderConfigResponse> DescribeIdentityProviderConfigAsync(DescribeIdentityProviderConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityProviderConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNodegroup

        internal virtual DescribeNodegroupResponse DescribeNodegroup(DescribeNodegroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodegroupResponseUnmarshaller.Instance;

            return Invoke<DescribeNodegroupResponse>(request, options);
        }



        /// <summary>
        /// Returns descriptive information about an Amazon EKS node group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodegroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodegroup service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeNodegroup">REST API Reference for DescribeNodegroup Operation</seealso>
        public virtual Task<DescribeNodegroupResponse> DescribeNodegroupAsync(DescribeNodegroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodegroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodegroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodegroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUpdate

        internal virtual DescribeUpdateResponse DescribeUpdate(DescribeUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return Invoke<DescribeUpdateResponse>(request, options);
        }



        /// <summary>
        /// Returns descriptive information about an update against your Amazon EKS cluster or
        /// associated managed node group or Amazon EKS add-on.
        /// 
        ///  
        /// <para>
        /// When the status of the update is <code>Succeeded</code>, the update is complete. If
        /// an update fails, the status is <code>Failed</code>, and an error detail explains the
        /// reason for the failure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUpdate service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeUpdate">REST API Reference for DescribeUpdate Operation</seealso>
        public virtual Task<DescribeUpdateResponse> DescribeUpdateAsync(DescribeUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIdentityProviderConfig

        internal virtual DisassociateIdentityProviderConfigResponse DisassociateIdentityProviderConfig(DisassociateIdentityProviderConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return Invoke<DisassociateIdentityProviderConfigResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an identity provider configuration from a cluster. If you disassociate
        /// an identity provider from your cluster, users included in the provider can no longer
        /// access the cluster. However, you can still access the cluster with Amazon Web Services
        /// IAM users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIdentityProviderConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateIdentityProviderConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DisassociateIdentityProviderConfig">REST API Reference for DisassociateIdentityProviderConfig Operation</seealso>
        public virtual Task<DisassociateIdentityProviderConfigResponse> DisassociateIdentityProviderConfigAsync(DisassociateIdentityProviderConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIdentityProviderConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIdentityProviderConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIdentityProviderConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAddons

        internal virtual ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAddonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonsResponseUnmarshaller.Instance;

            return Invoke<ListAddonsResponse>(request, options);
        }



        /// <summary>
        /// Lists the available add-ons.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddons service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddons service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListAddons">REST API Reference for ListAddons Operation</seealso>
        public virtual Task<ListAddonsResponse> ListAddonsAsync(ListAddonsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAddonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAddonsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon EKS clusters in your Amazon Web Services account in the specified
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFargateProfiles

        internal virtual ListFargateProfilesResponse ListFargateProfiles(ListFargateProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFargateProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFargateProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFargateProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the Fargate profiles associated with the specified cluster in your Amazon Web
        /// Services account in the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFargateProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFargateProfiles service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListFargateProfiles">REST API Reference for ListFargateProfiles Operation</seealso>
        public virtual Task<ListFargateProfilesResponse> ListFargateProfilesAsync(ListFargateProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFargateProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFargateProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFargateProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityProviderConfigs

        internal virtual ListIdentityProviderConfigsResponse ListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProviderConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProviderConfigsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProviderConfigsResponse>(request, options);
        }



        /// <summary>
        /// A list of identity provider configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviderConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityProviderConfigs service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListIdentityProviderConfigs">REST API Reference for ListIdentityProviderConfigs Operation</seealso>
        public virtual Task<ListIdentityProviderConfigsResponse> ListIdentityProviderConfigsAsync(ListIdentityProviderConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProviderConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProviderConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityProviderConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNodegroups

        internal virtual ListNodegroupsResponse ListNodegroups(ListNodegroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodegroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodegroupsResponseUnmarshaller.Instance;

            return Invoke<ListNodegroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon EKS managed node groups associated with the specified cluster in
        /// your Amazon Web Services account in the specified Region. Self-managed node groups
        /// are not listed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodegroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodegroups service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListNodegroups">REST API Reference for ListNodegroups Operation</seealso>
        public virtual Task<ListNodegroupsResponse> ListNodegroupsAsync(ListNodegroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodegroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodegroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNodegroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List the tags for an Amazon EKS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUpdates

        internal virtual ListUpdatesResponse ListUpdates(ListUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the updates associated with an Amazon EKS cluster or managed node group in your
        /// Amazon Web Services account, in the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUpdates service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListUpdates">REST API Reference for ListUpdates Operation</seealso>
        public virtual Task<ListUpdatesResponse> ListUpdatesAsync(ListUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCluster

        internal virtual RegisterClusterResponse RegisterCluster(RegisterClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClusterResponseUnmarshaller.Instance;

            return Invoke<RegisterClusterResponse>(request, options);
        }



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
        /// Cluster connection requires two steps. First, send a <code> <a>RegisterClusterRequest</a>
        /// </code> to add it to the Amazon EKS control plane.
        /// </para>
        ///  
        /// <para>
        /// Second, a <a href="https://amazon-eks.s3.us-west-2.amazonaws.com/eks-connector/manifests/eks-connector/latest/eks-connector.yaml">Manifest</a>
        /// containing the <code>activationID</code> and <code>activationCode</code> must be applied
        /// to the Kubernetes cluster through it's native provider to provide visibility.
        /// </para>
        ///  
        /// <para>
        /// After the Manifest is updated and applied, then the connected cluster is visible to
        /// the Amazon EKS control plane. If the Manifest is not applied within three days, then
        /// the connected cluster will no longer be visible and must be deregistered. See <a>DeregisterCluster</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        public virtual Task<RegisterClusterResponse> RegisterClusterAsync(RegisterClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// deleted as well. Tags that you create for Amazon EKS resources do not propagate to
        /// any other resources associated with the cluster. For example, if you tag a cluster
        /// with this operation, that tag does not automatically propagate to the subnets and
        /// nodes associated with the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAddon

        internal virtual UpdateAddonResponse UpdateAddon(UpdateAddonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddonResponseUnmarshaller.Instance;

            return Invoke<UpdateAddonResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon EKS add-on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAddon service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateAddon">REST API Reference for UpdateAddon Operation</seealso>
        public virtual Task<UpdateAddonResponse> UpdateAddonAsync(UpdateAddonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAddonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddonResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAddonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClusterConfig

        internal virtual UpdateClusterConfigResponse UpdateClusterConfig(UpdateClusterConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon EKS cluster configuration. Your cluster continues to function during
        /// the update. The response output includes an update ID that you can use to track the
        /// status of your cluster update with the <a>DescribeUpdate</a> API operation.
        /// 
        ///  
        /// <para>
        /// You can use this API operation to enable or disable exporting the Kubernetes control
        /// plane logs for your cluster to CloudWatch Logs. By default, cluster control plane
        /// logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
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
        /// You can also use this API operation to enable or disable public and private access
        /// to your cluster's Kubernetes API server endpoint. By default, public access is enabled,
        /// and private access is disabled. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS cluster endpoint access control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't update the subnets or security group IDs for an existing cluster.
        /// </para>
        ///  </important> 
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <code>UPDATING</code> (this status transition
        /// is eventually consistent). When the update is complete (either <code>Failed</code>
        /// or <code>Successful</code>), the cluster status moves to <code>Active</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterConfig">REST API Reference for UpdateClusterConfig Operation</seealso>
        public virtual Task<UpdateClusterConfigResponse> UpdateClusterConfigAsync(UpdateClusterConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClusterVersion

        internal virtual UpdateClusterVersionResponse UpdateClusterVersion(UpdateClusterVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon EKS cluster to the specified Kubernetes version. Your cluster continues
        /// to function during the update. The response output includes an update ID that you
        /// can use to track the status of your cluster update with the <a>DescribeUpdate</a>
        /// API operation.
        /// 
        ///  
        /// <para>
        /// Cluster updates are asynchronous, and they should finish within a few minutes. During
        /// an update, the cluster status moves to <code>UPDATING</code> (this status transition
        /// is eventually consistent). When the update is complete (either <code>Failed</code>
        /// or <code>Successful</code>), the cluster status moves to <code>Active</code>.
        /// </para>
        ///  
        /// <para>
        /// If your cluster has managed node groups attached to it, all of your node groups’ Kubernetes
        /// versions must match the cluster’s Kubernetes version in order to update the cluster
        /// to a new Kubernetes version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterVersion service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateClusterVersion">REST API Reference for UpdateClusterVersion Operation</seealso>
        public virtual Task<UpdateClusterVersionResponse> UpdateClusterVersionAsync(UpdateClusterVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNodegroupConfig

        internal virtual UpdateNodegroupConfigResponse UpdateNodegroupConfig(UpdateNodegroupConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateNodegroupConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon EKS managed node group configuration. Your node group continues
        /// to function during the update. The response output includes an update ID that you
        /// can use to track the status of your node group update with the <a>DescribeUpdate</a>
        /// API operation. Currently you can update the Kubernetes labels for a node group or
        /// the scaling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNodegroupConfig service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupConfig">REST API Reference for UpdateNodegroupConfig Operation</seealso>
        public virtual Task<UpdateNodegroupConfigResponse> UpdateNodegroupConfigAsync(UpdateNodegroupConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNodegroupConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNodegroupVersion

        internal virtual UpdateNodegroupVersionResponse UpdateNodegroupVersion(UpdateNodegroupVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateNodegroupVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the Kubernetes version or AMI version of an Amazon EKS managed node group.
        /// 
        ///  
        /// <para>
        /// You can update a node group using a launch template only if the node group was originally
        /// deployed with a launch template. If you need to update a custom AMI in a node group
        /// that was deployed with a launch template, then update your custom AMI, specify the
        /// new ID in a new version of the launch template, and then update the node group to
        /// the new version of the launch template.
        /// </para>
        ///  
        /// <para>
        /// If you update without a launch template, then you can update to the latest available
        /// AMI version of a node group's current Kubernetes version by not specifying a Kubernetes
        /// version in the request. You can update to the latest AMI version of your cluster's
        /// current Kubernetes version by specifying your cluster's Kubernetes version in the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html">Amazon
        /// EKS optimized Amazon Linux 2 AMI versions</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You cannot roll back a node group to an earlier Kubernetes version or AMI version.
        /// </para>
        ///  
        /// <para>
        /// When a node in a managed node group is terminated due to a scaling action or update,
        /// the pods in that node are drained first. Amazon EKS attempts to drain the nodes gracefully
        /// and will fail if it is unable to do so. You can <code>force</code> the update if Amazon
        /// EKS is unable to drain the nodes as a result of a pod disruption budget issue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodegroupVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNodegroupVersion service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action. Actions can include using an action
        /// or resource on behalf of a user that doesn't have permissions to use the action or
        /// resource or specifying an identifier that is not valid.
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
        /// <a>ListClusters</a>. You can view your available managed node groups with <a>ListNodegroups</a>.
        /// Amazon EKS clusters and node groups are Region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/UpdateNodegroupVersion">REST API Reference for UpdateNodegroupVersion Operation</seealso>
        public virtual Task<UpdateNodegroupVersionResponse> UpdateNodegroupVersionAsync(UpdateNodegroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodegroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodegroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNodegroupVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}