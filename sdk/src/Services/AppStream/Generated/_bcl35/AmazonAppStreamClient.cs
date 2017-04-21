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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.AppStream.Model;
using Amazon.AppStream.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppStream
{
    /// <summary>
    /// Implementation for accessing AppStream
    ///
    /// Amazon AppStream 2.0 
    /// <para>
    /// API documentation for Amazon AppStream 2.0.
    /// </para>
    /// </summary>
    public partial class AmazonAppStreamClient : AmazonServiceClient, IAmazonAppStream
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        public AmazonAppStreamClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppStreamConfig()) { }

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        public AmazonAppStreamClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppStreamConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(AmazonAppStreamConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppStreamClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppStreamConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials and an
        /// AmazonAppStreamClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(AWSCredentials credentials, AmazonAppStreamConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppStreamConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppStreamClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppStreamConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppStreamConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppStreamClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppStreamConfig clientConfig)
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

        
        #region  AssociateFleet

        /// <summary>
        /// Associate a fleet to a stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public AssociateFleetResponse AssociateFleet(AssociateFleetRequest request)
        {
            var marshaller = new AssociateFleetRequestMarshaller();
            var unmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateFleetRequest,AssociateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public IAsyncResult BeginAssociateFleet(AssociateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateFleetRequestMarshaller();
            var unmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFleet.</param>
        /// 
        /// <returns>Returns a  AssociateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public  AssociateFleetResponse EndAssociateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a new fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public  CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStack

        /// <summary>
        /// Create a new stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public  CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStackResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamingURL

        /// <summary>
        /// Creates a URL to start an AppStream 2.0 streaming session for a user. By default,
        /// the URL is valid only for 1 minute from the time that it is generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        public CreateStreamingURLResponse CreateStreamingURL(CreateStreamingURLRequest request)
        {
            var marshaller = new CreateStreamingURLRequestMarshaller();
            var unmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingURLRequest,CreateStreamingURLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        public IAsyncResult BeginCreateStreamingURL(CreateStreamingURLRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStreamingURLRequestMarshaller();
            var unmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStreamingURLRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingURL.</param>
        /// 
        /// <returns>Returns a  CreateStreamingURLResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        public  CreateStreamingURLResponse EndCreateStreamingURL(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamingURLResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public  DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStack

        /// <summary>
        /// Deletes the stack. After this operation completes, the environment can no longer be
        /// activated, and any reservations made for the stack are released.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public  DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStackResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleets

        /// <summary>
        /// If fleet names are provided, this operation describes the specified fleets; otherwise,
        /// all the fleets in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var marshaller = new DescribeFleetsRequestMarshaller();
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsRequest,DescribeFleetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public IAsyncResult BeginDescribeFleets(DescribeFleetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFleetsRequestMarshaller();
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFleetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleets.</param>
        /// 
        /// <returns>Returns a  DescribeFleetsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public  DescribeFleetsResponse EndDescribeFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImages

        /// <summary>
        /// Describes the images. If a list of names is not provided, all images in your account
        /// are returned. This operation does not return a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public  DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSessions

        /// <summary>
        /// Describes the streaming sessions for a stack and a fleet. If a user ID is provided,
        /// this operation returns streaming sessions for only that user. Pass this value for
        /// the <code>nextToken</code> parameter in a subsequent call to this operation to retrieve
        /// the next set of items. If an authentication type is not provided, the operation defaults
        /// to users authenticated using a streaming url.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
        {
            var marshaller = new DescribeSessionsRequestMarshaller();
            var unmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSessionsRequest,DescribeSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public IAsyncResult BeginDescribeSessions(DescribeSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSessionsRequestMarshaller();
            var unmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSessionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSessions.</param>
        /// 
        /// <returns>Returns a  DescribeSessionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public  DescribeSessionsResponse EndDescribeSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStacks

        /// <summary>
        /// If stack names are not provided, this operation describes the specified stacks; otherwise,
        /// all stacks in the account are described. Pass the <code>nextToken</code> value in
        /// a subsequent call to this operation to retrieve the next set of items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public  DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateFleet

        /// <summary>
        /// Disassociates a fleet from a stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public DisassociateFleetResponse DisassociateFleet(DisassociateFleetRequest request)
        {
            var marshaller = new DisassociateFleetRequestMarshaller();
            var unmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateFleetRequest,DisassociateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public IAsyncResult BeginDisassociateFleet(DisassociateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateFleetRequestMarshaller();
            var unmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public  DisassociateFleetResponse EndDisassociateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  ExpireSession

        /// <summary>
        /// This operation immediately stops a streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var marshaller = new ExpireSessionRequestMarshaller();
            var unmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionRequest,ExpireSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExpireSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public IAsyncResult BeginExpireSession(ExpireSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ExpireSessionRequestMarshaller();
            var unmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return BeginInvoke<ExpireSessionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExpireSession.</param>
        /// 
        /// <returns>Returns a  ExpireSessionResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public  ExpireSessionResponse EndExpireSession(IAsyncResult asyncResult)
        {
            return EndInvoke<ExpireSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedFleets

        /// <summary>
        /// Lists all fleets associated with the stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request)
        {
            var marshaller = new ListAssociatedFleetsRequestMarshaller();
            var unmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedFleetsRequest,ListAssociatedFleetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public IAsyncResult BeginListAssociatedFleets(ListAssociatedFleetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssociatedFleetsRequestMarshaller();
            var unmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssociatedFleetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedFleets.</param>
        /// 
        /// <returns>Returns a  ListAssociatedFleetsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public  ListAssociatedFleetsResponse EndListAssociatedFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedStacks

        /// <summary>
        /// Lists all stacks to which the specified fleet is associated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request)
        {
            var marshaller = new ListAssociatedStacksRequestMarshaller();
            var unmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedStacksRequest,ListAssociatedStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public IAsyncResult BeginListAssociatedStacks(ListAssociatedStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssociatedStacksRequestMarshaller();
            var unmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssociatedStacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedStacks.</param>
        /// 
        /// <returns>Returns a  ListAssociatedStacksResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public  ListAssociatedStacksResponse EndListAssociatedStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFleet

        /// <summary>
        /// Starts a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleet service method.</param>
        /// 
        /// <returns>The response from the StartFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public StartFleetResponse StartFleet(StartFleetRequest request)
        {
            var marshaller = new StartFleetRequestMarshaller();
            var unmarshaller = StartFleetResponseUnmarshaller.Instance;

            return Invoke<StartFleetRequest,StartFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public IAsyncResult BeginStartFleet(StartFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartFleetRequestMarshaller();
            var unmarshaller = StartFleetResponseUnmarshaller.Instance;

            return BeginInvoke<StartFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFleet.</param>
        /// 
        /// <returns>Returns a  StartFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public  StartFleetResponse EndStartFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFleet

        /// <summary>
        /// Stops a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleet service method.</param>
        /// 
        /// <returns>The response from the StopFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public StopFleetResponse StopFleet(StopFleetRequest request)
        {
            var marshaller = new StopFleetRequestMarshaller();
            var unmarshaller = StopFleetResponseUnmarshaller.Instance;

            return Invoke<StopFleetRequest,StopFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public IAsyncResult BeginStopFleet(StopFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopFleetRequestMarshaller();
            var unmarshaller = StopFleetResponseUnmarshaller.Instance;

            return BeginInvoke<StopFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFleet.</param>
        /// 
        /// <returns>Returns a  StopFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public  StopFleetResponse EndStopFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleet

        /// <summary>
        /// Updates an existing fleet. All the attributes except the fleet name can be updated
        /// in the <b>STOPPED</b> state. When a fleet is in the <b>RUNNING</b> state, only <code>DisplayName</code>
        /// and <code>ComputeCapacity</code> can be updated. A fleet cannot be updated in a status
        /// of <b>STARTING</b> or <b>STOPPING</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred, please try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public UpdateFleetResponse UpdateFleet(UpdateFleetRequest request)
        {
            var marshaller = new UpdateFleetRequestMarshaller();
            var unmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetRequest,UpdateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFleetRequestMarshaller();
            var unmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public  UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStack

        /// <summary>
        /// Updates the specified fields in the stack with the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public  UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStackResponse>(asyncResult);
        }

        #endregion
        
    }
}