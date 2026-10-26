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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.Odb.Model;
using Amazon.Odb.Model.Internal.MarshallTransformations;
using Amazon.Odb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.Odb
{
    /// <summary>
    /// <para>Implementation for accessing Odb</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Oracle Database@Amazon Web Services is an offering that enables you to access Oracle
    /// Exadata infrastructure managed by Oracle Cloud Infrastructure (OCI) inside Amazon
    /// Web Services data centers. You can migrate your Oracle Exadata workloads, establish
    /// low-latency connectivity with applications running on Amazon Web Services, and integrate
    /// with Amazon Web Services services. For example, you can run application servers in
    /// a Virtual Private Cloud (VPC) and access an Oracle Exadata system running in Oracle
    /// Database@Amazon Web Services. You can get started with Oracle Database@Amazon Web
    /// Services by using the familiar Amazon Web Services Management Console, APIs, or CLI.
    /// 
    ///  
    /// <para>
    /// This interface reference for Oracle Database@Amazon Web Services contains documentation
    /// for a programming or command line interface that you can use to manage Oracle Database@Amazon
    /// Web Services. Oracle Database@Amazon Web Services is asynchronous, which means that
    /// some interfaces might require techniques such as polling or callback functions to
    /// determine when a command has been applied. The reference structure is as follows.
    /// </para>
    ///  
    /// <para>
    ///  <b>Oracle Database@Amazon Web Services API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonOdbClient : AmazonServiceClient, IAmazonOdb
    {
        private static IServiceMetadata serviceMetadata = new AmazonOdbMetadata();
        private IOdbPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOdbPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new OdbPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient() : base(new AmazonOdbConfig()) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient(RegionEndpoint region) : base(new AmazonOdbConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AmazonOdbConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOdbClient(AWSCredentials credentials)
            : this(credentials, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOdbConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials and an
        /// AmazonOdbClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AWSCredentials credentials, AmazonOdbConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOdbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOdbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOdbEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOdbAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// <returns>The response from the AcceptMarketplaceRegistration service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual AcceptMarketplaceRegistrationResponse AcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return Invoke<AcceptMarketplaceRegistrationResponse>(request, options);
        }
#else
        internal virtual AcceptMarketplaceRegistrationResponse AcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return Invoke<AcceptMarketplaceRegistrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AcceptMarketplaceRegistration service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual Task<AcceptMarketplaceRegistrationResponse> AcceptMarketplaceRegistrationAsync(AcceptMarketplaceRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMarketplaceRegistrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Associates an Amazon Web Services Identity and Access Management (IAM) service role
        /// with a specified resource to enable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamRoleToResource service method.</param>
        /// <returns>The response from the AssociateIamRoleToResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateIamRoleToResource">REST API Reference for AssociateIamRoleToResource Operation</seealso>
        public virtual AssociateIamRoleToResourceResponse AssociateIamRoleToResource(AssociateIamRoleToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIamRoleToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamRoleToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateIamRoleToResourceResponse>(request, options);
        }
#else
        internal virtual AssociateIamRoleToResourceResponse AssociateIamRoleToResource(AssociateIamRoleToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIamRoleToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamRoleToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateIamRoleToResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Associates an Amazon Web Services Identity and Access Management (IAM) service role
        /// with a specified resource to enable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamRoleToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateIamRoleToResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateIamRoleToResource">REST API Reference for AssociateIamRoleToResource Operation</seealso>
        public virtual Task<AssociateIamRoleToResourceResponse> AssociateIamRoleToResourceAsync(AssociateIamRoleToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIamRoleToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamRoleToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIamRoleToResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds virtual machines to the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualMachinesToExadbVmCluster service method.</param>
        /// <returns>The response from the AssociateVirtualMachinesToExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateVirtualMachinesToExadbVmCluster">REST API Reference for AssociateVirtualMachinesToExadbVmCluster Operation</seealso>
        public virtual AssociateVirtualMachinesToExadbVmClusterResponse AssociateVirtualMachinesToExadbVmCluster(AssociateVirtualMachinesToExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVirtualMachinesToExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualMachinesToExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<AssociateVirtualMachinesToExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual AssociateVirtualMachinesToExadbVmClusterResponse AssociateVirtualMachinesToExadbVmCluster(AssociateVirtualMachinesToExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVirtualMachinesToExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualMachinesToExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<AssociateVirtualMachinesToExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Adds virtual machines to the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualMachinesToExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateVirtualMachinesToExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateVirtualMachinesToExadbVmCluster">REST API Reference for AssociateVirtualMachinesToExadbVmCluster Operation</seealso>
        public virtual Task<AssociateVirtualMachinesToExadbVmClusterResponse> AssociateVirtualMachinesToExadbVmClusterAsync(AssociateVirtualMachinesToExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVirtualMachinesToExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualMachinesToExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVirtualMachinesToExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabase service method.</param>
        /// <returns>The response from the CreateAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabase">REST API Reference for CreateAutonomousDatabase Operation</seealso>
        public virtual CreateAutonomousDatabaseResponse CreateAutonomousDatabase(CreateAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual CreateAutonomousDatabaseResponse CreateAutonomousDatabase(CreateAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabase">REST API Reference for CreateAutonomousDatabase Operation</seealso>
        public virtual Task<CreateAutonomousDatabaseResponse> CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new backup of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabaseBackup service method.</param>
        /// <returns>The response from the CreateAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabaseBackup">REST API Reference for CreateAutonomousDatabaseBackup Operation</seealso>
        public virtual CreateAutonomousDatabaseBackupResponse CreateAutonomousDatabaseBackup(CreateAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseBackupResponse>(request, options);
        }
#else
        internal virtual CreateAutonomousDatabaseBackupResponse CreateAutonomousDatabaseBackup(CreateAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseBackupResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new backup of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabaseBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabaseBackup">REST API Reference for CreateAutonomousDatabaseBackup Operation</seealso>
        public virtual Task<CreateAutonomousDatabaseBackupResponse> CreateAutonomousDatabaseBackupAsync(CreateAutonomousDatabaseBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutonomousDatabaseBackupResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new wallet for the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabaseWallet service method.</param>
        /// <returns>The response from the CreateAutonomousDatabaseWallet service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabaseWallet">REST API Reference for CreateAutonomousDatabaseWallet Operation</seealso>
        public virtual CreateAutonomousDatabaseWalletResponse CreateAutonomousDatabaseWallet(CreateAutonomousDatabaseWalletRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseWalletRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseWalletResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseWalletResponse>(request, options);
        }
#else
        internal virtual CreateAutonomousDatabaseWalletResponse CreateAutonomousDatabaseWallet(CreateAutonomousDatabaseWalletRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseWalletRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseWalletResponseUnmarshaller.Instance;

            return Invoke<CreateAutonomousDatabaseWalletResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new wallet for the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutonomousDatabaseWallet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAutonomousDatabaseWallet service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateAutonomousDatabaseWallet">REST API Reference for CreateAutonomousDatabaseWallet Operation</seealso>
        public virtual Task<CreateAutonomousDatabaseWalletResponse> CreateAutonomousDatabaseWalletAsync(CreateAutonomousDatabaseWalletRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutonomousDatabaseWalletRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutonomousDatabaseWalletResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutonomousDatabaseWalletResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// <returns>The response from the CreateCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual CreateCloudAutonomousVmClusterResponse CreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudAutonomousVmClusterResponse>(request, options);
        }
#else
        internal virtual CreateCloudAutonomousVmClusterResponse CreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudAutonomousVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<CreateCloudAutonomousVmClusterResponse> CreateCloudAutonomousVmClusterAsync(CreateCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// <returns>The response from the CreateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual CreateCloudExadataInfrastructureResponse CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<CreateCloudExadataInfrastructureResponse>(request, options);
        }
#else
        internal virtual CreateCloudExadataInfrastructureResponse CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<CreateCloudExadataInfrastructureResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual Task<CreateCloudExadataInfrastructureResponse> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// <returns>The response from the CreateCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual CreateCloudVmClusterResponse CreateCloudVmCluster(CreateCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudVmClusterResponse>(request, options);
        }
#else
        internal virtual CreateCloudVmClusterResponse CreateCloudVmCluster(CreateCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual Task<CreateCloudVmClusterResponse> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExadbVmCluster service method.</param>
        /// <returns>The response from the CreateExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateExadbVmCluster">REST API Reference for CreateExadbVmCluster Operation</seealso>
        public virtual CreateExadbVmClusterResponse CreateExadbVmCluster(CreateExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual CreateExadbVmClusterResponse CreateExadbVmCluster(CreateExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateExadbVmCluster">REST API Reference for CreateExadbVmCluster Operation</seealso>
        public virtual Task<CreateExadbVmClusterResponse> CreateExadbVmClusterAsync(CreateExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Exascale storage vault.
        /// 
        ///  
        /// <para>
        /// To create the Exascale storage vault on dedicated Exadata infrastructure, specify
        /// <c>cloudExadataInfrastructureId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExascaleDbStorageVault service method.</param>
        /// <returns>The response from the CreateExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateExascaleDbStorageVault">REST API Reference for CreateExascaleDbStorageVault Operation</seealso>
        public virtual CreateExascaleDbStorageVaultResponse CreateExascaleDbStorageVault(CreateExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<CreateExascaleDbStorageVaultResponse>(request, options);
        }
#else
        internal virtual CreateExascaleDbStorageVaultResponse CreateExascaleDbStorageVault(CreateExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<CreateExascaleDbStorageVaultResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Exascale storage vault.
        /// 
        ///  
        /// <para>
        /// To create the Exascale storage vault on dedicated Exadata infrastructure, specify
        /// <c>cloudExadataInfrastructureId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExascaleDbStorageVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateExascaleDbStorageVault">REST API Reference for CreateExascaleDbStorageVault Operation</seealso>
        public virtual Task<CreateExascaleDbStorageVaultResponse> CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExascaleDbStorageVaultResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// <returns>The response from the CreateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual CreateOdbNetworkResponse CreateOdbNetwork(CreateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateOdbNetworkResponse>(request, options);
        }
#else
        internal virtual CreateOdbNetworkResponse CreateOdbNetwork(CreateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateOdbNetworkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual Task<CreateOdbNetworkResponse> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOdbNetworkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a peering connection between an ODB network and a VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// <returns>The response from the CreateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual CreateOdbPeeringConnectionResponse CreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOdbPeeringConnectionResponse>(request, options);
        }
#else
        internal virtual CreateOdbPeeringConnectionResponse CreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOdbPeeringConnectionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a peering connection between an ODB network and a VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual Task<CreateOdbPeeringConnectionResponse> CreateOdbPeeringConnectionAsync(CreateOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutonomousDatabase service method.</param>
        /// <returns>The response from the DeleteAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteAutonomousDatabase">REST API Reference for DeleteAutonomousDatabase Operation</seealso>
        public virtual DeleteAutonomousDatabaseResponse DeleteAutonomousDatabase(DeleteAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual DeleteAutonomousDatabaseResponse DeleteAutonomousDatabase(DeleteAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteAutonomousDatabase">REST API Reference for DeleteAutonomousDatabase Operation</seealso>
        public virtual Task<DeleteAutonomousDatabaseResponse> DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutonomousDatabaseBackup service method.</param>
        /// <returns>The response from the DeleteAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteAutonomousDatabaseBackup">REST API Reference for DeleteAutonomousDatabaseBackup Operation</seealso>
        public virtual DeleteAutonomousDatabaseBackupResponse DeleteAutonomousDatabaseBackup(DeleteAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutonomousDatabaseBackupResponse>(request, options);
        }
#else
        internal virtual DeleteAutonomousDatabaseBackupResponse DeleteAutonomousDatabaseBackup(DeleteAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutonomousDatabaseBackupResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutonomousDatabaseBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteAutonomousDatabaseBackup">REST API Reference for DeleteAutonomousDatabaseBackup Operation</seealso>
        public virtual Task<DeleteAutonomousDatabaseBackupResponse> DeleteAutonomousDatabaseBackupAsync(DeleteAutonomousDatabaseBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutonomousDatabaseBackupResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// <returns>The response from the DeleteCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual DeleteCloudAutonomousVmClusterResponse DeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudAutonomousVmClusterResponse>(request, options);
        }
#else
        internal virtual DeleteCloudAutonomousVmClusterResponse DeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudAutonomousVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<DeleteCloudAutonomousVmClusterResponse> DeleteCloudAutonomousVmClusterAsync(DeleteCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// <returns>The response from the DeleteCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual DeleteCloudExadataInfrastructureResponse DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudExadataInfrastructureResponse>(request, options);
        }
#else
        internal virtual DeleteCloudExadataInfrastructureResponse DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudExadataInfrastructureResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual Task<DeleteCloudExadataInfrastructureResponse> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// <returns>The response from the DeleteCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual DeleteCloudVmClusterResponse DeleteCloudVmCluster(DeleteCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudVmClusterResponse>(request, options);
        }
#else
        internal virtual DeleteCloudVmClusterResponse DeleteCloudVmCluster(DeleteCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual Task<DeleteCloudVmClusterResponse> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExadbVmCluster service method.</param>
        /// <returns>The response from the DeleteExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteExadbVmCluster">REST API Reference for DeleteExadbVmCluster Operation</seealso>
        public virtual DeleteExadbVmClusterResponse DeleteExadbVmCluster(DeleteExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual DeleteExadbVmClusterResponse DeleteExadbVmCluster(DeleteExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteExadbVmCluster">REST API Reference for DeleteExadbVmCluster Operation</seealso>
        public virtual Task<DeleteExadbVmClusterResponse> DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExascaleDbStorageVault service method.</param>
        /// <returns>The response from the DeleteExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteExascaleDbStorageVault">REST API Reference for DeleteExascaleDbStorageVault Operation</seealso>
        public virtual DeleteExascaleDbStorageVaultResponse DeleteExascaleDbStorageVault(DeleteExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteExascaleDbStorageVaultResponse>(request, options);
        }
#else
        internal virtual DeleteExascaleDbStorageVaultResponse DeleteExascaleDbStorageVault(DeleteExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteExascaleDbStorageVaultResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExascaleDbStorageVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteExascaleDbStorageVault">REST API Reference for DeleteExascaleDbStorageVault Operation</seealso>
        public virtual Task<DeleteExascaleDbStorageVaultResponse> DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExascaleDbStorageVaultResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// <returns>The response from the DeleteOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual DeleteOdbNetworkResponse DeleteOdbNetwork(DeleteOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbNetworkResponse>(request, options);
        }
#else
        internal virtual DeleteOdbNetworkResponse DeleteOdbNetwork(DeleteOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbNetworkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual Task<DeleteOdbNetworkResponse> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOdbNetworkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// <returns>The response from the DeleteOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual DeleteOdbPeeringConnectionResponse DeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbPeeringConnectionResponse>(request, options);
        }
#else
        internal virtual DeleteOdbPeeringConnectionResponse DeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbPeeringConnectionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual Task<DeleteOdbPeeringConnectionResponse> DeleteOdbPeeringConnectionAsync(DeleteOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates an Amazon Web Services Identity and Access Management (IAM) service
        /// role from a specified resource to disable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamRoleFromResource service method.</param>
        /// <returns>The response from the DisassociateIamRoleFromResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateIamRoleFromResource">REST API Reference for DisassociateIamRoleFromResource Operation</seealso>
        public virtual DisassociateIamRoleFromResourceResponse DisassociateIamRoleFromResource(DisassociateIamRoleFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIamRoleFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamRoleFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamRoleFromResourceResponse>(request, options);
        }
#else
        internal virtual DisassociateIamRoleFromResourceResponse DisassociateIamRoleFromResource(DisassociateIamRoleFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIamRoleFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamRoleFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamRoleFromResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Disassociates an Amazon Web Services Identity and Access Management (IAM) service
        /// role from a specified resource to disable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamRoleFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateIamRoleFromResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateIamRoleFromResource">REST API Reference for DisassociateIamRoleFromResource Operation</seealso>
        public virtual Task<DisassociateIamRoleFromResourceResponse> DisassociateIamRoleFromResourceAsync(DisassociateIamRoleFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIamRoleFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamRoleFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIamRoleFromResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes virtual machines from the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVirtualMachinesFromExadbVmCluster service method.</param>
        /// <returns>The response from the DisassociateVirtualMachinesFromExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateVirtualMachinesFromExadbVmCluster">REST API Reference for DisassociateVirtualMachinesFromExadbVmCluster Operation</seealso>
        public virtual DisassociateVirtualMachinesFromExadbVmClusterResponse DisassociateVirtualMachinesFromExadbVmCluster(DisassociateVirtualMachinesFromExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVirtualMachinesFromExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVirtualMachinesFromExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<DisassociateVirtualMachinesFromExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual DisassociateVirtualMachinesFromExadbVmClusterResponse DisassociateVirtualMachinesFromExadbVmCluster(DisassociateVirtualMachinesFromExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVirtualMachinesFromExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVirtualMachinesFromExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<DisassociateVirtualMachinesFromExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes virtual machines from the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVirtualMachinesFromExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateVirtualMachinesFromExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateVirtualMachinesFromExadbVmCluster">REST API Reference for DisassociateVirtualMachinesFromExadbVmCluster Operation</seealso>
        public virtual Task<DisassociateVirtualMachinesFromExadbVmClusterResponse> DisassociateVirtualMachinesFromExadbVmClusterAsync(DisassociateVirtualMachinesFromExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVirtualMachinesFromExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVirtualMachinesFromExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVirtualMachinesFromExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Initiates a failover of the specified Autonomous Database to a standby peer database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverAutonomousDatabase service method.</param>
        /// <returns>The response from the FailoverAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/FailoverAutonomousDatabase">REST API Reference for FailoverAutonomousDatabase Operation</seealso>
        public virtual FailoverAutonomousDatabaseResponse FailoverAutonomousDatabase(FailoverAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<FailoverAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual FailoverAutonomousDatabaseResponse FailoverAutonomousDatabase(FailoverAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<FailoverAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Initiates a failover of the specified Autonomous Database to a standby peer database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the FailoverAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/FailoverAutonomousDatabase">REST API Reference for FailoverAutonomousDatabase Operation</seealso>
        public virtual Task<FailoverAutonomousDatabaseResponse> FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets information about a specific Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabase service method.</param>
        /// <returns>The response from the GetAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabase">REST API Reference for GetAutonomousDatabase Operation</seealso>
        public virtual GetAutonomousDatabaseResponse GetAutonomousDatabase(GetAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual GetAutonomousDatabaseResponse GetAutonomousDatabase(GetAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets information about a specific Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabase">REST API Reference for GetAutonomousDatabase Operation</seealso>
        public virtual Task<GetAutonomousDatabaseResponse> GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets information about a specific Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabaseBackup service method.</param>
        /// <returns>The response from the GetAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabaseBackup">REST API Reference for GetAutonomousDatabaseBackup Operation</seealso>
        public virtual GetAutonomousDatabaseBackupResponse GetAutonomousDatabaseBackup(GetAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseBackupResponse>(request, options);
        }
#else
        internal virtual GetAutonomousDatabaseBackupResponse GetAutonomousDatabaseBackup(GetAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseBackupResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets information about a specific Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabaseBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabaseBackup">REST API Reference for GetAutonomousDatabaseBackup Operation</seealso>
        public virtual Task<GetAutonomousDatabaseBackupResponse> GetAutonomousDatabaseBackupAsync(GetAutonomousDatabaseBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutonomousDatabaseBackupResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the wallet details for the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabaseWalletDetails service method.</param>
        /// <returns>The response from the GetAutonomousDatabaseWalletDetails service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabaseWalletDetails">REST API Reference for GetAutonomousDatabaseWalletDetails Operation</seealso>
        public virtual GetAutonomousDatabaseWalletDetailsResponse GetAutonomousDatabaseWalletDetails(GetAutonomousDatabaseWalletDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseWalletDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseWalletDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseWalletDetailsResponse>(request, options);
        }
#else
        internal virtual GetAutonomousDatabaseWalletDetailsResponse GetAutonomousDatabaseWalletDetails(GetAutonomousDatabaseWalletDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseWalletDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseWalletDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAutonomousDatabaseWalletDetailsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the wallet details for the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutonomousDatabaseWalletDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAutonomousDatabaseWalletDetails service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetAutonomousDatabaseWalletDetails">REST API Reference for GetAutonomousDatabaseWalletDetails Operation</seealso>
        public virtual Task<GetAutonomousDatabaseWalletDetailsResponse> GetAutonomousDatabaseWalletDetailsAsync(GetAutonomousDatabaseWalletDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutonomousDatabaseWalletDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutonomousDatabaseWalletDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutonomousDatabaseWalletDetailsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// <returns>The response from the GetCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual GetCloudAutonomousVmClusterResponse GetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudAutonomousVmClusterResponse>(request, options);
        }
#else
        internal virtual GetCloudAutonomousVmClusterResponse GetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudAutonomousVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<GetCloudAutonomousVmClusterResponse> GetCloudAutonomousVmClusterAsync(GetCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// <returns>The response from the GetCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual GetCloudExadataInfrastructureResponse GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureResponse>(request, options);
        }
#else
        internal virtual GetCloudExadataInfrastructureResponse GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual Task<GetCloudExadataInfrastructureResponse> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// <returns>The response from the GetCloudExadataInfrastructureUnallocatedResources service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual GetCloudExadataInfrastructureUnallocatedResourcesResponse GetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options);
        }
#else
        internal virtual GetCloudExadataInfrastructureUnallocatedResourcesResponse GetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCloudExadataInfrastructureUnallocatedResources service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual Task<GetCloudExadataInfrastructureUnallocatedResourcesResponse> GetCloudExadataInfrastructureUnallocatedResourcesAsync(GetCloudExadataInfrastructureUnallocatedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// <returns>The response from the GetCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual GetCloudVmClusterResponse GetCloudVmCluster(GetCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudVmClusterResponse>(request, options);
        }
#else
        internal virtual GetCloudVmClusterResponse GetCloudVmCluster(GetCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual Task<GetCloudVmClusterResponse> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// <returns>The response from the GetDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual GetDbNodeResponse GetDbNode(GetDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return Invoke<GetDbNodeResponse>(request, options);
        }
#else
        internal virtual GetDbNodeResponse GetDbNode(GetDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return Invoke<GetDbNodeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual Task<GetDbNodeResponse> GetDbNodeAsync(GetDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetDbNodeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// <returns>The response from the GetDbServer service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual GetDbServerResponse GetDbServer(GetDbServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return Invoke<GetDbServerResponse>(request, options);
        }
#else
        internal virtual GetDbServerResponse GetDbServer(GetDbServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return Invoke<GetDbServerResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbServer service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual Task<GetDbServerResponse> GetDbServerAsync(GetDbServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return InvokeAsync<GetDbServerResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExadbVmCluster service method.</param>
        /// <returns>The response from the GetExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetExadbVmCluster">REST API Reference for GetExadbVmCluster Operation</seealso>
        public virtual GetExadbVmClusterResponse GetExadbVmCluster(GetExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual GetExadbVmClusterResponse GetExadbVmCluster(GetExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetExadbVmCluster">REST API Reference for GetExadbVmCluster Operation</seealso>
        public virtual Task<GetExadbVmClusterResponse> GetExadbVmClusterAsync(GetExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExascaleDbStorageVault service method.</param>
        /// <returns>The response from the GetExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetExascaleDbStorageVault">REST API Reference for GetExascaleDbStorageVault Operation</seealso>
        public virtual GetExascaleDbStorageVaultResponse GetExascaleDbStorageVault(GetExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<GetExascaleDbStorageVaultResponse>(request, options);
        }
#else
        internal virtual GetExascaleDbStorageVaultResponse GetExascaleDbStorageVault(GetExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<GetExascaleDbStorageVaultResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExascaleDbStorageVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetExascaleDbStorageVault">REST API Reference for GetExascaleDbStorageVault Operation</seealso>
        public virtual Task<GetExascaleDbStorageVaultResponse> GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return InvokeAsync<GetExascaleDbStorageVaultResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// <returns>The response from the GetOciOnboardingStatus service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual GetOciOnboardingStatusResponse GetOciOnboardingStatus(GetOciOnboardingStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOciOnboardingStatusResponse>(request, options);
        }
#else
        internal virtual GetOciOnboardingStatusResponse GetOciOnboardingStatus(GetOciOnboardingStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOciOnboardingStatusResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetOciOnboardingStatus service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual Task<GetOciOnboardingStatusResponse> GetOciOnboardingStatusAsync(GetOciOnboardingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetOciOnboardingStatusResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// <returns>The response from the GetOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual GetOdbNetworkResponse GetOdbNetwork(GetOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<GetOdbNetworkResponse>(request, options);
        }
#else
        internal virtual GetOdbNetworkResponse GetOdbNetwork(GetOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<GetOdbNetworkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual Task<GetOdbNetworkResponse> GetOdbNetworkAsync(GetOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<GetOdbNetworkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// <returns>The response from the GetOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual GetOdbPeeringConnectionResponse GetOdbPeeringConnection(GetOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<GetOdbPeeringConnectionResponse>(request, options);
        }
#else
        internal virtual GetOdbPeeringConnectionResponse GetOdbPeeringConnection(GetOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<GetOdbPeeringConnectionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual Task<GetOdbPeeringConnectionResponse> GetOdbPeeringConnectionAsync(GetOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <returns>The response from the InitializeService service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }
#else
        internal virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InitializeService service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return InvokeAsync<InitializeServiceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the backups of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseBackups service method.</param>
        /// <returns>The response from the ListAutonomousDatabaseBackups service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseBackups">REST API Reference for ListAutonomousDatabaseBackups Operation</seealso>
        public virtual ListAutonomousDatabaseBackupsResponse ListAutonomousDatabaseBackups(ListAutonomousDatabaseBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseBackupsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseBackupsResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabaseBackupsResponse ListAutonomousDatabaseBackups(ListAutonomousDatabaseBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseBackupsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseBackupsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the backups of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabaseBackups service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseBackups">REST API Reference for ListAutonomousDatabaseBackups Operation</seealso>
        public virtual Task<ListAutonomousDatabaseBackupsResponse> ListAutonomousDatabaseBackupsAsync(ListAutonomousDatabaseBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabaseBackupsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the available character sets for Autonomous Databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseCharacterSets service method.</param>
        /// <returns>The response from the ListAutonomousDatabaseCharacterSets service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseCharacterSets">REST API Reference for ListAutonomousDatabaseCharacterSets Operation</seealso>
        public virtual ListAutonomousDatabaseCharacterSetsResponse ListAutonomousDatabaseCharacterSets(ListAutonomousDatabaseCharacterSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseCharacterSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseCharacterSetsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseCharacterSetsResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabaseCharacterSetsResponse ListAutonomousDatabaseCharacterSets(ListAutonomousDatabaseCharacterSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseCharacterSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseCharacterSetsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseCharacterSetsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the available character sets for Autonomous Databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseCharacterSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabaseCharacterSets service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseCharacterSets">REST API Reference for ListAutonomousDatabaseCharacterSets Operation</seealso>
        public virtual Task<ListAutonomousDatabaseCharacterSetsResponse> ListAutonomousDatabaseCharacterSetsAsync(ListAutonomousDatabaseCharacterSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseCharacterSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseCharacterSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabaseCharacterSetsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the clones of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseClones service method.</param>
        /// <returns>The response from the ListAutonomousDatabaseClones service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseClones">REST API Reference for ListAutonomousDatabaseClones Operation</seealso>
        public virtual ListAutonomousDatabaseClonesResponse ListAutonomousDatabaseClones(ListAutonomousDatabaseClonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseClonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseClonesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseClonesResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabaseClonesResponse ListAutonomousDatabaseClones(ListAutonomousDatabaseClonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseClonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseClonesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseClonesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the clones of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseClones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabaseClones service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseClones">REST API Reference for ListAutonomousDatabaseClones Operation</seealso>
        public virtual Task<ListAutonomousDatabaseClonesResponse> ListAutonomousDatabaseClonesAsync(ListAutonomousDatabaseClonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseClonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseClonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabaseClonesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the peer databases of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabasePeers service method.</param>
        /// <returns>The response from the ListAutonomousDatabasePeers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabasePeers">REST API Reference for ListAutonomousDatabasePeers Operation</seealso>
        public virtual ListAutonomousDatabasePeersResponse ListAutonomousDatabasePeers(ListAutonomousDatabasePeersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasePeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasePeersResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabasePeersResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabasePeersResponse ListAutonomousDatabasePeers(ListAutonomousDatabasePeersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasePeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasePeersResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabasePeersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the peer databases of the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabasePeers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabasePeers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabasePeers">REST API Reference for ListAutonomousDatabasePeers Operation</seealso>
        public virtual Task<ListAutonomousDatabasePeersResponse> ListAutonomousDatabasePeersAsync(ListAutonomousDatabasePeersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasePeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasePeersResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabasePeersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the available Oracle Database software versions for Autonomous Databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseVersions service method.</param>
        /// <returns>The response from the ListAutonomousDatabaseVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseVersions">REST API Reference for ListAutonomousDatabaseVersions Operation</seealso>
        public virtual ListAutonomousDatabaseVersionsResponse ListAutonomousDatabaseVersions(ListAutonomousDatabaseVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseVersionsResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabaseVersionsResponse ListAutonomousDatabaseVersions(ListAutonomousDatabaseVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabaseVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the available Oracle Database software versions for Autonomous Databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabaseVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabaseVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabaseVersions">REST API Reference for ListAutonomousDatabaseVersions Operation</seealso>
        public virtual Task<ListAutonomousDatabaseVersionsResponse> ListAutonomousDatabaseVersionsAsync(ListAutonomousDatabaseVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabaseVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabaseVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabaseVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the Autonomous Databases owned by your Amazon Web Services
        /// account in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabases service method.</param>
        /// <returns>The response from the ListAutonomousDatabases service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabases">REST API Reference for ListAutonomousDatabases Operation</seealso>
        public virtual ListAutonomousDatabasesResponse ListAutonomousDatabases(ListAutonomousDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabasesResponse>(request, options);
        }
#else
        internal virtual ListAutonomousDatabasesResponse ListAutonomousDatabases(ListAutonomousDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousDatabasesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the Autonomous Databases owned by your Amazon Web Services
        /// account in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousDatabases service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousDatabases">REST API Reference for ListAutonomousDatabases Operation</seealso>
        public virtual Task<ListAutonomousDatabasesResponse> ListAutonomousDatabasesAsync(ListAutonomousDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousDatabasesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// <returns>The response from the ListAutonomousVirtualMachines service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual ListAutonomousVirtualMachinesResponse ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousVirtualMachinesResponse>(request, options);
        }
#else
        internal virtual ListAutonomousVirtualMachinesResponse ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousVirtualMachinesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAutonomousVirtualMachines service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual Task<ListAutonomousVirtualMachinesResponse> ListAutonomousVirtualMachinesAsync(ListAutonomousVirtualMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousVirtualMachinesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// <returns>The response from the ListCloudAutonomousVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual ListCloudAutonomousVmClustersResponse ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudAutonomousVmClustersResponse>(request, options);
        }
#else
        internal virtual ListCloudAutonomousVmClustersResponse ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudAutonomousVmClustersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCloudAutonomousVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual Task<ListCloudAutonomousVmClustersResponse> ListCloudAutonomousVmClustersAsync(ListCloudAutonomousVmClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudAutonomousVmClustersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// <returns>The response from the ListCloudExadataInfrastructures service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual ListCloudExadataInfrastructuresResponse ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return Invoke<ListCloudExadataInfrastructuresResponse>(request, options);
        }
#else
        internal virtual ListCloudExadataInfrastructuresResponse ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return Invoke<ListCloudExadataInfrastructuresResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCloudExadataInfrastructures service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual Task<ListCloudExadataInfrastructuresResponse> ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudExadataInfrastructuresResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// <returns>The response from the ListCloudVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual ListCloudVmClustersResponse ListCloudVmClusters(ListCloudVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudVmClustersResponse>(request, options);
        }
#else
        internal virtual ListCloudVmClustersResponse ListCloudVmClusters(ListCloudVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudVmClustersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCloudVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual Task<ListCloudVmClustersResponse> ListCloudVmClustersAsync(ListCloudVmClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudVmClustersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// <returns>The response from the ListDbNodes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual ListDbNodesResponse ListDbNodes(ListDbNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return Invoke<ListDbNodesResponse>(request, options);
        }
#else
        internal virtual ListDbNodesResponse ListDbNodes(ListDbNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return Invoke<ListDbNodesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbNodes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual Task<ListDbNodesResponse> ListDbNodesAsync(ListDbNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbNodesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// <returns>The response from the ListDbServers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual ListDbServersResponse ListDbServers(ListDbServersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return Invoke<ListDbServersResponse>(request, options);
        }
#else
        internal virtual ListDbServersResponse ListDbServers(ListDbServersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return Invoke<ListDbServersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbServers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual Task<ListDbServersResponse> ListDbServersAsync(ListDbServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbServersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// <returns>The response from the ListDbSystemShapes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual ListDbSystemShapesResponse ListDbSystemShapes(ListDbSystemShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return Invoke<ListDbSystemShapesResponse>(request, options);
        }
#else
        internal virtual ListDbSystemShapesResponse ListDbSystemShapes(ListDbSystemShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return Invoke<ListDbSystemShapesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbSystemShapes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual Task<ListDbSystemShapesResponse> ListDbSystemShapesAsync(ListDbSystemShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbSystemShapesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the Exascale VM clusters owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExadbVmClusters service method.</param>
        /// <returns>The response from the ListExadbVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListExadbVmClusters">REST API Reference for ListExadbVmClusters Operation</seealso>
        public virtual ListExadbVmClustersResponse ListExadbVmClusters(ListExadbVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExadbVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExadbVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListExadbVmClustersResponse>(request, options);
        }
#else
        internal virtual ListExadbVmClustersResponse ListExadbVmClusters(ListExadbVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExadbVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExadbVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListExadbVmClustersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the Exascale VM clusters owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExadbVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListExadbVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListExadbVmClusters">REST API Reference for ListExadbVmClusters Operation</seealso>
        public virtual Task<ListExadbVmClustersResponse> ListExadbVmClustersAsync(ListExadbVmClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExadbVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExadbVmClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListExadbVmClustersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the Exascale storage vaults owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExascaleDbStorageVaults service method.</param>
        /// <returns>The response from the ListExascaleDbStorageVaults service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListExascaleDbStorageVaults">REST API Reference for ListExascaleDbStorageVaults Operation</seealso>
        public virtual ListExascaleDbStorageVaultsResponse ListExascaleDbStorageVaults(ListExascaleDbStorageVaultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExascaleDbStorageVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExascaleDbStorageVaultsResponseUnmarshaller.Instance;

            return Invoke<ListExascaleDbStorageVaultsResponse>(request, options);
        }
#else
        internal virtual ListExascaleDbStorageVaultsResponse ListExascaleDbStorageVaults(ListExascaleDbStorageVaultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExascaleDbStorageVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExascaleDbStorageVaultsResponseUnmarshaller.Instance;

            return Invoke<ListExascaleDbStorageVaultsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the Exascale storage vaults owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExascaleDbStorageVaults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListExascaleDbStorageVaults service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListExascaleDbStorageVaults">REST API Reference for ListExascaleDbStorageVaults Operation</seealso>
        public virtual Task<ListExascaleDbStorageVaultsResponse> ListExascaleDbStorageVaultsAsync(ListExascaleDbStorageVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExascaleDbStorageVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExascaleDbStorageVaultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExascaleDbStorageVaultsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the flex components that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlexComponents service method.</param>
        /// <returns>The response from the ListFlexComponents service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListFlexComponents">REST API Reference for ListFlexComponents Operation</seealso>
        public virtual ListFlexComponentsResponse ListFlexComponents(ListFlexComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlexComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlexComponentsResponseUnmarshaller.Instance;

            return Invoke<ListFlexComponentsResponse>(request, options);
        }
#else
        internal virtual ListFlexComponentsResponse ListFlexComponents(ListFlexComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlexComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlexComponentsResponseUnmarshaller.Instance;

            return Invoke<ListFlexComponentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the flex components that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlexComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFlexComponents service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListFlexComponents">REST API Reference for ListFlexComponents Operation</seealso>
        public virtual Task<ListFlexComponentsResponse> ListFlexComponentsAsync(ListFlexComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlexComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlexComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlexComponentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of the Oracle Grid Infrastructure (GI) minor versions for the specified
        /// major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiMinorVersions service method.</param>
        /// <returns>The response from the ListGiMinorVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiMinorVersions">REST API Reference for ListGiMinorVersions Operation</seealso>
        public virtual ListGiMinorVersionsResponse ListGiMinorVersions(ListGiMinorVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiMinorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiMinorVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiMinorVersionsResponse>(request, options);
        }
#else
        internal virtual ListGiMinorVersionsResponse ListGiMinorVersions(ListGiMinorVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiMinorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiMinorVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiMinorVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a list of the Oracle Grid Infrastructure (GI) minor versions for the specified
        /// major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiMinorVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListGiMinorVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiMinorVersions">REST API Reference for ListGiMinorVersions Operation</seealso>
        public virtual Task<ListGiMinorVersionsResponse> ListGiMinorVersionsAsync(ListGiMinorVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiMinorVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiMinorVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGiMinorVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// <returns>The response from the ListGiVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual ListGiVersionsResponse ListGiVersions(ListGiVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiVersionsResponse>(request, options);
        }
#else
        internal virtual ListGiVersionsResponse ListGiVersions(ListGiVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListGiVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual Task<ListGiVersionsResponse> ListGiVersionsAsync(ListGiVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGiVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// <returns>The response from the ListOdbNetworks service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual ListOdbNetworksResponse ListOdbNetworks(ListOdbNetworksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return Invoke<ListOdbNetworksResponse>(request, options);
        }
#else
        internal virtual ListOdbNetworksResponse ListOdbNetworks(ListOdbNetworksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return Invoke<ListOdbNetworksResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListOdbNetworks service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual Task<ListOdbNetworksResponse> ListOdbNetworksAsync(ListOdbNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOdbNetworksResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// <returns>The response from the ListOdbPeeringConnections service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual ListOdbPeeringConnectionsResponse ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListOdbPeeringConnectionsResponse>(request, options);
        }
#else
        internal virtual ListOdbPeeringConnectionsResponse ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListOdbPeeringConnectionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListOdbPeeringConnections service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual Task<ListOdbPeeringConnectionsResponse> ListOdbPeeringConnectionsAsync(ListOdbPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOdbPeeringConnectionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// <returns>The response from the ListSystemVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual ListSystemVersionsResponse ListSystemVersions(ListSystemVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSystemVersionsResponse>(request, options);
        }
#else
        internal virtual ListSystemVersionsResponse ListSystemVersions(ListSystemVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSystemVersionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSystemVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual Task<ListSystemVersionsResponse> ListSystemVersionsAsync(ListSystemVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSystemVersionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Reboots the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootAutonomousDatabase service method.</param>
        /// <returns>The response from the RebootAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootAutonomousDatabase">REST API Reference for RebootAutonomousDatabase Operation</seealso>
        public virtual RebootAutonomousDatabaseResponse RebootAutonomousDatabase(RebootAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<RebootAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual RebootAutonomousDatabaseResponse RebootAutonomousDatabase(RebootAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<RebootAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Reboots the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RebootAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootAutonomousDatabase">REST API Reference for RebootAutonomousDatabase Operation</seealso>
        public virtual Task<RebootAutonomousDatabaseResponse> RebootAutonomousDatabaseAsync(RebootAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<RebootAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// <returns>The response from the RebootDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual RebootDbNodeResponse RebootDbNode(RebootDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return Invoke<RebootDbNodeResponse>(request, options);
        }
#else
        internal virtual RebootDbNodeResponse RebootDbNode(RebootDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return Invoke<RebootDbNodeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RebootDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual Task<RebootDbNodeResponse> RebootDbNodeAsync(RebootDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDbNodeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Restores the specified Autonomous Database to a point in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAutonomousDatabase service method.</param>
        /// <returns>The response from the RestoreAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RestoreAutonomousDatabase">REST API Reference for RestoreAutonomousDatabase Operation</seealso>
        public virtual RestoreAutonomousDatabaseResponse RestoreAutonomousDatabase(RestoreAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<RestoreAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual RestoreAutonomousDatabaseResponse RestoreAutonomousDatabase(RestoreAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<RestoreAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Restores the specified Autonomous Database to a point in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RestoreAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RestoreAutonomousDatabase">REST API Reference for RestoreAutonomousDatabase Operation</seealso>
        public virtual Task<RestoreAutonomousDatabaseResponse> RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Shrinks the storage of the specified Autonomous Database to reclaim unused space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShrinkAutonomousDatabase service method.</param>
        /// <returns>The response from the ShrinkAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ShrinkAutonomousDatabase">REST API Reference for ShrinkAutonomousDatabase Operation</seealso>
        public virtual ShrinkAutonomousDatabaseResponse ShrinkAutonomousDatabase(ShrinkAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShrinkAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShrinkAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<ShrinkAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual ShrinkAutonomousDatabaseResponse ShrinkAutonomousDatabase(ShrinkAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShrinkAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShrinkAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<ShrinkAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Shrinks the storage of the specified Autonomous Database to reclaim unused space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShrinkAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ShrinkAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ShrinkAutonomousDatabase">REST API Reference for ShrinkAutonomousDatabase Operation</seealso>
        public virtual Task<ShrinkAutonomousDatabaseResponse> ShrinkAutonomousDatabaseAsync(ShrinkAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShrinkAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShrinkAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<ShrinkAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutonomousDatabase service method.</param>
        /// <returns>The response from the StartAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartAutonomousDatabase">REST API Reference for StartAutonomousDatabase Operation</seealso>
        public virtual StartAutonomousDatabaseResponse StartAutonomousDatabase(StartAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<StartAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual StartAutonomousDatabaseResponse StartAutonomousDatabase(StartAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<StartAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartAutonomousDatabase">REST API Reference for StartAutonomousDatabase Operation</seealso>
        public virtual Task<StartAutonomousDatabaseResponse> StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<StartAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// <returns>The response from the StartDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual StartDbNodeResponse StartDbNode(StartDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return Invoke<StartDbNodeResponse>(request, options);
        }
#else
        internal virtual StartDbNodeResponse StartDbNode(StartDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return Invoke<StartDbNodeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual Task<StartDbNodeResponse> StartDbNodeAsync(StartDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<StartDbNodeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stops the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutonomousDatabase service method.</param>
        /// <returns>The response from the StopAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopAutonomousDatabase">REST API Reference for StopAutonomousDatabase Operation</seealso>
        public virtual StopAutonomousDatabaseResponse StopAutonomousDatabase(StopAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<StopAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual StopAutonomousDatabaseResponse StopAutonomousDatabase(StopAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<StopAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stops the specified Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopAutonomousDatabase">REST API Reference for StopAutonomousDatabase Operation</seealso>
        public virtual Task<StopAutonomousDatabaseResponse> StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<StopAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// <returns>The response from the StopDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual StopDbNodeResponse StopDbNode(StopDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return Invoke<StopDbNodeResponse>(request, options);
        }
#else
        internal virtual StopDbNodeResponse StopDbNode(StopDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return Invoke<StopDbNodeResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual Task<StopDbNodeResponse> StopDbNodeAsync(StopDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<StopDbNodeResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Performs a switchover of the specified Autonomous Database to a standby peer database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverAutonomousDatabase service method.</param>
        /// <returns>The response from the SwitchoverAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/SwitchoverAutonomousDatabase">REST API Reference for SwitchoverAutonomousDatabase Operation</seealso>
        public virtual SwitchoverAutonomousDatabaseResponse SwitchoverAutonomousDatabase(SwitchoverAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<SwitchoverAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual SwitchoverAutonomousDatabaseResponse SwitchoverAutonomousDatabase(SwitchoverAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<SwitchoverAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Performs a switchover of the specified Autonomous Database to a standby peer database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SwitchoverAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/SwitchoverAutonomousDatabase">REST API Reference for SwitchoverAutonomousDatabase Operation</seealso>
        public virtual Task<SwitchoverAutonomousDatabaseResponse> SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<SwitchoverAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of an Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutonomousDatabase service method.</param>
        /// <returns>The response from the UpdateAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateAutonomousDatabase">REST API Reference for UpdateAutonomousDatabase Operation</seealso>
        public virtual UpdateAutonomousDatabaseResponse UpdateAutonomousDatabase(UpdateAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAutonomousDatabaseResponse>(request, options);
        }
#else
        internal virtual UpdateAutonomousDatabaseResponse UpdateAutonomousDatabase(UpdateAutonomousDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAutonomousDatabaseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the properties of an Autonomous Database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutonomousDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAutonomousDatabase service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateAutonomousDatabase">REST API Reference for UpdateAutonomousDatabase Operation</seealso>
        public virtual Task<UpdateAutonomousDatabaseResponse> UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutonomousDatabaseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of an Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutonomousDatabaseBackup service method.</param>
        /// <returns>The response from the UpdateAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateAutonomousDatabaseBackup">REST API Reference for UpdateAutonomousDatabaseBackup Operation</seealso>
        public virtual UpdateAutonomousDatabaseBackupResponse UpdateAutonomousDatabaseBackup(UpdateAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutonomousDatabaseBackupResponse>(request, options);
        }
#else
        internal virtual UpdateAutonomousDatabaseBackupResponse UpdateAutonomousDatabaseBackup(UpdateAutonomousDatabaseBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutonomousDatabaseBackupResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the properties of an Autonomous Database backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutonomousDatabaseBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAutonomousDatabaseBackup service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateAutonomousDatabaseBackup">REST API Reference for UpdateAutonomousDatabaseBackup Operation</seealso>
        public virtual Task<UpdateAutonomousDatabaseBackupResponse> UpdateAutonomousDatabaseBackupAsync(UpdateAutonomousDatabaseBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutonomousDatabaseBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutonomousDatabaseBackupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutonomousDatabaseBackupResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// <returns>The response from the UpdateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual UpdateCloudExadataInfrastructureResponse UpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudExadataInfrastructureResponse>(request, options);
        }
#else
        internal virtual UpdateCloudExadataInfrastructureResponse UpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudExadataInfrastructureResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual Task<UpdateCloudExadataInfrastructureResponse> UpdateCloudExadataInfrastructureAsync(UpdateCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExadbVmCluster service method.</param>
        /// <returns>The response from the UpdateExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExadbVmCluster">REST API Reference for UpdateExadbVmCluster Operation</seealso>
        public virtual UpdateExadbVmClusterResponse UpdateExadbVmCluster(UpdateExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateExadbVmClusterResponse>(request, options);
        }
#else
        internal virtual UpdateExadbVmClusterResponse UpdateExadbVmCluster(UpdateExadbVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExadbVmClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateExadbVmClusterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the specified Exascale VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExadbVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateExadbVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExadbVmCluster">REST API Reference for UpdateExadbVmCluster Operation</seealso>
        public virtual Task<UpdateExadbVmClusterResponse> UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExadbVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExadbVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExadbVmClusterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Configures or updates the Exascale storage on an Exadata infrastructure. After you
        /// configure Exascale storage, you can create Exascale storage vaults on the infrastructure
        /// and VM clusters that use Exascale storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExascaleCloudExadataInfrastructure service method.</param>
        /// <returns>The response from the UpdateExascaleCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExascaleCloudExadataInfrastructure">REST API Reference for UpdateExascaleCloudExadataInfrastructure Operation</seealso>
        public virtual UpdateExascaleCloudExadataInfrastructureResponse UpdateExascaleCloudExadataInfrastructure(UpdateExascaleCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateExascaleCloudExadataInfrastructureResponse>(request, options);
        }
#else
        internal virtual UpdateExascaleCloudExadataInfrastructureResponse UpdateExascaleCloudExadataInfrastructure(UpdateExascaleCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateExascaleCloudExadataInfrastructureResponse>(request, options);
        }
#endif

        /// <summary>
        /// Configures or updates the Exascale storage on an Exadata infrastructure. After you
        /// configure Exascale storage, you can create Exascale storage vaults on the infrastructure
        /// and VM clusters that use Exascale storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExascaleCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateExascaleCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExascaleCloudExadataInfrastructure">REST API Reference for UpdateExascaleCloudExadataInfrastructure Operation</seealso>
        public virtual Task<UpdateExascaleCloudExadataInfrastructureResponse> UpdateExascaleCloudExadataInfrastructureAsync(UpdateExascaleCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExascaleCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExascaleDbStorageVault service method.</param>
        /// <returns>The response from the UpdateExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExascaleDbStorageVault">REST API Reference for UpdateExascaleDbStorageVault Operation</seealso>
        public virtual UpdateExascaleDbStorageVaultResponse UpdateExascaleDbStorageVault(UpdateExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<UpdateExascaleDbStorageVaultResponse>(request, options);
        }
#else
        internal virtual UpdateExascaleDbStorageVaultResponse UpdateExascaleDbStorageVault(UpdateExascaleDbStorageVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return Invoke<UpdateExascaleDbStorageVaultResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the specified Exascale storage vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExascaleDbStorageVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateExascaleDbStorageVault service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateExascaleDbStorageVault">REST API Reference for UpdateExascaleDbStorageVault Operation</seealso>
        public virtual Task<UpdateExascaleDbStorageVaultResponse> UpdateExascaleDbStorageVaultAsync(UpdateExascaleDbStorageVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExascaleDbStorageVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExascaleDbStorageVaultResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExascaleDbStorageVaultResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// <returns>The response from the UpdateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual UpdateOdbNetworkResponse UpdateOdbNetwork(UpdateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbNetworkResponse>(request, options);
        }
#else
        internal virtual UpdateOdbNetworkResponse UpdateOdbNetwork(UpdateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbNetworkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual Task<UpdateOdbNetworkResponse> UpdateOdbNetworkAsync(UpdateOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOdbNetworkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Modifies the settings of an Oracle Database@Amazon Web Services peering connection.
        /// You can update the display name and add or remove CIDR blocks from the peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbPeeringConnection service method.</param>
        /// <returns>The response from the UpdateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbPeeringConnection">REST API Reference for UpdateOdbPeeringConnection Operation</seealso>
        public virtual UpdateOdbPeeringConnectionResponse UpdateOdbPeeringConnection(UpdateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbPeeringConnectionResponse>(request, options);
        }
#else
        internal virtual UpdateOdbPeeringConnectionResponse UpdateOdbPeeringConnection(UpdateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbPeeringConnectionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Modifies the settings of an Oracle Database@Amazon Web Services peering connection.
        /// You can update the display name and add or remove CIDR blocks from the peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbPeeringConnection">REST API Reference for UpdateOdbPeeringConnection Operation</seealso>
        public virtual Task<UpdateOdbPeeringConnectionResponse> UpdateOdbPeeringConnectionAsync(UpdateOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }
    }
}
