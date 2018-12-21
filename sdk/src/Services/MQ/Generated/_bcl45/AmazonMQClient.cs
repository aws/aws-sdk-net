/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MQ.Model;
using Amazon.MQ.Model.Internal.MarshallTransformations;
using Amazon.MQ.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MQ
{
    /// <summary>
    /// Implementation for accessing MQ
    ///
    /// Amazon MQ is a managed message broker service for Apache ActiveMQ that makes it easy
    /// to set up and operate message brokers in the cloud. A message broker allows software
    /// applications and components to communicate using various programming languages, operating
    /// systems, and formal messaging protocols.
    /// </summary>
    public partial class AmazonMQClient : AmazonServiceClient, IAmazonMQ
    {
        private static IServiceMetadata serviceMetadata = new AmazonMQMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMQClient with the credentials loaded from the application's
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
        public AmazonMQClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMQConfig()) { }

        /// <summary>
        /// Constructs AmazonMQClient with the credentials loaded from the application's
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
        public AmazonMQClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMQConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMQClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMQClient Configuration Object</param>
        public AmazonMQClient(AmazonMQConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMQClient(AWSCredentials credentials)
            : this(credentials, new AmazonMQConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMQClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMQConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Credentials and an
        /// AmazonMQClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMQClient Configuration Object</param>
        public AmazonMQClient(AWSCredentials credentials, AmazonMQConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMQConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMQConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMQClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMQClient Configuration Object</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMQConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMQConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMQConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMQClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMQClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMQClient Configuration Object</param>
        public AmazonMQClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMQConfig clientConfig)
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


        #region  CreateBroker


        /// <summary>
        /// Creates a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBroker service method.</param>
        /// 
        /// <returns>The response from the CreateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        public virtual CreateBrokerResponse CreateBroker(CreateBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrokerResponseUnmarshaller.Instance;

            return Invoke<CreateBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBroker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        public virtual Task<CreateBrokerResponse> CreateBrokerAsync(CreateBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrokerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBrokerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfiguration


        /// <summary>
        /// Creates a new configuration for the specified configuration name. Amazon MQ uses the
        /// default configuration (the engine type and version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        public virtual CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        public virtual Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Add a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBroker


        /// <summary>
        /// Deletes a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBroker service method.</param>
        /// 
        /// <returns>The response from the DeleteBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        public virtual DeleteBrokerResponse DeleteBroker(DeleteBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrokerResponseUnmarshaller.Instance;

            return Invoke<DeleteBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBroker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        public virtual Task<DeleteBrokerResponse> DeleteBrokerAsync(DeleteBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrokerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBrokerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Remove a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBroker


        /// <summary>
        /// Returns information about the specified broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBroker service method.</param>
        /// 
        /// <returns>The response from the DescribeBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        public virtual DescribeBrokerResponse DescribeBroker(DescribeBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrokerResponseUnmarshaller.Instance;

            return Invoke<DescribeBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBroker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        public virtual Task<DescribeBrokerResponse> DescribeBrokerAsync(DescribeBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrokerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBrokerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfiguration


        /// <summary>
        /// Returns information about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        public virtual DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        public virtual Task<DescribeConfigurationResponse> DescribeConfigurationAsync(DescribeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationRevision


        /// <summary>
        /// Returns the specified configuration revision for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRevision service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        public virtual DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        public virtual Task<DescribeConfigurationRevisionResponse> DescribeConfigurationRevisionAsync(DescribeConfigurationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConfigurationRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBrokers


        /// <summary>
        /// Returns a list of all brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrokers service method.</param>
        /// 
        /// <returns>The response from the ListBrokers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        public virtual ListBrokersResponse ListBrokers(ListBrokersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrokersResponseUnmarshaller.Instance;

            return Invoke<ListBrokersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrokers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrokers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        public virtual Task<ListBrokersResponse> ListBrokersAsync(ListBrokersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrokersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBrokersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationRevisions


        /// <summary>
        /// Returns a list of all revisions for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationRevisions service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        public virtual ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        public virtual Task<ListConfigurationRevisionsResponse> ListConfigurationRevisionsAsync(ListConfigurationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConfigurationRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Returns a list of all configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns a list of all ActiveMQ users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootBroker


        /// <summary>
        /// Reboots a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
        /// 
        /// <returns>The response from the RebootBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        public virtual RebootBrokerResponse RebootBroker(RebootBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return Invoke<RebootBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        public virtual Task<RebootBrokerResponse> RebootBrokerAsync(RebootBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootBrokerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBroker


        /// <summary>
        /// Adds a pending configuration change to a broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBroker service method.</param>
        /// 
        /// <returns>The response from the UpdateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        public virtual UpdateBrokerResponse UpdateBroker(UpdateBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBroker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        public virtual Task<UpdateBrokerResponse> UpdateBrokerAsync(UpdateBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBrokerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the information for an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}