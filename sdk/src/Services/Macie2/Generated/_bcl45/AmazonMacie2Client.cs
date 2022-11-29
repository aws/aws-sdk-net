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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Macie2.Model;
using Amazon.Macie2.Model.Internal.MarshallTransformations;
using Amazon.Macie2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Macie2
{
    /// <summary>
    /// Implementation for accessing Macie2
    ///
    /// Amazon Macie
    /// </summary>
    public partial class AmazonMacie2Client : AmazonServiceClient, IAmazonMacie2
    {
        private static IServiceMetadata serviceMetadata = new AmazonMacie2Metadata();
        private IMacie2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMacie2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Macie2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonMacie2Client with the credentials loaded from the application's
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
        public AmazonMacie2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacie2Config()) { }

        /// <summary>
        /// Constructs AmazonMacie2Client with the credentials loaded from the application's
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
        public AmazonMacie2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacie2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMacie2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMacie2Client Configuration Object</param>
        public AmazonMacie2Client(AmazonMacie2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMacie2Client(AWSCredentials credentials)
            : this(credentials, new AmazonMacie2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacie2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMacie2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Credentials and an
        /// AmazonMacie2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMacie2Client Configuration Object</param>
        public AmazonMacie2Client(AWSCredentials credentials, AmazonMacie2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacie2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacie2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacie2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMacie2Client Configuration Object</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonMacie2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacie2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacie2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacie2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacie2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMacie2Client Configuration Object</param>
        public AmazonMacie2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMacie2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMacie2EndpointResolver());
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


        #region  AcceptInvitation


        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationResponse>(request, options);
        }


        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetCustomDataIdentifiers


        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the BatchGetCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        public virtual BatchGetCustomDataIdentifiersResponse BatchGetCustomDataIdentifiers(BatchGetCustomDataIdentifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCustomDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCustomDataIdentifiersResponseUnmarshaller.Instance;

            return Invoke<BatchGetCustomDataIdentifiersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        public virtual Task<BatchGetCustomDataIdentifiersResponse> BatchGetCustomDataIdentifiersAsync(BatchGetCustomDataIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCustomDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCustomDataIdentifiersResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetCustomDataIdentifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAllowList


        /// <summary>
        /// Creates and defines the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList service method.</param>
        /// 
        /// <returns>The response from the CreateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        public virtual CreateAllowListResponse CreateAllowList(CreateAllowListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAllowListResponseUnmarshaller.Instance;

            return Invoke<CreateAllowListResponse>(request, options);
        }


        /// <summary>
        /// Creates and defines the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        public virtual Task<CreateAllowListResponse> CreateAllowListAsync(CreateAllowListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAllowListResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAllowListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClassificationJob


        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
        /// 
        /// <returns>The response from the CreateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        public virtual CreateClassificationJobResponse CreateClassificationJob(CreateClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassificationJobResponseUnmarshaller.Instance;

            return Invoke<CreateClassificationJobResponse>(request, options);
        }


        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        public virtual Task<CreateClassificationJobResponse> CreateClassificationJobAsync(CreateClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassificationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomDataIdentifier


        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the CreateCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        public virtual CreateCustomDataIdentifierResponse CreateCustomDataIdentifier(CreateCustomDataIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDataIdentifierResponseUnmarshaller.Instance;

            return Invoke<CreateCustomDataIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        public virtual Task<CreateCustomDataIdentifierResponse> CreateCustomDataIdentifierAsync(CreateCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDataIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomDataIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFindingsFilter


        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        public virtual CreateFindingsFilterResponse CreateFindingsFilter(CreateFindingsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingsFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFindingsFilterResponse>(request, options);
        }


        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        public virtual Task<CreateFindingsFilterResponse> CreateFindingsFilterAsync(CreateFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingsFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFindingsFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInvitations


        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
        /// 
        /// <returns>The response from the CreateInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        public virtual CreateInvitationsResponse CreateInvitations(CreateInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvitationsResponseUnmarshaller.Instance;

            return Invoke<CreateInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        public virtual Task<CreateInvitationsResponse> CreateInvitationsAsync(CreateInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMember


        /// <summary>
        /// Associates an account with an Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        public virtual CreateMemberResponse CreateMember(CreateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemberResponseUnmarshaller.Instance;

            return Invoke<CreateMemberResponse>(request, options);
        }


        /// <summary>
        /// Associates an account with an Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        public virtual Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSampleFindings


        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSampleFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return Invoke<CreateSampleFindingsResponse>(request, options);
        }


        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSampleFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSampleFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeclineInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAllowList


        /// <summary>
        /// Deletes an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList service method.</param>
        /// 
        /// <returns>The response from the DeleteAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        public virtual DeleteAllowListResponse DeleteAllowList(DeleteAllowListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAllowListResponseUnmarshaller.Instance;

            return Invoke<DeleteAllowListResponse>(request, options);
        }


        /// <summary>
        /// Deletes an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        public virtual Task<DeleteAllowListResponse> DeleteAllowListAsync(DeleteAllowListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAllowListResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAllowListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomDataIdentifier


        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        public virtual DeleteCustomDataIdentifierResponse DeleteCustomDataIdentifier(DeleteCustomDataIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDataIdentifierResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomDataIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        public virtual Task<DeleteCustomDataIdentifierResponse> DeleteCustomDataIdentifierAsync(DeleteCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDataIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomDataIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFindingsFilter


        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        public virtual DeleteFindingsFilterResponse DeleteFindingsFilter(DeleteFindingsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingsFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFindingsFilterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        public virtual Task<DeleteFindingsFilterResponse> DeleteFindingsFilterAsync(DeleteFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingsFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFindingsFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMember


        /// <summary>
        /// Deletes the association between an Amazon Macie administrator account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return Invoke<DeleteMemberResponse>(request, options);
        }


        /// <summary>
        /// Deletes the association between an Amazon Macie administrator account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBuckets


        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
        /// 
        /// <returns>The response from the DescribeBuckets service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        public virtual DescribeBucketsResponse DescribeBuckets(DescribeBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBucketsResponseUnmarshaller.Instance;

            return Invoke<DescribeBucketsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuckets service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        public virtual Task<DescribeBucketsResponse> DescribeBucketsAsync(DescribeBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBucketsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClassificationJob


        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        public virtual DescribeClassificationJobResponse DescribeClassificationJob(DescribeClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassificationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeClassificationJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        public virtual Task<DescribeClassificationJobResponse> DescribeClassificationJobAsync(DescribeClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassificationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableMacie


        /// <summary>
        /// Disables Amazon Macie and deletes all settings and resources for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
        /// 
        /// <returns>The response from the DisableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        public virtual DisableMacieResponse DisableMacie(DisableMacieRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMacieRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMacieResponseUnmarshaller.Instance;

            return Invoke<DisableMacieResponse>(request, options);
        }


        /// <summary>
        /// Disables Amazon Macie and deletes all settings and resources for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        public virtual Task<DisableMacieResponse> DisableMacieAsync(DisableMacieRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMacieRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMacieResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableMacieResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableOrganizationAdminAccount


        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromAdministratorAccount


        /// <summary>
        /// Disassociates a member account from its Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromAdministratorAccountResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member account from its Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual Task<DisassociateFromAdministratorAccountResponse> DisassociateFromAdministratorAccountAsync(DisassociateFromAdministratorAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateFromAdministratorAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// (Deprecated) Disassociates a member account from its Amazon Macie administrator account.
        /// This operation has been replaced by the <link  linkend="DisassociateFromAdministratorAccount">DisassociateFromAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountResponse>(request, options);
        }


        /// <summary>
        /// (Deprecated) Disassociates a member account from its Amazon Macie administrator account.
        /// This operation has been replaced by the <link  linkend="DisassociateFromAdministratorAccount">DisassociateFromAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateFromMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMember


        /// <summary>
        /// Disassociates an Amazon Macie administrator account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        public virtual DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberResponse>(request, options);
        }


        /// <summary>
        /// Disassociates an Amazon Macie administrator account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        public virtual Task<DisassociateMemberResponse> DisassociateMemberAsync(DisassociateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableMacie


        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
        /// 
        /// <returns>The response from the EnableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        public virtual EnableMacieResponse EnableMacie(EnableMacieRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMacieRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMacieResponseUnmarshaller.Instance;

            return Invoke<EnableMacieResponse>(request, options);
        }


        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        public virtual Task<EnableMacieResponse> EnableMacieAsync(EnableMacieRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMacieRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMacieResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableMacieResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableOrganizationAdminAccount


        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<EnableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAdministratorAccount


        /// <summary>
        /// Retrieves information about the Amazon Macie administrator account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdministratorAccountResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the Amazon Macie administrator account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual Task<GetAdministratorAccountResponse> GetAdministratorAccountAsync(GetAdministratorAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAdministratorAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAllowList


        /// <summary>
        /// Retrieves the settings and status of an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList service method.</param>
        /// 
        /// <returns>The response from the GetAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        public virtual GetAllowListResponse GetAllowList(GetAllowListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllowListResponseUnmarshaller.Instance;

            return Invoke<GetAllowListResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the settings and status of an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        public virtual Task<GetAllowListResponse> GetAllowListAsync(GetAllowListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllowListResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAllowListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedDiscoveryConfiguration


        /// <summary>
        /// Retrieves the configuration settings and status of automated sensitive data discovery
        /// for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        public virtual GetAutomatedDiscoveryConfigurationResponse GetAutomatedDiscoveryConfiguration(GetAutomatedDiscoveryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomatedDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedDiscoveryConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration settings and status of automated sensitive data discovery
        /// for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        public virtual Task<GetAutomatedDiscoveryConfigurationResponse> GetAutomatedDiscoveryConfigurationAsync(GetAutomatedDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomatedDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedDiscoveryConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketStatistics


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about all the S3 buckets that Amazon
        /// Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
        /// 
        /// <returns>The response from the GetBucketStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        public virtual GetBucketStatisticsResponse GetBucketStatistics(GetBucketStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetBucketStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about all the S3 buckets that Amazon
        /// Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        public virtual Task<GetBucketStatisticsResponse> GetBucketStatisticsAsync(GetBucketStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBucketStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClassificationExportConfiguration


        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        public virtual GetClassificationExportConfigurationResponse GetClassificationExportConfiguration(GetClassificationExportConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassificationExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassificationExportConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetClassificationExportConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        public virtual Task<GetClassificationExportConfigurationResponse> GetClassificationExportConfigurationAsync(GetClassificationExportConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassificationExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassificationExportConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClassificationExportConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClassificationScope


        /// <summary>
        /// Retrieves the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope service method.</param>
        /// 
        /// <returns>The response from the GetClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        public virtual GetClassificationScopeResponse GetClassificationScope(GetClassificationScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassificationScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassificationScopeResponseUnmarshaller.Instance;

            return Invoke<GetClassificationScopeResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        public virtual Task<GetClassificationScopeResponse> GetClassificationScopeAsync(GetClassificationScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassificationScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassificationScopeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClassificationScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomDataIdentifier


        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        public virtual GetCustomDataIdentifierResponse GetCustomDataIdentifier(GetCustomDataIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDataIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetCustomDataIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        public virtual Task<GetCustomDataIdentifierResponse> GetCustomDataIdentifierAsync(GetCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomDataIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCustomDataIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsFilter


        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the GetFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        public virtual GetFindingsFilterResponse GetFindingsFilter(GetFindingsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsFilterResponseUnmarshaller.Instance;

            return Invoke<GetFindingsFilterResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        public virtual Task<GetFindingsFilterResponse> GetFindingsFilterAsync(GetFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsPublicationConfiguration


        /// <summary>
        /// Retrieves the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        public virtual GetFindingsPublicationConfigurationResponse GetFindingsPublicationConfiguration(GetFindingsPublicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsPublicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsPublicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFindingsPublicationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        public virtual Task<GetFindingsPublicationConfigurationResponse> GetFindingsPublicationConfigurationAsync(GetFindingsPublicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsPublicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsPublicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsPublicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingStatistics


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        public virtual GetFindingStatisticsResponse GetFindingStatistics(GetFindingStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetFindingStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        public virtual Task<GetFindingStatisticsResponse> GetFindingStatisticsAsync(GetFindingStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInvitationsCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMacieSession


        /// <summary>
        /// Retrieves the status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
        /// 
        /// <returns>The response from the GetMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        public virtual GetMacieSessionResponse GetMacieSession(GetMacieSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMacieSessionResponseUnmarshaller.Instance;

            return Invoke<GetMacieSessionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        public virtual Task<GetMacieSessionResponse> GetMacieSessionAsync(GetMacieSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMacieSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMacieSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// (Deprecated) Retrieves information about the Amazon Macie administrator account for
        /// an account. This operation has been replaced by the <link  linkend="GetAdministratorAccount">GetAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountResponse>(request, options);
        }


        /// <summary>
        /// (Deprecated) Retrieves information about the Amazon Macie administrator account for
        /// an account. This operation has been replaced by the <link  linkend="GetAdministratorAccount">GetAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMember


        /// <summary>
        /// Retrieves information about an account that's associated with an Amazon Macie administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual GetMemberResponse GetMember(GetMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;

            return Invoke<GetMemberResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an account that's associated with an Amazon Macie administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceProfile


        /// <summary>
        /// Retrieves (queries) sensitive data discovery statistics and the sensitivity score
        /// for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile service method.</param>
        /// 
        /// <returns>The response from the GetResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        public virtual GetResourceProfileResponse GetResourceProfile(GetResourceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceProfileResponseUnmarshaller.Instance;

            return Invoke<GetResourceProfileResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) sensitive data discovery statistics and the sensitivity score
        /// for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        public virtual Task<GetResourceProfileResponse> GetResourceProfileAsync(GetResourceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRevealConfiguration


        /// <summary>
        /// Retrieves the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        public virtual GetRevealConfigurationResponse GetRevealConfiguration(GetRevealConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevealConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevealConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRevealConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        public virtual Task<GetRevealConfigurationResponse> GetRevealConfigurationAsync(GetRevealConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevealConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevealConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRevealConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSensitiveDataOccurrences


        /// <summary>
        /// Retrieves occurrences of sensitive data reported by a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences service method.</param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrences service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.UnprocessableEntityException">
        /// Provides information about an error that occurred due to an unprocessable entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        public virtual GetSensitiveDataOccurrencesResponse GetSensitiveDataOccurrences(GetSensitiveDataOccurrencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitiveDataOccurrencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitiveDataOccurrencesResponseUnmarshaller.Instance;

            return Invoke<GetSensitiveDataOccurrencesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves occurrences of sensitive data reported by a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrences service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.UnprocessableEntityException">
        /// Provides information about an error that occurred due to an unprocessable entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        public virtual Task<GetSensitiveDataOccurrencesResponse> GetSensitiveDataOccurrencesAsync(GetSensitiveDataOccurrencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitiveDataOccurrencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitiveDataOccurrencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSensitiveDataOccurrencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSensitiveDataOccurrencesAvailability


        /// <summary>
        /// Checks whether occurrences of sensitive data can be retrieved for a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability service method.</param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrencesAvailability service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        public virtual GetSensitiveDataOccurrencesAvailabilityResponse GetSensitiveDataOccurrencesAvailability(GetSensitiveDataOccurrencesAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitiveDataOccurrencesAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitiveDataOccurrencesAvailabilityResponseUnmarshaller.Instance;

            return Invoke<GetSensitiveDataOccurrencesAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Checks whether occurrences of sensitive data can be retrieved for a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrencesAvailability service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        public virtual Task<GetSensitiveDataOccurrencesAvailabilityResponse> GetSensitiveDataOccurrencesAvailabilityAsync(GetSensitiveDataOccurrencesAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitiveDataOccurrencesAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitiveDataOccurrencesAvailabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSensitiveDataOccurrencesAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSensitivityInspectionTemplate


        /// <summary>
        /// Retrieves the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate service method.</param>
        /// 
        /// <returns>The response from the GetSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        public virtual GetSensitivityInspectionTemplateResponse GetSensitivityInspectionTemplate(GetSensitivityInspectionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitivityInspectionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitivityInspectionTemplateResponseUnmarshaller.Instance;

            return Invoke<GetSensitivityInspectionTemplateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        public virtual Task<GetSensitivityInspectionTemplateResponse> GetSensitivityInspectionTemplateAsync(GetSensitivityInspectionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSensitivityInspectionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSensitivityInspectionTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSensitivityInspectionTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUsageStatistics


        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// 
        /// <returns>The response from the GetUsageStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        public virtual GetUsageStatisticsResponse GetUsageStatistics(GetUsageStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetUsageStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        public virtual Task<GetUsageStatisticsResponse> GetUsageStatisticsAsync(GetUsageStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUsageStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUsageTotals


        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
        /// 
        /// <returns>The response from the GetUsageTotals service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        public virtual GetUsageTotalsResponse GetUsageTotals(GetUsageTotalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageTotalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageTotalsResponseUnmarshaller.Instance;

            return Invoke<GetUsageTotalsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageTotals service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        public virtual Task<GetUsageTotalsResponse> GetUsageTotalsAsync(GetUsageTotalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageTotalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageTotalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUsageTotalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAllowLists


        /// <summary>
        /// Retrieves a subset of information about all the allow lists for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists service method.</param>
        /// 
        /// <returns>The response from the ListAllowLists service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        public virtual ListAllowListsResponse ListAllowLists(ListAllowListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowListsResponseUnmarshaller.Instance;

            return Invoke<ListAllowListsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about all the allow lists for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAllowLists service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        public virtual Task<ListAllowListsResponse> ListAllowListsAsync(ListAllowListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowListsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAllowListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClassificationJobs


        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
        /// 
        /// <returns>The response from the ListClassificationJobs service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        public virtual ListClassificationJobsResponse ListClassificationJobs(ListClassificationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClassificationJobsResponseUnmarshaller.Instance;

            return Invoke<ListClassificationJobsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClassificationJobs service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        public virtual Task<ListClassificationJobsResponse> ListClassificationJobsAsync(ListClassificationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClassificationJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClassificationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClassificationScopes


        /// <summary>
        /// Retrieves a subset of information about the classification scope for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes service method.</param>
        /// 
        /// <returns>The response from the ListClassificationScopes service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        public virtual ListClassificationScopesResponse ListClassificationScopes(ListClassificationScopesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClassificationScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClassificationScopesResponseUnmarshaller.Instance;

            return Invoke<ListClassificationScopesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about the classification scope for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClassificationScopes service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        public virtual Task<ListClassificationScopesResponse> ListClassificationScopesAsync(ListClassificationScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClassificationScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClassificationScopesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClassificationScopesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomDataIdentifiers


        /// <summary>
        /// Retrieves a subset of information about all the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        public virtual ListCustomDataIdentifiersResponse ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDataIdentifiersResponseUnmarshaller.Instance;

            return Invoke<ListCustomDataIdentifiersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about all the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        public virtual Task<ListCustomDataIdentifiersResponse> ListCustomDataIdentifiersAsync(ListCustomDataIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomDataIdentifiersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomDataIdentifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindingsFilters


        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
        /// 
        /// <returns>The response from the ListFindingsFilters service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        public virtual ListFindingsFiltersResponse ListFindingsFilters(ListFindingsFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFindingsFiltersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingsFilters service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        public virtual Task<ListFindingsFiltersResponse> ListFindingsFiltersAsync(ListFindingsFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsFiltersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingsFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Retrieves information about the Amazon Macie membership invitations that were received
        /// by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the Amazon Macie membership invitations that were received
        /// by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedDataIdentifiers


        /// <summary>
        /// Retrieves information about all the managed data identifiers that Amazon Macie currently
        /// provides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListManagedDataIdentifiers service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        public virtual ListManagedDataIdentifiersResponse ListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedDataIdentifiersResponseUnmarshaller.Instance;

            return Invoke<ListManagedDataIdentifiersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about all the managed data identifiers that Amazon Macie currently
        /// provides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedDataIdentifiers service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        public virtual Task<ListManagedDataIdentifiersResponse> ListManagedDataIdentifiersAsync(ListManagedDataIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedDataIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedDataIdentifiersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedDataIdentifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationAdminAccounts


        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationAdminAccountsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual Task<ListOrganizationAdminAccountsResponse> ListOrganizationAdminAccountsAsync(ListOrganizationAdminAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationAdminAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceProfileArtifacts


        /// <summary>
        /// Retrieves information about objects that were selected from an S3 bucket for automated
        /// sensitive data discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListResourceProfileArtifacts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        public virtual ListResourceProfileArtifactsResponse ListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceProfileArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceProfileArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListResourceProfileArtifactsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about objects that were selected from an S3 bucket for automated
        /// sensitive data discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceProfileArtifacts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        public virtual Task<ListResourceProfileArtifactsResponse> ListResourceProfileArtifactsAsync(ListResourceProfileArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceProfileArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceProfileArtifactsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourceProfileArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceProfileDetections


        /// <summary>
        /// Retrieves information about the types and amount of sensitive data that Amazon Macie
        /// found in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections service method.</param>
        /// 
        /// <returns>The response from the ListResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        public virtual ListResourceProfileDetectionsResponse ListResourceProfileDetections(ListResourceProfileDetectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceProfileDetectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceProfileDetectionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceProfileDetectionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the types and amount of sensitive data that Amazon Macie
        /// found in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        public virtual Task<ListResourceProfileDetectionsResponse> ListResourceProfileDetectionsAsync(ListResourceProfileDetectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceProfileDetectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceProfileDetectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourceProfileDetectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSensitivityInspectionTemplates


        /// <summary>
        /// Retrieves a subset of information about the sensitivity inspection template for an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates service method.</param>
        /// 
        /// <returns>The response from the ListSensitivityInspectionTemplates service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        public virtual ListSensitivityInspectionTemplatesResponse ListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSensitivityInspectionTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensitivityInspectionTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListSensitivityInspectionTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a subset of information about the sensitivity inspection template for an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSensitivityInspectionTemplates service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        public virtual Task<ListSensitivityInspectionTemplatesResponse> ListSensitivityInspectionTemplatesAsync(ListSensitivityInspectionTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSensitivityInspectionTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensitivityInspectionTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSensitivityInspectionTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutClassificationExportConfiguration


        /// <summary>
        /// Creates or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        public virtual PutClassificationExportConfigurationResponse PutClassificationExportConfiguration(PutClassificationExportConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutClassificationExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClassificationExportConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutClassificationExportConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        public virtual Task<PutClassificationExportConfigurationResponse> PutClassificationExportConfigurationAsync(PutClassificationExportConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutClassificationExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClassificationExportConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutClassificationExportConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFindingsPublicationConfiguration


        /// <summary>
        /// Updates the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        public virtual PutFindingsPublicationConfigurationResponse PutFindingsPublicationConfiguration(PutFindingsPublicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFindingsPublicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFindingsPublicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutFindingsPublicationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        public virtual Task<PutFindingsPublicationConfigurationResponse> PutFindingsPublicationConfigurationAsync(PutFindingsPublicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFindingsPublicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFindingsPublicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutFindingsPublicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchResources


        /// <summary>
        /// Retrieves (queries) statistical data and other information about Amazon Web Services
        /// resources that Amazon Macie monitors and analyzes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        public virtual SearchResourcesResponse SearchResources(SearchResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResourcesResponseUnmarshaller.Instance;

            return Invoke<SearchResourcesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves (queries) statistical data and other information about Amazon Web Services
        /// resources that Amazon Macie monitors and analyzes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        public virtual Task<SearchResourcesResponse> SearchResourcesAsync(SearchResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with an Amazon
        /// Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with an Amazon
        /// Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestCustomDataIdentifier


        /// <summary>
        /// Tests a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the TestCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        public virtual TestCustomDataIdentifierResponse TestCustomDataIdentifier(TestCustomDataIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestCustomDataIdentifierResponseUnmarshaller.Instance;

            return Invoke<TestCustomDataIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Tests a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        public virtual Task<TestCustomDataIdentifierResponse> TestCustomDataIdentifierAsync(TestCustomDataIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestCustomDataIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestCustomDataIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestCustomDataIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAllowList


        /// <summary>
        /// Updates the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList service method.</param>
        /// 
        /// <returns>The response from the UpdateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        public virtual UpdateAllowListResponse UpdateAllowList(UpdateAllowListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAllowListResponseUnmarshaller.Instance;

            return Invoke<UpdateAllowListResponse>(request, options);
        }


        /// <summary>
        /// Updates the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        public virtual Task<UpdateAllowListResponse> UpdateAllowListAsync(UpdateAllowListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAllowListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAllowListResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAllowListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutomatedDiscoveryConfiguration


        /// <summary>
        /// Enables or disables automated sensitive data discovery for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        public virtual UpdateAutomatedDiscoveryConfigurationResponse UpdateAutomatedDiscoveryConfiguration(UpdateAutomatedDiscoveryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedDiscoveryConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Enables or disables automated sensitive data discovery for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        public virtual Task<UpdateAutomatedDiscoveryConfigurationResponse> UpdateAutomatedDiscoveryConfigurationAsync(UpdateAutomatedDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedDiscoveryConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutomatedDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClassificationJob


        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        public virtual UpdateClassificationJobResponse UpdateClassificationJob(UpdateClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassificationJobResponseUnmarshaller.Instance;

            return Invoke<UpdateClassificationJobResponse>(request, options);
        }


        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        public virtual Task<UpdateClassificationJobResponse> UpdateClassificationJobAsync(UpdateClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassificationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClassificationScope


        /// <summary>
        /// Updates the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope service method.</param>
        /// 
        /// <returns>The response from the UpdateClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        public virtual UpdateClassificationScopeResponse UpdateClassificationScope(UpdateClassificationScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassificationScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassificationScopeResponseUnmarshaller.Instance;

            return Invoke<UpdateClassificationScopeResponse>(request, options);
        }


        /// <summary>
        /// Updates the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        public virtual Task<UpdateClassificationScopeResponse> UpdateClassificationScopeAsync(UpdateClassificationScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassificationScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassificationScopeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClassificationScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindingsFilter


        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        public virtual UpdateFindingsFilterResponse UpdateFindingsFilter(UpdateFindingsFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsFilterResponse>(request, options);
        }


        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        public virtual Task<UpdateFindingsFilterResponse> UpdateFindingsFilterAsync(UpdateFindingsFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFindingsFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMacieSession


        /// <summary>
        /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
        /// 
        /// <returns>The response from the UpdateMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        public virtual UpdateMacieSessionResponse UpdateMacieSession(UpdateMacieSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMacieSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateMacieSessionResponse>(request, options);
        }


        /// <summary>
        /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        public virtual Task<UpdateMacieSessionResponse> UpdateMacieSessionAsync(UpdateMacieSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMacieSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMacieSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMemberSession


        /// <summary>
        /// Enables an Amazon Macie administrator to suspend or re-enable Macie for a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
        /// 
        /// <returns>The response from the UpdateMemberSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        public virtual UpdateMemberSessionResponse UpdateMemberSession(UpdateMemberSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMemberSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemberSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateMemberSessionResponse>(request, options);
        }


        /// <summary>
        /// Enables an Amazon Macie administrator to suspend or re-enable Macie for a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMemberSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        public virtual Task<UpdateMemberSessionResponse> UpdateMemberSessionAsync(UpdateMemberSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMemberSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemberSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMemberSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceProfile


        /// <summary>
        /// Updates the sensitivity score for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        public virtual UpdateResourceProfileResponse UpdateResourceProfile(UpdateResourceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates the sensitivity score for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        public virtual Task<UpdateResourceProfileResponse> UpdateResourceProfileAsync(UpdateResourceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResourceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceProfileDetections


        /// <summary>
        /// Updates the sensitivity scoring settings for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        public virtual UpdateResourceProfileDetectionsResponse UpdateResourceProfileDetections(UpdateResourceProfileDetectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceProfileDetectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceProfileDetectionsResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceProfileDetectionsResponse>(request, options);
        }


        /// <summary>
        /// Updates the sensitivity scoring settings for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        public virtual Task<UpdateResourceProfileDetectionsResponse> UpdateResourceProfileDetectionsAsync(UpdateResourceProfileDetectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceProfileDetectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceProfileDetectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResourceProfileDetectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRevealConfiguration


        /// <summary>
        /// Updates the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        public virtual UpdateRevealConfigurationResponse UpdateRevealConfiguration(UpdateRevealConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevealConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevealConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRevealConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        public virtual Task<UpdateRevealConfigurationResponse> UpdateRevealConfigurationAsync(UpdateRevealConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevealConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevealConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRevealConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSensitivityInspectionTemplate


        /// <summary>
        /// Updates the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        public virtual UpdateSensitivityInspectionTemplateResponse UpdateSensitivityInspectionTemplate(UpdateSensitivityInspectionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSensitivityInspectionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSensitivityInspectionTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateSensitivityInspectionTemplateResponse>(request, options);
        }


        /// <summary>
        /// Updates the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        public virtual Task<UpdateSensitivityInspectionTemplateResponse> UpdateSensitivityInspectionTemplateAsync(UpdateSensitivityInspectionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSensitivityInspectionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSensitivityInspectionTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSensitivityInspectionTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}