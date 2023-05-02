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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.VoiceID.Model;
using Amazon.VoiceID.Model.Internal.MarshallTransformations;
using Amazon.VoiceID.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.VoiceID
{
    /// <summary>
    /// Implementation for accessing VoiceID
    ///
    /// Amazon Connect Voice ID provides real-time caller authentication and fraud risk detection,
    /// which make voice interactions in contact centers more secure and efficient.
    /// </summary>
    public partial class AmazonVoiceIDClient : AmazonServiceClient, IAmazonVoiceID
    {
        private static IServiceMetadata serviceMetadata = new AmazonVoiceIDMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonVoiceIDClient with the credentials loaded from the application's
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
        public AmazonVoiceIDClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVoiceIDConfig()) { }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with the credentials loaded from the application's
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
        public AmazonVoiceIDClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVoiceIDConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonVoiceIDClient Configuration Object</param>
        public AmazonVoiceIDClient(AmazonVoiceIDConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonVoiceIDClient(AWSCredentials credentials)
            : this(credentials, new AmazonVoiceIDConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVoiceIDClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonVoiceIDConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Credentials and an
        /// AmazonVoiceIDClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonVoiceIDClient Configuration Object</param>
        public AmazonVoiceIDClient(AWSCredentials credentials, AmazonVoiceIDConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVoiceIDConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVoiceIDConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVoiceIDClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonVoiceIDClient Configuration Object</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonVoiceIDConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVoiceIDConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVoiceIDConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVoiceIDClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVoiceIDClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonVoiceIDClient Configuration Object</param>
        public AmazonVoiceIDClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonVoiceIDConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IVoiceIDPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IVoiceIDPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new VoiceIDPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonVoiceIDEndpointResolver());
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


        #region  AssociateFraudster

        internal virtual AssociateFraudsterResponse AssociateFraudster(AssociateFraudsterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFraudsterResponseUnmarshaller.Instance;

            return Invoke<AssociateFraudsterResponse>(request, options);
        }



        /// <summary>
        /// Associates the fraudsters with the watchlist specified in the same domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/AssociateFraudster">REST API Reference for AssociateFraudster Operation</seealso>
        public virtual Task<AssociateFraudsterResponse> AssociateFraudsterAsync(AssociateFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFraudsterResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFraudsterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates a domain that contains all Amazon Connect Voice ID data, such as speakers,
        /// fraudsters, customer audio, and voiceprints. Every domain is created with a default
        /// watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWatchlist

        internal virtual CreateWatchlistResponse CreateWatchlist(CreateWatchlistRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWatchlistResponseUnmarshaller.Instance;

            return Invoke<CreateWatchlistResponse>(request, options);
        }



        /// <summary>
        /// Creates a watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateWatchlist">REST API Reference for CreateWatchlist Operation</seealso>
        public virtual Task<CreateWatchlistResponse> CreateWatchlistAsync(CreateWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWatchlistResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWatchlistResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified domain from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFraudster

        internal virtual DeleteFraudsterResponse DeleteFraudster(DeleteFraudsterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFraudsterResponseUnmarshaller.Instance;

            return Invoke<DeleteFraudsterResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified fraudster from Voice ID. This action disassociates the fraudster
        /// from any watchlists it is a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteFraudster">REST API Reference for DeleteFraudster Operation</seealso>
        public virtual Task<DeleteFraudsterResponse> DeleteFraudsterAsync(DeleteFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFraudsterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFraudsterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpeaker

        internal virtual DeleteSpeakerResponse DeleteSpeaker(DeleteSpeakerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpeakerResponseUnmarshaller.Instance;

            return Invoke<DeleteSpeakerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified speaker from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpeaker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteSpeaker">REST API Reference for DeleteSpeaker Operation</seealso>
        public virtual Task<DeleteSpeakerResponse> DeleteSpeakerAsync(DeleteSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpeakerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpeakerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWatchlist

        internal virtual DeleteWatchlistResponse DeleteWatchlist(DeleteWatchlistRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWatchlistResponseUnmarshaller.Instance;

            return Invoke<DeleteWatchlistResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified watchlist from Voice ID. This API throws an exception when there
        /// are fraudsters in the watchlist that you are trying to delete. You must delete the
        /// fraudsters, and then delete the watchlist. Every domain has a default watchlist which
        /// cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteWatchlist">REST API Reference for DeleteWatchlist Operation</seealso>
        public virtual Task<DeleteWatchlistResponse> DeleteWatchlistAsync(DeleteWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWatchlistResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWatchlistResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain

        internal virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFraudster

        internal virtual DescribeFraudsterResponse DescribeFraudster(DescribeFraudsterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFraudsterResponseUnmarshaller.Instance;

            return Invoke<DescribeFraudsterResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified fraudster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudster">REST API Reference for DescribeFraudster Operation</seealso>
        public virtual Task<DescribeFraudsterResponse> DescribeFraudsterAsync(DescribeFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFraudsterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFraudsterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFraudsterRegistrationJob

        internal virtual DescribeFraudsterRegistrationJobResponse DescribeFraudsterRegistrationJob(DescribeFraudsterRegistrationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFraudsterRegistrationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFraudsterRegistrationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeFraudsterRegistrationJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified fraudster registration job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudsterRegistrationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFraudsterRegistrationJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudsterRegistrationJob">REST API Reference for DescribeFraudsterRegistrationJob Operation</seealso>
        public virtual Task<DescribeFraudsterRegistrationJobResponse> DescribeFraudsterRegistrationJobAsync(DescribeFraudsterRegistrationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFraudsterRegistrationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFraudsterRegistrationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFraudsterRegistrationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpeaker

        internal virtual DescribeSpeakerResponse DescribeSpeaker(DescribeSpeakerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpeakerResponseUnmarshaller.Instance;

            return Invoke<DescribeSpeakerResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified speaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeaker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeaker">REST API Reference for DescribeSpeaker Operation</seealso>
        public virtual Task<DescribeSpeakerResponse> DescribeSpeakerAsync(DescribeSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpeakerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpeakerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpeakerEnrollmentJob

        internal virtual DescribeSpeakerEnrollmentJobResponse DescribeSpeakerEnrollmentJob(DescribeSpeakerEnrollmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpeakerEnrollmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpeakerEnrollmentJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSpeakerEnrollmentJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified speaker enrollment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeakerEnrollmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpeakerEnrollmentJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeakerEnrollmentJob">REST API Reference for DescribeSpeakerEnrollmentJob Operation</seealso>
        public virtual Task<DescribeSpeakerEnrollmentJobResponse> DescribeSpeakerEnrollmentJobAsync(DescribeSpeakerEnrollmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpeakerEnrollmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpeakerEnrollmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpeakerEnrollmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWatchlist

        internal virtual DescribeWatchlistResponse DescribeWatchlist(DescribeWatchlistRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWatchlistResponseUnmarshaller.Instance;

            return Invoke<DescribeWatchlistResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified watchlist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeWatchlist">REST API Reference for DescribeWatchlist Operation</seealso>
        public virtual Task<DescribeWatchlistResponse> DescribeWatchlistAsync(DescribeWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWatchlistResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWatchlistResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFraudster

        internal virtual DisassociateFraudsterResponse DisassociateFraudster(DisassociateFraudsterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFraudsterResponseUnmarshaller.Instance;

            return Invoke<DisassociateFraudsterResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the fraudsters from the watchlist specified. Voice ID always expects
        /// a fraudster to be a part of at least one watchlist. If you try to disassociate a fraudster
        /// from its only watchlist, a <code>ValidationException</code> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DisassociateFraudster">REST API Reference for DisassociateFraudster Operation</seealso>
        public virtual Task<DisassociateFraudsterResponse> DisassociateFraudsterAsync(DisassociateFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFraudsterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFraudsterResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFraudsterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EvaluateSession

        internal virtual EvaluateSessionResponse EvaluateSession(EvaluateSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateSessionResponseUnmarshaller.Instance;

            return Invoke<EvaluateSessionResponse>(request, options);
        }



        /// <summary>
        /// Evaluates a specified session based on audio data accumulated during a streaming Amazon
        /// Connect Voice ID call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateSession service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/EvaluateSession">REST API Reference for EvaluateSession Operation</seealso>
        public virtual Task<EvaluateSessionResponse> EvaluateSessionAsync(EvaluateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<EvaluateSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the domains in the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFraudsterRegistrationJobs

        internal virtual ListFraudsterRegistrationJobsResponse ListFraudsterRegistrationJobs(ListFraudsterRegistrationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFraudsterRegistrationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFraudsterRegistrationJobsResponseUnmarshaller.Instance;

            return Invoke<ListFraudsterRegistrationJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the fraudster registration jobs in the domain with the given <code>JobStatus</code>.
        /// If <code>JobStatus</code> is not provided, this lists all fraudster registration jobs
        /// in the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsterRegistrationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFraudsterRegistrationJobs service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsterRegistrationJobs">REST API Reference for ListFraudsterRegistrationJobs Operation</seealso>
        public virtual Task<ListFraudsterRegistrationJobsResponse> ListFraudsterRegistrationJobsAsync(ListFraudsterRegistrationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFraudsterRegistrationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFraudsterRegistrationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFraudsterRegistrationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFraudsters

        internal virtual ListFraudstersResponse ListFraudsters(ListFraudstersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFraudstersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFraudstersResponseUnmarshaller.Instance;

            return Invoke<ListFraudstersResponse>(request, options);
        }



        /// <summary>
        /// Lists all fraudsters in a specified watchlist or domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFraudsters service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsters">REST API Reference for ListFraudsters Operation</seealso>
        public virtual Task<ListFraudstersResponse> ListFraudstersAsync(ListFraudstersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFraudstersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFraudstersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFraudstersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpeakerEnrollmentJobs

        internal virtual ListSpeakerEnrollmentJobsResponse ListSpeakerEnrollmentJobs(ListSpeakerEnrollmentJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpeakerEnrollmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeakerEnrollmentJobsResponseUnmarshaller.Instance;

            return Invoke<ListSpeakerEnrollmentJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the speaker enrollment jobs in the domain with the specified <code>JobStatus</code>.
        /// If <code>JobStatus</code> is not provided, this lists all jobs with all possible speaker
        /// enrollment job statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakerEnrollmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpeakerEnrollmentJobs service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakerEnrollmentJobs">REST API Reference for ListSpeakerEnrollmentJobs Operation</seealso>
        public virtual Task<ListSpeakerEnrollmentJobsResponse> ListSpeakerEnrollmentJobsAsync(ListSpeakerEnrollmentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpeakerEnrollmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeakerEnrollmentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSpeakerEnrollmentJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpeakers

        internal virtual ListSpeakersResponse ListSpeakers(ListSpeakersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpeakersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeakersResponseUnmarshaller.Instance;

            return Invoke<ListSpeakersResponse>(request, options);
        }



        /// <summary>
        /// Lists all speakers in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpeakers service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakers">REST API Reference for ListSpeakers Operation</seealso>
        public virtual Task<ListSpeakersResponse> ListSpeakersAsync(ListSpeakersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpeakersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeakersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSpeakersResponse>(request, options, cancellationToken);
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
        /// Lists all tags associated with a specified Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWatchlists

        internal virtual ListWatchlistsResponse ListWatchlists(ListWatchlistsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWatchlistsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWatchlistsResponseUnmarshaller.Instance;

            return Invoke<ListWatchlistsResponse>(request, options);
        }



        /// <summary>
        /// Lists all watchlists in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWatchlists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWatchlists service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListWatchlists">REST API Reference for ListWatchlists Operation</seealso>
        public virtual Task<ListWatchlistsResponse> ListWatchlistsAsync(ListWatchlistsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWatchlistsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWatchlistsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWatchlistsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OptOutSpeaker

        internal virtual OptOutSpeakerResponse OptOutSpeaker(OptOutSpeakerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptOutSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptOutSpeakerResponseUnmarshaller.Instance;

            return Invoke<OptOutSpeakerResponse>(request, options);
        }



        /// <summary>
        /// Opts out a speaker from Voice ID. A speaker can be opted out regardless of whether
        /// or not they already exist in Voice ID. If they don't yet exist, a new speaker is created
        /// in an opted out state. If they already exist, their existing status is overridden
        /// and they are opted out. Enrollment and evaluation authentication requests are rejected
        /// for opted out speakers, and opted out speakers have no voice embeddings stored in
        /// Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptOutSpeaker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptOutSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/OptOutSpeaker">REST API Reference for OptOutSpeaker Operation</seealso>
        public virtual Task<OptOutSpeakerResponse> OptOutSpeakerAsync(OptOutSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptOutSpeakerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptOutSpeakerResponseUnmarshaller.Instance;

            return InvokeAsync<OptOutSpeakerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFraudsterRegistrationJob

        internal virtual StartFraudsterRegistrationJobResponse StartFraudsterRegistrationJob(StartFraudsterRegistrationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFraudsterRegistrationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFraudsterRegistrationJobResponseUnmarshaller.Instance;

            return Invoke<StartFraudsterRegistrationJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a new batch fraudster registration job using provided details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFraudsterRegistrationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFraudsterRegistrationJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartFraudsterRegistrationJob">REST API Reference for StartFraudsterRegistrationJob Operation</seealso>
        public virtual Task<StartFraudsterRegistrationJobResponse> StartFraudsterRegistrationJobAsync(StartFraudsterRegistrationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFraudsterRegistrationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFraudsterRegistrationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartFraudsterRegistrationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSpeakerEnrollmentJob

        internal virtual StartSpeakerEnrollmentJobResponse StartSpeakerEnrollmentJob(StartSpeakerEnrollmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSpeakerEnrollmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeakerEnrollmentJobResponseUnmarshaller.Instance;

            return Invoke<StartSpeakerEnrollmentJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a new batch speaker enrollment job using specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerEnrollmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSpeakerEnrollmentJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartSpeakerEnrollmentJob">REST API Reference for StartSpeakerEnrollmentJob Operation</seealso>
        public virtual Task<StartSpeakerEnrollmentJobResponse> StartSpeakerEnrollmentJobAsync(StartSpeakerEnrollmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSpeakerEnrollmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeakerEnrollmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartSpeakerEnrollmentJobResponse>(request, options, cancellationToken);
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
        /// Tags a Voice ID resource with the provided list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes specified tags from a specified Amazon Connect Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomain

        internal virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified domain. This API has clobber behavior, and clears and replaces
        /// all attributes. If an optional field, such as 'Description' is not provided, it is
        /// removed from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWatchlist

        internal virtual UpdateWatchlistResponse UpdateWatchlist(UpdateWatchlistRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWatchlistResponseUnmarshaller.Instance;

            return Invoke<UpdateWatchlistResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified watchlist. Every domain has a default watchlist which cannot
        /// be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateWatchlist">REST API Reference for UpdateWatchlist Operation</seealso>
        public virtual Task<UpdateWatchlistResponse> UpdateWatchlistAsync(UpdateWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWatchlistRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWatchlistResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWatchlistResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}