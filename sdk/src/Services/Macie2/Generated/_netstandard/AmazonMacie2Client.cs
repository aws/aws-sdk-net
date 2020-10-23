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
    /// Amazon Macie is a fully managed data security and data privacy service that uses machine
    /// learning and pattern matching to discover and protect your sensitive data in AWS.
    /// Macie automates the discovery of sensitive data, such as PII and intellectual property,
    /// to provide you with insight into the data that your organization stores in AWS. Macie
    /// also provides an inventory of your Amazon S3 buckets, which it continually monitors
    /// for you. If Macie detects sensitive data or potential data access issues, it generates
    /// detailed findings for you to review and act upon as necessary.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonMacie2Client : AmazonServiceClient, IAmazonMacie2
    {
        private static IServiceMetadata serviceMetadata = new AmazonMacie2Metadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
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

        internal virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
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

        internal virtual BatchGetCustomDataIdentifiersResponse BatchGetCustomDataIdentifiers(BatchGetCustomDataIdentifiersRequest request)
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
        
        #region  CreateClassificationJob

        internal virtual CreateClassificationJobResponse CreateClassificationJob(CreateClassificationJobRequest request)
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

        internal virtual CreateCustomDataIdentifierResponse CreateCustomDataIdentifier(CreateCustomDataIdentifierRequest request)
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

        internal virtual CreateFindingsFilterResponse CreateFindingsFilter(CreateFindingsFilterRequest request)
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

        internal virtual CreateInvitationsResponse CreateInvitations(CreateInvitationsRequest request)
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

        internal virtual CreateMemberResponse CreateMember(CreateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemberResponseUnmarshaller.Instance;

            return Invoke<CreateMemberResponse>(request, options);
        }



        /// <summary>
        /// Associates an account with an Amazon Macie master account.
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

        internal virtual CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request)
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

        internal virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
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
        
        #region  DeleteCustomDataIdentifier

        internal virtual DeleteCustomDataIdentifierResponse DeleteCustomDataIdentifier(DeleteCustomDataIdentifierRequest request)
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

        internal virtual DeleteFindingsFilterResponse DeleteFindingsFilter(DeleteFindingsFilterRequest request)
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

        internal virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
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

        internal virtual DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return Invoke<DeleteMemberResponse>(request, options);
        }



        /// <summary>
        /// Deletes the association between an Amazon Macie master account and an account.
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

        internal virtual DescribeBucketsResponse DescribeBuckets(DescribeBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBucketsResponseUnmarshaller.Instance;

            return Invoke<DescribeBucketsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes.
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

        internal virtual DescribeClassificationJobResponse DescribeClassificationJob(DescribeClassificationJobRequest request)
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

        internal virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an AWS organization.
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

        internal virtual DisableMacieResponse DisableMacie(DisableMacieRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMacieRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMacieResponseUnmarshaller.Instance;

            return Invoke<DisableMacieResponse>(request, options);
        }



        /// <summary>
        /// Disables an Amazon Macie account and deletes Macie resources for the account.
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

        internal virtual DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisableOrganizationAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an AWS
        /// organization.
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
        
        #region  DisassociateFromMasterAccount

        internal virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a member account from its Amazon Macie master account.
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

        internal virtual DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an Amazon Macie master account from a member account.
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

        internal virtual EnableMacieResponse EnableMacie(EnableMacieRequest request)
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

        internal virtual EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<EnableOrganizationAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an AWS
        /// organization.
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
        
        #region  GetBucketStatistics

        internal virtual GetBucketStatisticsResponse GetBucketStatistics(GetBucketStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetBucketStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves (queries) aggregated statistical data for all the S3 buckets that Amazon
        /// Macie monitors and analyzes.
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

        internal virtual GetClassificationExportConfigurationResponse GetClassificationExportConfiguration(GetClassificationExportConfigurationRequest request)
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
        
        #region  GetCustomDataIdentifier

        internal virtual GetCustomDataIdentifierResponse GetCustomDataIdentifier(GetCustomDataIdentifierRequest request)
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

        internal virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
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

        internal virtual GetFindingsFilterResponse GetFindingsFilter(GetFindingsFilterRequest request)
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
        
        #region  GetFindingStatistics

        internal virtual GetFindingStatisticsResponse GetFindingStatistics(GetFindingStatisticsRequest request)
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

        internal virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
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

        internal virtual GetMacieSessionResponse GetMacieSession(GetMacieSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMacieSessionResponseUnmarshaller.Instance;

            return Invoke<GetMacieSessionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current status and configuration settings for an Amazon Macie account.
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

        internal virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the Amazon Macie master account for an account.
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

        internal virtual GetMemberResponse GetMember(GetMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;

            return Invoke<GetMemberResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a member account that's associated with an Amazon Macie
        /// master account.
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
        
        #region  GetUsageStatistics

        internal virtual GetUsageStatisticsResponse GetUsageStatistics(GetUsageStatisticsRequest request)
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

        internal virtual GetUsageTotalsResponse GetUsageTotals(GetUsageTotalsRequest request)
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
        
        #region  ListClassificationJobs

        internal virtual ListClassificationJobsResponse ListClassificationJobs(ListClassificationJobsRequest request)
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
        
        #region  ListCustomDataIdentifiers

        internal virtual ListCustomDataIdentifiersResponse ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request)
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

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
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

        internal virtual ListFindingsFiltersResponse ListFindingsFilters(ListFindingsFiltersRequest request)
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

        internal virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about all the Amazon Macie membership invitations that were
        /// received by an account.
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
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// master account.
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

        internal virtual ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationAdminAccountsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// AWS organization.
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
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with a classification job,
        /// custom data identifier, findings filter, or member account.
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

        internal virtual PutClassificationExportConfigurationResponse PutClassificationExportConfiguration(PutClassificationExportConfigurationRequest request)
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
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with a classification
        /// job, custom data identifier, findings filter, or member account.
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

        internal virtual TestCustomDataIdentifierResponse TestCustomDataIdentifier(TestCustomDataIdentifierRequest request)
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

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags (keys and values) from a classification job, custom data
        /// identifier, findings filter, or member account.
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
        
        #region  UpdateClassificationJob

        internal virtual UpdateClassificationJobResponse UpdateClassificationJob(UpdateClassificationJobRequest request)
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
        
        #region  UpdateFindingsFilter

        internal virtual UpdateFindingsFilterResponse UpdateFindingsFilter(UpdateFindingsFilterRequest request)
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

        internal virtual UpdateMacieSessionResponse UpdateMacieSession(UpdateMacieSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMacieSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMacieSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateMacieSessionResponse>(request, options);
        }



        /// <summary>
        /// Suspends or re-enables an Amazon Macie account, or updates the configuration settings
        /// for a Macie account.
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

        internal virtual UpdateMemberSessionResponse UpdateMemberSession(UpdateMemberSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMemberSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemberSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateMemberSessionResponse>(request, options);
        }



        /// <summary>
        /// Enables an Amazon Macie master account to suspend or re-enable a member account.
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

        internal virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the Amazon Macie configuration settings for an AWS organization.
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
        
    }
}