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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EMRContainers.Model;
using Amazon.EMRContainers.Model.Internal.MarshallTransformations;
using Amazon.EMRContainers.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EMRContainers
{
    /// <summary>
    /// Implementation for accessing EMRContainers
    ///
    /// Amazon EMR on EKS provides a deployment option for Amazon EMR that allows you to run
    /// open-source big data frameworks on Amazon Elastic Kubernetes Service (Amazon EKS).
    /// With this deployment option, you can focus on running analytics workloads while Amazon
    /// EMR on EKS builds, configures, and manages containers for open-source applications.
    /// For more information about Amazon EMR on EKS concepts and tasks, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/emr-eks.html">What
    /// is shared id="EMR-EKS"/&gt;</a>.
    /// 
    ///  
    /// <para>
    ///  <i>Amazon EMR containers</i> is the API name for Amazon EMR on EKS. The <code>emr-containers</code>
    /// prefix is used in the following scenarios: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It is the prefix in the CLI commands for Amazon EMR on EKS. For example, <code>aws
    /// emr-containers start-job-run</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix before IAM policy actions for Amazon EMR on EKS. For example, <code>"Action":
    /// [ "emr-containers:StartJobRun"]</code>. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-actions">Policy
    /// actions for Amazon EMR on EKS</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix used in Amazon EMR on EKS service endpoints. For example, <code>emr-containers.us-east-2.amazonaws.com</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/service-quotas.html#service-endpoints">Amazon
    /// EMR on EKSService Endpoints</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonEMRContainersClient : AmazonServiceClient, IAmazonEMRContainers
    {
        private static IServiceMetadata serviceMetadata = new AmazonEMRContainersMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEMRContainersClient with the credentials loaded from the application's
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
        public AmazonEMRContainersClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEMRContainersConfig()) { }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with the credentials loaded from the application's
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
        public AmazonEMRContainersClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEMRContainersConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEMRContainersClient Configuration Object</param>
        public AmazonEMRContainersClient(AmazonEMRContainersConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEMRContainersClient(AWSCredentials credentials)
            : this(credentials, new AmazonEMRContainersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRContainersClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEMRContainersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Credentials and an
        /// AmazonEMRContainersClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEMRContainersClient Configuration Object</param>
        public AmazonEMRContainersClient(AWSCredentials credentials, AmazonEMRContainersConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEMRContainersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEMRContainersConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEMRContainersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEMRContainersClient Configuration Object</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEMRContainersConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEMRContainersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEMRContainersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRContainersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEMRContainersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEMRContainersClient Configuration Object</param>
        public AmazonEMRContainersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEMRContainersConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IEMRContainersPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEMRContainersPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EMRContainersPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEMRContainersEndpointResolver());
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


        #region  CancelJobRun

        internal virtual CancelJobRunResponse CancelJobRun(CancelJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobRunResponseUnmarshaller.Instance;

            return Invoke<CancelJobRunResponse>(request, options);
        }



        /// <summary>
        /// Cancels a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        public virtual Task<CancelJobRunResponse> CancelJobRunAsync(CancelJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJobTemplate

        internal virtual CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateJobTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        public virtual Task<CreateJobTemplateResponse> CreateJobTemplateAsync(CreateJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateManagedEndpoint

        internal virtual CreateManagedEndpointResponse CreateManagedEndpoint(CreateManagedEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateManagedEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateManagedEndpoint">REST API Reference for CreateManagedEndpoint Operation</seealso>
        public virtual Task<CreateManagedEndpointResponse> CreateManagedEndpointAsync(CreateManagedEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateManagedEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVirtualCluster

        internal virtual CreateVirtualClusterResponse CreateVirtualCluster(CreateVirtualClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualClusterResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateVirtualCluster">REST API Reference for CreateVirtualCluster Operation</seealso>
        public virtual Task<CreateVirtualClusterResponse> CreateVirtualClusterAsync(CreateVirtualClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVirtualClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJobTemplate

        internal virtual DeleteJobTemplateResponse DeleteJobTemplate(DeleteJobTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteJobTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        public virtual Task<DeleteJobTemplateResponse> DeleteJobTemplateAsync(DeleteJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteManagedEndpoint

        internal virtual DeleteManagedEndpointResponse DeleteManagedEndpoint(DeleteManagedEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteManagedEndpoint">REST API Reference for DeleteManagedEndpoint Operation</seealso>
        public virtual Task<DeleteManagedEndpointResponse> DeleteManagedEndpointAsync(DeleteManagedEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteManagedEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualCluster

        internal virtual DeleteVirtualClusterResponse DeleteVirtualCluster(DeleteVirtualClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteVirtualCluster">REST API Reference for DeleteVirtualCluster Operation</seealso>
        public virtual Task<DeleteVirtualClusterResponse> DeleteVirtualClusterAsync(DeleteVirtualClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobRun

        internal virtual DescribeJobRunResponse DescribeJobRun(DescribeJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobRunResponseUnmarshaller.Instance;

            return Invoke<DescribeJobRunResponse>(request, options);
        }



        /// <summary>
        /// Displays detailed information about a job run. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobRun">REST API Reference for DescribeJobRun Operation</seealso>
        public virtual Task<DescribeJobRunResponse> DescribeJobRunAsync(DescribeJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobTemplate

        internal virtual DescribeJobTemplateResponse DescribeJobTemplate(DescribeJobTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeJobTemplateResponse>(request, options);
        }



        /// <summary>
        /// Displays detailed information about a specified job template. Job template stores
        /// values of StartJobRun API request in a template and can be used to start a job run.
        /// Job template allows two use cases: avoid repeating recurring StartJobRun API request
        /// values, enforcing certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        public virtual Task<DescribeJobTemplateResponse> DescribeJobTemplateAsync(DescribeJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeManagedEndpoint

        internal virtual DescribeManagedEndpointResponse DescribeManagedEndpoint(DescribeManagedEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedEndpointResponse>(request, options);
        }



        /// <summary>
        /// Displays detailed information about a managed endpoint. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeManagedEndpoint">REST API Reference for DescribeManagedEndpoint Operation</seealso>
        public virtual Task<DescribeManagedEndpointResponse> DescribeManagedEndpointAsync(DescribeManagedEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeManagedEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualCluster

        internal virtual DescribeVirtualClusterResponse DescribeVirtualCluster(DescribeVirtualClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualClusterResponse>(request, options);
        }



        /// <summary>
        /// Displays detailed information about a specified virtual cluster. Virtual cluster is
        /// a managed entity on Amazon EMR on EKS. You can create, describe, list and delete virtual
        /// clusters. They do not consume any additional resource in your system. A single virtual
        /// cluster maps to a single Kubernetes namespace. Given this relationship, you can model
        /// virtual clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeVirtualCluster">REST API Reference for DescribeVirtualCluster Operation</seealso>
        public virtual Task<DescribeVirtualClusterResponse> DescribeVirtualClusterAsync(DescribeVirtualClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobRuns

        internal virtual ListJobRunsResponse ListJobRuns(ListJobRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return Invoke<ListJobRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists job runs based on a set of parameters. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobTemplates

        internal virtual ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListJobTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists job templates based on a set of parameters. Job template stores values of StartJobRun
        /// API request in a template and can be used to start a job run. Job template allows
        /// two use cases: avoid repeating recurring StartJobRun API request values, enforcing
        /// certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        public virtual Task<ListJobTemplatesResponse> ListJobTemplatesAsync(ListJobTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedEndpoints

        internal virtual ListManagedEndpointsResponse ListManagedEndpoints(ListManagedEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListManagedEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Lists managed endpoints based on a set of parameters. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedEndpoints service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListManagedEndpoints">REST API Reference for ListManagedEndpoints Operation</seealso>
        public virtual Task<ListManagedEndpointsResponse> ListManagedEndpointsAsync(ListManagedEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedEndpointsResponse>(request, options, cancellationToken);
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
        /// Lists the tags assigned to the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualClusters

        internal virtual ListVirtualClustersResponse ListVirtualClusters(ListVirtualClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualClustersResponseUnmarshaller.Instance;

            return Invoke<ListVirtualClustersResponse>(request, options);
        }



        /// <summary>
        /// Lists information about the specified virtual cluster. Virtual cluster is a managed
        /// entity on Amazon EMR on EKS. You can create, describe, list and delete virtual clusters.
        /// They do not consume any additional resource in your system. A single virtual cluster
        /// maps to a single Kubernetes namespace. Given this relationship, you can model virtual
        /// clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualClusters service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListVirtualClusters">REST API Reference for ListVirtualClusters Operation</seealso>
        public virtual Task<ListVirtualClustersResponse> ListVirtualClustersAsync(ListVirtualClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun

        internal virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunResponse>(request, options, cancellationToken);
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
        /// Assigns tags to resources. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key and an optional value, both of which you define.
        /// Tags enable you to categorize your Amazon Web Services resources by attributes such
        /// as purpose, owner, or environment. When you have many resources of the same type,
        /// you can quickly identify a specific resource based on the tags you've assigned to
        /// it. For example, you can define a set of tags for your Amazon EMR on EKS clusters
        /// to help you track each cluster's owner and stack level. We recommend that you devise
        /// a consistent set of tag keys for each resource type. You can then search and filter
        /// the resources based on the tags that you add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}