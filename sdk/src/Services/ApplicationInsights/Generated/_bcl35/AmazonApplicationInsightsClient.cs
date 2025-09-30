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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationInsights.Model;
using Amazon.ApplicationInsights.Model.Internal.MarshallTransformations;
using Amazon.ApplicationInsights.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ApplicationInsights
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationInsights</para>
    ///
    /// Amazon CloudWatch Application Insights 
    /// <para>
    ///  Amazon CloudWatch Application Insights is a service that helps you detect common
    /// problems with your applications. It enables you to pinpoint the source of issues in
    /// your applications (built with technologies such as Microsoft IIS, .NET, and Microsoft
    /// SQL Server), by providing key insights into detected problems.
    /// </para>
    ///  
    /// <para>
    /// After you onboard your application, CloudWatch Application Insights identifies, recommends,
    /// and sets up metrics and logs. It continuously analyzes and correlates your metrics
    /// and logs for unusual behavior to surface actionable problems with your application.
    /// For example, if your application is slow and unresponsive and leading to HTTP 500
    /// errors in your Application Load Balancer (ALB), Application Insights informs you that
    /// a memory pressure problem with your SQL Server database is occurring. It bases this
    /// analysis on impactful metrics and log errors. 
    /// </para>
    /// </summary>
    public partial class AmazonApplicationInsightsClient : AmazonServiceClient, IAmazonApplicationInsights
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationInsightsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IApplicationInsightsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationInsightsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationInsightsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationInsightsConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationInsightsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AmazonApplicationInsightsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials and an
        /// AmazonApplicationInsightsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, AmazonApplicationInsightsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationInsightsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationInsightsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationInsightsEndpointResolver());
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


        #region  AddWorkload

        /// <summary>
        /// Adds a workload to a component. Each component can have at most five workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkload service method.</param>
        /// 
        /// <returns>The response from the AddWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/AddWorkload">REST API Reference for AddWorkload Operation</seealso>
        public virtual AddWorkloadResponse AddWorkload(AddWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkloadResponseUnmarshaller.Instance;

            return Invoke<AddWorkloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkload operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/AddWorkload">REST API Reference for AddWorkload Operation</seealso>
        public virtual IAsyncResult BeginAddWorkload(AddWorkloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddWorkload.</param>
        /// 
        /// <returns>Returns a  AddWorkloadResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/AddWorkload">REST API Reference for AddWorkload Operation</seealso>
        public virtual AddWorkloadResponse EndAddWorkload(IAsyncResult asyncResult)
        {
            return EndInvoke<AddWorkloadResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Adds an application that is created from a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.AccessDeniedException">
        /// User does not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TagsAlreadyExistException">
        /// Tags are already registered for the specified application ARN.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponent

        /// <summary>
        /// Creates a custom component by grouping similar standalone instances to monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLogPattern

        /// <summary>
        /// Adds an log pattern to a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogPattern service method.</param>
        /// 
        /// <returns>The response from the CreateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        public virtual CreateLogPatternResponse CreateLogPattern(CreateLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogPatternResponseUnmarshaller.Instance;

            return Invoke<CreateLogPatternResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        public virtual IAsyncResult BeginCreateLogPattern(CreateLogPatternRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogPatternResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogPattern.</param>
        /// 
        /// <returns>Returns a  CreateLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        public virtual CreateLogPatternResponse EndCreateLogPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogPatternResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Removes the specified application from monitoring. Does not delete the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Ungroups a custom component. When you ungroup custom components, all applicable monitors
        /// that are set up for the component are removed and the instances revert to their standalone
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLogPattern

        /// <summary>
        /// Removes the specified log pattern from a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogPattern service method.</param>
        /// 
        /// <returns>The response from the DeleteLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        public virtual DeleteLogPatternResponse DeleteLogPattern(DeleteLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogPatternResponseUnmarshaller.Instance;

            return Invoke<DeleteLogPatternResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        public virtual IAsyncResult BeginDeleteLogPattern(DeleteLogPatternRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogPatternResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogPattern.</param>
        /// 
        /// <returns>Returns a  DeleteLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        public virtual DeleteLogPatternResponse EndDeleteLogPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLogPatternResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplication

        /// <summary>
        /// Describes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponent

        /// <summary>
        /// Describes a component and lists the resources that are grouped together in a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse DescribeComponent(DescribeComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponent(DescribeComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponent.</param>
        /// 
        /// <returns>Returns a  DescribeComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse EndDescribeComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponentConfiguration

        /// <summary>
        /// Describes the monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual DescribeComponentConfigurationResponse DescribeComponentConfiguration(DescribeComponentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponentConfiguration(DescribeComponentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual DescribeComponentConfigurationResponse EndDescribeComponentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponentConfigurationRecommendation

        /// <summary>
        /// Describes the recommended monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfigurationRecommendation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual DescribeComponentConfigurationRecommendationResponse DescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationRecommendationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfigurationRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfigurationRecommendation.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationRecommendationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual DescribeComponentConfigurationRecommendationResponse EndDescribeComponentConfigurationRecommendation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentConfigurationRecommendationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLogPattern

        /// <summary>
        /// Describe a specific log pattern from a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogPattern service method.</param>
        /// 
        /// <returns>The response from the DescribeLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        public virtual DescribeLogPatternResponse DescribeLogPattern(DescribeLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogPatternResponseUnmarshaller.Instance;

            return Invoke<DescribeLogPatternResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        public virtual IAsyncResult BeginDescribeLogPattern(DescribeLogPatternRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogPatternResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLogPattern.</param>
        /// 
        /// <returns>Returns a  DescribeLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        public virtual DescribeLogPatternResponse EndDescribeLogPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLogPatternResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeObservation

        /// <summary>
        /// Describes an anomaly or error with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation service method.</param>
        /// 
        /// <returns>The response from the DescribeObservation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual DescribeObservationResponse DescribeObservation(DescribeObservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return Invoke<DescribeObservationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual IAsyncResult BeginDescribeObservation(DescribeObservationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObservation.</param>
        /// 
        /// <returns>Returns a  DescribeObservationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual DescribeObservationResponse EndDescribeObservation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeObservationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProblem

        /// <summary>
        /// Describes an application problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem service method.</param>
        /// 
        /// <returns>The response from the DescribeProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual DescribeProblemResponse DescribeProblem(DescribeProblemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual IAsyncResult BeginDescribeProblem(DescribeProblemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblem.</param>
        /// 
        /// <returns>Returns a  DescribeProblemResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual DescribeProblemResponse EndDescribeProblem(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProblemResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProblemObservations

        /// <summary>
        /// Describes the anomalies or errors associated with the problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations service method.</param>
        /// 
        /// <returns>The response from the DescribeProblemObservations service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual DescribeProblemObservationsResponse DescribeProblemObservations(DescribeProblemObservationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemObservationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblemObservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual IAsyncResult BeginDescribeProblemObservations(DescribeProblemObservationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblemObservations.</param>
        /// 
        /// <returns>Returns a  DescribeProblemObservationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual DescribeProblemObservationsResponse EndDescribeProblemObservations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProblemObservationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkload

        /// <summary>
        /// Describes a workload and its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkload service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeWorkload">REST API Reference for DescribeWorkload Operation</seealso>
        public virtual DescribeWorkloadResponse DescribeWorkload(DescribeWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkloadResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkload operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeWorkload">REST API Reference for DescribeWorkload Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkload(DescribeWorkloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkload.</param>
        /// 
        /// <returns>Returns a  DescribeWorkloadResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeWorkload">REST API Reference for DescribeWorkload Operation</seealso>
        public virtual DescribeWorkloadResponse EndDescribeWorkload(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkloadResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists the IDs of the applications that you are monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Lists the auto-grouped, standalone, and custom components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListComponentsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationHistory

        /// <summary>
        /// Lists the INFO, WARN, and ERROR events for periodic configuration updates performed
        /// by Application Insights. Examples of events represented are: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// INFO: creating a new alarm or updating an alarm threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARN: alarm not created due to insufficient data points used to predict thresholds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR: alarm not created due to permission errors or exceeding quotas. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationHistory service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationHistory service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        public virtual ListConfigurationHistoryResponse ListConfigurationHistory(ListConfigurationHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationHistoryResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationHistory operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationHistory(ListConfigurationHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationHistory.</param>
        /// 
        /// <returns>Returns a  ListConfigurationHistoryResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        public virtual ListConfigurationHistoryResponse EndListConfigurationHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLogPatterns

        /// <summary>
        /// Lists the log patterns in the specific log <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatterns service method.</param>
        /// 
        /// <returns>The response from the ListLogPatterns service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        public virtual ListLogPatternsResponse ListLogPatterns(ListLogPatternsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternsResponseUnmarshaller.Instance;

            return Invoke<ListLogPatternsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogPatterns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatterns operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogPatterns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        public virtual IAsyncResult BeginListLogPatterns(ListLogPatternsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogPatterns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogPatterns.</param>
        /// 
        /// <returns>Returns a  ListLogPatternsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        public virtual ListLogPatternsResponse EndListLogPatterns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLogPatternsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLogPatternSets

        /// <summary>
        /// Lists the log pattern sets in the specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListLogPatternSets service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        public virtual ListLogPatternSetsResponse ListLogPatternSets(ListLogPatternSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListLogPatternSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogPatternSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatternSets operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogPatternSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        public virtual IAsyncResult BeginListLogPatternSets(ListLogPatternSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogPatternSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogPatternSets.</param>
        /// 
        /// <returns>Returns a  ListLogPatternSetsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        public virtual ListLogPatternSetsResponse EndListLogPatternSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLogPatternSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProblems

        /// <summary>
        /// Lists the problems with your application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProblems service method.</param>
        /// 
        /// <returns>The response from the ListProblems service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual ListProblemsResponse ListProblems(ListProblemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return Invoke<ListProblemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProblems operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProblems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual IAsyncResult BeginListProblems(ListProblemsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProblems.</param>
        /// 
        /// <returns>Returns a  ListProblemsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual ListProblemsResponse EndListProblems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProblemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// application. A <i>tag</i> is a label that you optionally define and associate with
        /// an application. Each tag consists of a required <i>tag key</i> and an optional associated
        /// <i>tag value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkloads

        /// <summary>
        /// Lists the workloads that are configured on a given component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloads
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual IAsyncResult BeginListWorkloads(ListWorkloadsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloads.</param>
        /// 
        /// <returns>Returns a  ListWorkloadsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual ListWorkloadsResponse EndListWorkloads(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkloadsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveWorkload

        /// <summary>
        /// Remove workload from a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveWorkload service method.</param>
        /// 
        /// <returns>The response from the RemoveWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/RemoveWorkload">REST API Reference for RemoveWorkload Operation</seealso>
        public virtual RemoveWorkloadResponse RemoveWorkload(RemoveWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveWorkloadResponseUnmarshaller.Instance;

            return Invoke<RemoveWorkloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveWorkload operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/RemoveWorkload">REST API Reference for RemoveWorkload Operation</seealso>
        public virtual IAsyncResult BeginRemoveWorkload(RemoveWorkloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveWorkloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveWorkload.</param>
        /// 
        /// <returns>Returns a  RemoveWorkloadResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/RemoveWorkload">REST API Reference for RemoveWorkload Operation</seealso>
        public virtual RemoveWorkloadResponse EndRemoveWorkload(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveWorkloadResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add one or more tags (keys and values) to a specified application. A <i>tag</i> is
        /// a label that you optionally define and associate with an application. Tags can help
        /// you categorize and manage application in different ways, such as by purpose, owner,
        /// environment, or other criteria. 
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TooManyTagsException">
        /// The number of the provided tags is beyond the limit, or the number of total tags you
        /// are trying to attach to the specified resource exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove one or more tags (keys and values) from a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponent

        /// <summary>
        /// Updates the custom component name and/or the list of resources that make up the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UpdateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponentConfiguration

        /// <summary>
        /// Updates the monitoring configurations for the component. The configuration input parameter
        /// is an escaped JSON of the configuration and should match the schema of what is returned
        /// by <c>DescribeComponentConfigurationRecommendation</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual UpdateComponentConfigurationResponse UpdateComponentConfiguration(UpdateComponentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponentConfiguration(UpdateComponentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual UpdateComponentConfigurationResponse EndUpdateComponentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLogPattern

        /// <summary>
        /// Adds a log pattern to a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogPattern service method.</param>
        /// 
        /// <returns>The response from the UpdateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        public virtual UpdateLogPatternResponse UpdateLogPattern(UpdateLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogPatternResponseUnmarshaller.Instance;

            return Invoke<UpdateLogPatternResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        public virtual IAsyncResult BeginUpdateLogPattern(UpdateLogPatternRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogPatternResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLogPattern.</param>
        /// 
        /// <returns>Returns a  UpdateLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        public virtual UpdateLogPatternResponse EndUpdateLogPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLogPatternResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProblem

        /// <summary>
        /// Updates the visibility of the problem or specifies the problem as <c>RESOLVED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProblem service method.</param>
        /// 
        /// <returns>The response from the UpdateProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateProblem">REST API Reference for UpdateProblem Operation</seealso>
        public virtual UpdateProblemResponse UpdateProblem(UpdateProblemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProblemResponseUnmarshaller.Instance;

            return Invoke<UpdateProblemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProblem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProblem operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProblem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateProblem">REST API Reference for UpdateProblem Operation</seealso>
        public virtual IAsyncResult BeginUpdateProblem(UpdateProblemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProblemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProblem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProblem.</param>
        /// 
        /// <returns>Returns a  UpdateProblemResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateProblem">REST API Reference for UpdateProblem Operation</seealso>
        public virtual UpdateProblemResponse EndUpdateProblem(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProblemResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkload

        /// <summary>
        /// Adds a workload to a component. Each component can have at most five workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual UpdateWorkloadResponse UpdateWorkload(UpdateWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkload(UpdateWorkloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkload.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual UpdateWorkloadResponse EndUpdateWorkload(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkloadResponse>(asyncResult);
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
            var resolver = new AmazonApplicationInsightsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}