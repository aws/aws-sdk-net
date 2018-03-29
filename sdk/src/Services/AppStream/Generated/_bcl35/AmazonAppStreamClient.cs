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
    /// You can use Amazon AppStream 2.0 to stream desktop applications to any device running
    /// a web browser, without rewriting them.
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
        /// Associates the specified fleet with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public virtual AssociateFleetResponse AssociateFleet(AssociateFleetRequest request)
        {
            var marshaller = AssociateFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginAssociateFleet(AssociateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateFleetRequestMarshaller.Instance;
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
        public virtual AssociateFleetResponse EndAssociateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyImage

        /// <summary>
        /// Copies the image within the same region or to a new region within the same AWS account.
        /// Note that any tags you added to the image will not be copied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual IAsyncResult BeginCopyImage(CopyImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return BeginInvoke<CopyImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a  CopyImageResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual CopyImageResponse EndCopyImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDirectoryConfig

        /// <summary>
        /// Creates a directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual CreateDirectoryConfigResponse CreateDirectoryConfig(CreateDirectoryConfigRequest request)
        {
            var marshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryConfigRequest,CreateDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateDirectoryConfig(CreateDirectoryConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDirectoryConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual CreateDirectoryConfigResponse EndCreateDirectoryConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDirectoryConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
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
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImageBuilder

        /// <summary>
        /// Creates an image builder.
        /// 
        ///  
        /// <para>
        /// The initial state of the builder is <code>PENDING</code>. When it is ready, the state
        /// is <code>RUNNING</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        public virtual CreateImageBuilderResponse CreateImageBuilder(CreateImageBuilderRequest request)
        {
            var marshaller = CreateImageBuilderRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderRequest,CreateImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        public virtual IAsyncResult BeginCreateImageBuilder(CreateImageBuilderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateImageBuilderRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke<CreateImageBuilderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageBuilder.</param>
        /// 
        /// <returns>Returns a  CreateImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        public virtual CreateImageBuilderResponse EndCreateImageBuilder(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImageBuilderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImageBuilderStreamingURL

        /// <summary>
        /// Creates a URL to start an image builder streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilderStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual CreateImageBuilderStreamingURLResponse CreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request)
        {
            var marshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderStreamingURLRequest,CreateImageBuilderStreamingURLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilderStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageBuilderStreamingURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual IAsyncResult BeginCreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return BeginInvoke<CreateImageBuilderStreamingURLRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageBuilderStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageBuilderStreamingURL.</param>
        /// 
        /// <returns>Returns a  CreateImageBuilderStreamingURLResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual CreateImageBuilderStreamingURLResponse EndCreateImageBuilderStreamingURL(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImageBuilderStreamingURLResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStack

        /// <summary>
        /// Creates a stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
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
        public virtual CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStackResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamingURL

        /// <summary>
        /// Creates a URL to start a streaming session for the specified user.
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
        public virtual CreateStreamingURLResponse CreateStreamingURL(CreateStreamingURLRequest request)
        {
            var marshaller = CreateStreamingURLRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginCreateStreamingURL(CreateStreamingURLRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStreamingURLRequestMarshaller.Instance;
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
        public virtual CreateStreamingURLResponse EndCreateStreamingURL(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamingURLResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDirectoryConfig

        /// <summary>
        /// Deletes the specified directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual DeleteDirectoryConfigResponse DeleteDirectoryConfig(DeleteDirectoryConfigRequest request)
        {
            var marshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryConfigRequest,DeleteDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteDirectoryConfig(DeleteDirectoryConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDirectoryConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual DeleteDirectoryConfigResponse EndDeleteDirectoryConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDirectoryConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
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
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImage

        /// <summary>
        /// Deletes the specified image. You cannot delete an image that is currently in use.
        /// After you delete an image, you cannot provision new capacity using the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var marshaller = DeleteImageRequestMarshaller.Instance;
            var unmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageRequest,DeleteImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual IAsyncResult BeginDeleteImage(DeleteImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteImageRequestMarshaller.Instance;
            var unmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImage.</param>
        /// 
        /// <returns>Returns a  DeleteImageResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual DeleteImageResponse EndDeleteImage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImageBuilder

        /// <summary>
        /// Deletes the specified image builder and releases the capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder service method.</param>
        /// 
        /// <returns>The response from the DeleteImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        public virtual DeleteImageBuilderResponse DeleteImageBuilder(DeleteImageBuilderRequest request)
        {
            var marshaller = DeleteImageBuilderRequestMarshaller.Instance;
            var unmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return Invoke<DeleteImageBuilderRequest,DeleteImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        public virtual IAsyncResult BeginDeleteImageBuilder(DeleteImageBuilderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteImageBuilderRequestMarshaller.Instance;
            var unmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteImageBuilderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImageBuilder.</param>
        /// 
        /// <returns>Returns a  DeleteImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        public virtual DeleteImageBuilderResponse EndDeleteImageBuilder(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImageBuilderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStack

        /// <summary>
        /// Deletes the specified stack. After this operation completes, the environment can no
        /// longer be activated and any reservations made for the stack are released.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
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
        public virtual DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStackResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDirectoryConfigs

        /// <summary>
        /// Describes the specified directory configurations. Note that although the response
        /// syntax in this topic includes the account password, this password is not returned
        /// in the actual response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectoryConfigs service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual DescribeDirectoryConfigsResponse DescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request)
        {
            var marshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoryConfigsRequest,DescribeDirectoryConfigsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectoryConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectoryConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual IAsyncResult BeginDescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDirectoryConfigsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectoryConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectoryConfigs.</param>
        /// 
        /// <returns>Returns a  DescribeDirectoryConfigsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual DescribeDirectoryConfigsResponse EndDescribeDirectoryConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDirectoryConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleets

        /// <summary>
        /// Describes the specified fleets or all fleets in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDescribeFleets(DescribeFleetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
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
        public virtual DescribeFleetsResponse EndDescribeFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImageBuilders

        /// <summary>
        /// Describes the specified image builders or all image builders in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders service method.</param>
        /// 
        /// <returns>The response from the DescribeImageBuilders service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual DescribeImageBuildersResponse DescribeImageBuilders(DescribeImageBuildersRequest request)
        {
            var marshaller = DescribeImageBuildersRequestMarshaller.Instance;
            var unmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return Invoke<DescribeImageBuildersRequest,DescribeImageBuildersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageBuilders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageBuilders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual IAsyncResult BeginDescribeImageBuilders(DescribeImageBuildersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeImageBuildersRequestMarshaller.Instance;
            var unmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImageBuildersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageBuilders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageBuilders.</param>
        /// 
        /// <returns>Returns a  DescribeImageBuildersResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual DescribeImageBuildersResponse EndDescribeImageBuilders(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImageBuildersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImages

        /// <summary>
        /// Describes the specified images or all images in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
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
        public virtual DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSessions

        /// <summary>
        /// Describes the streaming sessions for the specified stack and fleet. If a user ID is
        /// provided, only the streaming sessions for only that user are returned. If an authentication
        /// type is not provided, the default is to authenticate users using a streaming URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
        {
            var marshaller = DescribeSessionsRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDescribeSessions(DescribeSessionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeSessionsRequestMarshaller.Instance;
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
        public virtual DescribeSessionsResponse EndDescribeSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStacks

        /// <summary>
        /// Describes the specified stacks or all stacks in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = DescribeStacksRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeStacksRequestMarshaller.Instance;
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
        public virtual DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateFleet

        /// <summary>
        /// Disassociates the specified fleet from the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public virtual DisassociateFleetResponse DisassociateFleet(DisassociateFleetRequest request)
        {
            var marshaller = DisassociateFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginDisassociateFleet(DisassociateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateFleetRequestMarshaller.Instance;
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
        public virtual DisassociateFleetResponse EndDisassociateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  ExpireSession

        /// <summary>
        /// Stops the specified streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var marshaller = ExpireSessionRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginExpireSession(ExpireSessionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ExpireSessionRequestMarshaller.Instance;
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
        public virtual ExpireSessionResponse EndExpireSession(IAsyncResult asyncResult)
        {
            return EndInvoke<ExpireSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedFleets

        /// <summary>
        /// Lists the fleets associated with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public virtual ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request)
        {
            var marshaller = ListAssociatedFleetsRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginListAssociatedFleets(ListAssociatedFleetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAssociatedFleetsRequestMarshaller.Instance;
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
        public virtual ListAssociatedFleetsResponse EndListAssociatedFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedStacks

        /// <summary>
        /// Lists the stacks associated with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public virtual ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request)
        {
            var marshaller = ListAssociatedStacksRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginListAssociatedStacks(ListAssociatedStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAssociatedStacksRequestMarshaller.Instance;
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
        public virtual ListAssociatedStacksResponse EndListAssociatedStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for the specified AppStream 2.0 resource. You can tag AppStream 2.0
        /// image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFleet

        /// <summary>
        /// Starts the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleet service method.</param>
        /// 
        /// <returns>The response from the StartFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        public virtual StartFleetResponse StartFleet(StartFleetRequest request)
        {
            var marshaller = StartFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginStartFleet(StartFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartFleetRequestMarshaller.Instance;
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
        public virtual StartFleetResponse EndStartFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImageBuilder

        /// <summary>
        /// Starts the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder service method.</param>
        /// 
        /// <returns>The response from the StartImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        public virtual StartImageBuilderResponse StartImageBuilder(StartImageBuilderRequest request)
        {
            var marshaller = StartImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StartImageBuilderRequest,StartImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        public virtual IAsyncResult BeginStartImageBuilder(StartImageBuilderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke<StartImageBuilderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImageBuilder.</param>
        /// 
        /// <returns>Returns a  StartImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        public virtual StartImageBuilderResponse EndStartImageBuilder(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImageBuilderResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFleet

        /// <summary>
        /// Stops the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleet service method.</param>
        /// 
        /// <returns>The response from the StopFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public virtual StopFleetResponse StopFleet(StopFleetRequest request)
        {
            var marshaller = StopFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginStopFleet(StopFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopFleetRequestMarshaller.Instance;
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
        public virtual StopFleetResponse EndStopFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  StopImageBuilder

        /// <summary>
        /// Stops the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder service method.</param>
        /// 
        /// <returns>The response from the StopImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        public virtual StopImageBuilderResponse StopImageBuilder(StopImageBuilderRequest request)
        {
            var marshaller = StopImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StopImageBuilderRequest,StopImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        public virtual IAsyncResult BeginStopImageBuilder(StopImageBuilderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke<StopImageBuilderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopImageBuilder.</param>
        /// 
        /// <returns>Returns a  StopImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        public virtual StopImageBuilderResponse EndStopImageBuilder(IAsyncResult asyncResult)
        {
            return EndInvoke<StopImageBuilderResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites one or more tags for the specified AppStream 2.0 resource. You
        /// can tag AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, this operation updates its value.
        /// </para>
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>. To disassociate
        /// tags from your resources, use <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Disassociates the specified tags from the specified AppStream 2.0 resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDirectoryConfig

        /// <summary>
        /// Updates the specified directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual UpdateDirectoryConfigResponse UpdateDirectoryConfig(UpdateDirectoryConfigRequest request)
        {
            var marshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectoryConfigRequest,UpdateDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateDirectoryConfig(UpdateDirectoryConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDirectoryConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  UpdateDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual UpdateDirectoryConfigResponse EndUpdateDirectoryConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDirectoryConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleet

        /// <summary>
        /// Updates the specified fleet.
        /// 
        ///  
        /// <para>
        /// If the fleet is in the <code>STOPPED</code> state, you can update any attribute except
        /// the fleet name. If the fleet is in the <code>RUNNING</code> state, you can update
        /// the <code>DisplayName</code> and <code>ComputeCapacity</code> attributes. If the fleet
        /// is in the <code>STARTING</code> or <code>STOPPING</code> state, you can't update it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
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
        public virtual UpdateFleetResponse UpdateFleet(UpdateFleetRequest request)
        {
            var marshaller = UpdateFleetRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFleetRequestMarshaller.Instance;
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
        public virtual UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStack

        /// <summary>
        /// Updates the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
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
        public virtual IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
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
        public virtual UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStackResponse>(asyncResult);
        }

        #endregion
        
    }
}