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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKIdentity.Model;
using Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKIdentity.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ChimeSDKIdentity
{
    /// <summary>
    /// <para>Implementation for accessing ChimeSDKIdentity</para>
    ///
    /// The Amazon Chime SDK Identity APIs in this section allow software developers to create
    /// and manage unique instances of their messaging applications. These APIs provide the
    /// overarching framework for creating and sending messages. For more information about
    /// the identity APIs, refer to <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Identity.html">Amazon
    /// Chime SDK identity</a>.
    /// </summary>
    public partial class AmazonChimeSDKIdentityClient : AmazonServiceClient, IAmazonChimeSDKIdentity
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKIdentityMetadata();
        private IChimeSDKIdentityPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKIdentityPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKIdentityPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with the credentials loaded from the application's
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
        public AmazonChimeSDKIdentityClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKIdentityConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with the credentials loaded from the application's
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
        public AmazonChimeSDKIdentityClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKIdentityConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeSDKIdentityClient Configuration Object</param>
        public AmazonChimeSDKIdentityClient(AmazonChimeSDKIdentityConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKIdentityClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKIdentityClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKIdentityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Credentials and an
        /// AmazonChimeSDKIdentityClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKIdentityClient Configuration Object</param>
        public AmazonChimeSDKIdentityClient(AWSCredentials credentials, AmazonChimeSDKIdentityConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKIdentityConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKIdentityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKIdentityClient Configuration Object</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKIdentityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKIdentityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKIdentityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKIdentityClient Configuration Object</param>
        public AmazonChimeSDKIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKIdentityConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChimeSDKIdentityEndpointResolver());
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


        #region  CreateAppInstance


        /// <summary>
        /// Creates an Amazon Chime SDK messaging <c>AppInstance</c> under an AWS account. Only
        /// SDK messaging customers use this API. <c>CreateAppInstance</c> supports idempotency
        /// behavior as described in the AWS API Standard.
        /// 
        ///  
        /// <para>
        /// identity
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        public virtual CreateAppInstanceResponse CreateAppInstance(CreateAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon Chime SDK messaging <c>AppInstance</c> under an AWS account. Only
        /// SDK messaging customers use this API. <c>CreateAppInstance</c> supports idempotency
        /// behavior as described in the AWS API Standard.
        /// 
        ///  
        /// <para>
        /// identity
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        public virtual Task<CreateAppInstanceResponse> CreateAppInstanceAsync(CreateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppInstanceAdmin


        /// <summary>
        /// Promotes an <c>AppInstanceUser</c> or <c>AppInstanceBot</c> to an <c>AppInstanceAdmin</c>.
        /// The promoted entity can perform the following actions. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ChannelModerator</c> actions across all channels in the <c>AppInstance</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteChannelMessage</c> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <c>AppInstanceUser</c> and <c>AppInstanceBot</c> can be promoted to an <c>AppInstanceAdmin</c>
        /// role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        public virtual CreateAppInstanceAdminResponse CreateAppInstanceAdmin(CreateAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceAdminResponse>(request, options);
        }


        /// <summary>
        /// Promotes an <c>AppInstanceUser</c> or <c>AppInstanceBot</c> to an <c>AppInstanceAdmin</c>.
        /// The promoted entity can perform the following actions. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ChannelModerator</c> actions across all channels in the <c>AppInstance</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteChannelMessage</c> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <c>AppInstanceUser</c> and <c>AppInstanceBot</c> can be promoted to an <c>AppInstanceAdmin</c>
        /// role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        public virtual Task<CreateAppInstanceAdminResponse> CreateAppInstanceAdminAsync(CreateAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppInstanceAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppInstanceBot


        /// <summary>
        /// Creates a bot under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>Configuration</c> and <c>Name</c> for that bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceBot">REST API Reference for CreateAppInstanceBot Operation</seealso>
        public virtual CreateAppInstanceBotResponse CreateAppInstanceBot(CreateAppInstanceBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceBotResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceBotResponse>(request, options);
        }


        /// <summary>
        /// Creates a bot under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>Configuration</c> and <c>Name</c> for that bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceBot">REST API Reference for CreateAppInstanceBot Operation</seealso>
        public virtual Task<CreateAppInstanceBotResponse> CreateAppInstanceBotAsync(CreateAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppInstanceBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppInstanceUser


        /// <summary>
        /// Creates a user under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>appInstanceUserId</c> and <c>Name</c> for that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        public virtual CreateAppInstanceUserResponse CreateAppInstanceUser(CreateAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceUserResponse>(request, options);
        }


        /// <summary>
        /// Creates a user under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>appInstanceUserId</c> and <c>Name</c> for that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        public virtual Task<CreateAppInstanceUserResponse> CreateAppInstanceUserAsync(CreateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppInstance


        /// <summary>
        /// Deletes an <c>AppInstance</c> and all associated data asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        public virtual DeleteAppInstanceResponse DeleteAppInstance(DeleteAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deletes an <c>AppInstance</c> and all associated data asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        public virtual Task<DeleteAppInstanceResponse> DeleteAppInstanceAsync(DeleteAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppInstanceAdmin


        /// <summary>
        /// Demotes an <c>AppInstanceAdmin</c> to an <c>AppInstanceUser</c> or <c>AppInstanceBot</c>.
        /// This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        public virtual DeleteAppInstanceAdminResponse DeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceAdminResponse>(request, options);
        }


        /// <summary>
        /// Demotes an <c>AppInstanceAdmin</c> to an <c>AppInstanceUser</c> or <c>AppInstanceBot</c>.
        /// This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        public virtual Task<DeleteAppInstanceAdminResponse> DeleteAppInstanceAdminAsync(DeleteAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppInstanceAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppInstanceBot


        /// <summary>
        /// Deletes an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceBot">REST API Reference for DeleteAppInstanceBot Operation</seealso>
        public virtual DeleteAppInstanceBotResponse DeleteAppInstanceBot(DeleteAppInstanceBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceBotResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceBotResponse>(request, options);
        }


        /// <summary>
        /// Deletes an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceBot">REST API Reference for DeleteAppInstanceBot Operation</seealso>
        public virtual Task<DeleteAppInstanceBotResponse> DeleteAppInstanceBotAsync(DeleteAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppInstanceBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppInstanceUser


        /// <summary>
        /// Deletes an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        public virtual DeleteAppInstanceUserResponse DeleteAppInstanceUser(DeleteAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceUserResponse>(request, options);
        }


        /// <summary>
        /// Deletes an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        public virtual Task<DeleteAppInstanceUserResponse> DeleteAppInstanceUserAsync(DeleteAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterAppInstanceUserEndpoint


        /// <summary>
        /// Deregisters an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeregisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeregisterAppInstanceUserEndpoint">REST API Reference for DeregisterAppInstanceUserEndpoint Operation</seealso>
        public virtual DeregisterAppInstanceUserEndpointResponse DeregisterAppInstanceUserEndpoint(DeregisterAppInstanceUserEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAppInstanceUserEndpointResponseUnmarshaller.Instance;

            return Invoke<DeregisterAppInstanceUserEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deregisters an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeregisterAppInstanceUserEndpoint">REST API Reference for DeregisterAppInstanceUserEndpoint Operation</seealso>
        public virtual Task<DeregisterAppInstanceUserEndpointResponse> DeregisterAppInstanceUserEndpointAsync(DeregisterAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAppInstanceUserEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterAppInstanceUserEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppInstance


        /// <summary>
        /// Returns the full details of an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        public virtual DescribeAppInstanceResponse DescribeAppInstance(DescribeAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceResponse>(request, options);
        }


        /// <summary>
        /// Returns the full details of an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        public virtual Task<DescribeAppInstanceResponse> DescribeAppInstanceAsync(DescribeAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppInstanceAdmin


        /// <summary>
        /// Returns the full details of an <c>AppInstanceAdmin</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        public virtual DescribeAppInstanceAdminResponse DescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceAdminResponse>(request, options);
        }


        /// <summary>
        /// Returns the full details of an <c>AppInstanceAdmin</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        public virtual Task<DescribeAppInstanceAdminResponse> DescribeAppInstanceAdminAsync(DescribeAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppInstanceAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppInstanceBot


        /// <summary>
        /// The <c>AppInstanceBot's</c> information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceBot">REST API Reference for DescribeAppInstanceBot Operation</seealso>
        public virtual DescribeAppInstanceBotResponse DescribeAppInstanceBot(DescribeAppInstanceBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceBotResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceBotResponse>(request, options);
        }


        /// <summary>
        /// The <c>AppInstanceBot's</c> information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceBot">REST API Reference for DescribeAppInstanceBot Operation</seealso>
        public virtual Task<DescribeAppInstanceBotResponse> DescribeAppInstanceBotAsync(DescribeAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppInstanceBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppInstanceUser


        /// <summary>
        /// Returns the full details of an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        public virtual DescribeAppInstanceUserResponse DescribeAppInstanceUser(DescribeAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceUserResponse>(request, options);
        }


        /// <summary>
        /// Returns the full details of an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        public virtual Task<DescribeAppInstanceUserResponse> DescribeAppInstanceUserAsync(DescribeAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppInstanceUserEndpoint


        /// <summary>
        /// Returns the full details of an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUserEndpoint">REST API Reference for DescribeAppInstanceUserEndpoint Operation</seealso>
        public virtual DescribeAppInstanceUserEndpointResponse DescribeAppInstanceUserEndpoint(DescribeAppInstanceUserEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceUserEndpointResponse>(request, options);
        }


        /// <summary>
        /// Returns the full details of an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUserEndpoint">REST API Reference for DescribeAppInstanceUserEndpoint Operation</seealso>
        public virtual Task<DescribeAppInstanceUserEndpointResponse> DescribeAppInstanceUserEndpointAsync(DescribeAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppInstanceUserEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppInstanceRetentionSettings


        /// <summary>
        /// Gets the retention settings for an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the GetAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        public virtual GetAppInstanceRetentionSettingsResponse GetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAppInstanceRetentionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Gets the retention settings for an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        public virtual Task<GetAppInstanceRetentionSettingsResponse> GetAppInstanceRetentionSettingsAsync(GetAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceRetentionSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppInstanceRetentionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppInstanceAdmins


        /// <summary>
        /// Returns a list of the administrators in the <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceAdmins service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        public virtual ListAppInstanceAdminsResponse ListAppInstanceAdmins(ListAppInstanceAdminsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceAdminsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceAdminsResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceAdminsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the administrators in the <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceAdmins service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        public virtual Task<ListAppInstanceAdminsResponse> ListAppInstanceAdminsAsync(ListAppInstanceAdminsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceAdminsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceAdminsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppInstanceAdminsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppInstanceBots


        /// <summary>
        /// Lists all <c>AppInstanceBots</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceBots service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceBots service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceBots">REST API Reference for ListAppInstanceBots Operation</seealso>
        public virtual ListAppInstanceBotsResponse ListAppInstanceBots(ListAppInstanceBotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceBotsResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceBotsResponse>(request, options);
        }


        /// <summary>
        /// Lists all <c>AppInstanceBots</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceBots service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceBots">REST API Reference for ListAppInstanceBots Operation</seealso>
        public virtual Task<ListAppInstanceBotsResponse> ListAppInstanceBotsAsync(ListAppInstanceBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceBotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppInstanceBotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppInstances


        /// <summary>
        /// Lists all Amazon Chime <c>AppInstance</c>s created under a single AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// 
        /// <returns>The response from the ListAppInstances service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        public virtual ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstancesResponseUnmarshaller.Instance;

            return Invoke<ListAppInstancesResponse>(request, options);
        }


        /// <summary>
        /// Lists all Amazon Chime <c>AppInstance</c>s created under a single AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstances service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        public virtual Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppInstanceUserEndpoints


        /// <summary>
        /// Lists all the <c>AppInstanceUserEndpoints</c> created under a single <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceUserEndpoints service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUserEndpoints">REST API Reference for ListAppInstanceUserEndpoints Operation</seealso>
        public virtual ListAppInstanceUserEndpointsResponse ListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceUserEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists all the <c>AppInstanceUserEndpoints</c> created under a single <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUserEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceUserEndpoints service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUserEndpoints">REST API Reference for ListAppInstanceUserEndpoints Operation</seealso>
        public virtual Task<ListAppInstanceUserEndpointsResponse> ListAppInstanceUserEndpointsAsync(ListAppInstanceUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUserEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppInstanceUserEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppInstanceUsers


        /// <summary>
        /// List all <c>AppInstanceUsers</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceUsers service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        public virtual ListAppInstanceUsersResponse ListAppInstanceUsers(ListAppInstanceUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUsersResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceUsersResponse>(request, options);
        }


        /// <summary>
        /// List all <c>AppInstanceUsers</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppInstanceUsers service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        public virtual Task<ListAppInstanceUsersResponse> ListAppInstanceUsersAsync(ListAppInstanceUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppInstanceUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAppInstanceRetentionSettings


        /// <summary>
        /// Sets the amount of time in days that a given <c>AppInstance</c> retains data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        public virtual PutAppInstanceRetentionSettingsResponse PutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<PutAppInstanceRetentionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Sets the amount of time in days that a given <c>AppInstance</c> retains data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        public virtual Task<PutAppInstanceRetentionSettingsResponse> PutAppInstanceRetentionSettingsAsync(PutAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceRetentionSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAppInstanceRetentionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAppInstanceUserExpirationSettings


        /// <summary>
        /// Sets the number of days before the <c>AppInstanceUser</c> is automatically deleted.
        /// 
        ///  <note> 
        /// <para>
        /// A background process deletes expired <c>AppInstanceUsers</c> within 6 hours of expiration.
        /// Actual deletion times may vary.
        /// </para>
        ///  
        /// <para>
        /// Expired <c>AppInstanceUsers</c> that have not yet been deleted appear as active, and
        /// you can update their expiration settings. The system honors the new settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceUserExpirationSettings service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceUserExpirationSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceUserExpirationSettings">REST API Reference for PutAppInstanceUserExpirationSettings Operation</seealso>
        public virtual PutAppInstanceUserExpirationSettingsResponse PutAppInstanceUserExpirationSettings(PutAppInstanceUserExpirationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceUserExpirationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceUserExpirationSettingsResponseUnmarshaller.Instance;

            return Invoke<PutAppInstanceUserExpirationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Sets the number of days before the <c>AppInstanceUser</c> is automatically deleted.
        /// 
        ///  <note> 
        /// <para>
        /// A background process deletes expired <c>AppInstanceUsers</c> within 6 hours of expiration.
        /// Actual deletion times may vary.
        /// </para>
        ///  
        /// <para>
        /// Expired <c>AppInstanceUsers</c> that have not yet been deleted appear as active, and
        /// you can update their expiration settings. The system honors the new settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceUserExpirationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppInstanceUserExpirationSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceUserExpirationSettings">REST API Reference for PutAppInstanceUserExpirationSettings Operation</seealso>
        public virtual Task<PutAppInstanceUserExpirationSettingsResponse> PutAppInstanceUserExpirationSettingsAsync(PutAppInstanceUserExpirationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceUserExpirationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceUserExpirationSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAppInstanceUserExpirationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterAppInstanceUserEndpoint


        /// <summary>
        /// Registers an endpoint under an Amazon Chime <c>AppInstanceUser</c>. The endpoint receives
        /// messages for a user. For push notifications, the endpoint is a mobile device used
        /// to receive mobile push notifications for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the RegisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/RegisterAppInstanceUserEndpoint">REST API Reference for RegisterAppInstanceUserEndpoint Operation</seealso>
        public virtual RegisterAppInstanceUserEndpointResponse RegisterAppInstanceUserEndpoint(RegisterAppInstanceUserEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAppInstanceUserEndpointResponseUnmarshaller.Instance;

            return Invoke<RegisterAppInstanceUserEndpointResponse>(request, options);
        }


        /// <summary>
        /// Registers an endpoint under an Amazon Chime <c>AppInstanceUser</c>. The endpoint receives
        /// messages for a user. For push notifications, the endpoint is a mobile device used
        /// to receive mobile push notifications for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/RegisterAppInstanceUserEndpoint">REST API Reference for RegisterAppInstanceUserEndpoint Operation</seealso>
        public virtual Task<RegisterAppInstanceUserEndpointResponse> RegisterAppInstanceUserEndpointAsync(RegisterAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAppInstanceUserEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterAppInstanceUserEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppInstance


        /// <summary>
        /// Updates <c>AppInstance</c> metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        public virtual UpdateAppInstanceResponse UpdateAppInstance(UpdateAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceResponse>(request, options);
        }


        /// <summary>
        /// Updates <c>AppInstance</c> metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        public virtual Task<UpdateAppInstanceResponse> UpdateAppInstanceAsync(UpdateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppInstanceBot


        /// <summary>
        /// Updates the name and metadata of an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceBot">REST API Reference for UpdateAppInstanceBot Operation</seealso>
        public virtual UpdateAppInstanceBotResponse UpdateAppInstanceBot(UpdateAppInstanceBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceBotResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceBotResponse>(request, options);
        }


        /// <summary>
        /// Updates the name and metadata of an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceBot">REST API Reference for UpdateAppInstanceBot Operation</seealso>
        public virtual Task<UpdateAppInstanceBotResponse> UpdateAppInstanceBotAsync(UpdateAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppInstanceBotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppInstanceUser


        /// <summary>
        /// Updates the details of an <c>AppInstanceUser</c>. You can update names and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        public virtual UpdateAppInstanceUserResponse UpdateAppInstanceUser(UpdateAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceUserResponse>(request, options);
        }


        /// <summary>
        /// Updates the details of an <c>AppInstanceUser</c>. You can update names and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        public virtual Task<UpdateAppInstanceUserResponse> UpdateAppInstanceUserAsync(UpdateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppInstanceUserEndpoint


        /// <summary>
        /// Updates the details of an <c>AppInstanceUserEndpoint</c>. You can update the name
        /// and <c>AllowMessage</c> values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUserEndpoint">REST API Reference for UpdateAppInstanceUserEndpoint Operation</seealso>
        public virtual UpdateAppInstanceUserEndpointResponse UpdateAppInstanceUserEndpoint(UpdateAppInstanceUserEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceUserEndpointResponse>(request, options);
        }


        /// <summary>
        /// Updates the details of an <c>AppInstanceUserEndpoint</c>. You can update the name
        /// and <c>AllowMessage</c> values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUserEndpoint">REST API Reference for UpdateAppInstanceUserEndpoint Operation</seealso>
        public virtual Task<UpdateAppInstanceUserEndpointResponse> UpdateAppInstanceUserEndpointAsync(UpdateAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppInstanceUserEndpointResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonChimeSDKIdentityEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}