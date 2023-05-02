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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ResilienceHub.Model;
using Amazon.ResilienceHub.Model.Internal.MarshallTransformations;
using Amazon.ResilienceHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ResilienceHub
{
    /// <summary>
    /// Implementation for accessing ResilienceHub
    ///
    /// Resilience Hub helps you proactively prepare and protect your Amazon Web Services
    /// applications from disruptions. It offers continual resiliency assessment and validation
    /// that integrates into your software development lifecycle. This enables you to uncover
    /// resiliency weaknesses, ensure recovery time objective (RTO) and recovery point objective
    /// (RPO) targets for your applications are met, and resolve issues before they are released
    /// into production.
    /// </summary>
    public partial class AmazonResilienceHubClient : AmazonServiceClient, IAmazonResilienceHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonResilienceHubMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IResilienceHubPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResilienceHubPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ResilienceHubPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        public AmazonResilienceHubClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResilienceHubConfig()) { }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        public AmazonResilienceHubClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResilienceHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(AmazonResilienceHubConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResilienceHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResilienceHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials and an
        /// AmazonResilienceHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(AWSCredentials credentials, AmazonResilienceHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResilienceHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResilienceHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonResilienceHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResilienceHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResilienceHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResilienceHubConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResilienceHubEndpointResolver());
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


        #region  AddDraftAppVersionResourceMappings

        /// <summary>
        /// Adds the resource mapping for the draft application version. You can also update an
        /// existing resource mapping to a new physical resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the AddDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        public virtual AddDraftAppVersionResourceMappingsResponse AddDraftAppVersionResourceMappings(AddDraftAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<AddDraftAppVersionResourceMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddDraftAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        public virtual IAsyncResult BeginAddDraftAppVersionResourceMappings(AddDraftAppVersionResourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddDraftAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  AddDraftAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        public virtual AddDraftAppVersionResourceMappingsResponse EndAddDraftAppVersionResourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<AddDraftAppVersionResourceMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApp

        /// <summary>
        /// Creates an Resilience Hub application. An Resilience Hub application is a collection
        /// of Amazon Web Services resources structured to prevent and recover Amazon Web Services
        /// application disruptions. To describe a Resilience Hub application, you provide an
        /// application name, resources from one or more–up to 20–CloudFormation stacks, and an
        /// appropriate resiliency policy.
        /// 
        ///  
        /// <para>
        /// After you create an Resilience Hub application, you publish it so that you can run
        /// a resiliency assessment on it. You can then use recommendations from the assessment
        /// to improve resiliency by running another assessment, comparing results, and then iterating
        /// the process until you achieve your goals for recovery time objective (RTO) and recovery
        /// point objective (RPO).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAppVersionAppComponent

        /// <summary>
        /// Creates a new Application Component in the Resilience Hub application.
        /// 
        ///  <note> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this Application
        /// Component for running assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppVersionAppComponent service method.</param>
        /// 
        /// <returns>The response from the CreateAppVersionAppComponent service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionAppComponent">REST API Reference for CreateAppVersionAppComponent Operation</seealso>
        public virtual CreateAppVersionAppComponentResponse CreateAppVersionAppComponent(CreateAppVersionAppComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppVersionAppComponentResponseUnmarshaller.Instance;

            return Invoke<CreateAppVersionAppComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppVersionAppComponent operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppVersionAppComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionAppComponent">REST API Reference for CreateAppVersionAppComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateAppVersionAppComponent(CreateAppVersionAppComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppVersionAppComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppVersionAppComponent.</param>
        /// 
        /// <returns>Returns a  CreateAppVersionAppComponentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionAppComponent">REST API Reference for CreateAppVersionAppComponent Operation</seealso>
        public virtual CreateAppVersionAppComponentResponse EndCreateAppVersionAppComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppVersionAppComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAppVersionResource

        /// <summary>
        /// Adds a resource to the Resilience Hub application and assigns it to the specified
        /// Application Components. If you specify a new Application Component, Resilience Hub
        /// will automatically create the Application Component.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action has no effect outside Resilience Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this resource
        /// for running resiliency assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To update application version with new <code>physicalResourceID</code>, you must call
        /// <code>ResolveAppVersionResources</code> API.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppVersionResource service method.</param>
        /// 
        /// <returns>The response from the CreateAppVersionResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionResource">REST API Reference for CreateAppVersionResource Operation</seealso>
        public virtual CreateAppVersionResourceResponse CreateAppVersionResource(CreateAppVersionResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppVersionResourceResponseUnmarshaller.Instance;

            return Invoke<CreateAppVersionResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppVersionResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppVersionResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionResource">REST API Reference for CreateAppVersionResource Operation</seealso>
        public virtual IAsyncResult BeginCreateAppVersionResource(CreateAppVersionResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppVersionResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppVersionResource.</param>
        /// 
        /// <returns>Returns a  CreateAppVersionResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateAppVersionResource">REST API Reference for CreateAppVersionResource Operation</seealso>
        public virtual CreateAppVersionResourceResponse EndCreateAppVersionResource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppVersionResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRecommendationTemplate

        /// <summary>
        /// Creates a new recommendation template for the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        public virtual CreateRecommendationTemplateResponse CreateRecommendationTemplate(CreateRecommendationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommendationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateRecommendationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecommendationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateRecommendationTemplate(CreateRecommendationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommendationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecommendationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateRecommendationTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        public virtual CreateRecommendationTemplateResponse EndCreateRecommendationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRecommendationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResiliencyPolicy

        /// <summary>
        /// Creates a resiliency policy for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        public virtual CreateResiliencyPolicyResponse CreateResiliencyPolicy(CreateResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateResiliencyPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateResiliencyPolicy(CreateResiliencyPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResiliencyPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  CreateResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        public virtual CreateResiliencyPolicyResponse EndCreateResiliencyPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResiliencyPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Deletes an Resilience Hub application. This is a destructive action that can't be
        /// undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppAssessment

        /// <summary>
        /// Deletes an Resilience Hub application assessment. This is a destructive action that
        /// can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        public virtual DeleteAppAssessmentResponse DeleteAppAssessment(DeleteAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAppAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppAssessment(DeleteAppAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        public virtual DeleteAppAssessmentResponse EndDeleteAppAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppInputSource

        /// <summary>
        /// Deletes the input source and all of its imported resources from the Resilience Hub
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInputSource service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInputSource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppInputSource">REST API Reference for DeleteAppInputSource Operation</seealso>
        public virtual DeleteAppInputSourceResponse DeleteAppInputSource(DeleteAppInputSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInputSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInputSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInputSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInputSource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInputSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppInputSource">REST API Reference for DeleteAppInputSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppInputSource(DeleteAppInputSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInputSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInputSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInputSource.</param>
        /// 
        /// <returns>Returns a  DeleteAppInputSourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppInputSource">REST API Reference for DeleteAppInputSource Operation</seealso>
        public virtual DeleteAppInputSourceResponse EndDeleteAppInputSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppInputSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppVersionAppComponent

        /// <summary>
        /// Deletes an Application Component from the Resilience Hub application.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this Application
        /// Component for running assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You will not be able to delete an Application Component if it has resources associated
        /// with it.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppVersionAppComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteAppVersionAppComponent service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionAppComponent">REST API Reference for DeleteAppVersionAppComponent Operation</seealso>
        public virtual DeleteAppVersionAppComponentResponse DeleteAppVersionAppComponent(DeleteAppVersionAppComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppVersionAppComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteAppVersionAppComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppVersionAppComponent operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppVersionAppComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionAppComponent">REST API Reference for DeleteAppVersionAppComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppVersionAppComponent(DeleteAppVersionAppComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppVersionAppComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppVersionAppComponent.</param>
        /// 
        /// <returns>Returns a  DeleteAppVersionAppComponentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionAppComponent">REST API Reference for DeleteAppVersionAppComponent Operation</seealso>
        public virtual DeleteAppVersionAppComponentResponse EndDeleteAppVersionAppComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppVersionAppComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppVersionResource

        /// <summary>
        /// Deletes a resource from the Resilience Hub application.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You can only delete a manually added resource. To exclude non-manually added resources,
        /// use the <code>UpdateAppVersionResource</code> API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This action has no effect outside Resilience Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this resource
        /// for running resiliency assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppVersionResource service method.</param>
        /// 
        /// <returns>The response from the DeleteAppVersionResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionResource">REST API Reference for DeleteAppVersionResource Operation</seealso>
        public virtual DeleteAppVersionResourceResponse DeleteAppVersionResource(DeleteAppVersionResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppVersionResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAppVersionResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppVersionResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppVersionResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionResource">REST API Reference for DeleteAppVersionResource Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppVersionResource(DeleteAppVersionResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppVersionResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppVersionResource.</param>
        /// 
        /// <returns>Returns a  DeleteAppVersionResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppVersionResource">REST API Reference for DeleteAppVersionResource Operation</seealso>
        public virtual DeleteAppVersionResourceResponse EndDeleteAppVersionResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppVersionResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecommendationTemplate

        /// <summary>
        /// Deletes a recommendation template. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        public virtual DeleteRecommendationTemplateResponse DeleteRecommendationTemplate(DeleteRecommendationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommendationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommendationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecommendationTemplate(DeleteRecommendationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommendationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteRecommendationTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        public virtual DeleteRecommendationTemplateResponse EndDeleteRecommendationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecommendationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResiliencyPolicy

        /// <summary>
        /// Deletes a resiliency policy. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        public virtual DeleteResiliencyPolicyResponse DeleteResiliencyPolicy(DeleteResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResiliencyPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResiliencyPolicy(DeleteResiliencyPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResiliencyPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        public virtual DeleteResiliencyPolicyResponse EndDeleteResiliencyPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResiliencyPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApp

        /// <summary>
        /// Describes an Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppAssessment

        /// <summary>
        /// Describes an assessment for an Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment service method.</param>
        /// 
        /// <returns>The response from the DescribeAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        public virtual DescribeAppAssessmentResponse DescribeAppAssessment(DescribeAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<DescribeAppAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppAssessment(DescribeAppAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppAssessment.</param>
        /// 
        /// <returns>Returns a  DescribeAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        public virtual DescribeAppAssessmentResponse EndDescribeAppAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppVersion

        /// <summary>
        /// Describes the Resilience Hub application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersion">REST API Reference for DescribeAppVersion Operation</seealso>
        public virtual DescribeAppVersionResponse DescribeAppVersion(DescribeAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersion">REST API Reference for DescribeAppVersion Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppVersion(DescribeAppVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersion.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersion">REST API Reference for DescribeAppVersion Operation</seealso>
        public virtual DescribeAppVersionResponse EndDescribeAppVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppVersionAppComponent

        /// <summary>
        /// Describes an Application Component in the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionAppComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionAppComponent service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionAppComponent">REST API Reference for DescribeAppVersionAppComponent Operation</seealso>
        public virtual DescribeAppVersionAppComponentResponse DescribeAppVersionAppComponent(DescribeAppVersionAppComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionAppComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionAppComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionAppComponent operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionAppComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionAppComponent">REST API Reference for DescribeAppVersionAppComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppVersionAppComponent(DescribeAppVersionAppComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionAppComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionAppComponent.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionAppComponentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionAppComponent">REST API Reference for DescribeAppVersionAppComponent Operation</seealso>
        public virtual DescribeAppVersionAppComponentResponse EndDescribeAppVersionAppComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppVersionAppComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppVersionResource

        /// <summary>
        /// Describes a resource of the Resilience Hub application.
        /// 
        ///  <note> 
        /// <para>
        /// This API accepts only one of the following parameters to descibe the resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resourceName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>logicalResourceId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>physicalResourceId</code> (Along with <code>physicalResourceId</code>, you
        /// can also provide <code>awsAccountId</code>, and <code>awsRegion</code>)
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResource service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResource">REST API Reference for DescribeAppVersionResource Operation</seealso>
        public virtual DescribeAppVersionResourceResponse DescribeAppVersionResource(DescribeAppVersionResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResource">REST API Reference for DescribeAppVersionResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppVersionResource(DescribeAppVersionResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionResource.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResource">REST API Reference for DescribeAppVersionResource Operation</seealso>
        public virtual DescribeAppVersionResourceResponse EndDescribeAppVersionResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppVersionResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppVersionResourcesResolutionStatus

        /// <summary>
        /// Returns the resolution status for the specified resolution identifier for an application
        /// version. If <code>resolutionId</code> is not specified, the current resolution status
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionResourcesResolutionStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        public virtual DescribeAppVersionResourcesResolutionStatusResponse DescribeAppVersionResourcesResolutionStatus(DescribeAppVersionResourcesResolutionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourcesResolutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourcesResolutionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionResourcesResolutionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionResourcesResolutionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionResourcesResolutionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppVersionResourcesResolutionStatus(DescribeAppVersionResourcesResolutionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourcesResolutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourcesResolutionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionResourcesResolutionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionResourcesResolutionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionResourcesResolutionStatusResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        public virtual DescribeAppVersionResourcesResolutionStatusResponse EndDescribeAppVersionResourcesResolutionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppVersionResourcesResolutionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppVersionTemplate

        /// <summary>
        /// Describes details about an Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        public virtual DescribeAppVersionTemplateResponse DescribeAppVersionTemplate(DescribeAppVersionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppVersionTemplate(DescribeAppVersionTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        public virtual DescribeAppVersionTemplateResponse EndDescribeAppVersionTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppVersionTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDraftAppVersionResourcesImportStatus

        /// <summary>
        /// Describes the status of importing resources to an application version.
        /// 
        ///  <note> 
        /// <para>
        /// If you get a 404 error with <code>ResourceImportStatusNotFoundAppMetadataException</code>,
        /// you must call <code>importResourcesToDraftAppVersion</code> after creating the application
        /// and before calling <code>describeDraftAppVersionResourcesImportStatus</code> to obtain
        /// the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeDraftAppVersionResourcesImportStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        public virtual DescribeDraftAppVersionResourcesImportStatusResponse DescribeDraftAppVersionResourcesImportStatus(DescribeDraftAppVersionResourcesImportStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDraftAppVersionResourcesImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDraftAppVersionResourcesImportStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeDraftAppVersionResourcesImportStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDraftAppVersionResourcesImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDraftAppVersionResourcesImportStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeDraftAppVersionResourcesImportStatus(DescribeDraftAppVersionResourcesImportStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDraftAppVersionResourcesImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDraftAppVersionResourcesImportStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDraftAppVersionResourcesImportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDraftAppVersionResourcesImportStatus.</param>
        /// 
        /// <returns>Returns a  DescribeDraftAppVersionResourcesImportStatusResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        public virtual DescribeDraftAppVersionResourcesImportStatusResponse EndDescribeDraftAppVersionResourcesImportStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDraftAppVersionResourcesImportStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResiliencyPolicy

        /// <summary>
        /// Describes a specified resiliency policy for an Resilience Hub application. The returned
        /// policy object includes creation time, data location constraints, the Amazon Resource
        /// Name (ARN) for the policy, tags, tier, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        public virtual DescribeResiliencyPolicyResponse DescribeResiliencyPolicy(DescribeResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResiliencyPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeResiliencyPolicy(DescribeResiliencyPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResiliencyPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        public virtual DescribeResiliencyPolicyResponse EndDescribeResiliencyPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResiliencyPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportResourcesToDraftAppVersion

        /// <summary>
        /// Imports resources to Resilience Hub application draft version from different input
        /// sources. For more information about the input sources supported by Resilience Hub,
        /// see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/discover-structure.html">Discover
        /// the structure and describe your Resilience Hub application</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion service method.</param>
        /// 
        /// <returns>The response from the ImportResourcesToDraftAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        public virtual ImportResourcesToDraftAppVersionResponse ImportResourcesToDraftAppVersion(ImportResourcesToDraftAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportResourcesToDraftAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportResourcesToDraftAppVersionResponseUnmarshaller.Instance;

            return Invoke<ImportResourcesToDraftAppVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportResourcesToDraftAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportResourcesToDraftAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        public virtual IAsyncResult BeginImportResourcesToDraftAppVersion(ImportResourcesToDraftAppVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportResourcesToDraftAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportResourcesToDraftAppVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportResourcesToDraftAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportResourcesToDraftAppVersion.</param>
        /// 
        /// <returns>Returns a  ImportResourcesToDraftAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        public virtual ImportResourcesToDraftAppVersionResponse EndImportResourcesToDraftAppVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportResourcesToDraftAppVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlarmRecommendations

        /// <summary>
        /// Lists the alarm recommendations for an Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListAlarmRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        public virtual ListAlarmRecommendationsResponse ListAlarmRecommendations(ListAlarmRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlarmRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListAlarmRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlarmRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlarmRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListAlarmRecommendations(ListAlarmRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlarmRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlarmRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlarmRecommendations.</param>
        /// 
        /// <returns>Returns a  ListAlarmRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        public virtual ListAlarmRecommendationsResponse EndListAlarmRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlarmRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppAssessments

        /// <summary>
        /// Lists the assessments for an Resilience Hub application. You can use request parameters
        /// to refine the results for the response object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAppAssessments service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        public virtual ListAppAssessmentsResponse ListAppAssessments(ListAppAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAppAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        public virtual IAsyncResult BeginListAppAssessments(ListAppAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppAssessments.</param>
        /// 
        /// <returns>Returns a  ListAppAssessmentsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        public virtual ListAppAssessmentsResponse EndListAppAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppComponentCompliances

        /// <summary>
        /// Lists the compliances for an Resilience Hub Application Component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances service method.</param>
        /// 
        /// <returns>The response from the ListAppComponentCompliances service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        public virtual ListAppComponentCompliancesResponse ListAppComponentCompliances(ListAppComponentCompliancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentCompliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentCompliancesResponseUnmarshaller.Instance;

            return Invoke<ListAppComponentCompliancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppComponentCompliances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppComponentCompliances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        public virtual IAsyncResult BeginListAppComponentCompliances(ListAppComponentCompliancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentCompliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentCompliancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppComponentCompliances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppComponentCompliances.</param>
        /// 
        /// <returns>Returns a  ListAppComponentCompliancesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        public virtual ListAppComponentCompliancesResponse EndListAppComponentCompliances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppComponentCompliancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppComponentRecommendations

        /// <summary>
        /// Lists the recommendations for an Resilience Hub Application Component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListAppComponentRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        public virtual ListAppComponentRecommendationsResponse ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListAppComponentRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppComponentRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppComponentRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListAppComponentRecommendations(ListAppComponentRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppComponentRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppComponentRecommendations.</param>
        /// 
        /// <returns>Returns a  ListAppComponentRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        public virtual ListAppComponentRecommendationsResponse EndListAppComponentRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppComponentRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppInputSources

        /// <summary>
        /// Lists all the input sources of the Resilience Hub application. For more information
        /// about the input sources supported by Resilience Hub, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/discover-structure.html">Discover
        /// the structure and describe your Resilience Hub application</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInputSources service method.</param>
        /// 
        /// <returns>The response from the ListAppInputSources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppInputSources">REST API Reference for ListAppInputSources Operation</seealso>
        public virtual ListAppInputSourcesResponse ListAppInputSources(ListAppInputSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInputSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInputSourcesResponseUnmarshaller.Instance;

            return Invoke<ListAppInputSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInputSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInputSources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInputSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppInputSources">REST API Reference for ListAppInputSources Operation</seealso>
        public virtual IAsyncResult BeginListAppInputSources(ListAppInputSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInputSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInputSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInputSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInputSources.</param>
        /// 
        /// <returns>Returns a  ListAppInputSourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppInputSources">REST API Reference for ListAppInputSources Operation</seealso>
        public virtual ListAppInputSourcesResponse EndListAppInputSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppInputSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApps

        /// <summary>
        /// Lists your Resilience Hub applications.
        /// 
        ///  <note> 
        /// <para>
        /// You can filter applications using only one filter at a time or without using any filter.
        /// If you try to filter applications using multiple filters, you will get the following
        /// error:
        /// </para>
        ///  
        /// <para>
        ///  <code>An error occurred (ValidationException) when calling the ListApps operation:
        /// Only one filter is supported for this operation.</code> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse EndListApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppVersionAppComponents

        /// <summary>
        /// Lists all the Application Components in the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionAppComponents service method.</param>
        /// 
        /// <returns>The response from the ListAppVersionAppComponents service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionAppComponents">REST API Reference for ListAppVersionAppComponents Operation</seealso>
        public virtual ListAppVersionAppComponentsResponse ListAppVersionAppComponents(ListAppVersionAppComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionAppComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionAppComponentsResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionAppComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersionAppComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionAppComponents operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersionAppComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionAppComponents">REST API Reference for ListAppVersionAppComponents Operation</seealso>
        public virtual IAsyncResult BeginListAppVersionAppComponents(ListAppVersionAppComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionAppComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionAppComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersionAppComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersionAppComponents.</param>
        /// 
        /// <returns>Returns a  ListAppVersionAppComponentsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionAppComponents">REST API Reference for ListAppVersionAppComponents Operation</seealso>
        public virtual ListAppVersionAppComponentsResponse EndListAppVersionAppComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppVersionAppComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppVersionResourceMappings

        /// <summary>
        /// Lists how the resources in an application version are mapped/sourced from. Mappings
        /// can be physical resource identifiers, CloudFormation stacks, resource-groups, or an
        /// application registry app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the ListAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        public virtual ListAppVersionResourceMappingsResponse ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionResourceMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        public virtual IAsyncResult BeginListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  ListAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        public virtual ListAppVersionResourceMappingsResponse EndListAppVersionResourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppVersionResourceMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppVersionResources

        /// <summary>
        /// Lists all the resources in an Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ListAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        public virtual ListAppVersionResourcesResponse ListAppVersionResources(ListAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        public virtual IAsyncResult BeginListAppVersionResources(ListAppVersionResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ListAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        public virtual ListAppVersionResourcesResponse EndListAppVersionResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppVersionResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppVersions

        /// <summary>
        /// Lists the different versions for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions service method.</param>
        /// 
        /// <returns>The response from the ListAppVersions service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        public virtual ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        public virtual IAsyncResult BeginListAppVersions(ListAppVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersions.</param>
        /// 
        /// <returns>Returns a  ListAppVersionsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        public virtual ListAppVersionsResponse EndListAppVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendationTemplates

        /// <summary>
        /// Lists the recommendation templates for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationTemplates service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        public virtual ListRecommendationTemplatesResponse ListRecommendationTemplates(ListRecommendationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        public virtual IAsyncResult BeginListRecommendationTemplates(ListRecommendationTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationTemplates.</param>
        /// 
        /// <returns>Returns a  ListRecommendationTemplatesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        public virtual ListRecommendationTemplatesResponse EndListRecommendationTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResiliencyPolicies

        /// <summary>
        /// Lists the resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        public virtual ListResiliencyPoliciesResponse ListResiliencyPolicies(ListResiliencyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResiliencyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResiliencyPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResiliencyPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        public virtual IAsyncResult BeginListResiliencyPolicies(ListResiliencyPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResiliencyPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResiliencyPolicies.</param>
        /// 
        /// <returns>Returns a  ListResiliencyPoliciesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        public virtual ListResiliencyPoliciesResponse EndListResiliencyPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResiliencyPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSopRecommendations

        /// <summary>
        /// Lists the standard operating procedure (SOP) recommendations for the Resilience Hub
        /// applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListSopRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        public virtual ListSopRecommendationsResponse ListSopRecommendations(ListSopRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSopRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSopRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListSopRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSopRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSopRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListSopRecommendations(ListSopRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSopRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSopRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSopRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSopRecommendations.</param>
        /// 
        /// <returns>Returns a  ListSopRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        public virtual ListSopRecommendationsResponse EndListSopRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSopRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSuggestedResiliencyPolicies

        /// <summary>
        /// Lists the suggested resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSuggestedResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        public virtual ListSuggestedResiliencyPoliciesResponse ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuggestedResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuggestedResiliencyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSuggestedResiliencyPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuggestedResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuggestedResiliencyPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        public virtual IAsyncResult BeginListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuggestedResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuggestedResiliencyPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuggestedResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuggestedResiliencyPolicies.</param>
        /// 
        /// <returns>Returns a  ListSuggestedResiliencyPoliciesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        public virtual ListSuggestedResiliencyPoliciesResponse EndListSuggestedResiliencyPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSuggestedResiliencyPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for your resources in your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTestRecommendations

        /// <summary>
        /// Lists the test recommendations for the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListTestRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        public virtual ListTestRecommendationsResponse ListTestRecommendations(ListTestRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListTestRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListTestRecommendations(ListTestRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestRecommendations.</param>
        /// 
        /// <returns>Returns a  ListTestRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        public virtual ListTestRecommendationsResponse EndListTestRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUnsupportedAppVersionResources

        /// <summary>
        /// Lists the resources that are not currently supported in Resilience Hub. An unsupported
        /// resource is a resource that exists in the object that was used to create an app, but
        /// is not supported by Resilience Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ListUnsupportedAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        public virtual ListUnsupportedAppVersionResourcesResponse ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUnsupportedAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUnsupportedAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListUnsupportedAppVersionResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUnsupportedAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUnsupportedAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        public virtual IAsyncResult BeginListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUnsupportedAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUnsupportedAppVersionResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUnsupportedAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUnsupportedAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ListUnsupportedAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        public virtual ListUnsupportedAppVersionResourcesResponse EndListUnsupportedAppVersionResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUnsupportedAppVersionResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishAppVersion

        /// <summary>
        /// Publishes a new version of a specific Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion service method.</param>
        /// 
        /// <returns>The response from the PublishAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        public virtual PublishAppVersionResponse PublishAppVersion(PublishAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishAppVersionResponseUnmarshaller.Instance;

            return Invoke<PublishAppVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PublishAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        public virtual IAsyncResult BeginPublishAppVersion(PublishAppVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishAppVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishAppVersion.</param>
        /// 
        /// <returns>Returns a  PublishAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        public virtual PublishAppVersionResponse EndPublishAppVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishAppVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDraftAppVersionTemplate

        /// <summary>
        /// Adds or updates the app template for an Resilience Hub application draft version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate service method.</param>
        /// 
        /// <returns>The response from the PutDraftAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        public virtual PutDraftAppVersionTemplateResponse PutDraftAppVersionTemplate(PutDraftAppVersionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDraftAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDraftAppVersionTemplateResponseUnmarshaller.Instance;

            return Invoke<PutDraftAppVersionTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDraftAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDraftAppVersionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        public virtual IAsyncResult BeginPutDraftAppVersionTemplate(PutDraftAppVersionTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDraftAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDraftAppVersionTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDraftAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDraftAppVersionTemplate.</param>
        /// 
        /// <returns>Returns a  PutDraftAppVersionTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        public virtual PutDraftAppVersionTemplateResponse EndPutDraftAppVersionTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDraftAppVersionTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveDraftAppVersionResourceMappings

        /// <summary>
        /// Removes resource mappings from a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the RemoveDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        public virtual RemoveDraftAppVersionResourceMappingsResponse RemoveDraftAppVersionResourceMappings(RemoveDraftAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<RemoveDraftAppVersionResourceMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveDraftAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        public virtual IAsyncResult BeginRemoveDraftAppVersionResourceMappings(RemoveDraftAppVersionResourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveDraftAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  RemoveDraftAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        public virtual RemoveDraftAppVersionResourceMappingsResponse EndRemoveDraftAppVersionResourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveDraftAppVersionResourceMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveAppVersionResources

        /// <summary>
        /// Resolves the resources for an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ResolveAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        public virtual ResolveAppVersionResourcesResponse ResolveAppVersionResources(ResolveAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ResolveAppVersionResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        public virtual IAsyncResult BeginResolveAppVersionResources(ResolveAppVersionResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAppVersionResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ResolveAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        public virtual ResolveAppVersionResourcesResponse EndResolveAppVersionResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveAppVersionResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAppAssessment

        /// <summary>
        /// Creates a new application assessment for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment service method.</param>
        /// 
        /// <returns>The response from the StartAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        public virtual StartAppAssessmentResponse StartAppAssessment(StartAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartAppAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        public virtual IAsyncResult BeginStartAppAssessment(StartAppAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAppAssessment.</param>
        /// 
        /// <returns>Returns a  StartAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        public virtual StartAppAssessmentResponse EndStartAppAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAppAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApp

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAppVersion

        /// <summary>
        /// Updates the Resilience Hub application version.
        /// 
        ///  <note> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this information
        /// for running resiliency assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersion">REST API Reference for UpdateAppVersion Operation</seealso>
        public virtual UpdateAppVersionResponse UpdateAppVersion(UpdateAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateAppVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersion">REST API Reference for UpdateAppVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppVersion(UpdateAppVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppVersion.</param>
        /// 
        /// <returns>Returns a  UpdateAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersion">REST API Reference for UpdateAppVersion Operation</seealso>
        public virtual UpdateAppVersionResponse EndUpdateAppVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAppVersionAppComponent

        /// <summary>
        /// Updates an existing Application Component in the Resilience Hub application.
        /// 
        ///  <note> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this Application
        /// Component for running assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersionAppComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateAppVersionAppComponent service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionAppComponent">REST API Reference for UpdateAppVersionAppComponent Operation</seealso>
        public virtual UpdateAppVersionAppComponentResponse UpdateAppVersionAppComponent(UpdateAppVersionAppComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionAppComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateAppVersionAppComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersionAppComponent operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppVersionAppComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionAppComponent">REST API Reference for UpdateAppVersionAppComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppVersionAppComponent(UpdateAppVersionAppComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionAppComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionAppComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppVersionAppComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppVersionAppComponent.</param>
        /// 
        /// <returns>Returns a  UpdateAppVersionAppComponentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionAppComponent">REST API Reference for UpdateAppVersionAppComponent Operation</seealso>
        public virtual UpdateAppVersionAppComponentResponse EndUpdateAppVersionAppComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppVersionAppComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAppVersionResource

        /// <summary>
        /// Updates the resource details in the Resilience Hub application.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action has no effect outside Resilience Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API updates the Resilience Hub application draft version. To use this resource
        /// for running resiliency assessments, you must publish the Resilience Hub application
        /// using the <code>PublishAppVersion</code> API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To update application version with new <code>physicalResourceID</code>, you must call
        /// <code>ResolveAppVersionResources</code> API.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersionResource service method.</param>
        /// 
        /// <returns>The response from the UpdateAppVersionResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// This exception occurs when you have exceeded your service quota. To perform the requested
        /// action, remove some of the relevant resources, or use Service Quotas to request a
        /// service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionResource">REST API Reference for UpdateAppVersionResource Operation</seealso>
        public virtual UpdateAppVersionResourceResponse UpdateAppVersionResource(UpdateAppVersionResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateAppVersionResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppVersionResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppVersionResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionResource">REST API Reference for UpdateAppVersionResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppVersionResource(UpdateAppVersionResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppVersionResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppVersionResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppVersionResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppVersionResource.</param>
        /// 
        /// <returns>Returns a  UpdateAppVersionResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateAppVersionResource">REST API Reference for UpdateAppVersionResource Operation</seealso>
        public virtual UpdateAppVersionResourceResponse EndUpdateAppVersionResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppVersionResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResiliencyPolicy

        /// <summary>
        /// Updates a resiliency policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful write is detected.
        /// This generally occurs when the previous write did not have time to propagate to the
        /// host serving the current request. A retry (with appropriate backoff logic) is the
        /// recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Resilience Hub service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// This exception occurs when the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// This exception occurs when you have exceeded the limit on the number of requests per
        /// second.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// This exception occurs when a request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        public virtual UpdateResiliencyPolicyResponse UpdateResiliencyPolicy(UpdateResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateResiliencyPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateResiliencyPolicy(UpdateResiliencyPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResiliencyPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        public virtual UpdateResiliencyPolicyResponse EndUpdateResiliencyPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResiliencyPolicyResponse>(asyncResult);
        }

        #endregion
        
    }
}