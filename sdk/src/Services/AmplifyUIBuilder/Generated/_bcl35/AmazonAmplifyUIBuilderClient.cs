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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Creates a new component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
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
        /// <returns>Returns a  CreateComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateForm

        /// <summary>
        /// Creates a new form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForm service method.</param>
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
        public virtual CreateFormResponse CreateForm(CreateFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormResponseUnmarshaller.Instance;

            return Invoke<CreateFormResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        public virtual IAsyncResult BeginCreateForm(CreateFormRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForm.</param>
        /// 
        /// <returns>Returns a  CreateFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        public virtual CreateFormResponse EndCreateForm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFormResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTheme

        /// <summary>
        /// Creates a theme to apply to the components in an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
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
        public virtual CreateThemeResponse CreateTheme(CreateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return Invoke<CreateThemeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        public virtual IAsyncResult BeginCreateTheme(CreateThemeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTheme.</param>
        /// 
        /// <returns>Returns a  CreateThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        public virtual CreateThemeResponse EndCreateTheme(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateThemeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Deletes a component from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
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
        /// <returns>Returns a  DeleteComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteForm

        /// <summary>
        /// Deletes a form from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm service method.</param>
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
        public virtual DeleteFormResponse DeleteForm(DeleteFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormResponseUnmarshaller.Instance;

            return Invoke<DeleteFormResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        public virtual IAsyncResult BeginDeleteForm(DeleteFormRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForm.</param>
        /// 
        /// <returns>Returns a  DeleteFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        public virtual DeleteFormResponse EndDeleteForm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFormResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTheme

        /// <summary>
        /// Deletes a theme from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
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
        public virtual DeleteThemeResponse DeleteTheme(DeleteThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return Invoke<DeleteThemeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        public virtual IAsyncResult BeginDeleteTheme(DeleteThemeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTheme.</param>
        /// 
        /// <returns>Returns a  DeleteThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        public virtual DeleteThemeResponse EndDeleteTheme(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteThemeResponse>(asyncResult);
        }

        #endregion
        
        #region  ExchangeCodeForToken

        /// <summary>
        /// Exchanges an access code for a token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken service method.</param>
        /// 
        /// <returns>The response from the ExchangeCodeForToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        public virtual ExchangeCodeForTokenResponse ExchangeCodeForToken(ExchangeCodeForTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExchangeCodeForTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExchangeCodeForTokenResponseUnmarshaller.Instance;

            return Invoke<ExchangeCodeForTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExchangeCodeForToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExchangeCodeForToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        public virtual IAsyncResult BeginExchangeCodeForToken(ExchangeCodeForTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExchangeCodeForTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExchangeCodeForTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExchangeCodeForToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExchangeCodeForToken.</param>
        /// 
        /// <returns>Returns a  ExchangeCodeForTokenResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        public virtual ExchangeCodeForTokenResponse EndExchangeCodeForToken(IAsyncResult asyncResult)
        {
            return EndInvoke<ExchangeCodeForTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportComponents

        /// <summary>
        /// Exports component configurations to code that is ready to integrate into an Amplify
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents service method.</param>
        /// 
        /// <returns>The response from the ExportComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        public virtual ExportComponentsResponse ExportComponents(ExportComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComponentsResponseUnmarshaller.Instance;

            return Invoke<ExportComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        public virtual IAsyncResult BeginExportComponents(ExportComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportComponents.</param>
        /// 
        /// <returns>Returns a  ExportComponentsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        public virtual ExportComponentsResponse EndExportComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportForms

        /// <summary>
        /// Exports form configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportForms service method.</param>
        /// 
        /// <returns>The response from the ExportForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        public virtual ExportFormsResponse ExportForms(ExportFormsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportFormsResponseUnmarshaller.Instance;

            return Invoke<ExportFormsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportForms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportForms operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportForms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        public virtual IAsyncResult BeginExportForms(ExportFormsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportFormsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportForms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportForms.</param>
        /// 
        /// <returns>Returns a  ExportFormsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        public virtual ExportFormsResponse EndExportForms(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportFormsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportThemes

        /// <summary>
        /// Exports theme configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes service method.</param>
        /// 
        /// <returns>The response from the ExportThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        public virtual ExportThemesResponse ExportThemes(ExportThemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportThemesResponseUnmarshaller.Instance;

            return Invoke<ExportThemesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportThemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportThemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        public virtual IAsyncResult BeginExportThemes(ExportThemesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportThemesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportThemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportThemes.</param>
        /// 
        /// <returns>Returns a  ExportThemesResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        public virtual ExportThemesResponse EndExportThemes(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportThemesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Returns an existing component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
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
        /// <returns>Returns a  GetComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetForm

        /// <summary>
        /// Returns an existing form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetForm service method.</param>
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
        public virtual GetFormResponse GetForm(GetFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormResponseUnmarshaller.Instance;

            return Invoke<GetFormResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        public virtual IAsyncResult BeginGetForm(GetFormRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetForm.</param>
        /// 
        /// <returns>Returns a  GetFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        public virtual GetFormResponse EndGetForm(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFormResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetadata

        /// <summary>
        /// Returns existing metadata for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata service method.</param>
        /// 
        /// <returns>The response from the GetMetadata service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        public virtual GetMetadataResponse GetMetadata(GetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataResponseUnmarshaller.Instance;

            return Invoke<GetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetMetadata(GetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetadata.</param>
        /// 
        /// <returns>Returns a  GetMetadataResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        public virtual GetMetadataResponse EndGetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTheme

        /// <summary>
        /// Returns an existing theme for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTheme service method.</param>
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
        public virtual GetThemeResponse GetTheme(GetThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThemeResponseUnmarshaller.Instance;

            return Invoke<GetThemeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        public virtual IAsyncResult BeginGetTheme(GetThemeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThemeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTheme.</param>
        /// 
        /// <returns>Returns a  GetThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        public virtual GetThemeResponse EndGetTheme(IAsyncResult asyncResult)
        {
            return EndInvoke<GetThemeResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Retrieves a list of components for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
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
        /// <returns>Returns a  ListComponentsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListForms

        /// <summary>
        /// Retrieves a list of forms for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForms service method.</param>
        /// 
        /// <returns>The response from the ListForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        public virtual ListFormsResponse ListForms(ListFormsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFormsResponseUnmarshaller.Instance;

            return Invoke<ListFormsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListForms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForms operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        public virtual IAsyncResult BeginListForms(ListFormsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFormsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFormsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListForms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForms.</param>
        /// 
        /// <returns>Returns a  ListFormsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        public virtual ListFormsResponse EndListForms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFormsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListThemes

        /// <summary>
        /// Retrieves a list of themes for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        public virtual ListThemesResponse ListThemes(ListThemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return Invoke<ListThemesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThemes operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        public virtual IAsyncResult BeginListThemes(ListThemesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListThemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThemes.</param>
        /// 
        /// <returns>Returns a  ListThemesResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        public virtual ListThemesResponse EndListThemes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListThemesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMetadataFlag

        /// <summary>
        /// Stores the metadata information about a feature on a form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag service method.</param>
        /// 
        /// <returns>The response from the PutMetadataFlag service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        public virtual PutMetadataFlagResponse PutMetadataFlag(PutMetadataFlagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataFlagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataFlagResponseUnmarshaller.Instance;

            return Invoke<PutMetadataFlagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetadataFlag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetadataFlag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        public virtual IAsyncResult BeginPutMetadataFlag(PutMetadataFlagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataFlagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataFlagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetadataFlag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetadataFlag.</param>
        /// 
        /// <returns>Returns a  PutMetadataFlagResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        public virtual PutMetadataFlagResponse EndPutMetadataFlag(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetadataFlagResponse>(asyncResult);
        }

        #endregion
        
        #region  RefreshToken

        /// <summary>
        /// Refreshes a previously issued access token that might have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken service method.</param>
        /// 
        /// <returns>The response from the RefreshToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        public virtual RefreshTokenResponse RefreshToken(RefreshTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshTokenResponseUnmarshaller.Instance;

            return Invoke<RefreshTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRefreshToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        public virtual IAsyncResult BeginRefreshToken(RefreshTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RefreshToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshToken.</param>
        /// 
        /// <returns>Returns a  RefreshTokenResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        public virtual RefreshTokenResponse EndRefreshToken(IAsyncResult asyncResult)
        {
            return EndInvoke<RefreshTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponent

        /// <summary>
        /// Updates an existing component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
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
        public virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponent.</param>
        /// 
        /// <returns>Returns a  UpdateComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateForm

        /// <summary>
        /// Updates an existing form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm service method.</param>
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
        public virtual UpdateFormResponse UpdateForm(UpdateFormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFormResponseUnmarshaller.Instance;

            return Invoke<UpdateFormResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        public virtual IAsyncResult BeginUpdateForm(UpdateFormRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFormResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateForm.</param>
        /// 
        /// <returns>Returns a  UpdateFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        public virtual UpdateFormResponse EndUpdateForm(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFormResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTheme

        /// <summary>
        /// Updates an existing theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
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
        public virtual UpdateThemeResponse UpdateTheme(UpdateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return Invoke<UpdateThemeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        public virtual IAsyncResult BeginUpdateTheme(UpdateThemeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTheme.</param>
        /// 
        /// <returns>Returns a  UpdateThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        public virtual UpdateThemeResponse EndUpdateTheme(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateThemeResponse>(asyncResult);
        }

        #endregion
        
    }
}