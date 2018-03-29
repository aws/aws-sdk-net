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

using Amazon.MQ.Model;
using Amazon.MQ.Model.Internal.MarshallTransformations;
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
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual CreateBrokerResponse CreateBroker(CreateBrokerRequest request)
        {
            var marshaller = CreateBrokerRequestMarshaller.Instance;
            var unmarshaller = CreateBrokerResponseUnmarshaller.Instance;

            return Invoke<CreateBrokerRequest,CreateBrokerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateBrokerRequestMarshaller.Instance;
            var unmarshaller = CreateBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrokerRequest,CreateBrokerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfiguration

        internal virtual CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request)
        {
            var marshaller = CreateConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationRequest,CreateConfigurationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationRequest,CreateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserRequest,CreateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBroker

        internal virtual DeleteBrokerResponse DeleteBroker(DeleteBrokerRequest request)
        {
            var marshaller = DeleteBrokerRequestMarshaller.Instance;
            var unmarshaller = DeleteBrokerResponseUnmarshaller.Instance;

            return Invoke<DeleteBrokerRequest,DeleteBrokerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteBrokerRequestMarshaller.Instance;
            var unmarshaller = DeleteBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrokerRequest,DeleteBrokerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserRequest,DeleteUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBroker

        internal virtual DescribeBrokerResponse DescribeBroker(DescribeBrokerRequest request)
        {
            var marshaller = DescribeBrokerRequestMarshaller.Instance;
            var unmarshaller = DescribeBrokerResponseUnmarshaller.Instance;

            return Invoke<DescribeBrokerRequest,DescribeBrokerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeBrokerRequestMarshaller.Instance;
            var unmarshaller = DescribeBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBrokerRequest,DescribeBrokerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfiguration

        internal virtual DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request)
        {
            var marshaller = DescribeConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRequest,DescribeConfigurationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationRequest,DescribeConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationRevision

        internal virtual DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request)
        {
            var marshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRevisionRequest,DescribeConfigurationRevisionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationRevisionRequest,DescribeConfigurationRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUser

        internal virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserRequest,DescribeUserResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserRequest,DescribeUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBrokers

        internal virtual ListBrokersResponse ListBrokers(ListBrokersRequest request)
        {
            var marshaller = ListBrokersRequestMarshaller.Instance;
            var unmarshaller = ListBrokersResponseUnmarshaller.Instance;

            return Invoke<ListBrokersRequest,ListBrokersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListBrokersRequestMarshaller.Instance;
            var unmarshaller = ListBrokersResponseUnmarshaller.Instance;

            return InvokeAsync<ListBrokersRequest,ListBrokersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationRevisions

        internal virtual ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request)
        {
            var marshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationRevisionsRequest,ListConfigurationRevisionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationRevisionsRequest,ListConfigurationRevisionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurations

        internal virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var marshaller = ListConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersRequest,ListUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootBroker

        internal virtual RebootBrokerResponse RebootBroker(RebootBrokerRequest request)
        {
            var marshaller = RebootBrokerRequestMarshaller.Instance;
            var unmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return Invoke<RebootBrokerRequest,RebootBrokerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RebootBrokerRequestMarshaller.Instance;
            var unmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<RebootBrokerRequest,RebootBrokerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBroker

        internal virtual UpdateBrokerResponse UpdateBroker(UpdateBrokerRequest request)
        {
            var marshaller = UpdateBrokerRequestMarshaller.Instance;
            var unmarshaller = UpdateBrokerResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerRequest,UpdateBrokerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateBrokerRequestMarshaller.Instance;
            var unmarshaller = UpdateBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrokerRequest,UpdateBrokerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfiguration

        internal virtual UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var marshaller = UpdateConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationRequest,UpdateConfigurationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationRequest,UpdateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserRequest,UpdateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}