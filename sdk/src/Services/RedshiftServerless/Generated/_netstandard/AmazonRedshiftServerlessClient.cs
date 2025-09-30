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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RedshiftServerless.Model;
using Amazon.RedshiftServerless.Model.Internal.MarshallTransformations;
using Amazon.RedshiftServerless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RedshiftServerless
{
    /// <summary>
    /// <para>Implementation for accessing RedshiftServerless</para>
    ///
    /// This is an interface reference for Amazon Redshift Serverless. It contains documentation
    /// for one of the programming or command line interfaces you can use to manage Amazon
    /// Redshift Serverless. 
    /// 
    ///  
    /// <para>
    /// Amazon Redshift Serverless automatically provisions data warehouse capacity and intelligently
    /// scales the underlying resources based on workload demands. Amazon Redshift Serverless
    /// adjusts capacity in seconds to deliver consistently high performance and simplified
    /// operations for even the most demanding and volatile workloads. Amazon Redshift Serverless
    /// lets you focus on using your data to acquire new insights for your business and customers.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  To learn more about Amazon Redshift Serverless, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-whatis.html">What
    /// is Amazon Redshift Serverless?</a>.
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftServerlessClient : AmazonServiceClient, IAmazonRedshiftServerless
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftServerlessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        public AmazonRedshiftServerlessClient()
            : base(new AmazonRedshiftServerlessConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        public AmazonRedshiftServerlessClient(RegionEndpoint region)
            : base(new AmazonRedshiftServerlessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AmazonRedshiftServerlessConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials and an
        /// AmazonRedshiftServerlessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, AmazonRedshiftServerlessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRedshiftServerlessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftServerlessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftServerlessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftServerlessEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftServerlessAuthSchemeHandler());
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


        #region  ConvertRecoveryPointToSnapshot

        internal virtual ConvertRecoveryPointToSnapshotResponse ConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return Invoke<ConvertRecoveryPointToSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Converts a recovery point to a snapshot. For more information about recovery points
        /// and snapshots, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery-points.html">Working
        /// with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConvertRecoveryPointToSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        public virtual Task<ConvertRecoveryPointToSnapshotResponse> ConvertRecoveryPointToSnapshotAsync(ConvertRecoveryPointToSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ConvertRecoveryPointToSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCustomDomainAssociation

        internal virtual CreateCustomDomainAssociationResponse CreateCustomDomainAssociation(CreateCustomDomainAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom domain association for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateCustomDomainAssociation">REST API Reference for CreateCustomDomainAssociation Operation</seealso>
        public virtual Task<CreateCustomDomainAssociationResponse> CreateCustomDomainAssociationAsync(CreateCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEndpointAccess

        internal virtual CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual Task<CreateEndpointAccessResponse> CreateEndpointAccessAsync(CreateEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateNamespace

        internal virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateReservation

        internal virtual CreateReservationResponse CreateReservation(CreateReservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservationResponseUnmarshaller.Instance;

            return Invoke<CreateReservationResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift Serverless reservation, which gives you the option to commit
        /// to a specified number of Redshift Processing Units (RPUs) for a year at a discount
        /// from Serverless on-demand (OD) rates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReservation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateReservation">REST API Reference for CreateReservation Operation</seealso>
        public virtual Task<CreateReservationResponse> CreateReservationAsync(CreateReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScheduledAction

        internal virtual CreateScheduledActionResponse CreateScheduledAction(CreateScheduledActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <c>CreateSnapshot</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual Task<CreateScheduledActionResponse> CreateScheduledActionAsync(CreateScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of all databases in a namespace. For more information about snapshots,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery-points.html">
        /// Working with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshotCopyConfiguration

        internal virtual CreateSnapshotCopyConfigurationResponse CreateSnapshotCopyConfiguration(CreateSnapshotCopyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot copy configuration that lets you copy snapshots to another Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshotCopyConfiguration">REST API Reference for CreateSnapshotCopyConfiguration Operation</seealso>
        public virtual Task<CreateSnapshotCopyConfigurationResponse> CreateSnapshotCopyConfigurationAsync(CreateSnapshotCopyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotCopyConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUsageLimit

        internal virtual CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<CreateUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift Serverless usage type. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual Task<CreateUsageLimitResponse> CreateUsageLimitAsync(CreateUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkgroup

        internal virtual CreateWorkgroupResponse CreateWorkgroup(CreateWorkgroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<CreateWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an workgroup in Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a workgroup is in an account with VPC
        /// BPA turned on, the following capabilities are blocked: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public access workgroup
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private workgroup to public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the workgroup when the workgroup is public
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        public virtual Task<CreateWorkgroupResponse> CreateWorkgroupAsync(CreateWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkgroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCustomDomainAssociation

        internal virtual DeleteCustomDomainAssociationResponse DeleteCustomDomainAssociation(DeleteCustomDomainAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom domain association for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteCustomDomainAssociation">REST API Reference for DeleteCustomDomainAssociation Operation</seealso>
        public virtual Task<DeleteCustomDomainAssociationResponse> DeleteCustomDomainAssociationAsync(DeleteCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEndpointAccess

        internal virtual DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual Task<DeleteEndpointAccessResponse> DeleteEndpointAccessAsync(DeleteEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNamespace

        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a namespace from Amazon Redshift Serverless. Before you delete the namespace,
        /// you can create a final snapshot that has all of the data within the namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScheduledAction

        internal virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshotCopyConfiguration

        internal virtual DeleteSnapshotCopyConfigurationResponse DeleteSnapshotCopyConfiguration(DeleteSnapshotCopyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot copy configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshotCopyConfiguration">REST API Reference for DeleteSnapshotCopyConfiguration Operation</seealso>
        public virtual Task<DeleteSnapshotCopyConfigurationResponse> DeleteSnapshotCopyConfigurationAsync(DeleteSnapshotCopyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotCopyConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUsageLimit

        internal virtual DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Deletes a usage limit from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual Task<DeleteUsageLimitResponse> DeleteUsageLimitAsync(DeleteUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkgroup

        internal virtual DeleteWorkgroupResponse DeleteWorkgroup(DeleteWorkgroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        public virtual Task<DeleteWorkgroupResponse> DeleteWorkgroupAsync(DeleteWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkgroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCredentials

        internal virtual GetCredentialsResponse GetCredentials(GetCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// By default, the temporary credentials expire in 900 seconds. You can optionally specify
        /// a duration between 900 seconds (15 minutes) and 3600 seconds (60 minutes).
        /// </para>
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) user or role that runs GetCredentials must
        /// have an IAM policy attached that allows access to all necessary actions and resources.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DbName</c> parameter is specified, the IAM policy must allow access to the
        /// resource dbname for the specified database name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentials service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        public virtual Task<GetCredentialsResponse> GetCredentialsAsync(GetCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCustomDomainAssociation

        internal virtual GetCustomDomainAssociationResponse GetCustomDomainAssociation(GetCustomDomainAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific custom domain association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCustomDomainAssociation">REST API Reference for GetCustomDomainAssociation Operation</seealso>
        public virtual Task<GetCustomDomainAssociationResponse> GetCustomDomainAssociationAsync(GetCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEndpointAccess

        internal virtual GetEndpointAccessResponse GetEndpointAccess(GetEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<GetEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Returns information, such as the name, about a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        public virtual Task<GetEndpointAccessResponse> GetEndpointAccessAsync(GetEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNamespace

        internal virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecoveryPoint

        internal virtual GetRecoveryPointResponse GetRecoveryPoint(GetRecoveryPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        public virtual Task<GetRecoveryPointResponse> GetRecoveryPointAsync(GetRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecoveryPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservation

        internal virtual GetReservationResponse GetReservation(GetReservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationResponseUnmarshaller.Instance;

            return Invoke<GetReservationResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon Redshift Serverless reservation. A reservation gives you the option
        /// to commit to a specified number of Redshift Processing Units (RPUs) for a year at
        /// a discount from Serverless on-demand (OD) rates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetReservation">REST API Reference for GetReservation Operation</seealso>
        public virtual Task<GetReservationResponse> GetReservationAsync(GetReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservationOffering

        internal virtual GetReservationOfferingResponse GetReservationOffering(GetReservationOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReservationOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationOfferingResponseUnmarshaller.Instance;

            return Invoke<GetReservationOfferingResponse>(request, options);
        }



        /// <summary>
        /// Returns the reservation offering. The offering determines the payment schedule for
        /// the reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationOffering service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetReservationOffering">REST API Reference for GetReservationOffering Operation</seealso>
        public virtual Task<GetReservationOfferingResponse> GetReservationOfferingAsync(GetReservationOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReservationOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationOfferingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetScheduledAction

        internal virtual GetScheduledActionResponse GetScheduledAction(GetScheduledActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledActionResponseUnmarshaller.Instance;

            return Invoke<GetScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetScheduledAction">REST API Reference for GetScheduledAction Operation</seealso>
        public virtual Task<GetScheduledActionResponse> GetScheduledActionAsync(GetScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<GetScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSnapshot

        internal virtual GetSnapshotResponse GetSnapshot(GetSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual Task<GetSnapshotResponse> GetSnapshotAsync(GetSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTableRestoreStatus

        internal virtual GetTableRestoreStatusResponse GetTableRestoreStatus(GetTableRestoreStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<GetTableRestoreStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a <c>TableRestoreStatus</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableRestoreStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        public virtual Task<GetTableRestoreStatusResponse> GetTableRestoreStatusAsync(GetTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableRestoreStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableRestoreStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrack

        internal virtual GetTrackResponse GetTrack(GetTrackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrackResponseUnmarshaller.Instance;

            return Invoke<GetTrackResponse>(request, options);
        }



        /// <summary>
        /// Get the Redshift Serverless version for a specified track.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrack service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTrack">REST API Reference for GetTrack Operation</seealso>
        public virtual Task<GetTrackResponse> GetTrackAsync(GetTrackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrackResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUsageLimit

        internal virtual GetUsageLimitResponse GetUsageLimit(GetUsageLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return Invoke<GetUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        public virtual Task<GetUsageLimitResponse> GetUsageLimitAsync(GetUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkgroup

        internal virtual GetWorkgroupResponse GetWorkgroup(GetWorkgroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return Invoke<GetWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        public virtual Task<GetWorkgroupResponse> GetWorkgroupAsync(GetWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkgroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCustomDomainAssociations

        internal virtual ListCustomDomainAssociationsResponse ListCustomDomainAssociations(ListCustomDomainAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCustomDomainAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists custom domain associations for Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomDomainAssociations service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListCustomDomainAssociations">REST API Reference for ListCustomDomainAssociations Operation</seealso>
        public virtual Task<ListCustomDomainAssociationsResponse> ListCustomDomainAssociationsAsync(ListCustomDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDomainAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomDomainAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEndpointAccess

        internal virtual ListEndpointAccessResponse ListEndpointAccess(ListEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ListEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <c>EndpointAccess</c> objects and relevant information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        public virtual Task<ListEndpointAccessResponse> ListEndpointAccessAsync(ListEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListManagedWorkgroups

        internal virtual ListManagedWorkgroupsResponse ListManagedWorkgroups(ListManagedWorkgroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedWorkgroupsResponseUnmarshaller.Instance;

            return Invoke<ListManagedWorkgroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of specified managed workgroups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedWorkgroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListManagedWorkgroups">REST API Reference for ListManagedWorkgroups Operation</seealso>
        public virtual Task<ListManagedWorkgroupsResponse> ListManagedWorkgroupsAsync(ListManagedWorkgroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedWorkgroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedWorkgroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNamespaces

        internal virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecoveryPoints

        internal virtual ListRecoveryPointsResponse ListRecoveryPoints(ListRecoveryPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of recovery points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryPoints service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        public virtual Task<ListRecoveryPointsResponse> ListRecoveryPointsAsync(ListRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecoveryPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReservationOfferings

        internal virtual ListReservationOfferingsResponse ListReservationOfferings(ListReservationOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListReservationOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Returns the current reservation offerings in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservationOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReservationOfferings service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListReservationOfferings">REST API Reference for ListReservationOfferings Operation</seealso>
        public virtual Task<ListReservationOfferingsResponse> ListReservationOfferingsAsync(ListReservationOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReservationOfferingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReservations

        internal virtual ListReservationsResponse ListReservations(ListReservationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return Invoke<ListReservationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Reservation objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual Task<ListReservationsResponse> ListReservationsAsync(ListReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReservationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListScheduledActions

        internal virtual ListScheduledActionsResponse ListScheduledActions(ListScheduledActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledActionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of scheduled actions. You can use the flags to filter the list of returned
        /// scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledActions service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        public virtual Task<ListScheduledActionsResponse> ListScheduledActionsAsync(ListScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScheduledActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSnapshotCopyConfigurations

        internal virtual ListSnapshotCopyConfigurationsResponse ListSnapshotCopyConfigurations(ListSnapshotCopyConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotCopyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotCopyConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotCopyConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of snapshot copy configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotCopyConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshotCopyConfigurations service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshotCopyConfigurations">REST API Reference for ListSnapshotCopyConfigurations Operation</seealso>
        public virtual Task<ListSnapshotCopyConfigurationsResponse> ListSnapshotCopyConfigurationsAsync(ListSnapshotCopyConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotCopyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotCopyConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSnapshotCopyConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSnapshots

        internal virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTableRestoreStatus

        internal virtual ListTableRestoreStatusResponse ListTableRestoreStatus(ListTableRestoreStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<ListTableRestoreStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an array of <c>TableRestoreStatus</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableRestoreStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        public virtual Task<ListTableRestoreStatusResponse> ListTableRestoreStatusAsync(ListTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRestoreStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListTableRestoreStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTracks

        internal virtual ListTracksResponse ListTracks(ListTracksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTracksResponseUnmarshaller.Instance;

            return Invoke<ListTracksResponse>(request, options);
        }



        /// <summary>
        /// List the Amazon Redshift Serverless versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTracks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTracks service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTracks">REST API Reference for ListTracks Operation</seealso>
        public virtual Task<ListTracksResponse> ListTracksAsync(ListTracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTracksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTracksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUsageLimits

        internal virtual ListUsageLimitsResponse ListUsageLimits(ListUsageLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return Invoke<ListUsageLimitsResponse>(request, options);
        }



        /// <summary>
        /// Lists all usage limits within Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageLimits service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        public virtual Task<ListUsageLimitsResponse> ListUsageLimitsAsync(ListUsageLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsageLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkgroups

        internal virtual ListWorkgroupsResponse ListWorkgroups(ListWorkgroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return Invoke<ListWorkgroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of specified workgroups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        public virtual Task<ListWorkgroupsResponse> ListWorkgroupsAsync(ListWorkgroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkgroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a resource policy. Currently, you can use policies to share snapshots
        /// across Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreFromRecoveryPoint

        internal virtual RestoreFromRecoveryPointResponse RestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RestoreFromRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Restore the data from a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        public virtual Task<RestoreFromRecoveryPointResponse> RestoreFromRecoveryPointAsync(RestoreFromRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromRecoveryPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreFromSnapshot

        internal virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Restores a namespace from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreTableFromRecoveryPoint

        internal virtual RestoreTableFromRecoveryPointResponse RestoreTableFromRecoveryPoint(RestoreTableFromRecoveryPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Restores a table from a recovery point to your Amazon Redshift Serverless instance.
        /// You can't use this operation to restore tables with interleaved sort keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromRecoveryPoint">REST API Reference for RestoreTableFromRecoveryPoint Operation</seealso>
        public virtual Task<RestoreTableFromRecoveryPointResponse> RestoreTableFromRecoveryPointAsync(RestoreTableFromRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableFromRecoveryPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreTableFromSnapshot

        internal virtual RestoreTableFromSnapshotResponse RestoreTableFromSnapshot(RestoreTableFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Restores a table from a snapshot to your Amazon Redshift Serverless instance. You
        /// can't use this operation to restore tables with <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_Sorting_data.html#t_Sorting_data-interleaved">interleaved
        /// sort keys</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        public virtual Task<RestoreTableFromSnapshotResponse> RestoreTableFromSnapshotAsync(RestoreTableFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableFromSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag or set of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCustomDomainAssociation

        internal virtual UpdateCustomDomainAssociationResponse UpdateCustomDomainAssociation(UpdateCustomDomainAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Redshift Serverless certificate associated with a custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomDomainAssociation service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateCustomDomainAssociation">REST API Reference for UpdateCustomDomainAssociation Operation</seealso>
        public virtual Task<UpdateCustomDomainAssociationResponse> UpdateCustomDomainAssociationAsync(UpdateCustomDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEndpointAccess

        internal virtual UpdateEndpointAccessResponse UpdateEndpointAccess(UpdateEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Redshift Serverless managed endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        public virtual Task<UpdateEndpointAccessResponse> UpdateEndpointAccessAsync(UpdateEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateNamespace

        internal virtual UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Updates a namespace with the specified settings. Unless required, you can't update
        /// multiple parameters in one request. For example, you must specify both <c>adminUsername</c>
        /// and <c>adminUserPassword</c> to update either field, but you can't update both <c>kmsKeyId</c>
        /// and <c>logExports</c> in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        public virtual Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateScheduledAction

        internal virtual UpdateScheduledActionResponse UpdateScheduledAction(UpdateScheduledActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Updates a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledAction service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        public virtual Task<UpdateScheduledActionResponse> UpdateScheduledActionAsync(UpdateScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScheduledActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSnapshot

        internal virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Updates a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSnapshotCopyConfiguration

        internal virtual UpdateSnapshotCopyConfigurationResponse UpdateSnapshotCopyConfiguration(UpdateSnapshotCopyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotCopyConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates a snapshot copy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotCopyConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshotCopyConfiguration service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshotCopyConfiguration">REST API Reference for UpdateSnapshotCopyConfiguration Operation</seealso>
        public virtual Task<UpdateSnapshotCopyConfigurationResponse> UpdateSnapshotCopyConfigurationAsync(UpdateSnapshotCopyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotCopyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotCopyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotCopyConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUsageLimit

        internal virtual UpdateUsageLimitResponse UpdateUsageLimit(UpdateUsageLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Update a usage limit in Amazon Redshift Serverless. You can't update the usage type
        /// or period of a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        public virtual Task<UpdateUsageLimitResponse> UpdateUsageLimitAsync(UpdateUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUsageLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkgroup

        internal virtual UpdateWorkgroupResponse UpdateWorkgroup(UpdateWorkgroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a workgroup with the specified configuration settings. You can't update multiple
        /// parameters in one request. For example, you can update <c>baseCapacity</c> or <c>port</c>
        /// in a single request, but you can't update both in the same request.
        /// 
        ///  
        /// <para>
        /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
        /// you own in a Region from reaching or being reached from the internet through internet
        /// gateways and egress-only internet gateways. If a workgroup is in an account with VPC
        /// BPA turned on, the following capabilities are blocked: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating a public access workgroup
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying a private workgroup to public
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding a subnet with VPC BPA turned on to the workgroup when the workgroup is public
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
        /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.Ipv6CidrBlockNotFoundException">
        /// There are no subnets in your VPC with associated IPv6 CIDR blocks. To use dual-stack
        /// mode, associate an IPv6 CIDR block with each subnet in your VPC.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        public virtual Task<UpdateWorkgroupResponse> UpdateWorkgroupAsync(UpdateWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkgroupResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}