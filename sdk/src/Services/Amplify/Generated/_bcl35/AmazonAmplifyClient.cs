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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Amplify.Model;
using Amazon.Amplify.Model.Internal.MarshallTransformations;
using Amazon.Amplify.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Amplify
{
    /// <summary>
    /// Implementation for accessing Amplify
    ///
    /// Amplify is a fully managed continuous deployment and hosting service for modern web
    /// apps.
    /// </summary>
    public partial class AmazonAmplifyClient : AmazonServiceClient, IAmazonAmplify
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AmazonAmplifyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials and an
        /// AmazonAmplifyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AWSCredentials credentials, AmazonAmplifyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyConfig clientConfig)
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


        #region  CreateApp

        /// <summary>
        /// Creates a new Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
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
        /// <returns>Returns a  CreateAppResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBranch

        /// <summary>
        /// Creates a new Branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual IAsyncResult BeginCreateBranch(CreateBranchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBranch.</param>
        /// 
        /// <returns>Returns a  CreateBranchResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual CreateBranchResponse EndCreateBranch(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBranchResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainAssociation

        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual CreateDomainAssociationResponse CreateDomainAssociation(CreateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainAssociation(CreateDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainAssociation.</param>
        /// 
        /// <returns>Returns a  CreateDomainAssociationResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual CreateDomainAssociationResponse EndCreateDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Delete an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
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
        /// <returns>Returns a  DeleteAppResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBranch

        /// <summary>
        /// Deletes a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual DeleteBranchResponse DeleteBranch(DeleteBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return Invoke<DeleteBranchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual IAsyncResult BeginDeleteBranch(DeleteBranchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBranch.</param>
        /// 
        /// <returns>Returns a  DeleteBranchResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual DeleteBranchResponse EndDeleteBranch(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBranchResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainAssociation

        /// <summary>
        /// Deletes a DomainAssociation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual DeleteDomainAssociationResponse DeleteDomainAssociation(DeleteDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainAssociation(DeleteDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteDomainAssociationResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual DeleteDomainAssociationResponse EndDeleteDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJob

        /// <summary>
        /// Delete a job, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApp

        /// <summary>
        /// Retrieves an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse EndGetApp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBranch

        /// <summary>
        /// Retrieves a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual IAsyncResult BeginGetBranch(GetBranchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBranch.</param>
        /// 
        /// <returns>Returns a  GetBranchResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual GetBranchResponse EndGetBranch(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBranchResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainAssociation

        /// <summary>
        /// Retrieves domain info that corresponds to an appId and domainName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the GetDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual GetDomainAssociationResponse GetDomainAssociation(GetDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<GetDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetDomainAssociation(GetDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainAssociation.</param>
        /// 
        /// <returns>Returns a  GetDomainAssociationResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual GetDomainAssociationResponse EndGetDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJob

        /// <summary>
        /// Get a job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApps

        /// <summary>
        /// Lists existing Amplify Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
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
        /// <returns>Returns a  ListAppsResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse EndListApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBranches

        /// <summary>
        /// Lists branches for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBranches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual IAsyncResult BeginListBranches(ListBranchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBranches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBranches.</param>
        /// 
        /// <returns>Returns a  ListBranchesResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual ListBranchesResponse EndListBranches(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBranchesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomainAssociations

        /// <summary>
        /// List domains with an app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDomainAssociations service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual ListDomainAssociationsResponse ListDomainAssociations(ListDomainAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListDomainAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual IAsyncResult BeginListDomainAssociations(ListDomainAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainAssociations.</param>
        /// 
        /// <returns>Returns a  ListDomainAssociationsResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual ListDomainAssociationsResponse EndListDomainAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// List Jobs for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartJob

        /// <summary>
        /// Starts a new job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse StartJob(StartJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return Invoke<StartJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJob operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual IAsyncResult BeginStartJob(StartJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJob.</param>
        /// 
        /// <returns>Returns a  StartJobResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse EndStartJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopJob

        /// <summary>
        /// Stop a job that is in progress, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual StopJobResponse StopJob(StopJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return Invoke<StopJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopJob operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual IAsyncResult BeginStopJob(StopJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopJob.</param>
        /// 
        /// <returns>Returns a  StopJobResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual StopJobResponse EndStopJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApp

        /// <summary>
        /// Updates an existing Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
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
        /// <returns>Returns a  UpdateAppResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBranch

        /// <summary>
        /// Updates a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual UpdateBranchResponse UpdateBranch(UpdateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateBranchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual IAsyncResult BeginUpdateBranch(UpdateBranchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBranch.</param>
        /// 
        /// <returns>Returns a  UpdateBranchResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual UpdateBranchResponse EndUpdateBranch(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBranchResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainAssociation

        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation operation on AmazonAmplifyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainAssociation(UpdateDomainAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateDomainAssociationResult from Amplify.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual UpdateDomainAssociationResponse EndUpdateDomainAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainAssociationResponse>(asyncResult);
        }

        #endregion
        
    }
}