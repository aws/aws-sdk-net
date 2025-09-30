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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations;
using Amazon.ServerlessApplicationRepository.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ServerlessApplicationRepository
{
    /// <summary>
    /// <para>Implementation for accessing ServerlessApplicationRepository</para>
    ///
    /// The AWS Serverless Application Repository makes it easy for developers and enterprises
    /// to quickly find and deploy serverless applications in the AWS Cloud. For more information
    /// about serverless applications, see Serverless Computing and Applications on the AWS
    /// website.
    /// 
    /// 
    /// <para>
    /// The AWS Serverless Application Repository is deeply integrated with the AWS Lambda
    /// console, so that developers of  all levels can get started with serverless computing
    /// without needing to learn anything new. You can use category  keywords to browse for
    /// applications such as web and mobile backends, data processing applications, or chatbots.
    ///  You can also search for applications by name, publisher, or event source. To use
    /// an application, you simply choose it,  configure any required fields, and deploy it
    /// with a few clicks. 
    /// </para>
    /// 
    /// <para>
    /// You can also easily publish applications, sharing them publicly with the community
    /// at large, or privately within your team or across your organization. To publish a
    /// serverless application (or app), you can use the AWS Management Console, AWS Command
    /// Line Interface (AWS CLI), or AWS SDKs to upload the code. Along with the code, you
    /// upload a simple manifest file, also known as the AWS Serverless Application Model
    /// (AWS SAM) template. For more information about AWS SAM, see AWS Serverless Application
    /// Model (AWS SAM) on the AWS Labs GitHub repository.
    /// </para>
    /// 
    /// <para>
    /// The AWS Serverless Application Repository Developer Guide contains more information
    /// about the two developer experiences available:
    /// </para>
    /// <ul> <li> 
    /// <para>
    /// Consuming Applications – Browse for applications and view information about them,
    /// including source code and readme files. Also install, configure, and deploy applications
    /// of your choosing. 
    /// </para>
    ///  
    /// <para>
    /// Publishing Applications – Configure and upload applications to make them available
    /// to other developers, and publish new versions of applications. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonServerlessApplicationRepositoryClient : AmazonServiceClient, IAmazonServerlessApplicationRepository
    {
        private static IServiceMetadata serviceMetadata = new AmazonServerlessApplicationRepositoryMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IServerlessApplicationRepositoryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IServerlessApplicationRepositoryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ServerlessApplicationRepositoryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with the credentials loaded from the application's
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
        public AmazonServerlessApplicationRepositoryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerlessApplicationRepositoryConfig()) { }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with the credentials loaded from the application's
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
        public AmazonServerlessApplicationRepositoryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerlessApplicationRepositoryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServerlessApplicationRepositoryClient Configuration Object</param>
        public AmazonServerlessApplicationRepositoryClient(AmazonServerlessApplicationRepositoryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServerlessApplicationRepositoryClient(AWSCredentials credentials)
            : this(credentials, new AmazonServerlessApplicationRepositoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerlessApplicationRepositoryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServerlessApplicationRepositoryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Credentials and an
        /// AmazonServerlessApplicationRepositoryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServerlessApplicationRepositoryClient Configuration Object</param>
        public AmazonServerlessApplicationRepositoryClient(AWSCredentials credentials, AmazonServerlessApplicationRepositoryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerlessApplicationRepositoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerlessApplicationRepositoryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerlessApplicationRepositoryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServerlessApplicationRepositoryClient Configuration Object</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServerlessApplicationRepositoryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerlessApplicationRepositoryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerlessApplicationRepositoryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerlessApplicationRepositoryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerlessApplicationRepositoryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServerlessApplicationRepositoryClient Configuration Object</param>
        public AmazonServerlessApplicationRepositoryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServerlessApplicationRepositoryConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServerlessApplicationRepositoryEndpointResolver());
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


        #region  CreateApplication

        /// <summary>
        /// Creates an application, optionally including an AWS SAM file to create the first application
        /// version in the same call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
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
        /// <returns>Returns a  CreateApplicationResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplicationVersion

        /// <summary>
        /// Creates an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateApplicationVersionResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudFormationChangeSet

        /// <summary>
        /// Creates an AWS CloudFormation change set for the given application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFormationChangeSet service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationChangeSet">REST API Reference for CreateCloudFormationChangeSet Operation</seealso>
        public virtual CreateCloudFormationChangeSetResponse CreateCloudFormationChangeSet(CreateCloudFormationChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFormationChangeSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFormationChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationChangeSet operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFormationChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationChangeSet">REST API Reference for CreateCloudFormationChangeSet Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudFormationChangeSet(CreateCloudFormationChangeSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFormationChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFormationChangeSet.</param>
        /// 
        /// <returns>Returns a  CreateCloudFormationChangeSetResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationChangeSet">REST API Reference for CreateCloudFormationChangeSet Operation</seealso>
        public virtual CreateCloudFormationChangeSetResponse EndCreateCloudFormationChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudFormationChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCloudFormationTemplate

        /// <summary>
        /// Creates an AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFormationTemplate service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationTemplate">REST API Reference for CreateCloudFormationTemplate Operation</seealso>
        public virtual CreateCloudFormationTemplateResponse CreateCloudFormationTemplate(CreateCloudFormationTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFormationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFormationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationTemplate operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFormationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationTemplate">REST API Reference for CreateCloudFormationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudFormationTemplate(CreateCloudFormationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFormationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFormationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateCloudFormationTemplateResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationTemplate">REST API Reference for CreateCloudFormationTemplate Operation</seealso>
        public virtual CreateCloudFormationTemplateResponse EndCreateCloudFormationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudFormationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
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
        /// <returns>Returns a  DeleteApplicationResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplication

        /// <summary>
        /// Gets the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationPolicy

        /// <summary>
        /// Retrieves the policy for the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationPolicy service method.</param>
        /// 
        /// <returns>The response from the GetApplicationPolicy service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplicationPolicy">REST API Reference for GetApplicationPolicy Operation</seealso>
        public virtual GetApplicationPolicyResponse GetApplicationPolicy(GetApplicationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetApplicationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationPolicy operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplicationPolicy">REST API Reference for GetApplicationPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationPolicy(GetApplicationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationPolicy.</param>
        /// 
        /// <returns>Returns a  GetApplicationPolicyResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplicationPolicy">REST API Reference for GetApplicationPolicy Operation</seealso>
        public virtual GetApplicationPolicyResponse EndGetApplicationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudFormationTemplate

        /// <summary>
        /// Gets the specified AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCloudFormationTemplate service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetCloudFormationTemplate">REST API Reference for GetCloudFormationTemplate Operation</seealso>
        public virtual GetCloudFormationTemplateResponse GetCloudFormationTemplate(GetCloudFormationTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCloudFormationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFormationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationTemplate operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFormationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetCloudFormationTemplate">REST API Reference for GetCloudFormationTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetCloudFormationTemplate(GetCloudFormationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFormationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFormationTemplate.</param>
        /// 
        /// <returns>Returns a  GetCloudFormationTemplateResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetCloudFormationTemplate">REST API Reference for GetCloudFormationTemplate Operation</seealso>
        public virtual GetCloudFormationTemplateResponse EndGetCloudFormationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudFormationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationDependencies

        /// <summary>
        /// Retrieves the list of applications nested in the containing application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDependencies service method.</param>
        /// 
        /// <returns>The response from the ListApplicationDependencies service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationDependencies">REST API Reference for ListApplicationDependencies Operation</seealso>
        public virtual ListApplicationDependenciesResponse ListApplicationDependencies(ListApplicationDependenciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationDependenciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDependencies operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationDependencies">REST API Reference for ListApplicationDependencies Operation</seealso>
        public virtual IAsyncResult BeginListApplicationDependencies(ListApplicationDependenciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDependenciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationDependencies.</param>
        /// 
        /// <returns>Returns a  ListApplicationDependenciesResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationDependencies">REST API Reference for ListApplicationDependencies Operation</seealso>
        public virtual ListApplicationDependenciesResponse EndListApplicationDependencies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationDependenciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists applications owned by the requester.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplications">REST API Reference for ListApplications Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplications">REST API Reference for ListApplications Operation</seealso>
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
        /// <returns>Returns a  ListApplicationsResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationVersions

        /// <summary>
        /// Lists versions for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the ListApplicationVersions service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual ListApplicationVersionsResponse ListApplicationVersions(ListApplicationVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual IAsyncResult BeginListApplicationVersions(ListApplicationVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationVersions.</param>
        /// 
        /// <returns>Returns a  ListApplicationVersionsResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual ListApplicationVersionsResponse EndListApplicationVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationPolicy

        /// <summary>
        /// Sets the permission policy for an application. For the list of actions supported for
        /// this operation, see <a href="https://docs.aws.amazon.com/serverlessrepo/latest/devguide/access-control-resource-based.html#application-permissions">Application
        ///  Permissions</a> .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutApplicationPolicy service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/PutApplicationPolicy">REST API Reference for PutApplicationPolicy Operation</seealso>
        public virtual PutApplicationPolicyResponse PutApplicationPolicy(PutApplicationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutApplicationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationPolicy operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/PutApplicationPolicy">REST API Reference for PutApplicationPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationPolicy(PutApplicationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationPolicy.</param>
        /// 
        /// <returns>Returns a  PutApplicationPolicyResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/PutApplicationPolicy">REST API Reference for PutApplicationPolicy Operation</seealso>
        public virtual PutApplicationPolicyResponse EndPutApplicationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UnshareApplication

        /// <summary>
        /// Unshares an application from an AWS Organization.
        /// 
        /// 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnshareApplication service method.</param>
        /// 
        /// <returns>The response from the UnshareApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UnshareApplication">REST API Reference for UnshareApplication Operation</seealso>
        public virtual UnshareApplicationResponse UnshareApplication(UnshareApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnshareApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareApplicationResponseUnmarshaller.Instance;

            return Invoke<UnshareApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnshareApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnshareApplication operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnshareApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UnshareApplication">REST API Reference for UnshareApplication Operation</seealso>
        public virtual IAsyncResult BeginUnshareApplication(UnshareApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnshareApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnshareApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnshareApplication.</param>
        /// 
        /// <returns>Returns a  UnshareApplicationResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UnshareApplication">REST API Reference for UnshareApplication Operation</seealso>
        public virtual UnshareApplicationResponse EndUnshareApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UnshareApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonServerlessApplicationRepositoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
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
        /// <returns>Returns a  UpdateApplicationResult from ServerlessApplicationRepository.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
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
            var resolver = new AmazonServerlessApplicationRepositoryEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}