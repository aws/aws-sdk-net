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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Imagebuilder.Model;
using Amazon.Imagebuilder.Model.Internal.MarshallTransformations;
using Amazon.Imagebuilder.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Imagebuilder
{
    /// <summary>
    /// Implementation for accessing Imagebuilder
    ///
    /// EC2 Image Builder is a fully managed Amazon Web Services service that makes it easier
    /// to automate the creation, management, and deployment of customized, secure, and up-to-date
    /// "golden" server images that are pre-installed and pre-configured with software and
    /// settings to meet specific IT standards.
    /// </summary>
    public partial class AmazonImagebuilderClient : AmazonServiceClient, IAmazonImagebuilder
    {
        private static IServiceMetadata serviceMetadata = new AmazonImagebuilderMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IImagebuilderPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IImagebuilderPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ImagebuilderPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        public AmazonImagebuilderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImagebuilderConfig()) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        public AmazonImagebuilderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImagebuilderConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(AmazonImagebuilderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonImagebuilderClient(AWSCredentials credentials)
            : this(credentials, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonImagebuilderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Credentials and an
        /// AmazonImagebuilderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(AWSCredentials credentials, AmazonImagebuilderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImagebuilderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImagebuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonImagebuilderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImagebuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImagebuilderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonImagebuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImagebuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonImagebuilderClient Configuration Object</param>
        public AmazonImagebuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonImagebuilderConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonImagebuilderEndpointResolver());
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


        #region  CancelImageCreation

        /// <summary>
        /// CancelImageCreation cancels the creation of Image. This operation can only be used
        /// on images in a non-terminal state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImageCreation service method.</param>
        /// 
        /// <returns>The response from the CancelImageCreation service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelImageCreation">REST API Reference for CancelImageCreation Operation</seealso>
        public virtual CancelImageCreationResponse CancelImageCreation(CancelImageCreationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImageCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImageCreationResponseUnmarshaller.Instance;

            return Invoke<CancelImageCreationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelImageCreation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImageCreation operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelImageCreation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelImageCreation">REST API Reference for CancelImageCreation Operation</seealso>
        public virtual IAsyncResult BeginCancelImageCreation(CancelImageCreationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImageCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImageCreationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelImageCreation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelImageCreation.</param>
        /// 
        /// <returns>Returns a  CancelImageCreationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CancelImageCreation">REST API Reference for CancelImageCreation Operation</seealso>
        public virtual CancelImageCreationResponse EndCancelImageCreation(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelImageCreationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponent

        /// <summary>
        /// Creates a new component that can be used to build, validate, test, and assess your
        /// image. The component is based on a YAML document that you specify using exactly one
        /// of the following methods:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Inline, using the <code>data</code> property in the request body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A URL that points to a YAML document file stored in Amazon S3, using the <code>uri</code>
        /// property in the request body.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified two or more mutually exclusive parameters. Review the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponent.</param>
        /// 
        /// <returns>Returns a  CreateComponentResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContainerRecipe

        /// <summary>
        /// Creates a new container recipe. Container recipes define how images are configured,
        /// tested, and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerRecipe service method.</param>
        /// 
        /// <returns>The response from the CreateContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateContainerRecipe">REST API Reference for CreateContainerRecipe Operation</seealso>
        public virtual CreateContainerRecipeResponse CreateContainerRecipe(CreateContainerRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateContainerRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContainerRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateContainerRecipe">REST API Reference for CreateContainerRecipe Operation</seealso>
        public virtual IAsyncResult BeginCreateContainerRecipe(CreateContainerRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContainerRecipe.</param>
        /// 
        /// <returns>Returns a  CreateContainerRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateContainerRecipe">REST API Reference for CreateContainerRecipe Operation</seealso>
        public virtual CreateContainerRecipeResponse EndCreateContainerRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContainerRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDistributionConfiguration

        /// <summary>
        /// Creates a new distribution configuration. Distribution configurations define and configure
        /// the outputs of your pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified two or more mutually exclusive parameters. Review the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateDistributionConfiguration">REST API Reference for CreateDistributionConfiguration Operation</seealso>
        public virtual CreateDistributionConfigurationResponse CreateDistributionConfiguration(CreateDistributionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistributionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateDistributionConfiguration">REST API Reference for CreateDistributionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateDistributionConfiguration(CreateDistributionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistributionConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateDistributionConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateDistributionConfiguration">REST API Reference for CreateDistributionConfiguration Operation</seealso>
        public virtual CreateDistributionConfigurationResponse EndCreateDistributionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDistributionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImage

        /// <summary>
        /// Creates a new image. This request will create a new image along with all of the configured
        /// output resources defined in the distribution configuration. You must specify exactly
        /// one recipe for your image, using either a ContainerRecipeArn or an ImageRecipeArn.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual IAsyncResult BeginCreateImage(CreateImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a  CreateImageResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual CreateImageResponse EndCreateImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImagePipeline

        /// <summary>
        /// Creates a new image pipeline. Image pipelines enable you to automate the creation
        /// and distribution of images.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImagePipeline service method.</param>
        /// 
        /// <returns>The response from the CreateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImagePipeline">REST API Reference for CreateImagePipeline Operation</seealso>
        public virtual CreateImagePipelineResponse CreateImagePipeline(CreateImagePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<CreateImagePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImagePipeline operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImagePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImagePipeline">REST API Reference for CreateImagePipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateImagePipeline(CreateImagePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImagePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImagePipeline.</param>
        /// 
        /// <returns>Returns a  CreateImagePipelineResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImagePipeline">REST API Reference for CreateImagePipeline Operation</seealso>
        public virtual CreateImagePipelineResponse EndCreateImagePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImagePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImageRecipe

        /// <summary>
        /// Creates a new image recipe. Image recipes define how images are configured, tested,
        /// and assessed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageRecipe service method.</param>
        /// 
        /// <returns>The response from the CreateImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImageRecipe">REST API Reference for CreateImageRecipe Operation</seealso>
        public virtual CreateImageRecipeResponse CreateImageRecipe(CreateImageRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateImageRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImageRecipe">REST API Reference for CreateImageRecipe Operation</seealso>
        public virtual IAsyncResult BeginCreateImageRecipe(CreateImageRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageRecipe.</param>
        /// 
        /// <returns>Returns a  CreateImageRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateImageRecipe">REST API Reference for CreateImageRecipe Operation</seealso>
        public virtual CreateImageRecipeResponse EndCreateImageRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImageRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInfrastructureConfiguration

        /// <summary>
        /// Creates a new infrastructure configuration. An infrastructure configuration defines
        /// the environment in which your image will be built and tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInfrastructureConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceAlreadyExistsException">
        /// The resource that you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceQuotaExceededException">
        /// You have exceeded the number of permitted resources or operations for this service.
        /// For service quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html#limits_imagebuilder">EC2
        /// Image Builder endpoints and quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateInfrastructureConfiguration">REST API Reference for CreateInfrastructureConfiguration Operation</seealso>
        public virtual CreateInfrastructureConfigurationResponse CreateInfrastructureConfiguration(CreateInfrastructureConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInfrastructureConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInfrastructureConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInfrastructureConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateInfrastructureConfiguration">REST API Reference for CreateInfrastructureConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateInfrastructureConfiguration(CreateInfrastructureConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInfrastructureConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateInfrastructureConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/CreateInfrastructureConfiguration">REST API Reference for CreateInfrastructureConfiguration Operation</seealso>
        public virtual CreateInfrastructureConfigurationResponse EndCreateInfrastructureConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInfrastructureConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Deletes a component build version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContainerRecipe

        /// <summary>
        /// Deletes a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerRecipe service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteContainerRecipe">REST API Reference for DeleteContainerRecipe Operation</seealso>
        public virtual DeleteContainerRecipeResponse DeleteContainerRecipe(DeleteContainerRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContainerRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteContainerRecipe">REST API Reference for DeleteContainerRecipe Operation</seealso>
        public virtual IAsyncResult BeginDeleteContainerRecipe(DeleteContainerRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContainerRecipe.</param>
        /// 
        /// <returns>Returns a  DeleteContainerRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteContainerRecipe">REST API Reference for DeleteContainerRecipe Operation</seealso>
        public virtual DeleteContainerRecipeResponse EndDeleteContainerRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContainerRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDistributionConfiguration

        /// <summary>
        /// Deletes a distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteDistributionConfiguration">REST API Reference for DeleteDistributionConfiguration Operation</seealso>
        public virtual DeleteDistributionConfigurationResponse DeleteDistributionConfiguration(DeleteDistributionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistributionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteDistributionConfiguration">REST API Reference for DeleteDistributionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteDistributionConfiguration(DeleteDistributionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistributionConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteDistributionConfiguration">REST API Reference for DeleteDistributionConfiguration Operation</seealso>
        public virtual DeleteDistributionConfigurationResponse EndDeleteDistributionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDistributionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImage

        /// <summary>
        /// Deletes an Image Builder image resource. This does not delete any EC2 AMIs or ECR
        /// container images that are created during the image build process. You must clean those
        /// up separately, using the appropriate Amazon EC2 or Amazon ECR console actions, or
        /// API or CLI commands.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To deregister an EC2 Linux AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html">Deregister
        /// your Linux AMI</a> in the <i> <i>Amazon EC2 User Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To deregister an EC2 Windows AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/deregister-ami.html">Deregister
        /// your Windows AMI</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a container image from Amazon ECR, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/delete_image.html">Deleting
        /// an image</a> in the <i>Amazon ECR User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual IAsyncResult BeginDeleteImage(DeleteImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImage.</param>
        /// 
        /// <returns>Returns a  DeleteImageResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual DeleteImageResponse EndDeleteImage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImagePipeline

        /// <summary>
        /// Deletes an image pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePipeline service method.</param>
        /// 
        /// <returns>The response from the DeleteImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImagePipeline">REST API Reference for DeleteImagePipeline Operation</seealso>
        public virtual DeleteImagePipelineResponse DeleteImagePipeline(DeleteImagePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteImagePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePipeline operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImagePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImagePipeline">REST API Reference for DeleteImagePipeline Operation</seealso>
        public virtual IAsyncResult BeginDeleteImagePipeline(DeleteImagePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImagePipeline.</param>
        /// 
        /// <returns>Returns a  DeleteImagePipelineResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImagePipeline">REST API Reference for DeleteImagePipeline Operation</seealso>
        public virtual DeleteImagePipelineResponse EndDeleteImagePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImagePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImageRecipe

        /// <summary>
        /// Deletes an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageRecipe service method.</param>
        /// 
        /// <returns>The response from the DeleteImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImageRecipe">REST API Reference for DeleteImageRecipe Operation</seealso>
        public virtual DeleteImageRecipeResponse DeleteImageRecipe(DeleteImageRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageRecipeResponseUnmarshaller.Instance;

            return Invoke<DeleteImageRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImageRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImageRecipe">REST API Reference for DeleteImageRecipe Operation</seealso>
        public virtual IAsyncResult BeginDeleteImageRecipe(DeleteImageRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImageRecipe.</param>
        /// 
        /// <returns>Returns a  DeleteImageRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteImageRecipe">REST API Reference for DeleteImageRecipe Operation</seealso>
        public virtual DeleteImageRecipeResponse EndDeleteImageRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImageRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInfrastructureConfiguration

        /// <summary>
        /// Deletes an infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInfrastructureConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceDependencyException">
        /// You have attempted to mutate or delete a resource with a dependency that prohibits
        /// this action. See the error message for more details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteInfrastructureConfiguration">REST API Reference for DeleteInfrastructureConfiguration Operation</seealso>
        public virtual DeleteInfrastructureConfigurationResponse DeleteInfrastructureConfiguration(DeleteInfrastructureConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInfrastructureConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInfrastructureConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInfrastructureConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteInfrastructureConfiguration">REST API Reference for DeleteInfrastructureConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteInfrastructureConfiguration(DeleteInfrastructureConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInfrastructureConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInfrastructureConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteInfrastructureConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/DeleteInfrastructureConfiguration">REST API Reference for DeleteInfrastructureConfiguration Operation</seealso>
        public virtual DeleteInfrastructureConfigurationResponse EndDeleteInfrastructureConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInfrastructureConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Gets a component object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponentPolicy

        /// <summary>
        /// Gets a component policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentPolicy service method.</param>
        /// 
        /// <returns>The response from the GetComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponentPolicy">REST API Reference for GetComponentPolicy Operation</seealso>
        public virtual GetComponentPolicyResponse GetComponentPolicy(GetComponentPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<GetComponentPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponentPolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponentPolicy">REST API Reference for GetComponentPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetComponentPolicy(GetComponentPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponentPolicy.</param>
        /// 
        /// <returns>Returns a  GetComponentPolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetComponentPolicy">REST API Reference for GetComponentPolicy Operation</seealso>
        public virtual GetComponentPolicyResponse EndGetComponentPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContainerRecipe

        /// <summary>
        /// Retrieves a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipe service method.</param>
        /// 
        /// <returns>The response from the GetContainerRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipe">REST API Reference for GetContainerRecipe Operation</seealso>
        public virtual GetContainerRecipeResponse GetContainerRecipe(GetContainerRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipeResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipe">REST API Reference for GetContainerRecipe Operation</seealso>
        public virtual IAsyncResult BeginGetContainerRecipe(GetContainerRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerRecipe.</param>
        /// 
        /// <returns>Returns a  GetContainerRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipe">REST API Reference for GetContainerRecipe Operation</seealso>
        public virtual GetContainerRecipeResponse EndGetContainerRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContainerRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContainerRecipePolicy

        /// <summary>
        /// Retrieves the policy for a container recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipePolicy service method.</param>
        /// 
        /// <returns>The response from the GetContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipePolicy">REST API Reference for GetContainerRecipePolicy Operation</seealso>
        public virtual GetContainerRecipePolicyResponse GetContainerRecipePolicy(GetContainerRecipePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerRecipePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContainerRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerRecipePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerRecipePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipePolicy">REST API Reference for GetContainerRecipePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetContainerRecipePolicy(GetContainerRecipePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerRecipePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerRecipePolicy.</param>
        /// 
        /// <returns>Returns a  GetContainerRecipePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetContainerRecipePolicy">REST API Reference for GetContainerRecipePolicy Operation</seealso>
        public virtual GetContainerRecipePolicyResponse EndGetContainerRecipePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContainerRecipePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDistributionConfiguration

        /// <summary>
        /// Gets a distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetDistributionConfiguration">REST API Reference for GetDistributionConfiguration Operation</seealso>
        public virtual GetDistributionConfigurationResponse GetDistributionConfiguration(GetDistributionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetDistributionConfiguration">REST API Reference for GetDistributionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetDistributionConfiguration(GetDistributionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDistributionConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetDistributionConfiguration">REST API Reference for GetDistributionConfiguration Operation</seealso>
        public virtual GetDistributionConfigurationResponse EndGetDistributionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDistributionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImage

        /// <summary>
        /// Gets an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImage service method.</param>
        /// 
        /// <returns>The response from the GetImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImage">REST API Reference for GetImage Operation</seealso>
        public virtual GetImageResponse GetImage(GetImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageResponseUnmarshaller.Instance;

            return Invoke<GetImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImage operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImage">REST API Reference for GetImage Operation</seealso>
        public virtual IAsyncResult BeginGetImage(GetImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImage.</param>
        /// 
        /// <returns>Returns a  GetImageResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImage">REST API Reference for GetImage Operation</seealso>
        public virtual GetImageResponse EndGetImage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImagePipeline

        /// <summary>
        /// Gets an image pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePipeline service method.</param>
        /// 
        /// <returns>The response from the GetImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePipeline">REST API Reference for GetImagePipeline Operation</seealso>
        public virtual GetImagePipelineResponse GetImagePipeline(GetImagePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePipelineResponseUnmarshaller.Instance;

            return Invoke<GetImagePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImagePipeline operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImagePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePipeline">REST API Reference for GetImagePipeline Operation</seealso>
        public virtual IAsyncResult BeginGetImagePipeline(GetImagePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImagePipeline.</param>
        /// 
        /// <returns>Returns a  GetImagePipelineResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePipeline">REST API Reference for GetImagePipeline Operation</seealso>
        public virtual GetImagePipelineResponse EndGetImagePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImagePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImagePolicy

        /// <summary>
        /// Gets an image policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImagePolicy service method.</param>
        /// 
        /// <returns>The response from the GetImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePolicy">REST API Reference for GetImagePolicy Operation</seealso>
        public virtual GetImagePolicyResponse GetImagePolicy(GetImagePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImagePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImagePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImagePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImagePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePolicy">REST API Reference for GetImagePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetImagePolicy(GetImagePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImagePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImagePolicy.</param>
        /// 
        /// <returns>Returns a  GetImagePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImagePolicy">REST API Reference for GetImagePolicy Operation</seealso>
        public virtual GetImagePolicyResponse EndGetImagePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImagePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImageRecipe

        /// <summary>
        /// Gets an image recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipe service method.</param>
        /// 
        /// <returns>The response from the GetImageRecipe service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipe">REST API Reference for GetImageRecipe Operation</seealso>
        public virtual GetImageRecipeResponse GetImageRecipe(GetImageRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipeResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipe operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImageRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipe">REST API Reference for GetImageRecipe Operation</seealso>
        public virtual IAsyncResult BeginGetImageRecipe(GetImageRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImageRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImageRecipe.</param>
        /// 
        /// <returns>Returns a  GetImageRecipeResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipe">REST API Reference for GetImageRecipe Operation</seealso>
        public virtual GetImageRecipeResponse EndGetImageRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImageRecipePolicy

        /// <summary>
        /// Gets an image recipe policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipePolicy service method.</param>
        /// 
        /// <returns>The response from the GetImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipePolicy">REST API Reference for GetImageRecipePolicy Operation</seealso>
        public virtual GetImageRecipePolicyResponse GetImageRecipePolicy(GetImageRecipePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<GetImageRecipePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImageRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImageRecipePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImageRecipePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipePolicy">REST API Reference for GetImageRecipePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetImageRecipePolicy(GetImageRecipePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImageRecipePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImageRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImageRecipePolicy.</param>
        /// 
        /// <returns>Returns a  GetImageRecipePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetImageRecipePolicy">REST API Reference for GetImageRecipePolicy Operation</seealso>
        public virtual GetImageRecipePolicyResponse EndGetImageRecipePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImageRecipePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInfrastructureConfiguration

        /// <summary>
        /// Gets an infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInfrastructureConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetInfrastructureConfiguration">REST API Reference for GetInfrastructureConfiguration Operation</seealso>
        public virtual GetInfrastructureConfigurationResponse GetInfrastructureConfiguration(GetInfrastructureConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetInfrastructureConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInfrastructureConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInfrastructureConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetInfrastructureConfiguration">REST API Reference for GetInfrastructureConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetInfrastructureConfiguration(GetInfrastructureConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInfrastructureConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInfrastructureConfiguration.</param>
        /// 
        /// <returns>Returns a  GetInfrastructureConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/GetInfrastructureConfiguration">REST API Reference for GetInfrastructureConfiguration Operation</seealso>
        public virtual GetInfrastructureConfigurationResponse EndGetInfrastructureConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInfrastructureConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportComponent

        /// <summary>
        /// Imports a component and transforms its data into a component document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportComponent service method.</param>
        /// 
        /// <returns>The response from the ImportComponent service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified two or more mutually exclusive parameters. Review the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidVersionNumberException">
        /// Your version number is out of bounds or does not follow the required syntax.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportComponent">REST API Reference for ImportComponent Operation</seealso>
        public virtual ImportComponentResponse ImportComponent(ImportComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportComponentResponseUnmarshaller.Instance;

            return Invoke<ImportComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportComponent operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportComponent">REST API Reference for ImportComponent Operation</seealso>
        public virtual IAsyncResult BeginImportComponent(ImportComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportComponent.</param>
        /// 
        /// <returns>Returns a  ImportComponentResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportComponent">REST API Reference for ImportComponent Operation</seealso>
        public virtual ImportComponentResponse EndImportComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportVmImage

        /// <summary>
        /// When you export your virtual machine (VM) from its virtualization environment, that
        /// process creates a set of one or more disk container files that act as snapshots of
        /// your VM’s environment, settings, and data. The Amazon EC2 API <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportImage.html">ImportImage</a>
        /// action uses those files to import your VM and create an AMI. To import using the CLI
        /// command, see <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/import-image.html">import-image</a>
        /// 
        /// 
        ///  
        /// <para>
        /// You can reference the task ID from the VM import to pull in the AMI that the import
        /// created as the base image for your Image Builder recipe.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVmImage service method.</param>
        /// 
        /// <returns>The response from the ImportVmImage service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportVmImage">REST API Reference for ImportVmImage Operation</seealso>
        public virtual ImportVmImageResponse ImportVmImage(ImportVmImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVmImageResponseUnmarshaller.Instance;

            return Invoke<ImportVmImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVmImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVmImage operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportVmImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportVmImage">REST API Reference for ImportVmImage Operation</seealso>
        public virtual IAsyncResult BeginImportVmImage(ImportVmImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVmImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportVmImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVmImage.</param>
        /// 
        /// <returns>Returns a  ImportVmImageResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ImportVmImage">REST API Reference for ImportVmImage Operation</seealso>
        public virtual ImportVmImageResponse EndImportVmImage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportVmImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponentBuildVersions

        /// <summary>
        /// Returns the list of component build versions for the specified semantic version.
        /// 
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> With semantic versioning, you have the flexibility to use wildcards
        /// (x) to specify the most recent versions or nodes when selecting the base image or
        /// components for your recipe. When you use a wildcard in any node, all nodes to the
        /// right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentBuildVersions service method.</param>
        /// 
        /// <returns>The response from the ListComponentBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponentBuildVersions">REST API Reference for ListComponentBuildVersions Operation</seealso>
        public virtual ListComponentBuildVersionsResponse ListComponentBuildVersions(ListComponentBuildVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentBuildVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentBuildVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentBuildVersions operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentBuildVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponentBuildVersions">REST API Reference for ListComponentBuildVersions Operation</seealso>
        public virtual IAsyncResult BeginListComponentBuildVersions(ListComponentBuildVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentBuildVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentBuildVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentBuildVersions.</param>
        /// 
        /// <returns>Returns a  ListComponentBuildVersionsResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponentBuildVersions">REST API Reference for ListComponentBuildVersions Operation</seealso>
        public virtual ListComponentBuildVersionsResponse EndListComponentBuildVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentBuildVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Returns the list of components that can be filtered by name, or by using the listed
        /// <code>filters</code> to streamline results. Newly created components can take up to
        /// two minutes to appear in the ListComponents API Results.
        /// 
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> With semantic versioning, you have the flexibility to use wildcards
        /// (x) to specify the most recent versions or nodes when selecting the base image or
        /// components for your recipe. When you use a wildcard in any node, all nodes to the
        /// right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContainerRecipes

        /// <summary>
        /// Returns a list of container recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerRecipes service method.</param>
        /// 
        /// <returns>The response from the ListContainerRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListContainerRecipes">REST API Reference for ListContainerRecipes Operation</seealso>
        public virtual ListContainerRecipesResponse ListContainerRecipes(ListContainerRecipesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainerRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerRecipesResponseUnmarshaller.Instance;

            return Invoke<ListContainerRecipesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContainerRecipes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainerRecipes operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContainerRecipes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListContainerRecipes">REST API Reference for ListContainerRecipes Operation</seealso>
        public virtual IAsyncResult BeginListContainerRecipes(ListContainerRecipesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContainerRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerRecipesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContainerRecipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContainerRecipes.</param>
        /// 
        /// <returns>Returns a  ListContainerRecipesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListContainerRecipes">REST API Reference for ListContainerRecipes Operation</seealso>
        public virtual ListContainerRecipesResponse EndListContainerRecipes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContainerRecipesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDistributionConfigurations

        /// <summary>
        /// Returns a list of distribution configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListDistributionConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListDistributionConfigurations">REST API Reference for ListDistributionConfigurations Operation</seealso>
        public virtual ListDistributionConfigurationsResponse ListDistributionConfigurations(ListDistributionConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionConfigurations operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListDistributionConfigurations">REST API Reference for ListDistributionConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListDistributionConfigurations(ListDistributionConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionConfigurations.</param>
        /// 
        /// <returns>Returns a  ListDistributionConfigurationsResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListDistributionConfigurations">REST API Reference for ListDistributionConfigurations Operation</seealso>
        public virtual ListDistributionConfigurationsResponse EndListDistributionConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDistributionConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImageBuildVersions

        /// <summary>
        /// Returns a list of image build versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageBuildVersions service method.</param>
        /// 
        /// <returns>The response from the ListImageBuildVersions service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageBuildVersions">REST API Reference for ListImageBuildVersions Operation</seealso>
        public virtual ListImageBuildVersionsResponse ListImageBuildVersions(ListImageBuildVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageBuildVersionsResponseUnmarshaller.Instance;

            return Invoke<ListImageBuildVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImageBuildVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImageBuildVersions operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImageBuildVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageBuildVersions">REST API Reference for ListImageBuildVersions Operation</seealso>
        public virtual IAsyncResult BeginListImageBuildVersions(ListImageBuildVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageBuildVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageBuildVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImageBuildVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImageBuildVersions.</param>
        /// 
        /// <returns>Returns a  ListImageBuildVersionsResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageBuildVersions">REST API Reference for ListImageBuildVersions Operation</seealso>
        public virtual ListImageBuildVersionsResponse EndListImageBuildVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImageBuildVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImagePackages

        /// <summary>
        /// List the Packages that are associated with an Image Build Version, as determined by
        /// Amazon Web Services Systems Manager Inventory at build time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePackages service method.</param>
        /// 
        /// <returns>The response from the ListImagePackages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePackages">REST API Reference for ListImagePackages Operation</seealso>
        public virtual ListImagePackagesResponse ListImagePackages(ListImagePackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePackagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImagePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImagePackages operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImagePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePackages">REST API Reference for ListImagePackages Operation</seealso>
        public virtual IAsyncResult BeginListImagePackages(ListImagePackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImagePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImagePackages.</param>
        /// 
        /// <returns>Returns a  ListImagePackagesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePackages">REST API Reference for ListImagePackages Operation</seealso>
        public virtual ListImagePackagesResponse EndListImagePackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImagePackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImagePipelineImages

        /// <summary>
        /// Returns a list of images created by the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelineImages service method.</param>
        /// 
        /// <returns>The response from the ListImagePipelineImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelineImages">REST API Reference for ListImagePipelineImages Operation</seealso>
        public virtual ListImagePipelineImagesResponse ListImagePipelineImages(ListImagePipelineImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePipelineImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelineImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelineImagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImagePipelineImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelineImages operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImagePipelineImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelineImages">REST API Reference for ListImagePipelineImages Operation</seealso>
        public virtual IAsyncResult BeginListImagePipelineImages(ListImagePipelineImagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePipelineImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelineImagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImagePipelineImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImagePipelineImages.</param>
        /// 
        /// <returns>Returns a  ListImagePipelineImagesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelineImages">REST API Reference for ListImagePipelineImages Operation</seealso>
        public virtual ListImagePipelineImagesResponse EndListImagePipelineImages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImagePipelineImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImagePipelines

        /// <summary>
        /// Returns a list of image pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelines service method.</param>
        /// 
        /// <returns>The response from the ListImagePipelines service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelines">REST API Reference for ListImagePipelines Operation</seealso>
        public virtual ListImagePipelinesResponse ListImagePipelines(ListImagePipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelinesResponseUnmarshaller.Instance;

            return Invoke<ListImagePipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImagePipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImagePipelines operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImagePipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelines">REST API Reference for ListImagePipelines Operation</seealso>
        public virtual IAsyncResult BeginListImagePipelines(ListImagePipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagePipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImagePipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImagePipelines.</param>
        /// 
        /// <returns>Returns a  ListImagePipelinesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImagePipelines">REST API Reference for ListImagePipelines Operation</seealso>
        public virtual ListImagePipelinesResponse EndListImagePipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImagePipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImageRecipes

        /// <summary>
        /// Returns a list of image recipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageRecipes service method.</param>
        /// 
        /// <returns>The response from the ListImageRecipes service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageRecipes">REST API Reference for ListImageRecipes Operation</seealso>
        public virtual ListImageRecipesResponse ListImageRecipes(ListImageRecipesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageRecipesResponseUnmarshaller.Instance;

            return Invoke<ListImageRecipesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImageRecipes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImageRecipes operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImageRecipes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageRecipes">REST API Reference for ListImageRecipes Operation</seealso>
        public virtual IAsyncResult BeginListImageRecipes(ListImageRecipesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageRecipesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImageRecipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImageRecipes.</param>
        /// 
        /// <returns>Returns a  ListImageRecipesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImageRecipes">REST API Reference for ListImageRecipes Operation</seealso>
        public virtual ListImageRecipesResponse EndListImageRecipes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImageRecipesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImages

        /// <summary>
        /// Returns the list of images that you have access to. Newly created images can take
        /// up to two minutes to appear in the ListImages API Results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImages">REST API Reference for ListImages Operation</seealso>
        public virtual ListImagesResponse ListImages(ListImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImages operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImages">REST API Reference for ListImages Operation</seealso>
        public virtual IAsyncResult BeginListImages(ListImagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImages.</param>
        /// 
        /// <returns>Returns a  ListImagesResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListImages">REST API Reference for ListImages Operation</seealso>
        public virtual ListImagesResponse EndListImages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInfrastructureConfigurations

        /// <summary>
        /// Returns a list of infrastructure configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInfrastructureConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListInfrastructureConfigurations service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidPaginationTokenException">
        /// You have provided an invalid pagination token in your request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListInfrastructureConfigurations">REST API Reference for ListInfrastructureConfigurations Operation</seealso>
        public virtual ListInfrastructureConfigurationsResponse ListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInfrastructureConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInfrastructureConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListInfrastructureConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInfrastructureConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInfrastructureConfigurations operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInfrastructureConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListInfrastructureConfigurations">REST API Reference for ListInfrastructureConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListInfrastructureConfigurations(ListInfrastructureConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInfrastructureConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInfrastructureConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInfrastructureConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInfrastructureConfigurations.</param>
        /// 
        /// <returns>Returns a  ListInfrastructureConfigurationsResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListInfrastructureConfigurations">REST API Reference for ListInfrastructureConfigurations Operation</seealso>
        public virtual ListInfrastructureConfigurationsResponse EndListInfrastructureConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInfrastructureConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns the list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutComponentPolicy

        /// <summary>
        /// Applies a policy to a component. We recommend that you call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>
        /// to share resources. If you call the Image Builder API <code>PutComponentPolicy</code>,
        /// you must also call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// in order for the resource to be visible to all principals with whom the resource is
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComponentPolicy service method.</param>
        /// 
        /// <returns>The response from the PutComponentPolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutComponentPolicy">REST API Reference for PutComponentPolicy Operation</seealso>
        public virtual PutComponentPolicyResponse PutComponentPolicy(PutComponentPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComponentPolicyResponseUnmarshaller.Instance;

            return Invoke<PutComponentPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutComponentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutComponentPolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutComponentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutComponentPolicy">REST API Reference for PutComponentPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutComponentPolicy(PutComponentPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutComponentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComponentPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutComponentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutComponentPolicy.</param>
        /// 
        /// <returns>Returns a  PutComponentPolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutComponentPolicy">REST API Reference for PutComponentPolicy Operation</seealso>
        public virtual PutComponentPolicyResponse EndPutComponentPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutComponentPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutContainerRecipePolicy

        /// <summary>
        /// Applies a policy to a container image. We recommend that you call the RAM API CreateResourceShare
        /// (https://docs.aws.amazon.com//ram/latest/APIReference/API_CreateResourceShare.html)
        /// to share resources. If you call the Image Builder API <code>PutContainerImagePolicy</code>,
        /// you must also call the RAM API PromoteResourceShareCreatedFromPolicy (https://docs.aws.amazon.com//ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html)
        /// in order for the resource to be visible to all principals with whom the resource is
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerRecipePolicy service method.</param>
        /// 
        /// <returns>The response from the PutContainerRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutContainerRecipePolicy">REST API Reference for PutContainerRecipePolicy Operation</seealso>
        public virtual PutContainerRecipePolicyResponse PutContainerRecipePolicy(PutContainerRecipePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerRecipePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutContainerRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContainerRecipePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContainerRecipePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutContainerRecipePolicy">REST API Reference for PutContainerRecipePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutContainerRecipePolicy(PutContainerRecipePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContainerRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerRecipePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutContainerRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContainerRecipePolicy.</param>
        /// 
        /// <returns>Returns a  PutContainerRecipePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutContainerRecipePolicy">REST API Reference for PutContainerRecipePolicy Operation</seealso>
        public virtual PutContainerRecipePolicyResponse EndPutContainerRecipePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutContainerRecipePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutImagePolicy

        /// <summary>
        /// Applies a policy to an image. We recommend that you call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>
        /// to share resources. If you call the Image Builder API <code>PutImagePolicy</code>,
        /// you must also call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// in order for the resource to be visible to all principals with whom the resource is
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImagePolicy service method.</param>
        /// 
        /// <returns>The response from the PutImagePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImagePolicy">REST API Reference for PutImagePolicy Operation</seealso>
        public virtual PutImagePolicyResponse PutImagePolicy(PutImagePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImagePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImagePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutImagePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImagePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutImagePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImagePolicy">REST API Reference for PutImagePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutImagePolicy(PutImagePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImagePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImagePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutImagePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutImagePolicy.</param>
        /// 
        /// <returns>Returns a  PutImagePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImagePolicy">REST API Reference for PutImagePolicy Operation</seealso>
        public virtual PutImagePolicyResponse EndPutImagePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutImagePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutImageRecipePolicy

        /// <summary>
        /// Applies a policy to an image recipe. We recommend that you call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_CreateResourceShare.html">CreateResourceShare</a>
        /// to share resources. If you call the Image Builder API <code>PutImageRecipePolicy</code>,
        /// you must also call the RAM API <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// in order for the resource to be visible to all principals with whom the resource is
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImageRecipePolicy service method.</param>
        /// 
        /// <returns>The response from the PutImageRecipePolicy service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterValueException">
        /// The value that you provided for the specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImageRecipePolicy">REST API Reference for PutImageRecipePolicy Operation</seealso>
        public virtual PutImageRecipePolicyResponse PutImageRecipePolicy(PutImageRecipePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageRecipePolicyResponseUnmarshaller.Instance;

            return Invoke<PutImageRecipePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutImageRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImageRecipePolicy operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutImageRecipePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImageRecipePolicy">REST API Reference for PutImageRecipePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutImageRecipePolicy(PutImageRecipePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutImageRecipePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutImageRecipePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutImageRecipePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutImageRecipePolicy.</param>
        /// 
        /// <returns>Returns a  PutImageRecipePolicyResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/PutImageRecipePolicy">REST API Reference for PutImageRecipePolicy Operation</seealso>
        public virtual PutImageRecipePolicyResponse EndPutImageRecipePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutImageRecipePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImagePipelineExecution

        /// <summary>
        /// Manually triggers a pipeline to create an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImagePipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StartImagePipelineExecution service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartImagePipelineExecution">REST API Reference for StartImagePipelineExecution Operation</seealso>
        public virtual StartImagePipelineExecutionResponse StartImagePipelineExecution(StartImagePipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImagePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImagePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartImagePipelineExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImagePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImagePipelineExecution operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImagePipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartImagePipelineExecution">REST API Reference for StartImagePipelineExecution Operation</seealso>
        public virtual IAsyncResult BeginStartImagePipelineExecution(StartImagePipelineExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImagePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImagePipelineExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImagePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImagePipelineExecution.</param>
        /// 
        /// <returns>Returns a  StartImagePipelineExecutionResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/StartImagePipelineExecution">REST API Reference for StartImagePipelineExecution Operation</seealso>
        public virtual StartImagePipelineExecutionResponse EndStartImagePipelineExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImagePipelineExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceNotFoundException">
        /// At least one of the resources referenced by your request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDistributionConfiguration

        /// <summary>
        /// Updates a new distribution configuration. Distribution configurations define and
        /// configure the outputs of your pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDistributionConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidParameterCombinationException">
        /// You have specified two or more mutually exclusive parameters. Review the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateDistributionConfiguration">REST API Reference for UpdateDistributionConfiguration Operation</seealso>
        public virtual UpdateDistributionConfigurationResponse UpdateDistributionConfiguration(UpdateDistributionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistributionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateDistributionConfiguration">REST API Reference for UpdateDistributionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateDistributionConfiguration(UpdateDistributionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistributionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistributionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateDistributionConfiguration">REST API Reference for UpdateDistributionConfiguration Operation</seealso>
        public virtual UpdateDistributionConfigurationResponse EndUpdateDistributionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDistributionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateImagePipeline

        /// <summary>
        /// Updates an image pipeline. Image pipelines enable you to automate the creation and
        /// distribution of images.
        /// 
        ///  <note> 
        /// <para>
        /// UpdateImagePipeline does not support selective updates for the pipeline. You must
        /// specify all of the required properties in the update request, not just the properties
        /// that have changed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdateImagePipeline service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateImagePipeline">REST API Reference for UpdateImagePipeline Operation</seealso>
        public virtual UpdateImagePipelineResponse UpdateImagePipeline(UpdateImagePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateImagePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePipeline operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImagePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateImagePipeline">REST API Reference for UpdateImagePipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdateImagePipeline(UpdateImagePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImagePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImagePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImagePipeline.</param>
        /// 
        /// <returns>Returns a  UpdateImagePipelineResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateImagePipeline">REST API Reference for UpdateImagePipeline Operation</seealso>
        public virtual UpdateImagePipelineResponse EndUpdateImagePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateImagePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInfrastructureConfiguration

        /// <summary>
        /// Updates a new infrastructure configuration. An infrastructure configuration defines
        /// the environment in which your image will be built and tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInfrastructureConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateInfrastructureConfiguration service method, as returned by Imagebuilder.</returns>
        /// <exception cref="Amazon.Imagebuilder.Model.CallRateLimitExceededException">
        /// You have exceeded the permitted request rate for the specific operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an invalid resource identifier.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ForbiddenException">
        /// You are not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.IdempotentParameterMismatchException">
        /// You have specified a client token for an operation using parameter values that differ
        /// from a previous request that used the same client token.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.InvalidRequestException">
        /// You have made a request for an action that is not supported by the service.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ResourceInUseException">
        /// The resource that you are trying to operate on is currently in use. Review the message
        /// details and retry later.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceException">
        /// This exception is thrown when the service encounters an unrecoverable exception.
        /// </exception>
        /// <exception cref="Amazon.Imagebuilder.Model.ServiceUnavailableException">
        /// The service is unable to process your request at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateInfrastructureConfiguration">REST API Reference for UpdateInfrastructureConfiguration Operation</seealso>
        public virtual UpdateInfrastructureConfigurationResponse UpdateInfrastructureConfiguration(UpdateInfrastructureConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInfrastructureConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInfrastructureConfiguration operation on AmazonImagebuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInfrastructureConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateInfrastructureConfiguration">REST API Reference for UpdateInfrastructureConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateInfrastructureConfiguration(UpdateInfrastructureConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInfrastructureConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInfrastructureConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInfrastructureConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInfrastructureConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateInfrastructureConfigurationResult from Imagebuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/imagebuilder-2019-12-02/UpdateInfrastructureConfiguration">REST API Reference for UpdateInfrastructureConfiguration Operation</seealso>
        public virtual UpdateInfrastructureConfigurationResponse EndUpdateInfrastructureConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInfrastructureConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}