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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations;
using Amazon.ServerlessApplicationRepository.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonServerlessApplicationRepositoryConfig()) { }

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
            : base(new AmazonServerlessApplicationRepositoryConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServerlessApplicationRepositoryEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServerlessApplicationRepositoryAuthSchemeHandler());
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
        /// Creates an application, optionally including an AWS SAM file to create the first application
        /// version in the same call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
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
        /// Creates an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationVersionResponse>(request, options, cancellationToken);
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
        /// Creates an AWS CloudFormation change set for the given application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateCloudFormationChangeSetResponse> CreateCloudFormationChangeSetAsync(CreateCloudFormationChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCloudFormationChangeSetResponse>(request, options, cancellationToken);
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
        /// Creates an AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateCloudFormationTemplateResponse> CreateCloudFormationTemplateAsync(CreateCloudFormationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCloudFormationTemplateResponse>(request, options, cancellationToken);
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
        /// Deletes the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
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
        /// Gets the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
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
        /// Retrieves the policy for the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetApplicationPolicyResponse> GetApplicationPolicyAsync(GetApplicationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApplicationPolicyResponse>(request, options, cancellationToken);
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
        /// Gets the specified AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCloudFormationTemplateResponse> GetCloudFormationTemplateAsync(GetCloudFormationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFormationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCloudFormationTemplateResponse>(request, options, cancellationToken);
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
        /// Retrieves the list of applications nested in the containing application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListApplicationDependenciesResponse> ListApplicationDependenciesAsync(ListApplicationDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDependenciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationDependenciesResponse>(request, options, cancellationToken);
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
        /// Lists applications owned by the requester.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
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
        /// Lists versions for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListApplicationVersionsResponse> ListApplicationVersionsAsync(ListApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationVersionsResponse>(request, options, cancellationToken);
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
        /// Sets the permission policy for an application. For the list of actions supported for
        /// this operation, see <a href="https://docs.aws.amazon.com/serverlessrepo/latest/devguide/access-control-resource-based.html#application-permissions">Application
        ///  Permissions</a> .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutApplicationPolicyResponse> PutApplicationPolicyAsync(PutApplicationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutApplicationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutApplicationPolicyResponse>(request, options, cancellationToken);
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
        /// Unshares an application from an AWS Organization.
        /// 
        /// 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnshareApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UnshareApplicationResponse> UnshareApplicationAsync(UnshareApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnshareApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnshareApplicationResponse>(request, options, cancellationToken);
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
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}