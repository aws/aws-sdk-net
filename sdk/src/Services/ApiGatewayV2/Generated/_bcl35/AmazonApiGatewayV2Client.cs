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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ApiGatewayV2.Model;
using Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations;
using Amazon.ApiGatewayV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ApiGatewayV2
{
    /// <summary>
    /// <para>Implementation for accessing ApiGatewayV2</para>
    ///
    /// Amazon API Gateway V2
    /// </summary>
    public partial class AmazonApiGatewayV2Client : AmazonServiceClient, IAmazonApiGatewayV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayV2Metadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IApiGatewayV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApiGatewayV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApiGatewayV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        public AmazonApiGatewayV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayV2Config()) { }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        public AmazonApiGatewayV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(AmazonApiGatewayV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApiGatewayV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials and an
        /// AmazonApiGatewayV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials, AmazonApiGatewayV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonApiGatewayV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApiGatewayV2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApiGatewayV2EndpointResolver());
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


        #region  CreateApi

        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// 
        /// <returns>The response from the CreateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual IAsyncResult BeginCreateApi(CreateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApi.</param>
        /// 
        /// <returns>Returns a  CreateApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual CreateApiResponse EndCreateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApiMapping

        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// 
        /// <returns>The response from the CreateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        public virtual CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateApiMapping(CreateApiMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiMapping.</param>
        /// 
        /// <returns>Returns a  CreateApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        public virtual CreateApiMappingResponse EndCreateApiMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAuthorizer

        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainName

        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIntegration

        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual IAsyncResult BeginCreateIntegration(CreateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegration.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse EndCreateIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIntegrationResponse

        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the CreateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        public virtual CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginCreateIntegrationResponse(CreateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        public virtual CreateIntegrationResponseResponse EndCreateIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoute

        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouteResponse

        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// 
        /// <returns>The response from the CreateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        public virtual CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        public virtual IAsyncResult BeginCreateRouteResponse(CreateRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteResponse.</param>
        /// 
        /// <returns>Returns a  CreateRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        public virtual CreateRouteResponseResponse EndCreateRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoutingRule

        /// <summary>
        /// Creates a RoutingRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule service method.</param>
        /// 
        /// <returns>The response from the CreateRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        public virtual CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        public virtual IAsyncResult BeginCreateRoutingRule(CreateRoutingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoutingRule.</param>
        /// 
        /// <returns>Returns a  CreateRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        public virtual CreateRoutingRuleResponse EndCreateRoutingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoutingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcLink

        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// 
        /// <returns>The response from the CreateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcLink(CreateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcLink.</param>
        /// 
        /// <returns>Returns a  CreateVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual CreateVpcLinkResponse EndCreateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessLogSettings

        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessLogSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        public virtual DeleteAccessLogSettingsResponse DeleteAccessLogSettings(DeleteAccessLogSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessLogSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessLogSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessLogSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessLogSettings(DeleteAccessLogSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessLogSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessLogSettings.</param>
        /// 
        /// <returns>Returns a  DeleteAccessLogSettingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        public virtual DeleteAccessLogSettingsResponse EndDeleteAccessLogSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessLogSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApi

        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// 
        /// <returns>The response from the DeleteApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual IAsyncResult BeginDeleteApi(DeleteApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApi.</param>
        /// 
        /// <returns>Returns a  DeleteApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual DeleteApiResponse EndDeleteApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApiMapping

        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        public virtual DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteApiMapping(DeleteApiMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiMapping.</param>
        /// 
        /// <returns>Returns a  DeleteApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        public virtual DeleteApiMappingResponse EndDeleteApiMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAuthorizer

        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCorsConfiguration

        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCorsConfiguration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        public virtual DeleteCorsConfigurationResponse DeleteCorsConfiguration(DeleteCorsConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCorsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCorsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteCorsConfiguration(DeleteCorsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCorsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCorsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCorsConfigurationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        public virtual DeleteCorsConfigurationResponse EndDeleteCorsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCorsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeployment

        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainName

        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegration

        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegrationResponse

        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModel

        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoute

        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouteRequestParameter

        /// <summary>
        /// Deletes a route request parameter. Supported only for WebSocket APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteRequestParameter service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        public virtual DeleteRouteRequestParameterResponse DeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequestParameterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteRequestParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteRequestParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteRequestParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteRequestParameter.</param>
        /// 
        /// <returns>Returns a  DeleteRouteRequestParameterResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        public virtual DeleteRouteRequestParameterResponse EndDeleteRouteRequestParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteRequestParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouteResponse

        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        public virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouteResponse(DeleteRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteResponse.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        public virtual DeleteRouteResponseResponse EndDeleteRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouteSettings

        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        public virtual DeleteRouteSettingsResponse DeleteRouteSettings(DeleteRouteSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouteSettings(DeleteRouteSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteSettings.</param>
        /// 
        /// <returns>Returns a  DeleteRouteSettingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        public virtual DeleteRouteSettingsResponse EndDeleteRouteSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoutingRule

        /// <summary>
        /// Deletes a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        public virtual DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoutingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoutingRule(DeleteRoutingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoutingRule.</param>
        /// 
        /// <returns>Returns a  DeleteRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        public virtual DeleteRoutingRuleResponse EndDeleteRoutingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoutingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStage

        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcLink

        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcLink(DeleteVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcLink.</param>
        /// 
        /// <returns>Returns a  DeleteVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual DeleteVpcLinkResponse EndDeleteVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportApi

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// 
        /// <returns>The response from the ExportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        public virtual ExportApiResponse ExportApi(ExportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return Invoke<ExportApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        public virtual IAsyncResult BeginExportApi(ExportApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportApi.</param>
        /// 
        /// <returns>Returns a  ExportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        public virtual ExportApiResponse EndExportApi(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApi

        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// 
        /// <returns>The response from the GetApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual IAsyncResult BeginGetApi(GetApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApi.</param>
        /// 
        /// <returns>Returns a  GetApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual GetApiResponse EndGetApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiMapping

        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// 
        /// <returns>The response from the GetApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        public virtual GetApiMappingResponse GetApiMapping(GetApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        public virtual IAsyncResult BeginGetApiMapping(GetApiMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMapping.</param>
        /// 
        /// <returns>Returns a  GetApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        public virtual GetApiMappingResponse EndGetApiMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiMappings

        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// 
        /// <returns>The response from the GetApiMappings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        public virtual GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        public virtual IAsyncResult BeginGetApiMappings(GetApiMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMappings.</param>
        /// 
        /// <returns>Returns a  GetApiMappingsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        public virtual GetApiMappingsResponse EndGetApiMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApis

        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// 
        /// <returns>The response from the GetApis service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        public virtual GetApisResponse GetApis(GetApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApis operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        public virtual IAsyncResult BeginGetApis(GetApisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApis.</param>
        /// 
        /// <returns>Returns a  GetApisResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        public virtual GetApisResponse EndGetApis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizer

        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizers

        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual GetAuthorizersResponse EndGetAuthorizers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployments

        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainName

        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainNames

        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegration

        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegrationResponse

        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegrationResponses

        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        public virtual GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        public virtual IAsyncResult BeginGetIntegrationResponses(GetIntegrationResponsesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponses.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponsesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        public virtual GetIntegrationResponsesResponse EndGetIntegrationResponses(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponsesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegrations

        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// 
        /// <returns>The response from the GetIntegrations service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        public virtual GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        public virtual IAsyncResult BeginGetIntegrations(GetIntegrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrations.</param>
        /// 
        /// <returns>Returns a  GetIntegrationsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        public virtual GetIntegrationsResponse EndGetIntegrations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModel

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual GetModelResponse EndGetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModels

        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse EndGetModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelTemplate

        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoute

        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// 
        /// <returns>The response from the GetRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        public virtual GetRouteResponse GetRoute(GetRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        public virtual IAsyncResult BeginGetRoute(GetRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoute.</param>
        /// 
        /// <returns>Returns a  GetRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        public virtual GetRouteResponse EndGetRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouteResponse

        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// 
        /// <returns>The response from the GetRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        public virtual GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        public virtual IAsyncResult BeginGetRouteResponse(GetRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponse.</param>
        /// 
        /// <returns>Returns a  GetRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        public virtual GetRouteResponseResponse EndGetRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouteResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouteResponses

        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// 
        /// <returns>The response from the GetRouteResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        public virtual GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        public virtual IAsyncResult BeginGetRouteResponses(GetRouteResponsesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponses.</param>
        /// 
        /// <returns>Returns a  GetRouteResponsesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        public virtual GetRouteResponsesResponse EndGetRouteResponses(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouteResponsesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoutes

        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// 
        /// <returns>The response from the GetRoutes service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        public virtual GetRoutesResponse GetRoutes(GetRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        public virtual IAsyncResult BeginGetRoutes(GetRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutes.</param>
        /// 
        /// <returns>Returns a  GetRoutesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        public virtual GetRoutesResponse EndGetRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoutingRule

        /// <summary>
        /// Gets a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule service method.</param>
        /// 
        /// <returns>The response from the GetRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        public virtual GetRoutingRuleResponse GetRoutingRule(GetRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<GetRoutingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        public virtual IAsyncResult BeginGetRoutingRule(GetRoutingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutingRule.</param>
        /// 
        /// <returns>Returns a  GetRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        public virtual GetRoutingRuleResponse EndGetRoutingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoutingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStage

        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse EndGetStage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStages

        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual GetStagesResponse EndGetStages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTags

        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse EndGetTags(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcLink

        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// 
        /// <returns>The response from the GetVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual IAsyncResult BeginGetVpcLink(GetVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLink.</param>
        /// 
        /// <returns>Returns a  GetVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual GetVpcLinkResponse EndGetVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcLinks

        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual IAsyncResult BeginGetVpcLinks(GetVpcLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLinks.</param>
        /// 
        /// <returns>Returns a  GetVpcLinksResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual GetVpcLinksResponse EndGetVpcLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportApi

        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// 
        /// <returns>The response from the ImportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        public virtual ImportApiResponse ImportApi(ImportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return Invoke<ImportApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        public virtual IAsyncResult BeginImportApi(ImportApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApi.</param>
        /// 
        /// <returns>Returns a  ImportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        public virtual ImportApiResponse EndImportApi(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportApiResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoutingRules

        /// <summary>
        /// Lists routing rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules service method.</param>
        /// 
        /// <returns>The response from the ListRoutingRules service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        public virtual ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingRulesResponseUnmarshaller.Instance;

            return Invoke<ListRoutingRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        public virtual IAsyncResult BeginListRoutingRules(ListRoutingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutingRules.</param>
        /// 
        /// <returns>Returns a  ListRoutingRulesResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        public virtual ListRoutingRulesResponse EndListRoutingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoutingRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRoutingRule

        /// <summary>
        /// Updates a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule service method.</param>
        /// 
        /// <returns>The response from the PutRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        public virtual PutRoutingRuleResponse PutRoutingRule(PutRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<PutRoutingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRoutingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        public virtual IAsyncResult BeginPutRoutingRule(PutRoutingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoutingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRoutingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRoutingRule.</param>
        /// 
        /// <returns>Returns a  PutRoutingRuleResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        public virtual PutRoutingRuleResponse EndPutRoutingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRoutingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  ReimportApi

        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// 
        /// <returns>The response from the ReimportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        public virtual ReimportApiResponse ReimportApi(ReimportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return Invoke<ReimportApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReimportApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReimportApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        public virtual IAsyncResult BeginReimportApi(ReimportApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReimportApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReimportApi.</param>
        /// 
        /// <returns>Returns a  ReimportApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        public virtual ReimportApiResponse EndReimportApi(IAsyncResult asyncResult)
        {
            return EndInvoke<ReimportApiResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetAuthorizersCache

        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the ResetAuthorizersCache service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        public virtual ResetAuthorizersCacheResponse ResetAuthorizersCache(ResetAuthorizersCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<ResetAuthorizersCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetAuthorizersCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        public virtual IAsyncResult BeginResetAuthorizersCache(ResetAuthorizersCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  ResetAuthorizersCacheResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        public virtual ResetAuthorizersCacheResponse EndResetAuthorizersCache(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetAuthorizersCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApi

        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// 
        /// <returns>The response from the UpdateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual IAsyncResult BeginUpdateApi(UpdateApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApi.</param>
        /// 
        /// <returns>Returns a  UpdateApiResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual UpdateApiResponse EndUpdateApi(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiMapping

        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        public virtual UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateApiMapping(UpdateApiMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiMapping.</param>
        /// 
        /// <returns>Returns a  UpdateApiMappingResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        public virtual UpdateApiMappingResponse EndUpdateApiMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuthorizer

        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeployment

        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainName

        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIntegration

        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse EndUpdateIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIntegrationResponse

        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModel

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoute

        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual UpdateRouteResponse EndUpdateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRouteResponse

        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        public virtual UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouteResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateRouteResponse(UpdateRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouteResponse.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResponseResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        public virtual UpdateRouteResponseResponse EndUpdateRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouteResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStage

        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcLink

        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink operation on AmazonApiGatewayV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual IAsyncResult BeginUpdateVpcLink(UpdateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcLink.</param>
        /// 
        /// <returns>Returns a  UpdateVpcLinkResult from ApiGatewayV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual UpdateVpcLinkResponse EndUpdateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcLinkResponse>(asyncResult);
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
            var resolver = new AmazonApiGatewayV2EndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}