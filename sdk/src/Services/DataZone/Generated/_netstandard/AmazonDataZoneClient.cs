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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataZone.Model;
using Amazon.DataZone.Model.Internal.MarshallTransformations;
using Amazon.DataZone.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DataZone
{
    /// <summary>
    /// <para>Implementation for accessing DataZone</para>
    ///
    /// Amazon DataZone is a data management service that enables you to catalog, discover,
    /// govern, share, and analyze your data. With Amazon DataZone, you can share and access
    /// your data across accounts and supported regions. Amazon DataZone simplifies your experience
    /// across Amazon Web Services services, including, but not limited to, Amazon Redshift,
    /// Amazon Athena, Amazon Web Services Glue, and Amazon Web Services Lake Formation.
    /// </summary>
    public partial class AmazonDataZoneClient : AmazonServiceClient, IAmazonDataZone
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataZoneMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient()
            : base(new AmazonDataZoneConfig()) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient(RegionEndpoint region)
            : base(new AmazonDataZoneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AmazonDataZoneConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataZoneClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials and an
        /// AmazonDataZoneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AWSCredentials credentials, AmazonDataZoneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataZoneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataZoneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDataZonePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataZonePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataZonePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataZoneEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataZoneAuthSchemeHandler());
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


        #region  AcceptPredictions

        internal virtual AcceptPredictionsResponse AcceptPredictions(AcceptPredictionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;

            return Invoke<AcceptPredictionsResponse>(request, options);
        }



        /// <summary>
        /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual Task<AcceptPredictionsResponse> AcceptPredictionsAsync(AcceptPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptPredictionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AcceptSubscriptionRequest

        internal virtual AcceptSubscriptionRequestResponse AcceptSubscriptionRequest(AcceptSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptSubscriptionRequestResponse>(request, options);
        }



        /// <summary>
        /// Accepts a subscription request to a specific asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual Task<AcceptSubscriptionRequestResponse> AcceptSubscriptionRequestAsync(AcceptSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptSubscriptionRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddEntityOwner

        internal virtual AddEntityOwnerResponse AddEntityOwner(AddEntityOwnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddEntityOwnerResponseUnmarshaller.Instance;

            return Invoke<AddEntityOwnerResponse>(request, options);
        }



        /// <summary>
        /// Adds the owner of an entity (a domain unit).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddEntityOwner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddEntityOwner service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddEntityOwner">REST API Reference for AddEntityOwner Operation</seealso>
        public virtual Task<AddEntityOwnerResponse> AddEntityOwnerAsync(AddEntityOwnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddEntityOwnerResponseUnmarshaller.Instance;

            return InvokeAsync<AddEntityOwnerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddPolicyGrant

        internal virtual AddPolicyGrantResponse AddPolicyGrant(AddPolicyGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyGrantResponseUnmarshaller.Instance;

            return Invoke<AddPolicyGrantResponse>(request, options);
        }



        /// <summary>
        /// Adds a policy grant (an authorization policy) to a specified entity, including domain
        /// units, environment blueprint configurations, or environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPolicyGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddPolicyGrant">REST API Reference for AddPolicyGrant Operation</seealso>
        public virtual Task<AddPolicyGrantResponse> AddPolicyGrantAsync(AddPolicyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<AddPolicyGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateEnvironmentRole

        internal virtual AssociateEnvironmentRoleResponse AssociateEnvironmentRole(AssociateEnvironmentRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateEnvironmentRoleResponse>(request, options);
        }



        /// <summary>
        /// Associates the environment role in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnvironmentRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEnvironmentRole service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateEnvironmentRole">REST API Reference for AssociateEnvironmentRole Operation</seealso>
        public virtual Task<AssociateEnvironmentRoleResponse> AssociateEnvironmentRoleAsync(AssociateEnvironmentRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentRoleResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateEnvironmentRoleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateGovernedTerms

        internal virtual AssociateGovernedTermsResponse AssociateGovernedTerms(AssociateGovernedTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGovernedTermsResponseUnmarshaller.Instance;

            return Invoke<AssociateGovernedTermsResponse>(request, options);
        }



        /// <summary>
        /// Associates governed terms with an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateGovernedTerms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateGovernedTerms service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateGovernedTerms">REST API Reference for AssociateGovernedTerms Operation</seealso>
        public virtual Task<AssociateGovernedTermsResponse> AssociateGovernedTermsAsync(AssociateGovernedTermsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGovernedTermsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateGovernedTermsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelMetadataGenerationRun

        internal virtual CancelMetadataGenerationRunResponse CancelMetadataGenerationRun(CancelMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<CancelMetadataGenerationRunResponse>(request, options);
        }



        /// <summary>
        /// Cancels the metadata generation run.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The run must exist and be in a cancelable status (e.g., SUBMITTED, IN_PROGRESS). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Runs in SUCCEEDED status cannot be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have access to the run and cancel permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMetadataGenerationRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelMetadataGenerationRun">REST API Reference for CancelMetadataGenerationRun Operation</seealso>
        public virtual Task<CancelMetadataGenerationRunResponse> CancelMetadataGenerationRunAsync(CancelMetadataGenerationRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMetadataGenerationRunResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMetadataGenerationRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelSubscription

        internal virtual CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Cancels the subscription to the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAccountPool

        internal virtual CreateAccountPoolResponse CreateAccountPool(CreateAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountPoolResponseUnmarshaller.Instance;

            return Invoke<CreateAccountPoolResponse>(request, options);
        }



        /// <summary>
        /// Creates an account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAccountPool">REST API Reference for CreateAccountPool Operation</seealso>
        public virtual Task<CreateAccountPoolResponse> CreateAccountPoolAsync(CreateAccountPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAsset

        internal virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }



        /// <summary>
        /// Creates an asset in Amazon DataZone catalog.
        /// 
        ///  
        /// <para>
        /// Before creating assets, make sure that the following requirements are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>--domain-identifier</c> must refer to an existing domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>--owning-project-identifier</c> must be a valid project within the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset type must be created beforehand using <c>create-asset-type</c>, or be a supported
        /// system-defined type. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/datazone/create-asset-type.html">create-asset-type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>--type-revision</c> (if used) must match a valid revision of the asset type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>formsInput</c> is required when it is associated as required in the <c>asset-type</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/datazone/create-form-type.html">create-form-type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Form content must include all required fields as per the form schema (e.g., <c>bucketArn</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must invoke the following pre-requisite commands before invoking this API:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateAssetType.html">CreateAssetType</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssetFilter

        internal virtual CreateAssetFilterResponse CreateAssetFilter(CreateAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetFilterResponseUnmarshaller.Instance;

            return Invoke<CreateAssetFilterResponse>(request, options);
        }



        /// <summary>
        /// Creates a data asset filter.
        /// 
        ///  
        /// <para>
        /// Asset filters provide a sophisticated way to create controlled views of data assets
        /// by selecting specific columns or applying row-level filters. This capability is crucial
        /// for organizations that need to share data while maintaining security and privacy controls.
        /// For example, your database might be filtered to show only non-PII fields to certain
        /// users, or sales data might be filtered by region for different regional teams. Asset
        /// filters enable fine-grained access control while maintaining a single source of truth.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A valid domain (<c>--domain-identifier</c>) must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A data asset (<c>--asset-identifier</c>) must already be created under that domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must have the referenced columns available in its schema for column-based
        /// filtering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot specify both (<c>columnConfiguration</c>, <c>rowConfiguration</c>)at the
        /// same time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetFilter">REST API Reference for CreateAssetFilter Operation</seealso>
        public virtual Task<CreateAssetFilterResponse> CreateAssetFilterAsync(CreateAssetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssetRevision

        internal virtual CreateAssetRevisionResponse CreateAssetRevision(CreateAssetRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateAssetRevisionResponse>(request, options);
        }



        /// <summary>
        /// Creates a revision of the asset.
        /// 
        ///  
        /// <para>
        /// Asset revisions represent new versions of existing assets, capturing changes to either
        /// the underlying data or its metadata. They maintain a historical record of how assets
        /// evolve over time, who made changes, and when those changes occurred. This versioning
        /// capability is crucial for governance and compliance, allowing organizations to track
        /// changes, understand their impact, and roll back if necessary.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asset must already exist in the domain with identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>formsInput</c> is required when asset has the form type. <c>typeRevision</c> should
        /// be the latest version of form type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form content must include all required fields (e.g., <c>bucketArn</c> for <c>S3ObjectCollectionForm</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project of the original asset must still exist and be active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have write access to the project and domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual Task<CreateAssetRevisionResponse> CreateAssetRevisionAsync(CreateAssetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetRevisionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssetType

        internal virtual CreateAssetTypeResponse CreateAssetType(CreateAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;

            return Invoke<CreateAssetTypeResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom asset type.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>formsInput</c> field is required, however, can be passed as empty (e.g. <c>-forms-input
        /// {})</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have <c>CreateAssetType</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain-identifier and owning-project-identifier must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the asset type must be unique within the domain — duplicate names will
        /// cause failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JSON input must be valid — incorrect formatting causes Invalid JSON errors.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual Task<CreateAssetTypeResponse> CreateAssetTypeAsync(CreateAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnection

        internal virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new connection. In Amazon DataZone, a connection enables you to connect
        /// your resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataProduct

        internal virtual CreateDataProductResponse CreateDataProduct(CreateDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductResponseUnmarshaller.Instance;

            return Invoke<CreateDataProductResponse>(request, options);
        }



        /// <summary>
        /// Creates a data product.
        /// 
        ///  
        /// <para>
        /// A data product is a comprehensive package that combines data assets with their associated
        /// metadata, documentation, and access controls. It's designed to serve specific business
        /// needs or use cases, making it easier for users to find and consume data appropriately.
        /// Data products include important information about data quality, freshness, and usage
        /// guidelines, effectively bridging the gap between data producers and consumers while
        /// ensuring proper governance.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain must exist and be accessible. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must be unique within the domain (no existing data product with the same
        /// name).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have create permissions for data products in the project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProduct">REST API Reference for CreateDataProduct Operation</seealso>
        public virtual Task<CreateDataProductResponse> CreateDataProductAsync(CreateDataProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataProductRevision

        internal virtual CreateDataProductRevisionResponse CreateDataProductRevision(CreateDataProductRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateDataProductRevisionResponse>(request, options);
        }



        /// <summary>
        /// Creates a data product revision.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The original data product must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The new revision name must comply with naming constraints (if required).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProductRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataProductRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProductRevision">REST API Reference for CreateDataProductRevision Operation</seealso>
        public virtual Task<CreateDataProductRevisionResponse> CreateDataProductRevisionAsync(CreateDataProductRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataProductRevisionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomainUnit

        internal virtual CreateDomainUnitResponse CreateDomainUnit(CreateDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainUnitResponseUnmarshaller.Instance;

            return Invoke<CreateDomainUnitResponse>(request, options);
        }



        /// <summary>
        /// Creates a domain unit in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomainUnit">REST API Reference for CreateDomainUnit Operation</seealso>
        public virtual Task<CreateDomainUnitResponse> CreateDomainUnitAsync(CreateDomainUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainUnitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainUnitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Create an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnvironmentAction

        internal virtual CreateEnvironmentActionResponse CreateEnvironmentAction(CreateEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentActionResponse>(request, options);
        }



        /// <summary>
        /// Creates an action for the environment, for example, creates a console link for an
        /// analytics tool that is available in this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentAction">REST API Reference for CreateEnvironmentAction Operation</seealso>
        public virtual Task<CreateEnvironmentActionResponse> CreateEnvironmentActionAsync(CreateEnvironmentActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentActionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnvironmentBlueprint

        internal virtual CreateEnvironmentBlueprintResponse CreateEnvironmentBlueprint(CreateEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Creates a Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentBlueprint">REST API Reference for CreateEnvironmentBlueprint Operation</seealso>
        public virtual Task<CreateEnvironmentBlueprintResponse> CreateEnvironmentBlueprintAsync(CreateEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentBlueprintResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnvironmentProfile

        internal virtual CreateEnvironmentProfileResponse CreateEnvironmentProfile(CreateEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon DataZone environment profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual Task<CreateEnvironmentProfileResponse> CreateEnvironmentProfileAsync(CreateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFormType

        internal virtual CreateFormTypeResponse CreateFormType(CreateFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;

            return Invoke<CreateFormTypeResponse>(request, options);
        }



        /// <summary>
        /// Creates a metadata form type.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain must exist and be in an <c>ENABLED</c> state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project must exist and be accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must be unique within the domain.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For custom form types, to indicate that a field should be searchable, annotate it
        /// with <c>@amazon.datazone#searchable</c>. By default, searchable fields are indexed
        /// for semantic search, where related query terms will match the attribute value even
        /// if they are not stemmed or keyword matches. To indicate that a field should be indexed
        /// for lexical search (which disables semantic search but supports stemmed and partial
        /// matches), annotate it with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
        /// To indicate that a field should be indexed for technical identifier search (for more
        /// information on technical identifier search, see: <a href="https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/">https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/</a>),
        /// annotate it with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
        /// </para>
        ///  
        /// <para>
        /// To denote that a field will store glossary term ids (which are filterable via the
        /// Search/SearchListings APIs), annotate it with <c>@amazon.datazone#glossaryterm("${GLOSSARY_ID}")</c>,
        /// where <c>${GLOSSARY_ID}</c> is the id of the glossary that the glossary terms stored
        /// in the field belong to. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual Task<CreateFormTypeResponse> CreateFormTypeAsync(CreateFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFormTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGlossary

        internal virtual CreateGlossaryResponse CreateGlossary(CreateGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon DataZone business glossary.
        /// 
        ///  
        /// <para>
        /// Specifies that this is a create glossary policy.
        /// </para>
        ///  
        /// <para>
        /// A glossary serves as the central repository for business terminology and definitions
        /// within an organization. It helps establish and maintain a common language across different
        /// departments and teams, reducing miscommunication and ensuring consistent interpretation
        /// of business concepts. Glossaries can include hierarchical relationships between terms,
        /// cross-references, and links to actual data assets, making them invaluable for both
        /// business users and technical teams trying to understand and use data correctly.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain must exist and be in an active state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owning project must exist and be accessible by the caller.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary name must be unique within the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual Task<CreateGlossaryResponse> CreateGlossaryAsync(CreateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlossaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGlossaryTerm

        internal virtual CreateGlossaryTermResponse CreateGlossaryTerm(CreateGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryTermResponse>(request, options);
        }



        /// <summary>
        /// Creates a business glossary term.
        /// 
        ///  
        /// <para>
        /// A glossary term represents an individual entry within the Amazon DataZone glossary,
        /// serving as a standardized definition for a specific business concept or data element.
        /// Each term can include rich metadata such as detailed definitions, synonyms, related
        /// terms, and usage examples. Glossary terms can be linked directly to data assets, providing
        /// business context to technical data elements. This linking capability helps users understand
        /// the business meaning of data fields and ensures consistent interpretation across different
        /// systems and teams. Terms can also have relationships with other terms, creating a
        /// semantic network that reflects the complexity of business concepts.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Glossary must exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term name must be unique within the glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure term does not conflict with existing terms in hierarchy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual Task<CreateGlossaryTermResponse> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlossaryTermResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroupProfile

        internal virtual CreateGroupProfileResponse CreateGroupProfile(CreateGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<CreateGroupProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual Task<CreateGroupProfileResponse> CreateGroupProfileAsync(CreateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateListingChangeSet

        internal virtual CreateListingChangeSetResponse CreateListingChangeSet(CreateListingChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateListingChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Publishes a listing (a record of an asset at a given time) or removes a listing from
        /// the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListingChangeSet service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual Task<CreateListingChangeSetResponse> CreateListingChangeSetAsync(CreateListingChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateListingChangeSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon DataZone project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProjectMembership

        internal virtual CreateProjectMembershipResponse CreateProjectMembership(CreateProjectMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateProjectMembershipResponse>(request, options);
        }



        /// <summary>
        /// Creates a project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual Task<CreateProjectMembershipResponse> CreateProjectMembershipAsync(CreateProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProjectProfile

        internal virtual CreateProjectProfileResponse CreateProjectProfile(CreateProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProjectProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectProfile">REST API Reference for CreateProjectProfile Operation</seealso>
        public virtual Task<CreateProjectProfileResponse> CreateProjectProfileAsync(CreateProjectProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRule

        internal virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a rule in Amazon DataZone. A rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriptionGrant

        internal virtual CreateSubscriptionGrantResponse CreateSubscriptionGrant(CreateSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionGrantResponse>(request, options);
        }



        /// <summary>
        /// Creates a subsscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual Task<CreateSubscriptionGrantResponse> CreateSubscriptionGrantAsync(CreateSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriptionRequest

        internal virtual CreateSubscriptionRequestResponse CreateSubscriptionRequest(CreateSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionRequestResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual Task<CreateSubscriptionRequestResponse> CreateSubscriptionRequestAsync(CreateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriptionTarget

        internal virtual CreateSubscriptionTargetResponse CreateSubscriptionTarget(CreateSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionTargetResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual Task<CreateSubscriptionTargetResponse> CreateSubscriptionTargetAsync(CreateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUserProfile

        internal virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccountPool

        internal virtual DeleteAccountPoolResponse DeleteAccountPool(DeleteAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPoolResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAccountPool">REST API Reference for DeleteAccountPool Operation</seealso>
        public virtual Task<DeleteAccountPoolResponse> DeleteAccountPoolAsync(DeleteAccountPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAsset

        internal virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }



        /// <summary>
        /// Deletes an asset in Amazon DataZone.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// --domain-identifier must refer to a valid and existing domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --identifier must refer to an existing asset in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must not be referenced in any existing asset filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must not be linked to any draft or published data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have delete permissions for the domain and project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssetFilter

        internal virtual DeleteAssetFilterResponse DeleteAssetFilter(DeleteAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetFilterResponse>(request, options);
        }



        /// <summary>
        /// Deletes an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset filter must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain and asset must not have been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure the --identifier refers to a valid filter ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetFilter">REST API Reference for DeleteAssetFilter Operation</seealso>
        public virtual Task<DeleteAssetFilterResponse> DeleteAssetFilterAsync(DeleteAssetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssetType

        internal virtual DeleteAssetTypeResponse DeleteAssetType(DeleteAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetTypeResponse>(request, options);
        }



        /// <summary>
        /// Deletes an asset type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset type must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have DeleteAssetType permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset type must not be in use (e.g., assigned to any asset). If used, deletion
        /// will fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You should retrieve the asset type using get-asset-type to confirm its presence before
        /// deletion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual Task<DeleteAssetTypeResponse> DeleteAssetTypeAsync(DeleteAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConnection

        internal virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes and connection. In Amazon DataZone, a connection enables you to connect your
        /// resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataProduct

        internal virtual DeleteDataProductResponse DeleteDataProduct(DeleteDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProductResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProductResponse>(request, options);
        }



        /// <summary>
        /// Deletes a data product in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product must exist and not be deleted or archived. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have delete permissions for the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain and project must be active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataProduct">REST API Reference for DeleteDataProduct Operation</seealso>
        public virtual Task<DeleteDataProductResponse> DeleteDataProductAsync(DeleteDataProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProductResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomainUnit

        internal virtual DeleteDomainUnitResponse DeleteDomainUnit(DeleteDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainUnitResponse>(request, options);
        }



        /// <summary>
        /// Deletes a domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomainUnit">REST API Reference for DeleteDomainUnit Operation</seealso>
        public virtual Task<DeleteDomainUnitResponse> DeleteDomainUnitAsync(DeleteDomainUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainUnitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainUnitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironmentAction

        internal virtual DeleteEnvironmentActionResponse DeleteEnvironmentAction(DeleteEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentActionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an action for the environment, for example, deletes a console link for an
        /// analytics tool that is available in this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentAction">REST API Reference for DeleteEnvironmentAction Operation</seealso>
        public virtual Task<DeleteEnvironmentActionResponse> DeleteEnvironmentActionAsync(DeleteEnvironmentActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironmentBlueprint

        internal virtual DeleteEnvironmentBlueprintResponse DeleteEnvironmentBlueprint(DeleteEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Deletes a blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprint">REST API Reference for DeleteEnvironmentBlueprint Operation</seealso>
        public virtual Task<DeleteEnvironmentBlueprintResponse> DeleteEnvironmentBlueprintAsync(DeleteEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentBlueprintResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironmentBlueprintConfiguration

        internal virtual DeleteEnvironmentBlueprintConfigurationResponse DeleteEnvironmentBlueprintConfiguration(DeleteEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentBlueprintConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<DeleteEnvironmentBlueprintConfigurationResponse> DeleteEnvironmentBlueprintConfigurationAsync(DeleteEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironmentProfile

        internal virtual DeleteEnvironmentProfileResponse DeleteEnvironmentProfile(DeleteEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes an environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual Task<DeleteEnvironmentProfileResponse> DeleteEnvironmentProfileAsync(DeleteEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFormType

        internal virtual DeleteFormTypeResponse DeleteFormType(DeleteFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteFormTypeResponse>(request, options);
        }



        /// <summary>
        /// Deletes and metadata form type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The form type must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form type must not be in use by any asset types or assets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have delete permissions on the form type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any dependencies (such as linked asset types) must be removed first.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual Task<DeleteFormTypeResponse> DeleteFormTypeAsync(DeleteFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFormTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGlossary

        internal virtual DeleteGlossaryResponse DeleteGlossary(DeleteGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryResponse>(request, options);
        }



        /// <summary>
        /// Deletes a business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The glossary must be in DISABLED state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must not have any glossary terms associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must exist in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:DeleteGlossary</c> permission in the domain and
        /// glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Glossary should not be linked to any active metadata forms.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual Task<DeleteGlossaryResponse> DeleteGlossaryAsync(DeleteGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlossaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGlossaryTerm

        internal virtual DeleteGlossaryTermResponse DeleteGlossaryTerm(DeleteGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryTermResponse>(request, options);
        }



        /// <summary>
        /// Deletes a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term must exist and be active. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term must not be linked to other assets or child terms.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Caller must have delete permissions in the domain/glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure all associations (such as to assets or parent terms) are removed before deletion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual Task<DeleteGlossaryTermResponse> DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlossaryTermResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteListing

        internal virtual DeleteListingResponse DeleteListing(DeleteListingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;

            return Invoke<DeleteListingResponse>(request, options);
        }



        /// <summary>
        /// Deletes a listing (a record of an asset at a given time).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual Task<DeleteListingResponse> DeleteListingAsync(DeleteListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteListingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProjectMembership

        internal virtual DeleteProjectMembershipResponse DeleteProjectMembership(DeleteProjectMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectMembershipResponse>(request, options);
        }



        /// <summary>
        /// Deletes project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual Task<DeleteProjectMembershipResponse> DeleteProjectMembershipAsync(DeleteProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProjectProfile

        internal virtual DeleteProjectProfileResponse DeleteProjectProfile(DeleteProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectProfile">REST API Reference for DeleteProjectProfile Operation</seealso>
        public virtual Task<DeleteProjectProfileResponse> DeleteProjectProfileAsync(DeleteProjectProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRule

        internal virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a rule in Amazon DataZone. A rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubscriptionGrant

        internal virtual DeleteSubscriptionGrantResponse DeleteSubscriptionGrant(DeleteSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionGrantResponse>(request, options);
        }



        /// <summary>
        /// Deletes and subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual Task<DeleteSubscriptionGrantResponse> DeleteSubscriptionGrantAsync(DeleteSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubscriptionRequest

        internal virtual DeleteSubscriptionRequestResponse DeleteSubscriptionRequest(DeleteSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionRequestResponse>(request, options);
        }



        /// <summary>
        /// Deletes a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual Task<DeleteSubscriptionRequestResponse> DeleteSubscriptionRequestAsync(DeleteSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubscriptionTarget

        internal virtual DeleteSubscriptionTargetResponse DeleteSubscriptionTarget(DeleteSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionTargetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual Task<DeleteSubscriptionTargetResponse> DeleteSubscriptionTargetAsync(DeleteSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTimeSeriesDataPoints

        internal virtual DeleteTimeSeriesDataPointsResponse DeleteTimeSeriesDataPoints(DeleteTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<DeleteTimeSeriesDataPointsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified time series form for the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeriesDataPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteTimeSeriesDataPoints">REST API Reference for DeleteTimeSeriesDataPoints Operation</seealso>
        public virtual Task<DeleteTimeSeriesDataPointsResponse> DeleteTimeSeriesDataPointsAsync(DeleteTimeSeriesDataPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTimeSeriesDataPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateEnvironmentRole

        internal virtual DisassociateEnvironmentRoleResponse DisassociateEnvironmentRole(DisassociateEnvironmentRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateEnvironmentRoleResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the environment role in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnvironmentRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEnvironmentRole service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateEnvironmentRole">REST API Reference for DisassociateEnvironmentRole Operation</seealso>
        public virtual Task<DisassociateEnvironmentRoleResponse> DisassociateEnvironmentRoleAsync(DisassociateEnvironmentRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateEnvironmentRoleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateGovernedTerms

        internal virtual DisassociateGovernedTermsResponse DisassociateGovernedTerms(DisassociateGovernedTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGovernedTermsResponseUnmarshaller.Instance;

            return Invoke<DisassociateGovernedTermsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates restricted terms from an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGovernedTerms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateGovernedTerms service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateGovernedTerms">REST API Reference for DisassociateGovernedTerms Operation</seealso>
        public virtual Task<DisassociateGovernedTermsResponse> DisassociateGovernedTermsAsync(DisassociateGovernedTermsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGovernedTermsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateGovernedTermsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccountPool

        internal virtual GetAccountPoolResponse GetAccountPool(GetAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPoolResponseUnmarshaller.Instance;

            return Invoke<GetAccountPoolResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of the account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAccountPool">REST API Reference for GetAccountPool Operation</seealso>
        public virtual Task<GetAccountPoolResponse> GetAccountPoolAsync(GetAccountPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPoolResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAsset

        internal virtual GetAssetResponse GetAsset(GetAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return Invoke<GetAssetResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone asset.
        /// 
        ///  
        /// <para>
        /// An asset is the fundamental building block in Amazon DataZone, representing any data
        /// resource that needs to be cataloged and managed. It can take many forms, from Amazon
        /// S3 buckets and database tables to dashboards and machine learning models. Each asset
        /// contains comprehensive metadata about the resource, including its location, schema,
        /// ownership, and lineage information. Assets are essential for organizing and managing
        /// data resources across an organization, making them discoverable and usable while maintaining
        /// proper governance.
        /// </para>
        ///  
        /// <para>
        /// Before using the Amazon DataZone GetAsset command, ensure the following prerequisites
        /// are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain identifier must exist and be valid
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset identifier must exist
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have the required permissions to perform the action
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual Task<GetAssetResponse> GetAssetAsync(GetAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssetFilter

        internal virtual GetAssetFilterResponse GetAssetFilter(GetAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetFilterResponseUnmarshaller.Instance;

            return Invoke<GetAssetFilterResponse>(request, options);
        }



        /// <summary>
        /// Gets an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain (<c>--domain-identifier</c>), asset (<c>--asset-identifier</c>), and filter
        /// (<c>--identifier</c>) must all exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset filter should not have been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must still exist (since the filter is linked to it).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetFilter">REST API Reference for GetAssetFilter Operation</seealso>
        public virtual Task<GetAssetFilterResponse> GetAssetFilterAsync(GetAssetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssetType

        internal virtual GetAssetTypeResponse GetAssetType(GetAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;

            return Invoke<GetAssetTypeResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone asset type.
        /// 
        ///  
        /// <para>
        /// Asset types define the categories and characteristics of different kinds of data assets
        /// within Amazon DataZone.. They determine what metadata fields are required, what operations
        /// are possible, and how the asset integrates with other Amazon Web Services services.
        /// Asset types can range from built-in types like Amazon S3 buckets and Amazon Web Services
        /// Glue tables to custom types defined for specific organizational needs. Understanding
        /// asset types is crucial for properly organizing and managing different kinds of data
        /// resources.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset type with identifier must exist in the domain. ResourceNotFoundException.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the GetAssetType permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure the domain-identifier value is correct and accessible.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual Task<GetAssetTypeResponse> GetAssetTypeAsync(GetAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnection

        internal virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }



        /// <summary>
        /// Gets a connection. In Amazon DataZone, a connection enables you to connect your resources
        /// (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataProduct

        internal virtual GetDataProductResponse GetDataProduct(GetDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProductResponseUnmarshaller.Instance;

            return Invoke<GetDataProductResponse>(request, options);
        }



        /// <summary>
        /// Gets the data product.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product ID must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have read or discovery permissions for the data product.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataProduct">REST API Reference for GetDataProduct Operation</seealso>
        public virtual Task<GetDataProductResponse> GetDataProductAsync(GetDataProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProductResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataSourceRun

        internal virtual GetDataSourceRunResponse GetDataSourceRun(GetDataSourceRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceRunResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone data source run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual Task<GetDataSourceRunResponse> GetDataSourceRunAsync(GetDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomain

        internal virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomainUnit

        internal virtual GetDomainUnitResponse GetDomainUnit(GetDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainUnitResponseUnmarshaller.Instance;

            return Invoke<GetDomainUnitResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of the specified domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomainUnit">REST API Reference for GetDomainUnit Operation</seealso>
        public virtual Task<GetDomainUnitResponse> GetDomainUnitAsync(GetDomainUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainUnitResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainUnitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironmentAction

        internal virtual GetEnvironmentActionResponse GetEnvironmentAction(GetEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentActionResponse>(request, options);
        }



        /// <summary>
        /// Gets the specified environment action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentAction">REST API Reference for GetEnvironmentAction Operation</seealso>
        public virtual Task<GetEnvironmentActionResponse> GetEnvironmentActionAsync(GetEnvironmentActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentActionResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironmentBlueprint

        internal virtual GetEnvironmentBlueprintResponse GetEnvironmentBlueprint(GetEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual Task<GetEnvironmentBlueprintResponse> GetEnvironmentBlueprintAsync(GetEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentBlueprintResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironmentBlueprintConfiguration

        internal virtual GetEnvironmentBlueprintConfigurationResponse GetEnvironmentBlueprintConfiguration(GetEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<GetEnvironmentBlueprintConfigurationResponse> GetEnvironmentBlueprintConfigurationAsync(GetEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironmentCredentials

        internal virtual GetEnvironmentCredentialsResponse GetEnvironmentCredentials(GetEnvironmentCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Gets the credentials of an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentCredentials service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentCredentials">REST API Reference for GetEnvironmentCredentials Operation</seealso>
        public virtual Task<GetEnvironmentCredentialsResponse> GetEnvironmentCredentialsAsync(GetEnvironmentCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironmentProfile

        internal virtual GetEnvironmentProfileResponse GetEnvironmentProfile(GetEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets an evinronment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual Task<GetEnvironmentProfileResponse> GetEnvironmentProfileAsync(GetEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFormType

        internal virtual GetFormTypeResponse GetFormType(GetFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;

            return Invoke<GetFormTypeResponse>(request, options);
        }



        /// <summary>
        /// Gets a metadata form type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Form types define the structure and validation rules for collecting metadata about
        /// assets in Amazon DataZone. They act as templates that ensure consistent metadata capture
        /// across similar types of assets, while allowing for customization to meet specific
        /// organizational needs. Form types can include required fields, validation rules, and
        /// dependencies, helping maintain high-quality metadata that makes data assets more discoverable
        /// and usable.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The form type with the specified identifier must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permission on the form type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form type should not be deleted or in an invalid state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// One use case for this API is to determine whether a form field is indexed for search.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A searchable field will be annotated with <c>@amazon.datazone#searchable</c>. By default,
        /// searchable fields are indexed for semantic search, where related query terms will
        /// match the attribute value even if they are not stemmed or keyword matches. If a field
        /// is indexed technical identifier search, it will be annotated with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
        /// If a field is indexed for lexical search (supports stemmed and prefix matches but
        /// not semantic matches), it will be annotated with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
        /// </para>
        ///  
        /// <para>
        /// A field storing glossary term IDs (which is filterable) will be annotated with <c>@amazon.datazone#glossaryterm("${glossaryId}")</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual Task<GetFormTypeResponse> GetFormTypeAsync(GetFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetFormTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGlossary

        internal virtual GetGlossaryResponse GetGlossary(GetGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryResponse>(request, options);
        }



        /// <summary>
        /// Gets a business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The specified glossary ID must exist and be associated with the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:GetGlossary</c> permission on the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual Task<GetGlossaryResponse> GetGlossaryAsync(GetGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetGlossaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGlossaryTerm

        internal virtual GetGlossaryTermResponse GetGlossaryTerm(GetGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryTermResponse>(request, options);
        }



        /// <summary>
        /// Gets a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term with identifier must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permission on the glossary term.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain must be accessible and active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual Task<GetGlossaryTermResponse> GetGlossaryTermAsync(GetGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;

            return InvokeAsync<GetGlossaryTermResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGroupProfile

        internal virtual GetGroupProfileResponse GetGroupProfile(GetGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;

            return Invoke<GetGroupProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual Task<GetGroupProfileResponse> GetGroupProfileAsync(GetGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIamPortalLoginUrl

        internal virtual GetIamPortalLoginUrlResponse GetIamPortalLoginUrl(GetIamPortalLoginUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;

            return Invoke<GetIamPortalLoginUrlResponse>(request, options);
        }



        /// <summary>
        /// Gets the data portal URL for the specified Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIamPortalLoginUrl service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual Task<GetIamPortalLoginUrlResponse> GetIamPortalLoginUrlAsync(GetIamPortalLoginUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetIamPortalLoginUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetJobRun

        internal virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunResponse>(request, options);
        }



        /// <summary>
        /// The details of the job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLineageEvent

        internal virtual GetLineageEventResponse GetLineageEvent(GetLineageEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageEventResponseUnmarshaller.Instance;

            return Invoke<GetLineageEventResponse>(request, options);
        }



        /// <summary>
        /// Describes the lineage event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLineageEvent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageEvent">REST API Reference for GetLineageEvent Operation</seealso>
        public virtual Task<GetLineageEventResponse> GetLineageEventAsync(GetLineageEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageEventResponseUnmarshaller.Instance;

            return InvokeAsync<GetLineageEventResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLineageNode

        internal virtual GetLineageNodeResponse GetLineageNode(GetLineageNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageNodeResponseUnmarshaller.Instance;

            return Invoke<GetLineageNodeResponse>(request, options);
        }



        /// <summary>
        /// Gets the data lineage node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLineageNode service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageNode">REST API Reference for GetLineageNode Operation</seealso>
        public virtual Task<GetLineageNodeResponse> GetLineageNodeAsync(GetLineageNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageNodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetLineageNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetListing

        internal virtual GetListingResponse GetListing(GetListingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return Invoke<GetListingResponse>(request, options);
        }



        /// <summary>
        /// Gets a listing (a record of an asset at a given time). If you specify a listing version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual Task<GetListingResponse> GetListingAsync(GetListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return InvokeAsync<GetListingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMetadataGenerationRun

        internal virtual GetMetadataGenerationRunResponse GetMetadataGenerationRun(GetMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<GetMetadataGenerationRunResponse>(request, options);
        }



        /// <summary>
        /// Gets a metadata generation run in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid domain and run identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The metadata generation run must exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have read access to the metadata run.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadataGenerationRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetMetadataGenerationRun">REST API Reference for GetMetadataGenerationRun Operation</seealso>
        public virtual Task<GetMetadataGenerationRunResponse> GetMetadataGenerationRunAsync(GetMetadataGenerationRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataGenerationRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetadataGenerationRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProject

        internal virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }



        /// <summary>
        /// Gets a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProjectProfile

        internal virtual GetProjectProfileResponse GetProjectProfile(GetProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectProfileResponseUnmarshaller.Instance;

            return Invoke<GetProjectProfileResponse>(request, options);
        }



        /// <summary>
        /// The details of the project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProjectProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProjectProfile">REST API Reference for GetProjectProfile Operation</seealso>
        public virtual Task<GetProjectProfileResponse> GetProjectProfileAsync(GetProjectProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProjectProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRule

        internal virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a rule in Amazon DataZone. A rule is a formal agreement that enforces
        /// specific requirements across user workflows (e.g., publishing assets to the catalog,
        /// requesting subscriptions, creating projects) within the Amazon DataZone data portal.
        /// These rules help maintain consistency, ensure compliance, and uphold governance standards
        /// in data management processes. For instance, a metadata enforcement rule can specify
        /// the required information for creating a subscription request or publishing a data
        /// asset to the catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscription

        internal virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Gets a subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscriptionGrant

        internal virtual GetSubscriptionGrantResponse GetSubscriptionGrant(GetSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionGrantResponse>(request, options);
        }



        /// <summary>
        /// Gets the subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual Task<GetSubscriptionGrantResponse> GetSubscriptionGrantAsync(GetSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscriptionRequestDetails

        internal virtual GetSubscriptionRequestDetailsResponse GetSubscriptionRequestDetails(GetSubscriptionRequestDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionRequestDetailsResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionRequestDetails service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual Task<GetSubscriptionRequestDetailsResponse> GetSubscriptionRequestDetailsAsync(GetSubscriptionRequestDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionRequestDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscriptionTarget

        internal virtual GetSubscriptionTargetResponse GetSubscriptionTarget(GetSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionTargetResponse>(request, options);
        }



        /// <summary>
        /// Gets the subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual Task<GetSubscriptionTargetResponse> GetSubscriptionTargetAsync(GetSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTimeSeriesDataPoint

        internal virtual GetTimeSeriesDataPointResponse GetTimeSeriesDataPoint(GetTimeSeriesDataPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesDataPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesDataPointResponseUnmarshaller.Instance;

            return Invoke<GetTimeSeriesDataPointResponse>(request, options);
        }



        /// <summary>
        /// Gets the existing data point for the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesDataPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimeSeriesDataPoint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetTimeSeriesDataPoint">REST API Reference for GetTimeSeriesDataPoint Operation</seealso>
        public virtual Task<GetTimeSeriesDataPointResponse> GetTimeSeriesDataPointAsync(GetTimeSeriesDataPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesDataPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesDataPointResponseUnmarshaller.Instance;

            return InvokeAsync<GetTimeSeriesDataPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUserProfile

        internal virtual GetUserProfileResponse GetUserProfile(GetUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;

            return Invoke<GetUserProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual Task<GetUserProfileResponse> GetUserProfileAsync(GetUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAccountPools

        internal virtual ListAccountPoolsResponse ListAccountPools(ListAccountPoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPoolsResponseUnmarshaller.Instance;

            return Invoke<ListAccountPoolsResponse>(request, options);
        }



        /// <summary>
        /// Lists existing account pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountPools service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountPools">REST API Reference for ListAccountPools Operation</seealso>
        public virtual Task<ListAccountPoolsResponse> ListAccountPoolsAsync(ListAccountPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountPoolsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAccountsInAccountPool

        internal virtual ListAccountsInAccountPoolResponse ListAccountsInAccountPool(ListAccountsInAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsInAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsInAccountPoolResponseUnmarshaller.Instance;

            return Invoke<ListAccountsInAccountPoolResponse>(request, options);
        }



        /// <summary>
        /// Lists the accounts in the specified account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsInAccountPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountsInAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountsInAccountPool">REST API Reference for ListAccountsInAccountPool Operation</seealso>
        public virtual Task<ListAccountsInAccountPoolResponse> ListAccountsInAccountPoolAsync(ListAccountsInAccountPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsInAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsInAccountPoolResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsInAccountPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetFilters

        internal virtual ListAssetFiltersResponse ListAssetFilters(ListAssetFiltersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetFiltersResponseUnmarshaller.Instance;

            return Invoke<ListAssetFiltersResponse>(request, options);
        }



        /// <summary>
        /// Lists asset filters.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A valid domain and asset must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must have at least one filter created to return results. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetFilters service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetFilters">REST API Reference for ListAssetFilters Operation</seealso>
        public virtual Task<ListAssetFiltersResponse> ListAssetFiltersAsync(ListAssetFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetFiltersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetRevisions

        internal virtual ListAssetRevisionsResponse ListAssetRevisions(ListAssetRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListAssetRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the revisions for the asset.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There must be at least one revision of the asset (which happens automatically after
        /// creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the asset and domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual Task<ListAssetRevisionsResponse> ListAssetRevisionsAsync(ListAssetRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetRevisionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnections

        internal virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists connections. In Amazon DataZone, a connection enables you to connect your resources
        /// (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataProductRevisions

        internal virtual ListDataProductRevisionsResponse ListDataProductRevisions(ListDataProductRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProductRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProductRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListDataProductRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Lists data product revisions.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product ID must exist within the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have view permissions on the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be in a valid and accessible state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataProductRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataProductRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataProductRevisions">REST API Reference for ListDataProductRevisions Operation</seealso>
        public virtual Task<ListDataProductRevisionsResponse> ListDataProductRevisionsAsync(ListDataProductRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProductRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProductRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataProductRevisionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSourceRunActivities

        internal virtual ListDataSourceRunActivitiesResponse ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunActivitiesResponse>(request, options);
        }



        /// <summary>
        /// Lists data source run activities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRunActivities service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual Task<ListDataSourceRunActivitiesResponse> ListDataSourceRunActivitiesAsync(ListDataSourceRunActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourceRunActivitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSourceRuns

        internal virtual ListDataSourceRunsResponse ListDataSourceRuns(ListDataSourceRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists data source runs in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual Task<ListDataSourceRunsResponse> ListDataSourceRunsAsync(ListDataSourceRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourceRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists data sources in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon DataZone domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainUnitsForParent

        internal virtual ListDomainUnitsForParentResponse ListDomainUnitsForParent(ListDomainUnitsForParentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainUnitsForParentResponseUnmarshaller.Instance;

            return Invoke<ListDomainUnitsForParentResponse>(request, options);
        }



        /// <summary>
        /// Lists child domain units for the specified parent domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainUnitsForParent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainUnitsForParent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomainUnitsForParent">REST API Reference for ListDomainUnitsForParent Operation</seealso>
        public virtual Task<ListDomainUnitsForParentResponse> ListDomainUnitsForParentAsync(ListDomainUnitsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainUnitsForParentResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainUnitsForParentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEntityOwners

        internal virtual ListEntityOwnersResponse ListEntityOwners(ListEntityOwnersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntityOwnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityOwnersResponseUnmarshaller.Instance;

            return Invoke<ListEntityOwnersResponse>(request, options);
        }



        /// <summary>
        /// Lists the entity (domain units) owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityOwners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntityOwners service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEntityOwners">REST API Reference for ListEntityOwners Operation</seealso>
        public virtual Task<ListEntityOwnersResponse> ListEntityOwnersAsync(ListEntityOwnersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntityOwnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityOwnersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntityOwnersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironmentActions

        internal virtual ListEnvironmentActionsResponse ListEnvironmentActions(ListEnvironmentActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentActionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentActionsResponse>(request, options);
        }



        /// <summary>
        /// Lists existing environment actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentActions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentActions">REST API Reference for ListEnvironmentActions Operation</seealso>
        public virtual Task<ListEnvironmentActionsResponse> ListEnvironmentActionsAsync(ListEnvironmentActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironmentBlueprintConfigurations

        internal virtual ListEnvironmentBlueprintConfigurationsResponse ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists blueprint configurations for a Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprintConfigurations service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual Task<ListEnvironmentBlueprintConfigurationsResponse> ListEnvironmentBlueprintConfigurationsAsync(ListEnvironmentBlueprintConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentBlueprintConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironmentBlueprints

        internal virtual ListEnvironmentBlueprintsResponse ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintsResponse>(request, options);
        }



        /// <summary>
        /// Lists blueprints in an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual Task<ListEnvironmentBlueprintsResponse> ListEnvironmentBlueprintsAsync(ListEnvironmentBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentBlueprintsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironmentProfiles

        internal virtual ListEnvironmentProfilesResponse ListEnvironmentProfiles(ListEnvironmentProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon DataZone environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual Task<ListEnvironmentProfilesResponse> ListEnvironmentProfilesAsync(ListEnvironmentProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon DataZone environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJobRuns

        internal virtual ListJobRunsResponse ListJobRuns(ListJobRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return Invoke<ListJobRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists job runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLineageEvents

        internal virtual ListLineageEventsResponse ListLineageEvents(ListLineageEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageEventsResponseUnmarshaller.Instance;

            return Invoke<ListLineageEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists lineage events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLineageEvents service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageEvents">REST API Reference for ListLineageEvents Operation</seealso>
        public virtual Task<ListLineageEventsResponse> ListLineageEventsAsync(ListLineageEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLineageEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLineageNodeHistory

        internal virtual ListLineageNodeHistoryResponse ListLineageNodeHistory(ListLineageNodeHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageNodeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageNodeHistoryResponseUnmarshaller.Instance;

            return Invoke<ListLineageNodeHistoryResponse>(request, options);
        }



        /// <summary>
        /// Lists the history of the specified data lineage node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageNodeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLineageNodeHistory service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageNodeHistory">REST API Reference for ListLineageNodeHistory Operation</seealso>
        public virtual Task<ListLineageNodeHistoryResponse> ListLineageNodeHistoryAsync(ListLineageNodeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageNodeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageNodeHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListLineageNodeHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMetadataGenerationRuns

        internal virtual ListMetadataGenerationRunsResponse ListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetadataGenerationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetadataGenerationRunsResponseUnmarshaller.Instance;

            return Invoke<ListMetadataGenerationRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists all metadata generation runs.
        /// 
        ///  
        /// <para>
        /// Metadata generation runs represent automated processes that leverage AI/ML capabilities
        /// to create or enhance asset metadata at scale. This feature helps organizations maintain
        /// comprehensive and consistent metadata across large numbers of assets without manual
        /// intervention. It can automatically generate business descriptions, tags, and other
        /// metadata elements, significantly reducing the time and effort required for metadata
        /// management while improving consistency and completeness.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid domain identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have access to metadata generation runs in the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetadataGenerationRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetadataGenerationRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListMetadataGenerationRuns">REST API Reference for ListMetadataGenerationRuns Operation</seealso>
        public virtual Task<ListMetadataGenerationRunsResponse> ListMetadataGenerationRunsAsync(ListMetadataGenerationRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetadataGenerationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetadataGenerationRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetadataGenerationRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNotifications

        internal virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all Amazon DataZone notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotificationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicyGrants

        internal virtual ListPolicyGrantsResponse ListPolicyGrants(ListPolicyGrantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGrantsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyGrantsResponse>(request, options);
        }



        /// <summary>
        /// Lists policy grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListPolicyGrants">REST API Reference for ListPolicyGrants Operation</seealso>
        public virtual Task<ListPolicyGrantsResponse> ListPolicyGrantsAsync(ListPolicyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyGrantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjectMemberships

        internal virtual ListProjectMembershipsResponse ListProjectMemberships(ListProjectMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListProjectMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists all members of the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectMemberships service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual Task<ListProjectMembershipsResponse> ListProjectMembershipsAsync(ListProjectMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectMembershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjectProfiles

        internal virtual ListProjectProfilesResponse ListProjectProfiles(ListProjectProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProjectProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists project profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectProfiles">REST API Reference for ListProjectProfiles Operation</seealso>
        public virtual Task<ListProjectProfilesResponse> ListProjectProfilesAsync(ListProjectProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon DataZone projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRules

        internal virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }



        /// <summary>
        /// Lists existing rules. In Amazon DataZone, a rule is a formal agreement that enforces
        /// specific requirements across user workflows (e.g., publishing assets to the catalog,
        /// requesting subscriptions, creating projects) within the Amazon DataZone data portal.
        /// These rules help maintain consistency, ensure compliance, and uphold governance standards
        /// in data management processes. For instance, a metadata enforcement rule can specify
        /// the required information for creating a subscription request or publishing a data
        /// asset to the catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptionGrants

        internal virtual ListSubscriptionGrantsResponse ListSubscriptionGrants(ListSubscriptionGrantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionGrantsResponse>(request, options);
        }



        /// <summary>
        /// Lists subscription grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual Task<ListSubscriptionGrantsResponse> ListSubscriptionGrantsAsync(ListSubscriptionGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionGrantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptionRequests

        internal virtual ListSubscriptionRequestsResponse ListSubscriptionRequests(ListSubscriptionRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionRequestsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon DataZone subscription requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionRequests service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual Task<ListSubscriptionRequestsResponse> ListSubscriptionRequestsAsync(ListSubscriptionRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptions

        internal virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Lists subscriptions in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptionTargets

        internal virtual ListSubscriptionTargetsResponse ListSubscriptionTargets(ListSubscriptionTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionTargetsResponse>(request, options);
        }



        /// <summary>
        /// Lists subscription targets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionTargets service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual Task<ListSubscriptionTargetsResponse> ListSubscriptionTargetsAsync(ListSubscriptionTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionTargetsResponse>(request, options, cancellationToken);
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
        /// Lists tags for the specified resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTimeSeriesDataPoints

        internal virtual ListTimeSeriesDataPointsResponse ListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<ListTimeSeriesDataPointsResponse>(request, options);
        }



        /// <summary>
        /// Lists time series data points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeriesDataPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTimeSeriesDataPoints">REST API Reference for ListTimeSeriesDataPoints Operation</seealso>
        public virtual Task<ListTimeSeriesDataPointsResponse> ListTimeSeriesDataPointsAsync(ListTimeSeriesDataPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTimeSeriesDataPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PostLineageEvent

        internal virtual PostLineageEventResponse PostLineageEvent(PostLineageEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostLineageEventResponseUnmarshaller.Instance;

            return Invoke<PostLineageEventResponse>(request, options);
        }



        /// <summary>
        /// Posts a data lineage event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostLineageEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostLineageEvent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostLineageEvent">REST API Reference for PostLineageEvent Operation</seealso>
        public virtual Task<PostLineageEventResponse> PostLineageEventAsync(PostLineageEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostLineageEventResponseUnmarshaller.Instance;

            return InvokeAsync<PostLineageEventResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PostTimeSeriesDataPoints

        internal virtual PostTimeSeriesDataPointsResponse PostTimeSeriesDataPoints(PostTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<PostTimeSeriesDataPointsResponse>(request, options);
        }



        /// <summary>
        /// Posts time series data points to Amazon DataZone for the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostTimeSeriesDataPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostTimeSeriesDataPoints">REST API Reference for PostTimeSeriesDataPoints Operation</seealso>
        public virtual Task<PostTimeSeriesDataPointsResponse> PostTimeSeriesDataPointsAsync(PostTimeSeriesDataPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return InvokeAsync<PostTimeSeriesDataPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEnvironmentBlueprintConfiguration

        internal virtual PutEnvironmentBlueprintConfigurationResponse PutEnvironmentBlueprintConfiguration(PutEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEnvironmentBlueprintConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<PutEnvironmentBlueprintConfigurationResponse> PutEnvironmentBlueprintConfigurationAsync(PutEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RejectPredictions

        internal virtual RejectPredictionsResponse RejectPredictions(RejectPredictionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;

            return Invoke<RejectPredictionsResponse>(request, options);
        }



        /// <summary>
        /// Rejects automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual Task<RejectPredictionsResponse> RejectPredictionsAsync(RejectPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;

            return InvokeAsync<RejectPredictionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RejectSubscriptionRequest

        internal virtual RejectSubscriptionRequestResponse RejectSubscriptionRequest(RejectSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<RejectSubscriptionRequestResponse>(request, options);
        }



        /// <summary>
        /// Rejects the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual Task<RejectSubscriptionRequestResponse> RejectSubscriptionRequestAsync(RejectSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;

            return InvokeAsync<RejectSubscriptionRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveEntityOwner

        internal virtual RemoveEntityOwnerResponse RemoveEntityOwner(RemoveEntityOwnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveEntityOwnerResponseUnmarshaller.Instance;

            return Invoke<RemoveEntityOwnerResponse>(request, options);
        }



        /// <summary>
        /// Removes an owner from an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveEntityOwner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveEntityOwner service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemoveEntityOwner">REST API Reference for RemoveEntityOwner Operation</seealso>
        public virtual Task<RemoveEntityOwnerResponse> RemoveEntityOwnerAsync(RemoveEntityOwnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveEntityOwnerResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveEntityOwnerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemovePolicyGrant

        internal virtual RemovePolicyGrantResponse RemovePolicyGrant(RemovePolicyGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemovePolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePolicyGrantResponseUnmarshaller.Instance;

            return Invoke<RemovePolicyGrantResponse>(request, options);
        }



        /// <summary>
        /// Removes a policy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePolicyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePolicyGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemovePolicyGrant">REST API Reference for RemovePolicyGrant Operation</seealso>
        public virtual Task<RemovePolicyGrantResponse> RemovePolicyGrantAsync(RemovePolicyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemovePolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePolicyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePolicyGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeSubscription

        internal virtual RevokeSubscriptionResponse RevokeSubscription(RevokeSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RevokeSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Revokes a specified subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Search

        internal virtual SearchResponse Search(SearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }



        /// <summary>
        /// Searches for assets in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Search in Amazon DataZone is a powerful capability that enables users to discover
        /// and explore data assets, glossary terms, and data products across their organization.
        /// It provides both basic and advanced search functionality, allowing users to find resources
        /// based on names, descriptions, metadata, and other attributes. Search can be scoped
        /// to specific types of resources (like assets, glossary terms, or data products) and
        /// can be filtered using various criteria such as creation date, owner, or status. The
        /// search functionality is essential for making the wealth of data resources in an organization
        /// discoverable and usable, helping users find the right data for their needs quickly
        /// and efficiently.
        /// </para>
        ///  
        /// <para>
        /// Many search commands in Amazon DataZone are paginated, including <c>search</c> and
        /// <c>search-types</c>. When the result set is large, Amazon DataZone returns a <c>nextToken</c>
        /// in the response. This token can be used to retrieve the next page of results. 
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The --domain-identifier must refer to an existing Amazon DataZone domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --search-scope must be one of: ASSET, GLOSSARY_TERM, DATA_PRODUCT, or GLOSSARY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have search permissions in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using --filters, ensure that the JSON is well-formed and that each filter includes
        /// valid attribute and value keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For paginated results, be prepared to use --next-token to fetch additional pages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return InvokeAsync<SearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchGroupProfiles

        internal virtual SearchGroupProfilesResponse SearchGroupProfiles(SearchGroupProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchGroupProfilesResponse>(request, options);
        }



        /// <summary>
        /// Searches group profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroupProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual Task<SearchGroupProfilesResponse> SearchGroupProfilesAsync(SearchGroupProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGroupProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchListings

        internal virtual SearchListingsResponse SearchListings(SearchListingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return Invoke<SearchListingsResponse>(request, options);
        }



        /// <summary>
        /// Searches listings in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// SearchListings is a powerful capability that enables users to discover and explore
        /// published assets and data products across their organization. It provides both basic
        /// and advanced search functionality, allowing users to find resources based on names,
        /// descriptions, metadata, and other attributes. SearchListings also supports filtering
        /// using various criteria such as creation date, owner, or status. This API is essential
        /// for making the wealth of data resources in an organization discoverable and usable,
        /// helping users find the right data for their needs quickly and efficiently.
        /// </para>
        ///  
        /// <para>
        /// SearchListings returns results in a paginated format. When the result set is large,
        /// the response will include a nextToken, which can be used to retrieve the next page
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// The SearchListings API gives users flexibility in specifying what kind of search is
        /// run.
        /// </para>
        ///  
        /// <para>
        /// To run a free-text search, the <c>searchText</c> parameter must be supplied. By default,
        /// all searchable fields are indexed for semantic search and will return semantic matches
        /// for SearchListings queries. To prevent semantic search indexing for a custom form
        /// attribute, see the <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType
        /// API documentation</a>. To run a lexical search query, enclose the query with double
        /// quotes (""). This will disable semantic search even for fields that have semantic
        /// search enabled and will only return results that contain the keywords wrapped by double
        /// quotes (order of tokens in the query is not enforced). Free-text search is supported
        /// for all attributes annotated with @amazon.datazone#searchable.
        /// </para>
        ///  
        /// <para>
        /// To run a filtered search, provide filter clause using the filters parameter. To filter
        /// on glossary terms, use the special attribute <c>__DataZoneGlossaryTerms</c>.
        /// </para>
        ///  
        /// <para>
        ///  To find out whether an attribute has been annotated and indexed for a given search
        /// type, use the GetFormType API to retrieve the form containing the attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual Task<SearchListingsResponse> SearchListingsAsync(SearchListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchListingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchTypes

        internal virtual SearchTypesResponse SearchTypes(SearchTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;

            return Invoke<SearchTypesResponse>(request, options);
        }



        /// <summary>
        /// Searches for types in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The --domain-identifier must refer to an existing Amazon DataZone domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --search-scope must be one of the valid values including: ASSET_TYPE, GLOSSARY_TERM_TYPE,
        /// DATA_PRODUCT_TYPE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The --managed flag must be present without a value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have permissions for form or asset types in the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using --filters, ensure that the JSON is valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filters contain correct structure (attribute, value, operator).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTypes service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual Task<SearchTypesResponse> SearchTypesAsync(SearchTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchUserProfiles

        internal virtual SearchUserProfilesResponse SearchUserProfiles(SearchUserProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchUserProfilesResponse>(request, options);
        }



        /// <summary>
        /// Searches user profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUserProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual Task<SearchUserProfilesResponse> SearchUserProfilesAsync(SearchUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchUserProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDataSourceRun

        internal virtual StartDataSourceRunResponse StartDataSourceRun(StartDataSourceRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceRunResponse>(request, options);
        }



        /// <summary>
        /// Start the run of the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual Task<StartDataSourceRunResponse> StartDataSourceRunAsync(StartDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataSourceRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMetadataGenerationRun

        internal virtual StartMetadataGenerationRunResponse StartMetadataGenerationRun(StartMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<StartMetadataGenerationRunResponse>(request, options);
        }



        /// <summary>
        /// Starts the metadata generation run.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asset must be created and belong to the specified domain and project. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset type must be supported for metadata generation (e.g., Amazon Web Services Glue
        /// table).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must have a structured schema with valid rows and columns.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for --type: BUSINESS_DESCRIPTIONS, BUSINESS_NAMES.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have permission to run metadata generation in the domain/project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataGenerationRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartMetadataGenerationRun">REST API Reference for StartMetadataGenerationRun Operation</seealso>
        public virtual Task<StartMetadataGenerationRunResponse> StartMetadataGenerationRunAsync(StartMetadataGenerationRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataGenerationRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartMetadataGenerationRunResponse>(request, options, cancellationToken);
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
        /// Tags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Untags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAccountPool

        internal virtual UpdateAccountPoolResponse UpdateAccountPool(UpdateAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPoolResponse>(request, options);
        }



        /// <summary>
        /// Updates the account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAccountPool">REST API Reference for UpdateAccountPool Operation</seealso>
        public virtual Task<UpdateAccountPoolResponse> UpdateAccountPoolAsync(UpdateAccountPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssetFilter

        internal virtual UpdateAssetFilterResponse UpdateAssetFilter(UpdateAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetFilterResponse>(request, options);
        }



        /// <summary>
        /// Updates an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain, asset, and asset filter identifier must all exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must contain the columns being referenced in the update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If applying a row filter, ensure the column referenced in the expression exists in
        /// the asset schema.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAssetFilter">REST API Reference for UpdateAssetFilter Operation</seealso>
        public virtual Task<UpdateAssetFilterResponse> UpdateAssetFilterAsync(UpdateAssetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssetFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnection

        internal virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Updates a connection. In Amazon DataZone, a connection enables you to connect your
        /// resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomain

        internal virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }



        /// <summary>
        /// Updates a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomainUnit

        internal virtual UpdateDomainUnitResponse UpdateDomainUnit(UpdateDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainUnitResponse>(request, options);
        }



        /// <summary>
        /// Updates the domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomainUnit">REST API Reference for UpdateDomainUnit Operation</seealso>
        public virtual Task<UpdateDomainUnitResponse> UpdateDomainUnitAsync(UpdateDomainUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainUnitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainUnitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironmentAction

        internal virtual UpdateEnvironmentActionResponse UpdateEnvironmentAction(UpdateEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentActionResponse>(request, options);
        }



        /// <summary>
        /// Updates an environment action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentAction">REST API Reference for UpdateEnvironmentAction Operation</seealso>
        public virtual Task<UpdateEnvironmentActionResponse> UpdateEnvironmentActionAsync(UpdateEnvironmentActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentActionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironmentBlueprint

        internal virtual UpdateEnvironmentBlueprintResponse UpdateEnvironmentBlueprint(UpdateEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Updates an environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentBlueprint">REST API Reference for UpdateEnvironmentBlueprint Operation</seealso>
        public virtual Task<UpdateEnvironmentBlueprintResponse> UpdateEnvironmentBlueprintAsync(UpdateEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentBlueprintResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironmentProfile

        internal virtual UpdateEnvironmentProfileResponse UpdateEnvironmentProfile(UpdateEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual Task<UpdateEnvironmentProfileResponse> UpdateEnvironmentProfileAsync(UpdateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGlossary

        internal virtual UpdateGlossaryResponse UpdateGlossary(UpdateGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryResponse>(request, options);
        }



        /// <summary>
        /// Updates the business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The glossary must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:UpdateGlossary</c> permission to update it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating the name, the new name must be unique within the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must not be deleted or in a terminal state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual Task<UpdateGlossaryResponse> UpdateGlossaryAsync(UpdateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGlossaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGlossaryTerm

        internal virtual UpdateGlossaryTermResponse UpdateGlossaryTerm(UpdateGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryTermResponse>(request, options);
        }



        /// <summary>
        /// Updates a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term must exist in the specified domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New name must not conflict with existing terms in the same glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the term.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term must not be in DELETED status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual Task<UpdateGlossaryTermResponse> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGlossaryTermResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGroupProfile

        internal virtual UpdateGroupProfileResponse UpdateGroupProfile(UpdateGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual Task<UpdateGroupProfileResponse> UpdateGroupProfileAsync(UpdateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProjectProfile

        internal virtual UpdateProjectProfileResponse UpdateProjectProfile(UpdateProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProjectProfile">REST API Reference for UpdateProjectProfile Operation</seealso>
        public virtual Task<UpdateProjectProfileResponse> UpdateProjectProfileAsync(UpdateProjectProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRule

        internal virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates a rule. In Amazon DataZone, a rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubscriptionGrantStatus

        internal virtual UpdateSubscriptionGrantStatusResponse UpdateSubscriptionGrantStatus(UpdateSubscriptionGrantStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionGrantStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of the specified subscription grant status in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionGrantStatus service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual Task<UpdateSubscriptionGrantStatusResponse> UpdateSubscriptionGrantStatusAsync(UpdateSubscriptionGrantStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionGrantStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubscriptionRequest

        internal virtual UpdateSubscriptionRequestResponse UpdateSubscriptionRequest(UpdateSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionRequestResponse>(request, options);
        }



        /// <summary>
        /// Updates a specified subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual Task<UpdateSubscriptionRequestResponse> UpdateSubscriptionRequestAsync(UpdateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubscriptionTarget

        internal virtual UpdateSubscriptionTargetResponse UpdateSubscriptionTarget(UpdateSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionTargetResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual Task<UpdateSubscriptionTargetResponse> UpdateSubscriptionTargetAsync(UpdateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUserProfile

        internal virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileResponse>(request, options, cancellationToken);
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