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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AppStream.Model;
using Amazon.AppStream.Model.Internal.MarshallTransformations;
using Amazon.AppStream.Internal;
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
    /// This is the <i>Amazon AppStream 2.0 API Reference</i>. This documentation provides
    /// descriptions and syntax for each of the actions and data types in AppStream 2.0. AppStream
    /// 2.0 is a fully managed, secure application streaming service that lets you stream
    /// desktop applications to users without rewriting applications. AppStream 2.0 manages
    /// the AWS resources that are required to host and run your applications, scales automatically,
    /// and provides access to your users on demand. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can call the AppStream 2.0 API operations by using an interface VPC endpoint (interface
    /// endpoint). For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/access-api-cli-through-interface-vpc-endpoint.html">Access
    /// AppStream 2.0 API Operations and CLI Commands Through an Interface VPC Endpoint</a>
    /// in the <i>Amazon AppStream 2.0 Administration Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To learn more about AppStream 2.0, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/appstream2">Amazon AppStream 2.0 product page</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/appstream2">Amazon AppStream 2.0 documentation</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonAppStreamClient : AmazonServiceClient, IAmazonAppStream
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppStreamMetadata();

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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  BatchAssociateUserStack

        /// <summary>
        /// Associates the specified users with the specified stacks. Users in a user pool cannot
        /// be assigned to stacks with fleets that are joined to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateUserStack service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateUserStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        public virtual BatchAssociateUserStackResponse BatchAssociateUserStack(BatchAssociateUserStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateUserStackResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateUserStackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateUserStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateUserStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateUserStack(BatchAssociateUserStackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateUserStackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateUserStack.</param>
        /// 
        /// <returns>Returns a  BatchAssociateUserStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        public virtual BatchAssociateUserStackResponse EndBatchAssociateUserStack(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateUserStackResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateUserStack

        /// <summary>
        /// Disassociates the specified users from the specified stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateUserStack service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateUserStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        public virtual BatchDisassociateUserStackResponse BatchDisassociateUserStack(BatchDisassociateUserStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateUserStackResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateUserStackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateUserStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateUserStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateUserStack(BatchDisassociateUserStackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateUserStackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateUserStack.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateUserStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        public virtual BatchDisassociateUserStackResponse EndBatchDisassociateUserStack(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateUserStackResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a Directory Config object in AppStream 2.0. This object includes the configuration
        /// information required to join fleets and image builders to Microsoft Active Directory
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual CreateDirectoryConfigResponse CreateDirectoryConfig(CreateDirectoryConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryConfigResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a fleet. A fleet consists of streaming instances that run a specified image.
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
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates an image builder. An image builder is a virtual machine that is used to create
        /// an image.
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
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderStreamingURLResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a stack to start streaming applications to users. A stack consists of an associated
        /// fleet, user access policies, and storage configurations.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates a temporary URL to start an AppStream 2.0 streaming session for the specified
        /// user. A streaming URL enables application streaming to be tested without user setup.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingURLResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  CreateUsageReportSubscription

        /// <summary>
        /// Creates a usage report subscription. Usage reports are generated daily.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageReportSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateUsageReportSubscription service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUsageReportSubscription">REST API Reference for CreateUsageReportSubscription Operation</seealso>
        public virtual CreateUsageReportSubscriptionResponse CreateUsageReportSubscription(CreateUsageReportSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageReportSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateUsageReportSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsageReportSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageReportSubscription operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsageReportSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUsageReportSubscription">REST API Reference for CreateUsageReportSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateUsageReportSubscription(CreateUsageReportSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageReportSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsageReportSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsageReportSubscription.</param>
        /// 
        /// <returns>Returns a  CreateUsageReportSubscriptionResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUsageReportSubscription">REST API Reference for CreateUsageReportSubscription Operation</seealso>
        public virtual CreateUsageReportSubscriptionResponse EndCreateUsageReportSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUsageReportSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a new user in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDirectoryConfig

        /// <summary>
        /// Deletes the specified Directory Config object from AppStream 2.0. This object includes
        /// the information required to join streaming instances to an Active Directory domain.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryConfigResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Deletes the specified image. You cannot delete an image when it is in use. After you
        /// delete an image, you cannot provision new capacity using the image.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return Invoke<DeleteImageBuilderResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeleteImagePermissions

        /// <summary>
        /// Deletes permissions for the specified private image. After you delete permissions
        /// for an image, AWS accounts to which you previously granted these permissions can no
        /// longer use the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        public virtual DeleteImagePermissionsResponse DeleteImagePermissions(DeleteImagePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteImagePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        public virtual IAsyncResult BeginDeleteImagePermissions(DeleteImagePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImagePermissions.</param>
        /// 
        /// <returns>Returns a  DeleteImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        public virtual DeleteImagePermissionsResponse EndDeleteImagePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImagePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStack

        /// <summary>
        /// Deletes the specified stack. After the stack is deleted, the application streaming
        /// environment provided by the stack is no longer available to users. Also, any reservations
        /// made for application streaming sessions for the stack are released.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeleteUsageReportSubscription

        /// <summary>
        /// Disables usage report generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageReportSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteUsageReportSubscription service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUsageReportSubscription">REST API Reference for DeleteUsageReportSubscription Operation</seealso>
        public virtual DeleteUsageReportSubscriptionResponse DeleteUsageReportSubscription(DeleteUsageReportSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageReportSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageReportSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsageReportSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageReportSubscription operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsageReportSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUsageReportSubscription">REST API Reference for DeleteUsageReportSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteUsageReportSubscription(DeleteUsageReportSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageReportSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsageReportSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsageReportSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteUsageReportSubscriptionResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUsageReportSubscription">REST API Reference for DeleteUsageReportSubscription Operation</seealso>
        public virtual DeleteUsageReportSubscriptionResponse EndDeleteUsageReportSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsageReportSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a user from the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDirectoryConfigs

        /// <summary>
        /// Retrieves a list that describes one or more specified Directory Config objects for
        /// AppStream 2.0, if the names for these objects are provided. Otherwise, all Directory
        /// Config objects in the account are described. These objects include the configuration
        /// information required to join fleets and image builders to Microsoft Active Directory
        /// domains. 
        /// 
        ///  
        /// <para>
        /// Although the response syntax in this topic includes the account password, this password
        /// is not returned in the actual response.
        /// </para>
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoryConfigsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a list that describes one or more specified fleets, if the fleet names are
        /// provided. Otherwise, all fleets in the account are described.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a list that describes one or more specified image builders, if the image
        /// builder names are provided. Otherwise, all image builders in the account are described.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return Invoke<DescribeImageBuildersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DescribeImagePermissions

        /// <summary>
        /// Retrieves a list that describes the permissions for shared AWS account IDs on a private
        /// image that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImagePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        public virtual DescribeImagePermissionsResponse DescribeImagePermissions(DescribeImagePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeImagePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeImagePermissions(DescribeImagePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImagePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        public virtual DescribeImagePermissionsResponse EndDescribeImagePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImagePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImages

        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image names or
        /// image ARNs are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a list that describes the streaming sessions for a specified stack and fleet.
        /// If a UserId is provided for the stack and fleet, only streaming sessions for that
        /// user are described. If an authentication type is not provided, the default is to authenticate
        /// users using a streaming URL.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSessionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a list that describes one or more specified stacks, if the stack names are
        /// provided. Otherwise, all stacks in the account are described.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DescribeUsageReportSubscriptions

        /// <summary>
        /// Retrieves a list that describes one or more usage report subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageReportSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeUsageReportSubscriptions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsageReportSubscriptions">REST API Reference for DescribeUsageReportSubscriptions Operation</seealso>
        public virtual DescribeUsageReportSubscriptionsResponse DescribeUsageReportSubscriptions(DescribeUsageReportSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageReportSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageReportSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeUsageReportSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsageReportSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageReportSubscriptions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsageReportSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsageReportSubscriptions">REST API Reference for DescribeUsageReportSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeUsageReportSubscriptions(DescribeUsageReportSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageReportSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageReportSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsageReportSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsageReportSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeUsageReportSubscriptionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsageReportSubscriptions">REST API Reference for DescribeUsageReportSubscriptions Operation</seealso>
        public virtual DescribeUsageReportSubscriptionsResponse EndDescribeUsageReportSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUsageReportSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUsers

        /// <summary>
        /// Retrieves a list that describes one or more specified users in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual IAsyncResult BeginDescribeUsers(DescribeUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsers.</param>
        /// 
        /// <returns>Returns a  DescribeUsersResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual DescribeUsersResponse EndDescribeUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserStackAssociations

        /// <summary>
        /// Retrieves a list that describes the UserStackAssociation objects. You must specify
        /// either or both of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The stack name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user name (email address of the user associated with the stack) and the authentication
        /// type for the user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserStackAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeUserStackAssociations service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        public virtual DescribeUserStackAssociationsResponse DescribeUserStackAssociations(DescribeUserStackAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserStackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserStackAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeUserStackAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserStackAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserStackAssociations operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserStackAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserStackAssociations(DescribeUserStackAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserStackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserStackAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserStackAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserStackAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeUserStackAssociationsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        public virtual DescribeUserStackAssociationsResponse EndDescribeUserStackAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserStackAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableUser

        /// <summary>
        /// Disables the specified user in the user pool. Users can't sign in to AppStream 2.0
        /// until they are re-enabled. This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual DisableUserResponse DisableUser(DisableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return Invoke<DisableUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual IAsyncResult BeginDisableUser(DisableUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableUser.</param>
        /// 
        /// <returns>Returns a  DisableUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual DisableUserResponse EndDisableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableUserResponse>(asyncResult);
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
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  EnableUser

        /// <summary>
        /// Enables a user in the user pool. After being enabled, users can sign in to AppStream
        /// 2.0 and open applications from the stacks to which they are assigned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableUser service method.</param>
        /// 
        /// <returns>The response from the EnableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        public virtual EnableUserResponse EnableUser(EnableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableUserResponseUnmarshaller.Instance;

            return Invoke<EnableUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        public virtual IAsyncResult BeginEnableUser(EnableUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableUser.</param>
        /// 
        /// <returns>Returns a  EnableUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        public virtual EnableUserResponse EndEnableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ExpireSession

        /// <summary>
        /// Immediately stops the specified streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves the name of the fleet that is associated with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public virtual ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedFleetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves the name of the stack with which the specified fleet is associated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public virtual ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedStacksResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Retrieves a list of all tags for the specified AppStream 2.0 resource. You can tag
        /// AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
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
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public virtual StartFleetResponse StartFleet(StartFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetResponseUnmarshaller.Instance;

            return Invoke<StartFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StartImageBuilderResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetResponseUnmarshaller.Instance;

            return Invoke<StopFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StopImageBuilderResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
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
        /// <returns>Returns a  TagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Disassociates one or more specified tags from the specified AppStream 2.0 resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
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
        /// <returns>Returns a  UntagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDirectoryConfig

        /// <summary>
        /// Updates the specified Directory Config object in AppStream 2.0. This object includes
        /// the configuration information required to join fleets and image builders to Microsoft
        /// Active Directory domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual UpdateDirectoryConfigResponse UpdateDirectoryConfig(UpdateDirectoryConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectoryConfigResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// the <code>DisplayName</code>, <code>ComputeCapacity</code>, <code>ImageARN</code>,
        /// <code>ImageName</code>, <code>IdleDisconnectTimeoutInSeconds</code>, and <code>DisconnectTimeoutInSeconds</code>
        /// attributes. If the fleet is in the <code>STARTING</code> or <code>STOPPING</code>
        /// state, you can't update it.
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
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  UpdateImagePermissions

        /// <summary>
        /// Adds or updates permissions for the specified private image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        public virtual UpdateImagePermissionsResponse UpdateImagePermissions(UpdateImagePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateImagePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateImagePermissions(UpdateImagePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImagePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        public virtual UpdateImagePermissionsResponse EndUpdateImagePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateImagePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStack

        /// <summary>
        /// Updates the specified fields for the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
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
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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