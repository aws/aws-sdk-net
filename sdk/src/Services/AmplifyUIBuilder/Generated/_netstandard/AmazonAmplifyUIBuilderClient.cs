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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations;
using Amazon.AmplifyUIBuilder.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AmplifyUIBuilder
{
    /// <summary>
    /// Implementation for accessing AmplifyUIBuilder
    ///
    /// The Amplify UI Builder API provides a programmatic interface for creating and configuring
    /// user interface (UI) component libraries and themes for use in your Amplify applications.
    /// You can then connect these UI components to an application's backend Amazon Web Services
    /// resources.
    /// 
    ///  
    /// <para>
    /// You can also use the Amplify Studio visual designer to create UI components and model
    /// data for an app. For more information, see <a href="https://docs.amplify.aws/console/adminui/intro">Introduction</a>
    /// in the <i>Amplify Docs</i>.
    /// </para>
    ///  
    /// <para>
    /// The Amplify Framework is a comprehensive set of SDKs, libraries, tools, and documentation
    /// for client app development. For more information, see the <a href="https://docs.amplify.aws/">Amplify
    /// Framework</a>. For more information about deploying an Amplify application to Amazon
    /// Web Services, see the <a href="https://docs.aws.amazon.com/amplify/latest/userguide/welcome.html">Amplify
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAmplifyUIBuilderClient : AmazonServiceClient, IAmazonAmplifyUIBuilder
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyUIBuilderMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with the credentials loaded from the application's
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
        public AmazonAmplifyUIBuilderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyUIBuilderConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with the credentials loaded from the application's
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
        public AmazonAmplifyUIBuilderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyUIBuilderConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyUIBuilderClient Configuration Object</param>
        public AmazonAmplifyUIBuilderClient(AmazonAmplifyUIBuilderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyUIBuilderClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyUIBuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyUIBuilderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyUIBuilderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Credentials and an
        /// AmazonAmplifyUIBuilderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyUIBuilderClient Configuration Object</param>
        public AmazonAmplifyUIBuilderClient(AWSCredentials credentials, AmazonAmplifyUIBuilderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyUIBuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyUIBuilderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyUIBuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyUIBuilderClient Configuration Object</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyUIBuilderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyUIBuilderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyUIBuilderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyUIBuilderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyUIBuilderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyUIBuilderClient Configuration Object</param>
        public AmazonAmplifyUIBuilderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyUIBuilderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAmplifyUIBuilderPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAmplifyUIBuilderPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AmplifyUIBuilderPaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAmplifyUIBuilderEndpointResolver());
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


        #region  CreateComponent

        internal virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }



        /// <summary>
        /// Creates a new component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateForm

        internal virtual CreateFormResponse CreateForm(CreateFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormResponseUnmarshaller.Instance;

            return Invoke<CreateFormResponse>(request, options);
        }



        /// <summary>
        /// Creates a new form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        public virtual Task<CreateFormResponse> CreateFormAsync(CreateFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFormResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTheme

        internal virtual CreateThemeResponse CreateTheme(CreateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return Invoke<CreateThemeResponse>(request, options);
        }



        /// <summary>
        /// Creates a theme to apply to the components in an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        public virtual Task<CreateThemeResponse> CreateThemeAsync(CreateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteComponent

        internal virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a component from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteForm

        internal virtual DeleteFormResponse DeleteForm(DeleteFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormResponseUnmarshaller.Instance;

            return Invoke<DeleteFormResponse>(request, options);
        }



        /// <summary>
        /// Deletes a form from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        public virtual Task<DeleteFormResponse> DeleteFormAsync(DeleteFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFormResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTheme

        internal virtual DeleteThemeResponse DeleteTheme(DeleteThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return Invoke<DeleteThemeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a theme from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        public virtual Task<DeleteThemeResponse> DeleteThemeAsync(DeleteThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExchangeCodeForToken

        internal virtual ExchangeCodeForTokenResponse ExchangeCodeForToken(ExchangeCodeForTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExchangeCodeForTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExchangeCodeForTokenResponseUnmarshaller.Instance;

            return Invoke<ExchangeCodeForTokenResponse>(request, options);
        }



        /// <summary>
        /// Exchanges an access code for a token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExchangeCodeForToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        public virtual Task<ExchangeCodeForTokenResponse> ExchangeCodeForTokenAsync(ExchangeCodeForTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExchangeCodeForTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExchangeCodeForTokenResponseUnmarshaller.Instance;

            return InvokeAsync<ExchangeCodeForTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportComponents

        internal virtual ExportComponentsResponse ExportComponents(ExportComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComponentsResponseUnmarshaller.Instance;

            return Invoke<ExportComponentsResponse>(request, options);
        }



        /// <summary>
        /// Exports component configurations to code that is ready to integrate into an Amplify
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        public virtual Task<ExportComponentsResponse> ExportComponentsAsync(ExportComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportComponentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportForms

        internal virtual ExportFormsResponse ExportForms(ExportFormsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportFormsResponseUnmarshaller.Instance;

            return Invoke<ExportFormsResponse>(request, options);
        }



        /// <summary>
        /// Exports form configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportForms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        public virtual Task<ExportFormsResponse> ExportFormsAsync(ExportFormsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportFormsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportFormsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportThemes

        internal virtual ExportThemesResponse ExportThemes(ExportThemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportThemesResponseUnmarshaller.Instance;

            return Invoke<ExportThemesResponse>(request, options);
        }



        /// <summary>
        /// Exports theme configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        public virtual Task<ExportThemesResponse> ExportThemesAsync(ExportThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportThemesResponseUnmarshaller.Instance;

            return InvokeAsync<ExportThemesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComponent

        internal virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }



        /// <summary>
        /// Returns an existing component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return InvokeAsync<GetComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetForm

        internal virtual GetFormResponse GetForm(GetFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormResponseUnmarshaller.Instance;

            return Invoke<GetFormResponse>(request, options);
        }



        /// <summary>
        /// Returns an existing form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        public virtual Task<GetFormResponse> GetFormAsync(GetFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormResponseUnmarshaller.Instance;

            return InvokeAsync<GetFormResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMetadata

        internal virtual GetMetadataResponse GetMetadata(GetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataResponseUnmarshaller.Instance;

            return Invoke<GetMetadataResponse>(request, options);
        }



        /// <summary>
        /// Returns existing metadata for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetadata service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        public virtual Task<GetMetadataResponse> GetMetadataAsync(GetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTheme

        internal virtual GetThemeResponse GetTheme(GetThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThemeResponseUnmarshaller.Instance;

            return Invoke<GetThemeResponse>(request, options);
        }



        /// <summary>
        /// Returns an existing theme for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        public virtual Task<GetThemeResponse> GetThemeAsync(GetThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThemeResponseUnmarshaller.Instance;

            return InvokeAsync<GetThemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComponents

        internal virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of components for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListForms

        internal virtual ListFormsResponse ListForms(ListFormsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFormsResponseUnmarshaller.Instance;

            return Invoke<ListFormsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of forms for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        public virtual Task<ListFormsResponse> ListFormsAsync(ListFormsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFormsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFormsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThemes

        internal virtual ListThemesResponse ListThemes(ListThemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return Invoke<ListThemesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of themes for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        public virtual Task<ListThemesResponse> ListThemesAsync(ListThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return InvokeAsync<ListThemesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMetadataFlag

        internal virtual PutMetadataFlagResponse PutMetadataFlag(PutMetadataFlagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataFlagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataFlagResponseUnmarshaller.Instance;

            return Invoke<PutMetadataFlagResponse>(request, options);
        }



        /// <summary>
        /// Stores the metadata information about a feature on a form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetadataFlag service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        public virtual Task<PutMetadataFlagResponse> PutMetadataFlagAsync(PutMetadataFlagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataFlagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataFlagResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetadataFlagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RefreshToken

        internal virtual RefreshTokenResponse RefreshToken(RefreshTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshTokenResponseUnmarshaller.Instance;

            return Invoke<RefreshTokenResponse>(request, options);
        }



        /// <summary>
        /// Refreshes a previously issued access token that might have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RefreshToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        public virtual Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshTokenResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComponent

        internal virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual Task<UpdateComponentResponse> UpdateComponentAsync(UpdateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateForm

        internal virtual UpdateFormResponse UpdateForm(UpdateFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFormResponseUnmarshaller.Instance;

            return Invoke<UpdateFormResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        public virtual Task<UpdateFormResponse> UpdateFormAsync(UpdateFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFormResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFormResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTheme

        internal virtual UpdateThemeResponse UpdateTheme(UpdateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return Invoke<UpdateThemeResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        public virtual Task<UpdateThemeResponse> UpdateThemeAsync(UpdateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}