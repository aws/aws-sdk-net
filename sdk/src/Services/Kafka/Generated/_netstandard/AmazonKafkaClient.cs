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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Kafka.Model;
using Amazon.Kafka.Model.Internal.MarshallTransformations;
using Amazon.Kafka.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kafka
{
    /// <summary>
    /// Implementation for accessing Kafka
    ///
    /// The operations for managing an Amazon MSK cluster.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonKafkaClient : AmazonServiceClient, IAmazonKafka
    {
        private static IServiceMetadata serviceMetadata = new AmazonKafkaMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKafkaClient with the credentials loaded from the application's
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
        public AmazonKafkaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKafkaConfig()) { }

        /// <summary>
        /// Constructs AmazonKafkaClient with the credentials loaded from the application's
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
        public AmazonKafkaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKafkaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKafkaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKafkaClient Configuration Object</param>
        public AmazonKafkaClient(AmazonKafkaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKafkaClient(AWSCredentials credentials)
            : this(credentials, new AmazonKafkaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKafkaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Credentials and an
        /// AmazonKafkaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKafkaClient Configuration Object</param>
        public AmazonKafkaClient(AWSCredentials credentials, AmazonKafkaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKafkaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKafkaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKafkaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKafkaClient Configuration Object</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKafkaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKafkaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKafkaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKafkaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKafkaClient Configuration Object</param>
        public AmazonKafkaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKafkaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IKafkaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKafkaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KafkaPaginatorFactory(this);
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


        #region  BatchAssociateScramSecret

        internal virtual BatchAssociateScramSecretResponse BatchAssociateScramSecret(BatchAssociateScramSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateScramSecretResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateScramSecretResponse>(request, options);
        }



        /// <summary>
        /// Associates one or more Scram Secrets with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateScramSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateScramSecret service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        public virtual Task<BatchAssociateScramSecretResponse> BatchAssociateScramSecretAsync(BatchAssociateScramSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateScramSecretResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateScramSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateScramSecret

        internal virtual BatchDisassociateScramSecretResponse BatchDisassociateScramSecret(BatchDisassociateScramSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateScramSecretResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateScramSecretResponse>(request, options);
        }



        /// <summary>
        /// Disassociates one or more Scram Secrets from an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateScramSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateScramSecret service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        public virtual Task<BatchDisassociateScramSecretResponse> BatchDisassociateScramSecretAsync(BatchDisassociateScramSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateScramSecretResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateScramSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfiguration

        internal virtual CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        public virtual Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes the MSK cluster specified by the Amazon Resource Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfiguration

        internal virtual DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an MSK Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        public virtual Task<DeleteConfigurationResponse> DeleteConfigurationAsync(DeleteConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of the MSK cluster whose Amazon Resource Name (ARN) is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterOperation

        internal virtual DescribeClusterOperationResponse DescribeClusterOperation(DescribeClusterOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of the cluster operation specified by the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterOperation service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        public virtual Task<DescribeClusterOperationResponse> DescribeClusterOperationAsync(DescribeClusterOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfiguration

        internal virtual DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of this MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        public virtual Task<DescribeConfigurationResponse> DescribeConfigurationAsync(DescribeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationRevision

        internal virtual DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRevisionResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of this revision of the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRevision service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        public virtual Task<DescribeConfigurationRevisionResponse> DescribeConfigurationRevisionAsync(DescribeConfigurationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBootstrapBrokers

        internal virtual GetBootstrapBrokersResponse GetBootstrapBrokers(GetBootstrapBrokersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBootstrapBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBootstrapBrokersResponseUnmarshaller.Instance;

            return Invoke<GetBootstrapBrokersResponse>(request, options);
        }



        /// <summary>
        /// A list of brokers that a client application can use to bootstrap.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBootstrapBrokers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBootstrapBrokers service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        public virtual Task<GetBootstrapBrokersResponse> GetBootstrapBrokersAsync(GetBootstrapBrokersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBootstrapBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBootstrapBrokersResponseUnmarshaller.Instance;

            return InvokeAsync<GetBootstrapBrokersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCompatibleKafkaVersions

        internal virtual GetCompatibleKafkaVersionsResponse GetCompatibleKafkaVersions(GetCompatibleKafkaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleKafkaVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleKafkaVersionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the Apache Kafka versions to which you can update the MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleKafkaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCompatibleKafkaVersions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        public virtual Task<GetCompatibleKafkaVersionsResponse> GetCompatibleKafkaVersionsAsync(GetCompatibleKafkaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleKafkaVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCompatibleKafkaVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusterOperations

        internal virtual ListClusterOperationsResponse ListClusterOperations(ListClusterOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsResponseUnmarshaller.Instance;

            return Invoke<ListClusterOperationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the operations that have been performed on the specified MSK
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterOperations service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        public virtual Task<ListClusterOperationsResponse> ListClusterOperationsAsync(ListClusterOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListClusterOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the MSK clusters in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationRevisions

        internal virtual ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationRevisions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        public virtual Task<ListConfigurationRevisionsResponse> ListConfigurationRevisionsAsync(ListConfigurationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurations

        internal virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKafkaVersions

        internal virtual ListKafkaVersionsResponse ListKafkaVersions(ListKafkaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKafkaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListKafkaVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Kafka versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKafkaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKafkaVersions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        public virtual Task<ListKafkaVersionsResponse> ListKafkaVersionsAsync(ListKafkaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKafkaVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKafkaVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNodes

        internal virtual ListNodesResponse ListNodes(ListNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return Invoke<ListNodesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScramSecrets

        internal virtual ListScramSecretsResponse ListScramSecrets(ListScramSecretsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScramSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScramSecretsResponseUnmarshaller.Instance;

            return Invoke<ListScramSecretsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the Scram Secrets associated with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScramSecrets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScramSecrets service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        public virtual Task<ListScramSecretsResponse> ListScramSecretsAsync(ListScramSecretsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScramSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScramSecretsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScramSecretsResponse>(request, options, cancellationToken);
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
        /// Returns a list of the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootBroker

        internal virtual RebootBrokerResponse RebootBroker(RebootBrokerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return Invoke<RebootBrokerResponse>(request, options);
        }



        /// <summary>
        /// Reboots brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootBroker service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        public virtual Task<RebootBrokerResponse> RebootBrokerAsync(RebootBrokerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return InvokeAsync<RebootBrokerResponse>(request, options, cancellationToken);
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
        /// Adds tags to the specified MSK resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the tags associated with the keys that are provided in the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBrokerCount

        internal virtual UpdateBrokerCountResponse UpdateBrokerCount(UpdateBrokerCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerCountResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerCountResponse>(request, options);
        }



        /// <summary>
        /// Updates the number of broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrokerCount service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        public virtual Task<UpdateBrokerCountResponse> UpdateBrokerCountAsync(UpdateBrokerCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerCountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrokerCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBrokerStorage

        internal virtual UpdateBrokerStorageResponse UpdateBrokerStorage(UpdateBrokerStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerStorageResponse>(request, options);
        }



        /// <summary>
        /// Updates the EBS storage associated with MSK brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrokerStorage service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        public virtual Task<UpdateBrokerStorageResponse> UpdateBrokerStorageAsync(UpdateBrokerStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrokerStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerStorageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrokerStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClusterConfiguration

        internal virtual UpdateClusterConfigurationResponse UpdateClusterConfiguration(UpdateClusterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the cluster with the configuration that is specified in the request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        public virtual Task<UpdateClusterConfigurationResponse> UpdateClusterConfigurationAsync(UpdateClusterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateClusterKafkaVersion

        internal virtual UpdateClusterKafkaVersionResponse UpdateClusterKafkaVersion(UpdateClusterKafkaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterKafkaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterKafkaVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterKafkaVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the Apache Kafka version for the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterKafkaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterKafkaVersion service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        public virtual Task<UpdateClusterKafkaVersionResponse> UpdateClusterKafkaVersionAsync(UpdateClusterKafkaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterKafkaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterKafkaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterKafkaVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfiguration

        internal virtual UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates an MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMonitoring

        internal virtual UpdateMonitoringResponse UpdateMonitoring(UpdateMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitoringResponse>(request, options);
        }



        /// <summary>
        /// Updates the monitoring settings for the cluster. You can use this operation to specify
        /// which Apache Kafka metrics you want Amazon MSK to send to Amazon CloudWatch. You can
        /// also specify settings for open monitoring with Prometheus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoring service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitoring service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        public virtual Task<UpdateMonitoringResponse> UpdateMonitoringAsync(UpdateMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMonitoringResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}