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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ApiGatewayV2.Model;
using Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations;
using Amazon.ApiGatewayV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApiGatewayV2
{
    /// <summary>
    /// Implementation for accessing ApiGatewayV2
    ///
    /// Amazon API Gateway V2
    /// </summary>
    public partial class AmazonApiGatewayV2Client : AmazonServiceClient, IAmazonApiGatewayV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayV2Metadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        public virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var marshaller = CreateApiRequestMarshaller.Instance;
            var unmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiRequest,CreateApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateApi(CreateApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApiRequestMarshaller.Instance;
            var unmarshaller = CreateApiResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApi.</param>
        /// 
        /// <returns>Returns a  CreateApiResult from ApiGatewayV2.</returns>
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
        public virtual CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request)
        {
            var marshaller = CreateApiMappingRequestMarshaller.Instance;
            var unmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingRequest,CreateApiMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateApiMapping(CreateApiMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApiMappingRequestMarshaller.Instance;
            var unmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApiMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiMapping.</param>
        /// 
        /// <returns>Returns a  CreateApiMappingResult from ApiGatewayV2.</returns>
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
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerRequest,CreateAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from ApiGatewayV2.</returns>
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
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from ApiGatewayV2.</returns>
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
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from ApiGatewayV2.</returns>
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
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var marshaller = CreateIntegrationRequestMarshaller.Instance;
            var unmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationRequest,CreateIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateIntegration(CreateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateIntegrationRequestMarshaller.Instance;
            var unmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegration.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResult from ApiGatewayV2.</returns>
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
        public virtual CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request)
        {
            var marshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseRequest,CreateIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateIntegrationResponse(CreateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationResponseResult from ApiGatewayV2.</returns>
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
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelRequest,CreateModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke<CreateModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from ApiGatewayV2.</returns>
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
        public virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from ApiGatewayV2.</returns>
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
        public virtual CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request)
        {
            var marshaller = CreateRouteResponseRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseRequest,CreateRouteResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateRouteResponse(CreateRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateRouteResponseRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRouteResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteResponse.</param>
        /// 
        /// <returns>Returns a  CreateRouteResponseResult from ApiGatewayV2.</returns>
        public virtual CreateRouteResponseResponse EndCreateRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteResponseResponse>(asyncResult);
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
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageRequest,CreateStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from ApiGatewayV2.</returns>
        public virtual CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
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
        public virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var marshaller = DeleteApiRequestMarshaller.Instance;
            var unmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiRequest,DeleteApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteApi(DeleteApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApiRequestMarshaller.Instance;
            var unmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApi.</param>
        /// 
        /// <returns>Returns a  DeleteApiResult from ApiGatewayV2.</returns>
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
        public virtual DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request)
        {
            var marshaller = DeleteApiMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingRequest,DeleteApiMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteApiMapping(DeleteApiMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApiMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApiMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiMapping.</param>
        /// 
        /// <returns>Returns a  DeleteApiMappingResult from ApiGatewayV2.</returns>
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
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerRequest,DeleteAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from ApiGatewayV2.</returns>
        public virtual DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAuthorizerResponse>(asyncResult);
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
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from ApiGatewayV2.</returns>
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
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from ApiGatewayV2.</returns>
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
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from ApiGatewayV2.</returns>
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
        public virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from ApiGatewayV2.</returns>
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
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelRequest,DeleteModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from ApiGatewayV2.</returns>
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
        public virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from ApiGatewayV2.</returns>
        public virtual DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponse>(asyncResult);
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
        public virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request)
        {
            var marshaller = DeleteRouteResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseRequest,DeleteRouteResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteRouteResponse(DeleteRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteRouteResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRouteResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteResponse.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResponseResult from ApiGatewayV2.</returns>
        public virtual DeleteRouteResponseResponse EndDeleteRouteResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponseResponse>(asyncResult);
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
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageRequest,DeleteStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from ApiGatewayV2.</returns>
        public virtual DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
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
        public virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var marshaller = GetApiRequestMarshaller.Instance;
            var unmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiRequest,GetApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApi(GetApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApiRequestMarshaller.Instance;
            var unmarshaller = GetApiResponseUnmarshaller.Instance;

            return BeginInvoke<GetApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApi.</param>
        /// 
        /// <returns>Returns a  GetApiResult from ApiGatewayV2.</returns>
        public virtual GetApiResponse EndGetApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiMapping

        /// <summary>
        /// The API mapping.
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
        public virtual GetApiMappingResponse GetApiMapping(GetApiMappingRequest request)
        {
            var marshaller = GetApiMappingRequestMarshaller.Instance;
            var unmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingRequest,GetApiMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApiMapping(GetApiMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApiMappingRequestMarshaller.Instance;
            var unmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke<GetApiMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMapping.</param>
        /// 
        /// <returns>Returns a  GetApiMappingResult from ApiGatewayV2.</returns>
        public virtual GetApiMappingResponse EndGetApiMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiMappings

        /// <summary>
        /// The API mappings.
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
        public virtual GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request)
        {
            var marshaller = GetApiMappingsRequestMarshaller.Instance;
            var unmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsRequest,GetApiMappingsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApiMappings(GetApiMappingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApiMappingsRequestMarshaller.Instance;
            var unmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return BeginInvoke<GetApiMappingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiMappings.</param>
        /// 
        /// <returns>Returns a  GetApiMappingsResult from ApiGatewayV2.</returns>
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
        public virtual GetApisResponse GetApis(GetApisRequest request)
        {
            var marshaller = GetApisRequestMarshaller.Instance;
            var unmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisRequest,GetApisResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApis(GetApisRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApisRequestMarshaller.Instance;
            var unmarshaller = GetApisResponseUnmarshaller.Instance;

            return BeginInvoke<GetApisRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApis.</param>
        /// 
        /// <returns>Returns a  GetApisResult from ApiGatewayV2.</returns>
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
        public virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerRequest,GetAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<GetAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from ApiGatewayV2.</returns>
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
        public virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersRequest,GetAuthorizersResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return BeginInvoke<GetAuthorizersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from ApiGatewayV2.</returns>
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
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from ApiGatewayV2.</returns>
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
        public virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from ApiGatewayV2.</returns>
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
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from ApiGatewayV2.</returns>
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
        public virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from ApiGatewayV2.</returns>
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
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from ApiGatewayV2.</returns>
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
        public virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from ApiGatewayV2.</returns>
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
        public virtual GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request)
        {
            var marshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesRequest,GetIntegrationResponsesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegrationResponses(GetIntegrationResponsesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationResponsesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponses.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponsesResult from ApiGatewayV2.</returns>
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
        public virtual GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request)
        {
            var marshaller = GetIntegrationsRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsRequest,GetIntegrationsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegrations(GetIntegrationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationsRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrations.</param>
        /// 
        /// <returns>Returns a  GetIntegrationsResult from ApiGatewayV2.</returns>
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
        public virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelRequest,GetModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from ApiGatewayV2.</returns>
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
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsRequest,GetModelsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from ApiGatewayV2.</returns>
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
        public virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from ApiGatewayV2.</returns>
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
        public virtual GetRouteResponse GetRoute(GetRouteRequest request)
        {
            var marshaller = GetRouteRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteRequest,GetRouteResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRoute(GetRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRouteRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponseUnmarshaller.Instance;

            return BeginInvoke<GetRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoute.</param>
        /// 
        /// <returns>Returns a  GetRouteResult from ApiGatewayV2.</returns>
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
        public virtual GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request)
        {
            var marshaller = GetRouteResponseRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseRequest,GetRouteResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRouteResponse(GetRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRouteResponseRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke<GetRouteResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponse.</param>
        /// 
        /// <returns>Returns a  GetRouteResponseResult from ApiGatewayV2.</returns>
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
        public virtual GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request)
        {
            var marshaller = GetRouteResponsesRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesRequest,GetRouteResponsesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRouteResponses(GetRouteResponsesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRouteResponsesRequestMarshaller.Instance;
            var unmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return BeginInvoke<GetRouteResponsesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteResponses.</param>
        /// 
        /// <returns>Returns a  GetRouteResponsesResult from ApiGatewayV2.</returns>
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
        public virtual GetRoutesResponse GetRoutes(GetRoutesRequest request)
        {
            var marshaller = GetRoutesRequestMarshaller.Instance;
            var unmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesRequest,GetRoutesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRoutes(GetRoutesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRoutesRequestMarshaller.Instance;
            var unmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return BeginInvoke<GetRoutesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutes.</param>
        /// 
        /// <returns>Returns a  GetRoutesResult from ApiGatewayV2.</returns>
        public virtual GetRoutesResponse EndGetRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoutesResponse>(asyncResult);
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
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageRequest,GetStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke<GetStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from ApiGatewayV2.</returns>
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
        public virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesRequest,GetStagesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return BeginInvoke<GetStagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from ApiGatewayV2.</returns>
        public virtual GetStagesResponse EndGetStages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStagesResponse>(asyncResult);
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
        public virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var marshaller = UpdateApiRequestMarshaller.Instance;
            var unmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiRequest,UpdateApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateApi(UpdateApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApiRequestMarshaller.Instance;
            var unmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApi.</param>
        /// 
        /// <returns>Returns a  UpdateApiResult from ApiGatewayV2.</returns>
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
        public virtual UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request)
        {
            var marshaller = UpdateApiMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingRequest,UpdateApiMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateApiMapping(UpdateApiMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApiMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApiMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiMapping.</param>
        /// 
        /// <returns>Returns a  UpdateApiMappingResult from ApiGatewayV2.</returns>
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
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerRequest,UpdateAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from ApiGatewayV2.</returns>
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
        public virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from ApiGatewayV2.</returns>
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
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from ApiGatewayV2.</returns>
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
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from ApiGatewayV2.</returns>
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
        public virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from ApiGatewayV2.</returns>
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
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelRequest,UpdateModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from ApiGatewayV2.</returns>
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
        public virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var marshaller = UpdateRouteRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteRequest,UpdateRouteResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateRouteRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from ApiGatewayV2.</returns>
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
        public virtual UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request)
        {
            var marshaller = UpdateRouteResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseRequest,UpdateRouteResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateRouteResponse(UpdateRouteResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateRouteResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRouteResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouteResponse.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResponseResult from ApiGatewayV2.</returns>
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
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageRequest,UpdateStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from ApiGatewayV2.</returns>
        public virtual UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
        }

        #endregion
        
    }
}