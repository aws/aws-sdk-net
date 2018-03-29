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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServerlessApplicationRepository
{
    /// <summary>
    /// Implementation for accessing ServerlessApplicationRepository
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var marshaller = CreateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionRequest,CreateApplicationVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates an AWS CloudFormation ChangeSet for the given application.
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
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationChangeSet">REST API Reference for CreateCloudFormationChangeSet Operation</seealso>
        public virtual CreateCloudFormationChangeSetResponse CreateCloudFormationChangeSet(CreateCloudFormationChangeSetRequest request)
        {
            var marshaller = CreateCloudFormationChangeSetRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFormationChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFormationChangeSetRequest,CreateCloudFormationChangeSetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateCloudFormationChangeSetRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFormationChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCloudFormationChangeSetRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var marshaller = GetApplicationRequestMarshaller.Instance;
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRequest,GetApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApplicationRequestMarshaller.Instance;
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<GetApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Gets the policy for the specified application.
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplicationPolicy">REST API Reference for GetApplicationPolicy Operation</seealso>
        public virtual GetApplicationPolicyResponse GetApplicationPolicy(GetApplicationPolicyRequest request)
        {
            var marshaller = GetApplicationPolicyRequestMarshaller.Instance;
            var unmarshaller = GetApplicationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetApplicationPolicyRequest,GetApplicationPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApplicationPolicyRequestMarshaller.Instance;
            var unmarshaller = GetApplicationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetApplicationPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListApplicationsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual ListApplicationVersionsResponse ListApplicationVersions(ListApplicationVersionsRequest request)
        {
            var marshaller = ListApplicationVersionsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationVersionsRequest,ListApplicationVersionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListApplicationVersionsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListApplicationVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Puts the policy for the specified application.
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/PutApplicationPolicy">REST API Reference for PutApplicationPolicy Operation</seealso>
        public virtual PutApplicationPolicyResponse PutApplicationPolicy(PutApplicationPolicyRequest request)
        {
            var marshaller = PutApplicationPolicyRequestMarshaller.Instance;
            var unmarshaller = PutApplicationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutApplicationPolicyRequest,PutApplicationPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutApplicationPolicyRequestMarshaller.Instance;
            var unmarshaller = PutApplicationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutApplicationPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The resource (for example, an access policy statement) specified in the request does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}