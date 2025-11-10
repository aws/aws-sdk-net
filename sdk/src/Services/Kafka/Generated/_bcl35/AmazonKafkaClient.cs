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
using System.Collections.Generic;
using System.Net;

using Amazon.Kafka.Model;
using Amazon.Kafka.Model.Internal.MarshallTransformations;
using Amazon.Kafka.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Kafka
{
    /// <summary>
    /// <para>Implementation for accessing Kafka</para>
    ///
    /// The operations for managing an Amazon MSK cluster.
    /// </summary>
    public partial class AmazonKafkaClient : AmazonServiceClient, IAmazonKafka
    {
        private static IServiceMetadata serviceMetadata = new AmazonKafkaMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKafkaEndpointResolver());
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

        /// <summary>
        /// Associates one or more Scram Secrets with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateScramSecret service method.</param>
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
        public virtual BatchAssociateScramSecretResponse BatchAssociateScramSecret(BatchAssociateScramSecretRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateScramSecretResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateScramSecretResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateScramSecret operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateScramSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateScramSecret(BatchAssociateScramSecretRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateScramSecretResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateScramSecret.</param>
        /// 
        /// <returns>Returns a  BatchAssociateScramSecretResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        public virtual BatchAssociateScramSecretResponse EndBatchAssociateScramSecret(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateScramSecretResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateScramSecret

        /// <summary>
        /// Disassociates one or more Scram Secrets from an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateScramSecret service method.</param>
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
        public virtual BatchDisassociateScramSecretResponse BatchDisassociateScramSecret(BatchDisassociateScramSecretRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateScramSecretResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateScramSecretResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateScramSecret operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateScramSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateScramSecret(BatchDisassociateScramSecretRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateScramSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateScramSecretResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateScramSecret.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateScramSecretResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        public virtual BatchDisassociateScramSecretResponse EndBatchDisassociateScramSecret(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateScramSecretResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCluster

        /// <summary>
        /// Creates a new MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
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
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterV2

        /// <summary>
        /// Creates a new MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterV2 service method.</param>
        /// 
        /// <returns>The response from the CreateClusterV2 service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        public virtual CreateClusterV2Response CreateClusterV2(CreateClusterV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterV2ResponseUnmarshaller.Instance;

            return Invoke<CreateClusterV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterV2(CreateClusterV2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterV2.</param>
        /// 
        /// <returns>Returns a  CreateClusterV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        public virtual CreateClusterV2Response EndCreateClusterV2(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterV2Response>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguration

        /// <summary>
        /// Creates a new MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
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
        public virtual CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguration(CreateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        public virtual CreateConfigurationResponse EndCreateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicator

        /// <summary>
        /// Creates the replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicator service method.</param>
        /// 
        /// <returns>The response from the CreateReplicator service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        public virtual CreateReplicatorResponse CreateReplicator(CreateReplicatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicatorResponseUnmarshaller.Instance;

            return Invoke<CreateReplicatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicator(CreateReplicatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicator.</param>
        /// 
        /// <returns>Returns a  CreateReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        public virtual CreateReplicatorResponse EndCreateReplicator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicatorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcConnection

        /// <summary>
        /// Creates a new MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcConnection service method, as returned by Kafka.</returns>
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
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        public virtual CreateVpcConnectionResponse CreateVpcConnection(CreateVpcConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcConnection(CreateVpcConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        public virtual CreateVpcConnectionResponse EndCreateVpcConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Deletes the MSK cluster specified by the Amazon Resource Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
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
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterPolicy

        /// <summary>
        /// Deletes the MSK cluster policy specified by the Amazon Resource Name (ARN) in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterPolicy service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        public virtual DeleteClusterPolicyResponse DeleteClusterPolicy(DeleteClusterPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterPolicy(DeleteClusterPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        public virtual DeleteClusterPolicyResponse EndDeleteClusterPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguration

        /// <summary>
        /// Deletes an MSK Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration service method.</param>
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
        public virtual DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguration(DeleteConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        public virtual DeleteConfigurationResponse EndDeleteConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicator

        /// <summary>
        /// Deletes a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicator service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicator service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        public virtual DeleteReplicatorResponse DeleteReplicator(DeleteReplicatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicatorResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicator(DeleteReplicatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicator.</param>
        /// 
        /// <returns>Returns a  DeleteReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        public virtual DeleteReplicatorResponse EndDeleteReplicator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcConnection

        /// <summary>
        /// Deletes a MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcConnection service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        public virtual DeleteVpcConnectionResponse DeleteVpcConnection(DeleteVpcConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcConnection(DeleteVpcConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        public virtual DeleteVpcConnectionResponse EndDeleteVpcConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Returns a description of the MSK cluster whose Amazon Resource Name (ARN) is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
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
        public virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterOperation

        /// <summary>
        /// Returns a description of the cluster operation specified by the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperation service method.</param>
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
        public virtual DescribeClusterOperationResponse DescribeClusterOperation(DescribeClusterOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperation operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterOperation(DescribeClusterOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterOperation.</param>
        /// 
        /// <returns>Returns a  DescribeClusterOperationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        public virtual DescribeClusterOperationResponse EndDescribeClusterOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterOperationV2

        /// <summary>
        /// Returns a description of the cluster operation specified by the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperationV2 service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterOperationV2 service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        public virtual DescribeClusterOperationV2Response DescribeClusterOperationV2(DescribeClusterOperationV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationV2ResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterOperationV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterOperationV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperationV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterOperationV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterOperationV2(DescribeClusterOperationV2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterOperationV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterOperationV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterOperationV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterOperationV2.</param>
        /// 
        /// <returns>Returns a  DescribeClusterOperationV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        public virtual DescribeClusterOperationV2Response EndDescribeClusterOperationV2(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterOperationV2Response>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterV2

        /// <summary>
        /// Returns a description of the MSK cluster whose Amazon Resource Name (ARN) is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterV2 service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterV2 service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        public virtual DescribeClusterV2Response DescribeClusterV2(DescribeClusterV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterV2ResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterV2(DescribeClusterV2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterV2.</param>
        /// 
        /// <returns>Returns a  DescribeClusterV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        public virtual DescribeClusterV2Response EndDescribeClusterV2(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterV2Response>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfiguration

        /// <summary>
        /// Returns a description of this MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
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
        public virtual DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfiguration(DescribeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        public virtual DescribeConfigurationResponse EndDescribeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationRevision

        /// <summary>
        /// Returns a description of this revision of the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
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
        public virtual DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationRevision(DescribeConfigurationRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRevision.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRevisionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        public virtual DescribeConfigurationRevisionResponse EndDescribeConfigurationRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicator

        /// <summary>
        /// Describes a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicator service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicator service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        public virtual DescribeReplicatorResponse DescribeReplicator(DescribeReplicatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicatorResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicator(DescribeReplicatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicator.</param>
        /// 
        /// <returns>Returns a  DescribeReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        public virtual DescribeReplicatorResponse EndDescribeReplicator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcConnection

        /// <summary>
        /// Returns a description of this MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcConnection service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        public virtual DescribeVpcConnectionResponse DescribeVpcConnection(DescribeVpcConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcConnectionResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        public virtual IAsyncResult BeginDescribeVpcConnection(DescribeVpcConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcConnection.</param>
        /// 
        /// <returns>Returns a  DescribeVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        public virtual DescribeVpcConnectionResponse EndDescribeVpcConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBootstrapBrokers

        /// <summary>
        /// A list of brokers that a client application can use to bootstrap. This list doesn't
        /// necessarily include all of the brokers in the cluster. The following Python 3.6 example
        /// shows how you can use the Amazon Resource Name (ARN) of a cluster to get its bootstrap
        /// brokers. If you don't know the ARN of your cluster, you can use the <c>ListClusters</c>
        /// operation to get the ARNs of all the clusters in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBootstrapBrokers service method.</param>
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
        public virtual GetBootstrapBrokersResponse GetBootstrapBrokers(GetBootstrapBrokersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBootstrapBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBootstrapBrokersResponseUnmarshaller.Instance;

            return Invoke<GetBootstrapBrokersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBootstrapBrokers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBootstrapBrokers operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBootstrapBrokers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        public virtual IAsyncResult BeginGetBootstrapBrokers(GetBootstrapBrokersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBootstrapBrokersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBootstrapBrokersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBootstrapBrokers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBootstrapBrokers.</param>
        /// 
        /// <returns>Returns a  GetBootstrapBrokersResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        public virtual GetBootstrapBrokersResponse EndGetBootstrapBrokers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBootstrapBrokersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClusterPolicy

        /// <summary>
        /// Get the MSK cluster policy specified by the Amazon Resource Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the GetClusterPolicy service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        public virtual GetClusterPolicyResponse GetClusterPolicy(GetClusterPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterPolicyResponseUnmarshaller.Instance;

            return Invoke<GetClusterPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetClusterPolicy(GetClusterPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterPolicy.</param>
        /// 
        /// <returns>Returns a  GetClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        public virtual GetClusterPolicyResponse EndGetClusterPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCompatibleKafkaVersions

        /// <summary>
        /// Gets the Apache Kafka versions to which you can update the MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleKafkaVersions service method.</param>
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
        public virtual GetCompatibleKafkaVersionsResponse GetCompatibleKafkaVersions(GetCompatibleKafkaVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCompatibleKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleKafkaVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleKafkaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleKafkaVersions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleKafkaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        public virtual IAsyncResult BeginGetCompatibleKafkaVersions(GetCompatibleKafkaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCompatibleKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleKafkaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleKafkaVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleKafkaVersionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        public virtual GetCompatibleKafkaVersionsResponse EndGetCompatibleKafkaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCompatibleKafkaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClientVpcConnections

        /// <summary>
        /// Returns a list of all the VPC connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClientVpcConnections service method.</param>
        /// 
        /// <returns>The response from the ListClientVpcConnections service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        public virtual ListClientVpcConnectionsResponse ListClientVpcConnections(ListClientVpcConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClientVpcConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientVpcConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListClientVpcConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClientVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClientVpcConnections operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClientVpcConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        public virtual IAsyncResult BeginListClientVpcConnections(ListClientVpcConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClientVpcConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientVpcConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClientVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClientVpcConnections.</param>
        /// 
        /// <returns>Returns a  ListClientVpcConnectionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        public virtual ListClientVpcConnectionsResponse EndListClientVpcConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClientVpcConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusterOperations

        /// <summary>
        /// Returns a list of all the operations that have been performed on the specified MSK
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperations service method.</param>
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
        public virtual ListClusterOperationsResponse ListClusterOperations(ListClusterOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsResponseUnmarshaller.Instance;

            return Invoke<ListClusterOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperations operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        public virtual IAsyncResult BeginListClusterOperations(ListClusterOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterOperations.</param>
        /// 
        /// <returns>Returns a  ListClusterOperationsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        public virtual ListClusterOperationsResponse EndListClusterOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClusterOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusterOperationsV2

        /// <summary>
        /// Returns a list of all the operations that have been performed on the specified MSK
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperationsV2 service method.</param>
        /// 
        /// <returns>The response from the ListClusterOperationsV2 service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        public virtual ListClusterOperationsV2Response ListClusterOperationsV2(ListClusterOperationsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsV2ResponseUnmarshaller.Instance;

            return Invoke<ListClusterOperationsV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterOperationsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperationsV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterOperationsV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        public virtual IAsyncResult BeginListClusterOperationsV2(ListClusterOperationsV2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterOperationsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterOperationsV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterOperationsV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterOperationsV2.</param>
        /// 
        /// <returns>Returns a  ListClusterOperationsV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        public virtual ListClusterOperationsV2Response EndListClusterOperationsV2(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClusterOperationsV2Response>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Returns a list of all the MSK clusters in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
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
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClustersV2

        /// <summary>
        /// Returns a list of all the MSK clusters in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClustersV2 service method.</param>
        /// 
        /// <returns>The response from the ListClustersV2 service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        public virtual ListClustersV2Response ListClustersV2(ListClustersV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersV2ResponseUnmarshaller.Instance;

            return Invoke<ListClustersV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClustersV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClustersV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClustersV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        public virtual IAsyncResult BeginListClustersV2(ListClustersV2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClustersV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClustersV2.</param>
        /// 
        /// <returns>Returns a  ListClustersV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        public virtual ListClustersV2Response EndListClustersV2(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersV2Response>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationRevisions

        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
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
        public virtual ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationRevisions(ListConfigurationRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationRevisions.</param>
        /// 
        /// <returns>Returns a  ListConfigurationRevisionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        public virtual ListConfigurationRevisionsResponse EndListConfigurationRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurations

        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
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
        public virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKafkaVersions

        /// <summary>
        /// Returns a list of Apache Kafka versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKafkaVersions service method.</param>
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
        public virtual ListKafkaVersionsResponse ListKafkaVersions(ListKafkaVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKafkaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListKafkaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKafkaVersions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKafkaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        public virtual IAsyncResult BeginListKafkaVersions(ListKafkaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKafkaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKafkaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKafkaVersions.</param>
        /// 
        /// <returns>Returns a  ListKafkaVersionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        public virtual ListKafkaVersionsResponse EndListKafkaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKafkaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNodes

        /// <summary>
        /// Returns a list of the broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
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
        public virtual ListNodesResponse ListNodes(ListNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return Invoke<ListNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual ListNodesResponse EndListNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReplicators

        /// <summary>
        /// Lists the replicators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplicators service method.</param>
        /// 
        /// <returns>The response from the ListReplicators service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        public virtual ListReplicatorsResponse ListReplicators(ListReplicatorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReplicatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplicatorsResponseUnmarshaller.Instance;

            return Invoke<ListReplicatorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReplicators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReplicators operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReplicators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        public virtual IAsyncResult BeginListReplicators(ListReplicatorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReplicatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplicatorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplicators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplicators.</param>
        /// 
        /// <returns>Returns a  ListReplicatorsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        public virtual ListReplicatorsResponse EndListReplicators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReplicatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListScramSecrets

        /// <summary>
        /// Returns a list of the Scram Secrets associated with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScramSecrets service method.</param>
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
        public virtual ListScramSecretsResponse ListScramSecrets(ListScramSecretsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScramSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScramSecretsResponseUnmarshaller.Instance;

            return Invoke<ListScramSecretsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListScramSecrets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScramSecrets operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScramSecrets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        public virtual IAsyncResult BeginListScramSecrets(ListScramSecretsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScramSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScramSecretsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListScramSecrets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScramSecrets.</param>
        /// 
        /// <returns>Returns a  ListScramSecretsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        public virtual ListScramSecretsResponse EndListScramSecrets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListScramSecretsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcConnections

        /// <summary>
        /// Returns a list of all the VPC connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnections service method.</param>
        /// 
        /// <returns>The response from the ListVpcConnections service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        public virtual ListVpcConnectionsResponse ListVpcConnections(ListVpcConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListVpcConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnections operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        public virtual IAsyncResult BeginListVpcConnections(ListVpcConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcConnections.</param>
        /// 
        /// <returns>Returns a  ListVpcConnectionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        public virtual ListVpcConnectionsResponse EndListVpcConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutClusterPolicy

        /// <summary>
        /// Creates or updates the MSK cluster policy specified by the cluster Amazon Resource
        /// Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the PutClusterPolicy service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        public virtual PutClusterPolicyResponse PutClusterPolicy(PutClusterPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClusterPolicyResponseUnmarshaller.Instance;

            return Invoke<PutClusterPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutClusterPolicy(PutClusterPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutClusterPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutClusterPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutClusterPolicy.</param>
        /// 
        /// <returns>Returns a  PutClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        public virtual PutClusterPolicyResponse EndPutClusterPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutClusterPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootBroker

        /// <summary>
        /// Reboots brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
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
        public virtual RebootBrokerResponse RebootBroker(RebootBrokerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return Invoke<RebootBrokerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        public virtual IAsyncResult BeginRebootBroker(RebootBrokerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootBrokerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootBrokerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootBroker.</param>
        /// 
        /// <returns>Returns a  RebootBrokerResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        public virtual RebootBrokerResponse EndRebootBroker(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootBrokerResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectClientVpcConnection

        /// <summary>
        /// Returns empty response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectClientVpcConnection service method.</param>
        /// 
        /// <returns>The response from the RejectClientVpcConnection service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        public virtual RejectClientVpcConnectionResponse RejectClientVpcConnection(RejectClientVpcConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectClientVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectClientVpcConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectClientVpcConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectClientVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectClientVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectClientVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        public virtual IAsyncResult BeginRejectClientVpcConnection(RejectClientVpcConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectClientVpcConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectClientVpcConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectClientVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectClientVpcConnection.</param>
        /// 
        /// <returns>Returns a  RejectClientVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        public virtual RejectClientVpcConnectionResponse EndRejectClientVpcConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectClientVpcConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to the specified MSK resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the tags associated with the keys that are provided in the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBrokerCount

        /// <summary>
        /// Updates the number of broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerCount service method.</param>
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
        public virtual UpdateBrokerCountResponse UpdateBrokerCount(UpdateBrokerCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerCountResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerCountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerCount operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        public virtual IAsyncResult BeginUpdateBrokerCount(UpdateBrokerCountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerCount.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerCountResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        public virtual UpdateBrokerCountResponse EndUpdateBrokerCount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBrokerCountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBrokerStorage

        /// <summary>
        /// Updates the EBS storage associated with MSK brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerStorage service method.</param>
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
        public virtual UpdateBrokerStorageResponse UpdateBrokerStorage(UpdateBrokerStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerStorage operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        public virtual IAsyncResult BeginUpdateBrokerStorage(UpdateBrokerStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerStorage.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerStorageResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        public virtual UpdateBrokerStorageResponse EndUpdateBrokerStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBrokerStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBrokerType

        /// <summary>
        /// Updates EC2 instance type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerType service method.</param>
        /// 
        /// <returns>The response from the UpdateBrokerType service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        public virtual UpdateBrokerTypeResponse UpdateBrokerType(UpdateBrokerTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateBrokerTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerType operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        public virtual IAsyncResult BeginUpdateBrokerType(UpdateBrokerTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrokerTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrokerTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerType.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerTypeResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        public virtual UpdateBrokerTypeResponse EndUpdateBrokerType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBrokerTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterConfiguration

        /// <summary>
        /// Updates the cluster with the configuration that is specified in the request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfiguration service method.</param>
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
        public virtual UpdateClusterConfigurationResponse UpdateClusterConfiguration(UpdateClusterConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterConfiguration(UpdateClusterConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateClusterConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        public virtual UpdateClusterConfigurationResponse EndUpdateClusterConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClusterKafkaVersion

        /// <summary>
        /// Updates the Apache Kafka version for the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterKafkaVersion service method.</param>
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
        public virtual UpdateClusterKafkaVersionResponse UpdateClusterKafkaVersion(UpdateClusterKafkaVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterKafkaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterKafkaVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterKafkaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterKafkaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterKafkaVersion operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterKafkaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateClusterKafkaVersion(UpdateClusterKafkaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterKafkaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterKafkaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterKafkaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterKafkaVersion.</param>
        /// 
        /// <returns>Returns a  UpdateClusterKafkaVersionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        public virtual UpdateClusterKafkaVersionResponse EndUpdateClusterKafkaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterKafkaVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguration

        /// <summary>
        /// Updates an MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
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
        public virtual UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguration(UpdateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual UpdateConfigurationResponse EndUpdateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectivity

        /// <summary>
        /// Updates the cluster's connectivity configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivity service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectivity service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        public virtual UpdateConnectivityResponse UpdateConnectivity(UpdateConnectivityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectivityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivity operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectivity(UpdateConnectivityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectivity.</param>
        /// 
        /// <returns>Returns a  UpdateConnectivityResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        public virtual UpdateConnectivityResponse EndUpdateConnectivity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectivityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMonitoring

        /// <summary>
        /// Updates the monitoring settings for the cluster. You can use this operation to specify
        /// which Apache Kafka metrics you want Amazon MSK to send to Amazon CloudWatch. You can
        /// also specify settings for open monitoring with Prometheus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoring service method.</param>
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
        public virtual UpdateMonitoringResponse UpdateMonitoring(UpdateMonitoringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitoringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoring operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitoring
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        public virtual IAsyncResult BeginUpdateMonitoring(UpdateMonitoringRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitoring operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitoring.</param>
        /// 
        /// <returns>Returns a  UpdateMonitoringResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        public virtual UpdateMonitoringResponse EndUpdateMonitoring(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMonitoringResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRebalancing

        /// <summary>
        /// Use this resource to update the intelligent rebalancing status of an Amazon MSK Provisioned
        /// cluster with Express brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRebalancing service method.</param>
        /// 
        /// <returns>The response from the UpdateRebalancing service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        public virtual UpdateRebalancingResponse UpdateRebalancing(UpdateRebalancingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRebalancingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRebalancingResponseUnmarshaller.Instance;

            return Invoke<UpdateRebalancingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRebalancing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRebalancing operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRebalancing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        public virtual IAsyncResult BeginUpdateRebalancing(UpdateRebalancingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRebalancingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRebalancingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRebalancing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRebalancing.</param>
        /// 
        /// <returns>Returns a  UpdateRebalancingResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        public virtual UpdateRebalancingResponse EndUpdateRebalancing(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRebalancingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationInfo

        /// <summary>
        /// Updates replication info of a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationInfo service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        public virtual UpdateReplicationInfoResponse UpdateReplicationInfo(UpdateReplicationInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReplicationInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationInfo operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationInfo(UpdateReplicationInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReplicationInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationInfo.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationInfoResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        public virtual UpdateReplicationInfoResponse EndUpdateReplicationInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurity

        /// <summary>
        /// Updates the security settings for the cluster. You can use this operation to specify
        /// encryption and authentication on existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurity service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurity service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        public virtual UpdateSecurityResponse UpdateSecurity(UpdateSecurityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurity operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurity(UpdateSecurityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurity.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        public virtual UpdateSecurityResponse EndUpdateSecurity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStorage

        /// <summary>
        /// Updates cluster broker volume size (or) sets cluster storage mode to TIERED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateStorage service method, as returned by Kafka.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        public virtual UpdateStorageResponse UpdateStorage(UpdateStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorage operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        public virtual IAsyncResult BeginUpdateStorage(UpdateStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorage.</param>
        /// 
        /// <returns>Returns a  UpdateStorageResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        public virtual UpdateStorageResponse EndUpdateStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStorageResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonKafkaEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}