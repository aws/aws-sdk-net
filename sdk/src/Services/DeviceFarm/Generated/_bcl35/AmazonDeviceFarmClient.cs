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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DeviceFarm.Model;
using Amazon.DeviceFarm.Model.Internal.MarshallTransformations;
using Amazon.DeviceFarm.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DeviceFarm
{
    /// <summary>
    /// <para>Implementation for accessing DeviceFarm</para>
    ///
    /// Welcome to the AWS Device Farm API documentation, which contains APIs for:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Testing on desktop browsers
    /// </para>
    ///  
    /// <para>
    ///  Device Farm makes it possible for you to test your web applications on desktop browsers
    /// using Selenium. The APIs for desktop browser testing contain <c>TestGrid</c> in their
    /// names. For more information, see <a href="https://docs.aws.amazon.com/devicefarm/latest/testgrid/">Testing
    /// Web Applications on Selenium with Device Farm</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Testing on real mobile devices
    /// </para>
    ///  
    /// <para>
    /// Device Farm makes it possible for you to test apps on physical phones, tablets, and
    /// other devices in the cloud. For more information, see the <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/">Device
    /// Farm Developer Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonDeviceFarmClient : AmazonServiceClient, IAmazonDeviceFarm
    {
        private static IServiceMetadata serviceMetadata = new AmazonDeviceFarmMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDeviceFarmPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDeviceFarmPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DeviceFarmPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
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
        public AmazonDeviceFarmClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeviceFarmConfig()) { }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
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
        public AmazonDeviceFarmClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeviceFarmConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(AmazonDeviceFarmConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials)
            : this(credentials, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDeviceFarmConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Credentials and an
        /// AmazonDeviceFarmClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(AWSCredentials credentials, AmazonDeviceFarmConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeviceFarmConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeviceFarmClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDeviceFarmConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeviceFarmConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeviceFarmConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeviceFarmClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeviceFarmClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDeviceFarmClient Configuration Object</param>
        public AmazonDeviceFarmClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDeviceFarmConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDeviceFarmEndpointResolver());
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


        #region  CreateDevicePool

        /// <summary>
        /// Creates a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool service method.</param>
        /// 
        /// <returns>The response from the CreateDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public virtual CreateDevicePoolResponse CreateDevicePool(CreateDevicePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<CreateDevicePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public virtual IAsyncResult BeginCreateDevicePool(CreateDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevicePool.</param>
        /// 
        /// <returns>Returns a  CreateDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateDevicePool">REST API Reference for CreateDevicePool Operation</seealso>
        public virtual CreateDevicePoolResponse EndCreateDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstanceProfile

        /// <summary>
        /// Creates a profile that can be applied to one or more private fleet device instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkProfile

        /// <summary>
        /// Creates a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public virtual CreateNetworkProfileResponse CreateNetworkProfile(CreateNetworkProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateNetworkProfile(CreateNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkProfile.</param>
        /// 
        /// <returns>Returns a  CreateNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public virtual CreateNetworkProfileResponse EndCreateNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a project.
        /// </summary>
        /// <param name="name">The project's name.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagOperationException">
        /// The operation was not successful. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(string name)
        {
            var request = new CreateProjectRequest();
            request.Name = name;
            return CreateProject(request);
        }


        /// <summary>
        /// Creates a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagOperationException">
        /// The operation was not successful. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRemoteAccessSession

        /// <summary>
        /// Specifies and starts a remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the CreateRemoteAccessSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public virtual CreateRemoteAccessSessionResponse CreateRemoteAccessSession(CreateRemoteAccessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<CreateRemoteAccessSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public virtual IAsyncResult BeginCreateRemoteAccessSession(CreateRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  CreateRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateRemoteAccessSession">REST API Reference for CreateRemoteAccessSession Operation</seealso>
        public virtual CreateRemoteAccessSessionResponse EndCreateRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTestGridProject

        /// <summary>
        /// Creates a Selenium testing project. Projects are used to track <a>TestGridSession</a>
        /// instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestGridProject service method.</param>
        /// 
        /// <returns>The response from the CreateTestGridProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridProject">REST API Reference for CreateTestGridProject Operation</seealso>
        public virtual CreateTestGridProjectResponse CreateTestGridProject(CreateTestGridProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestGridProjectResponseUnmarshaller.Instance;

            return Invoke<CreateTestGridProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTestGridProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTestGridProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridProject">REST API Reference for CreateTestGridProject Operation</seealso>
        public virtual IAsyncResult BeginCreateTestGridProject(CreateTestGridProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestGridProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTestGridProject.</param>
        /// 
        /// <returns>Returns a  CreateTestGridProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridProject">REST API Reference for CreateTestGridProject Operation</seealso>
        public virtual CreateTestGridProjectResponse EndCreateTestGridProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTestGridProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTestGridUrl

        /// <summary>
        /// Creates a signed, short-term URL that can be passed to a Selenium <c>RemoteWebDriver</c>
        /// constructor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestGridUrl service method.</param>
        /// 
        /// <returns>The response from the CreateTestGridUrl service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridUrl">REST API Reference for CreateTestGridUrl Operation</seealso>
        public virtual CreateTestGridUrlResponse CreateTestGridUrl(CreateTestGridUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestGridUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestGridUrlResponseUnmarshaller.Instance;

            return Invoke<CreateTestGridUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTestGridUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTestGridUrl operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTestGridUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridUrl">REST API Reference for CreateTestGridUrl Operation</seealso>
        public virtual IAsyncResult BeginCreateTestGridUrl(CreateTestGridUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestGridUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestGridUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTestGridUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTestGridUrl.</param>
        /// 
        /// <returns>Returns a  CreateTestGridUrlResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateTestGridUrl">REST API Reference for CreateTestGridUrl Operation</seealso>
        public virtual CreateTestGridUrlResponse EndCreateTestGridUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTestGridUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUpload

        /// <summary>
        /// Uploads an app or test scripts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload service method.</param>
        /// 
        /// <returns>The response from the CreateUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public virtual CreateUploadResponse CreateUpload(CreateUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return Invoke<CreateUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public virtual IAsyncResult BeginCreateUpload(CreateUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUpload.</param>
        /// 
        /// <returns>Returns a  CreateUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateUpload">REST API Reference for CreateUpload Operation</seealso>
        public virtual CreateUploadResponse EndCreateUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVPCEConfiguration

        /// <summary>
        /// Creates a configuration record in Device Farm for your Amazon Virtual Private Cloud
        /// (VPC) endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCEConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateVPCEConfiguration service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateVPCEConfiguration">REST API Reference for CreateVPCEConfiguration Operation</seealso>
        public virtual CreateVPCEConfigurationResponse CreateVPCEConfiguration(CreateVPCEConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateVPCEConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCEConfiguration operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVPCEConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateVPCEConfiguration">REST API Reference for CreateVPCEConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateVPCEConfiguration(CreateVPCEConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCEConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVPCEConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateVPCEConfigurationResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/CreateVPCEConfiguration">REST API Reference for CreateVPCEConfiguration Operation</seealso>
        public virtual CreateVPCEConfigurationResponse EndCreateVPCEConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVPCEConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDevicePool

        /// <summary>
        /// Deletes a device pool given the pool ARN. Does not allow deletion of curated pools
        /// owned by the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevicePool service method.</param>
        /// 
        /// <returns>The response from the DeleteDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public virtual DeleteDevicePoolResponse DeleteDevicePool(DeleteDevicePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDevicePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevicePool(DeleteDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevicePool.</param>
        /// 
        /// <returns>Returns a  DeleteDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteDevicePool">REST API Reference for DeleteDevicePool Operation</seealso>
        public virtual DeleteDevicePoolResponse EndDeleteDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        /// <summary>
        /// Deletes a profile that can be applied to one or more private device instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkProfile

        /// <summary>
        /// Deletes a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public virtual DeleteNetworkProfileResponse DeleteNetworkProfile(DeleteNetworkProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteNetworkProfile(DeleteNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkProfile.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public virtual DeleteNetworkProfileResponse EndDeleteNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes an AWS Device Farm project, given the project ARN. You cannot delete a project
        /// if it has an active run or session.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot undo this operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRemoteAccessSession

        /// <summary>
        /// Deletes a completed remote access session and its results. You cannot delete a remote
        /// access session if it is still active.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot undo this operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the DeleteRemoteAccessSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public virtual DeleteRemoteAccessSessionResponse DeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteRemoteAccessSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public virtual IAsyncResult BeginDeleteRemoteAccessSession(DeleteRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  DeleteRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRemoteAccessSession">REST API Reference for DeleteRemoteAccessSession Operation</seealso>
        public virtual DeleteRemoteAccessSessionResponse EndDeleteRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRun

        /// <summary>
        /// Deletes the run, given the run ARN. You cannot delete a run if it is still active.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot undo this operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTestGridProject

        /// <summary>
        /// Deletes a Selenium testing project and all content generated under it. You cannot
        /// delete a project if it has active sessions.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot undo this operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestGridProject service method.</param>
        /// 
        /// <returns>The response from the DeleteTestGridProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.CannotDeleteException">
        /// The requested object could not be deleted.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteTestGridProject">REST API Reference for DeleteTestGridProject Operation</seealso>
        public virtual DeleteTestGridProjectResponse DeleteTestGridProject(DeleteTestGridProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestGridProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteTestGridProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestGridProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTestGridProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteTestGridProject">REST API Reference for DeleteTestGridProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteTestGridProject(DeleteTestGridProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestGridProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTestGridProject.</param>
        /// 
        /// <returns>Returns a  DeleteTestGridProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteTestGridProject">REST API Reference for DeleteTestGridProject Operation</seealso>
        public virtual DeleteTestGridProjectResponse EndDeleteTestGridProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTestGridProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUpload

        /// <summary>
        /// Deletes an upload given the upload ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUpload service method.</param>
        /// 
        /// <returns>The response from the DeleteUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public virtual DeleteUploadResponse DeleteUpload(DeleteUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return Invoke<DeleteUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public virtual IAsyncResult BeginDeleteUpload(DeleteUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUpload.</param>
        /// 
        /// <returns>Returns a  DeleteUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteUpload">REST API Reference for DeleteUpload Operation</seealso>
        public virtual DeleteUploadResponse EndDeleteUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVPCEConfiguration

        /// <summary>
        /// Deletes a configuration for your Amazon Virtual Private Cloud (VPC) endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCEConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteVPCEConfiguration service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InvalidOperationException">
        /// There was an error with the update request, or you do not have sufficient permissions
        /// to update this VPC endpoint configuration.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteVPCEConfiguration">REST API Reference for DeleteVPCEConfiguration Operation</seealso>
        public virtual DeleteVPCEConfigurationResponse DeleteVPCEConfiguration(DeleteVPCEConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVPCEConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCEConfiguration operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVPCEConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteVPCEConfiguration">REST API Reference for DeleteVPCEConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteVPCEConfiguration(DeleteVPCEConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCEConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVPCEConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVPCEConfigurationResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/DeleteVPCEConfiguration">REST API Reference for DeleteVPCEConfiguration Operation</seealso>
        public virtual DeleteVPCEConfigurationResponse EndDeleteVPCEConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVPCEConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Returns the number of unmetered iOS or unmetered Android devices that have been purchased
        /// by the account.
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings()
        {
            return GetAccountSettings(new GetAccountSettingsRequest());
        }

        /// <summary>
        /// Returns the number of unmetered iOS or unmetered Android devices that have been purchased
        /// by the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevice

        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="arn">The device type's ARN.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse GetDevice(string arn)
        {
            var request = new GetDeviceRequest();
            request.Arn = arn;
            return GetDevice(request);
        }


        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse EndGetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeviceInstance

        /// <summary>
        /// Returns information about a device instance that belongs to a private device fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeviceInstance service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDeviceInstance">REST API Reference for GetDeviceInstance Operation</seealso>
        public virtual GetDeviceInstanceResponse GetDeviceInstance(GetDeviceInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceInstance operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDeviceInstance">REST API Reference for GetDeviceInstance Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceInstance(GetDeviceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceInstance.</param>
        /// 
        /// <returns>Returns a  GetDeviceInstanceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDeviceInstance">REST API Reference for GetDeviceInstance Operation</seealso>
        public virtual GetDeviceInstanceResponse EndGetDeviceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePool

        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="arn">The device pool's ARN.</param>
        /// 
        /// <returns>The response from the GetDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public virtual GetDevicePoolResponse GetDevicePool(string arn)
        {
            var request = new GetDevicePoolRequest();
            request.Arn = arn;
            return GetDevicePool(request);
        }


        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool service method.</param>
        /// 
        /// <returns>The response from the GetDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public virtual GetDevicePoolResponse GetDevicePool(GetDevicePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public virtual IAsyncResult BeginGetDevicePool(GetDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePool.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePool">REST API Reference for GetDevicePool Operation</seealso>
        public virtual GetDevicePoolResponse EndGetDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePoolCompatibility

        /// <summary>
        /// Gets information about compatibility with a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility service method.</param>
        /// 
        /// <returns>The response from the GetDevicePoolCompatibility service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public virtual GetDevicePoolCompatibilityResponse GetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevicePoolCompatibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return Invoke<GetDevicePoolCompatibilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePoolCompatibility
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public virtual IAsyncResult BeginGetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevicePoolCompatibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePoolCompatibilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePoolCompatibility.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolCompatibilityResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetDevicePoolCompatibility">REST API Reference for GetDevicePoolCompatibility Operation</seealso>
        public virtual GetDevicePoolCompatibilityResponse EndGetDevicePoolCompatibility(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePoolCompatibilityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceProfile

        /// <summary>
        /// Returns information about the specified instance profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a  GetInstanceProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJob

        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="arn">The job's ARN.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(string arn)
        {
            var request = new GetJobRequest();
            request.Arn = arn;
            return GetJob(request);
        }


        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  GetJobResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkProfile

        /// <summary>
        /// Returns information about a network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the GetNetworkProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public virtual GetNetworkProfileResponse GetNetworkProfile(GetNetworkProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<GetNetworkProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkProfile(GetNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkProfile.</param>
        /// 
        /// <returns>Returns a  GetNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public virtual GetNetworkProfileResponse EndGetNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOfferingStatus

        /// <summary>
        /// Gets the current status and future status of all offerings purchased by an AWS account.
        /// The response indicates how many offerings are currently available and the offerings
        /// that will be available in the next period. The API returns a <c>NotEligible</c> error
        /// if the user is not permitted to invoke the operation. If you must be able to invoke
        /// this operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferingStatus service method.</param>
        /// 
        /// <returns>The response from the GetOfferingStatus service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public virtual GetOfferingStatusResponse GetOfferingStatus(GetOfferingStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOfferingStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOfferingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOfferingStatus operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOfferingStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public virtual IAsyncResult BeginGetOfferingStatus(GetOfferingStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferingStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOfferingStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOfferingStatus.</param>
        /// 
        /// <returns>Returns a  GetOfferingStatusResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetOfferingStatus">REST API Reference for GetOfferingStatus Operation</seealso>
        public virtual GetOfferingStatusResponse EndGetOfferingStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOfferingStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProject

        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="arn">The project's ARN.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse GetProject(string arn)
        {
            var request = new GetProjectRequest();
            request.Arn = arn;
            return GetProject(request);
        }


        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse EndGetProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRemoteAccessSession

        /// <summary>
        /// Returns a link to a currently running remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the GetRemoteAccessSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public virtual GetRemoteAccessSessionResponse GetRemoteAccessSession(GetRemoteAccessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<GetRemoteAccessSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public virtual IAsyncResult BeginGetRemoteAccessSession(GetRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  GetRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRemoteAccessSession">REST API Reference for GetRemoteAccessSession Operation</seealso>
        public virtual GetRemoteAccessSessionResponse EndGetRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRun

        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="arn">The run's ARN.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual GetRunResponse GetRun(string arn)
        {
            var request = new GetRunRequest();
            request.Arn = arn;
            return GetRun(request);
        }


        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual GetRunResponse GetRun(GetRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual IAsyncResult BeginGetRun(GetRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRun.</param>
        /// 
        /// <returns>Returns a  GetRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual GetRunResponse EndGetRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSuite

        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="arn">The suite's ARN.</param>
        /// 
        /// <returns>The response from the GetSuite service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public virtual GetSuiteResponse GetSuite(string arn)
        {
            var request = new GetSuiteRequest();
            request.Arn = arn;
            return GetSuite(request);
        }


        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuite service method.</param>
        /// 
        /// <returns>The response from the GetSuite service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public virtual GetSuiteResponse GetSuite(GetSuiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return Invoke<GetSuiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuite operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public virtual IAsyncResult BeginGetSuite(GetSuiteRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuite.</param>
        /// 
        /// <returns>Returns a  GetSuiteResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetSuite">REST API Reference for GetSuite Operation</seealso>
        public virtual GetSuiteResponse EndGetSuite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSuiteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTest

        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="arn">The test's ARN.</param>
        /// 
        /// <returns>The response from the GetTest service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public virtual GetTestResponse GetTest(string arn)
        {
            var request = new GetTestRequest();
            request.Arn = arn;
            return GetTest(request);
        }


        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTest service method.</param>
        /// 
        /// <returns>The response from the GetTest service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public virtual GetTestResponse GetTest(GetTestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestResponseUnmarshaller.Instance;

            return Invoke<GetTestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTest operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public virtual IAsyncResult BeginGetTest(GetTestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTest.</param>
        /// 
        /// <returns>Returns a  GetTestResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTest">REST API Reference for GetTest Operation</seealso>
        public virtual GetTestResponse EndGetTest(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTestResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTestGridProject

        /// <summary>
        /// Retrieves information about a Selenium testing project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestGridProject service method.</param>
        /// 
        /// <returns>The response from the GetTestGridProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridProject">REST API Reference for GetTestGridProject Operation</seealso>
        public virtual GetTestGridProjectResponse GetTestGridProject(GetTestGridProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestGridProjectResponseUnmarshaller.Instance;

            return Invoke<GetTestGridProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestGridProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestGridProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridProject">REST API Reference for GetTestGridProject Operation</seealso>
        public virtual IAsyncResult BeginGetTestGridProject(GetTestGridProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestGridProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestGridProject.</param>
        /// 
        /// <returns>Returns a  GetTestGridProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridProject">REST API Reference for GetTestGridProject Operation</seealso>
        public virtual GetTestGridProjectResponse EndGetTestGridProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTestGridProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTestGridSession

        /// <summary>
        /// A session is an instance of a browser created through a <c>RemoteWebDriver</c> with
        /// the URL from <a>CreateTestGridUrlResult$url</a>. You can use the following to look
        /// up sessions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The session ARN (<a>GetTestGridSessionRequest$sessionArn</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The project ARN and a session ID (<a>GetTestGridSessionRequest$projectArn</a> and
        /// <a>GetTestGridSessionRequest$sessionId</a>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestGridSession service method.</param>
        /// 
        /// <returns>The response from the GetTestGridSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridSession">REST API Reference for GetTestGridSession Operation</seealso>
        public virtual GetTestGridSessionResponse GetTestGridSession(GetTestGridSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestGridSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestGridSessionResponseUnmarshaller.Instance;

            return Invoke<GetTestGridSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestGridSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestGridSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestGridSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridSession">REST API Reference for GetTestGridSession Operation</seealso>
        public virtual IAsyncResult BeginGetTestGridSession(GetTestGridSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestGridSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestGridSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestGridSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestGridSession.</param>
        /// 
        /// <returns>Returns a  GetTestGridSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetTestGridSession">REST API Reference for GetTestGridSession Operation</seealso>
        public virtual GetTestGridSessionResponse EndGetTestGridSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTestGridSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpload

        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="arn">The upload's ARN.</param>
        /// 
        /// <returns>The response from the GetUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public virtual GetUploadResponse GetUpload(string arn)
        {
            var request = new GetUploadRequest();
            request.Arn = arn;
            return GetUpload(request);
        }


        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpload service method.</param>
        /// 
        /// <returns>The response from the GetUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public virtual GetUploadResponse GetUpload(GetUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadResponseUnmarshaller.Instance;

            return Invoke<GetUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public virtual IAsyncResult BeginGetUpload(GetUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpload.</param>
        /// 
        /// <returns>Returns a  GetUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetUpload">REST API Reference for GetUpload Operation</seealso>
        public virtual GetUploadResponse EndGetUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVPCEConfiguration

        /// <summary>
        /// Returns information about the configuration settings for your Amazon Virtual Private
        /// Cloud (VPC) endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVPCEConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVPCEConfiguration service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetVPCEConfiguration">REST API Reference for GetVPCEConfiguration Operation</seealso>
        public virtual GetVPCEConfigurationResponse GetVPCEConfiguration(GetVPCEConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVPCEConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVPCEConfiguration operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVPCEConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetVPCEConfiguration">REST API Reference for GetVPCEConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVPCEConfiguration(GetVPCEConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVPCEConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVPCEConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVPCEConfigurationResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/GetVPCEConfiguration">REST API Reference for GetVPCEConfiguration Operation</seealso>
        public virtual GetVPCEConfigurationResponse EndGetVPCEConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVPCEConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  InstallToRemoteAccessSession

        /// <summary>
        /// Installs an application to the device in a remote access session. For Android applications,
        /// the file must be in .apk format. For iOS applications, the file must be in .ipa format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InstallToRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the InstallToRemoteAccessSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public virtual InstallToRemoteAccessSessionResponse InstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InstallToRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<InstallToRemoteAccessSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InstallToRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InstallToRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInstallToRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public virtual IAsyncResult BeginInstallToRemoteAccessSession(InstallToRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InstallToRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstallToRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InstallToRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInstallToRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  InstallToRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/InstallToRemoteAccessSession">REST API Reference for InstallToRemoteAccessSession Operation</seealso>
        public virtual InstallToRemoteAccessSessionResponse EndInstallToRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<InstallToRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListArtifacts

        /// <summary>
        /// Gets information about artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual IAsyncResult BeginListArtifacts(ListArtifactsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArtifacts.</param>
        /// 
        /// <returns>Returns a  ListArtifactsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual ListArtifactsResponse EndListArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArtifactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeviceInstances

        /// <summary>
        /// Returns information about the private device instances associated with one or more
        /// AWS accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceInstances service method.</param>
        /// 
        /// <returns>The response from the ListDeviceInstances service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDeviceInstances">REST API Reference for ListDeviceInstances Operation</seealso>
        public virtual ListDeviceInstancesResponse ListDeviceInstances(ListDeviceInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceInstances operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDeviceInstances">REST API Reference for ListDeviceInstances Operation</seealso>
        public virtual IAsyncResult BeginListDeviceInstances(ListDeviceInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceInstances.</param>
        /// 
        /// <returns>Returns a  ListDeviceInstancesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDeviceInstances">REST API Reference for ListDeviceInstances Operation</seealso>
        public virtual ListDeviceInstancesResponse EndListDeviceInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicePools

        /// <summary>
        /// Gets information about device pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools service method.</param>
        /// 
        /// <returns>The response from the ListDevicePools service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public virtual ListDevicePoolsResponse ListDevicePools(ListDevicePoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return Invoke<ListDevicePoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicePools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public virtual IAsyncResult BeginListDevicePools(ListDevicePoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicePools.</param>
        /// 
        /// <returns>Returns a  ListDevicePoolsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevicePools">REST API Reference for ListDevicePools Operation</seealso>
        public virtual ListDevicePoolsResponse EndListDevicePools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicePoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Gets information about unique device types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceProfiles

        /// <summary>
        /// Returns information about all the instance profiles in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// Gets information about jobs for a given test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListJobsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworkProfiles

        /// <summary>
        /// Returns the list of available network profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkProfiles service method.</param>
        /// 
        /// <returns>The response from the ListNetworkProfiles service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public virtual ListNetworkProfilesResponse ListNetworkProfiles(ListNetworkProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkProfiles operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public virtual IAsyncResult BeginListNetworkProfiles(ListNetworkProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkProfiles.</param>
        /// 
        /// <returns>Returns a  ListNetworkProfilesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListNetworkProfiles">REST API Reference for ListNetworkProfiles Operation</seealso>
        public virtual ListNetworkProfilesResponse EndListNetworkProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworkProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferingPromotions

        /// <summary>
        /// Returns a list of offering promotions. Each offering promotion record contains the
        /// ID and description of the promotion. The API returns a <c>NotEligible</c> error if
        /// the caller is not permitted to invoke the operation. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you must be able to invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingPromotions service method.</param>
        /// 
        /// <returns>The response from the ListOfferingPromotions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public virtual ListOfferingPromotionsResponse ListOfferingPromotions(ListOfferingPromotionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingPromotionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingPromotionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingPromotions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingPromotions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferingPromotions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public virtual IAsyncResult BeginListOfferingPromotions(ListOfferingPromotionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingPromotionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingPromotionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferingPromotions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferingPromotions.</param>
        /// 
        /// <returns>Returns a  ListOfferingPromotionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingPromotions">REST API Reference for ListOfferingPromotions Operation</seealso>
        public virtual ListOfferingPromotionsResponse EndListOfferingPromotions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingPromotionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferings

        /// <summary>
        /// Returns a list of products or offerings that the user can manage through the API.
        /// Each offering record indicates the recurring price per unit and the frequency for
        /// that offering. The API returns a <c>NotEligible</c> error if the user is not permitted
        /// to invoke the operation. If you must be able to invoke this operation, contact <a
        /// href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual IAsyncResult BeginListOfferings(ListOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferings.</param>
        /// 
        /// <returns>Returns a  ListOfferingsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse EndListOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferingTransactions

        /// <summary>
        /// Returns a list of all historical purchases, renewals, and system renewal transactions
        /// for an AWS account. The list is paginated and ordered by a descending timestamp (most
        /// recent transactions are first). The API returns a <c>NotEligible</c> error if the
        /// user is not permitted to invoke the operation. If you must be able to invoke this
        /// operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingTransactions service method.</param>
        /// 
        /// <returns>The response from the ListOfferingTransactions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public virtual ListOfferingTransactionsResponse ListOfferingTransactions(ListOfferingTransactionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingTransactionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferingTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferingTransactions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferingTransactions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public virtual IAsyncResult BeginListOfferingTransactions(ListOfferingTransactionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingTransactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingTransactionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferingTransactions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferingTransactions.</param>
        /// 
        /// <returns>Returns a  ListOfferingTransactionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListOfferingTransactions">REST API Reference for ListOfferingTransactions Operation</seealso>
        public virtual ListOfferingTransactionsResponse EndListOfferingTransactions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingTransactionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Gets information about projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRemoteAccessSessions

        /// <summary>
        /// Returns a list of all currently running remote access sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRemoteAccessSessions service method.</param>
        /// 
        /// <returns>The response from the ListRemoteAccessSessions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public virtual ListRemoteAccessSessionsResponse ListRemoteAccessSessions(ListRemoteAccessSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRemoteAccessSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return Invoke<ListRemoteAccessSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRemoteAccessSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRemoteAccessSessions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRemoteAccessSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public virtual IAsyncResult BeginListRemoteAccessSessions(ListRemoteAccessSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRemoteAccessSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRemoteAccessSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRemoteAccessSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRemoteAccessSessions.</param>
        /// 
        /// <returns>Returns a  ListRemoteAccessSessionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRemoteAccessSessions">REST API Reference for ListRemoteAccessSessions Operation</seealso>
        public virtual ListRemoteAccessSessionsResponse EndListRemoteAccessSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRemoteAccessSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuns

        /// <summary>
        /// Gets information about runs, given an AWS Device Farm project ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual ListRunsResponse EndListRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSamples

        /// <summary>
        /// Gets information about samples, given an AWS Device Farm job ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSamples service method.</param>
        /// 
        /// <returns>The response from the ListSamples service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public virtual ListSamplesResponse ListSamples(ListSamplesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSamplesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return Invoke<ListSamplesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSamples operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSamples operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSamples
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public virtual IAsyncResult BeginListSamples(ListSamplesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSamplesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSamplesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSamples operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSamples.</param>
        /// 
        /// <returns>Returns a  ListSamplesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSamples">REST API Reference for ListSamples Operation</seealso>
        public virtual ListSamplesResponse EndListSamples(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSamplesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSuites

        /// <summary>
        /// Gets information about test suites for a given job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuites service method.</param>
        /// 
        /// <returns>The response from the ListSuites service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public virtual ListSuitesResponse ListSuites(ListSuitesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return Invoke<ListSuitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuites operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public virtual IAsyncResult BeginListSuites(ListSuitesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuites.</param>
        /// 
        /// <returns>Returns a  ListSuitesResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListSuites">REST API Reference for ListSuites Operation</seealso>
        public virtual ListSuitesResponse EndListSuites(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSuitesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for an AWS Device Farm resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagOperationException">
        /// The operation was not successful. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTestGridProjects

        /// <summary>
        /// Gets a list of all Selenium testing projects in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridProjects service method.</param>
        /// 
        /// <returns>The response from the ListTestGridProjects service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridProjects">REST API Reference for ListTestGridProjects Operation</seealso>
        public virtual ListTestGridProjectsResponse ListTestGridProjects(ListTestGridProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridProjectsResponseUnmarshaller.Instance;

            return Invoke<ListTestGridProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestGridProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridProjects operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestGridProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridProjects">REST API Reference for ListTestGridProjects Operation</seealso>
        public virtual IAsyncResult BeginListTestGridProjects(ListTestGridProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestGridProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestGridProjects.</param>
        /// 
        /// <returns>Returns a  ListTestGridProjectsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridProjects">REST API Reference for ListTestGridProjects Operation</seealso>
        public virtual ListTestGridProjectsResponse EndListTestGridProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestGridProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTestGridSessionActions

        /// <summary>
        /// Returns a list of the actions taken in a <a>TestGridSession</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessionActions service method.</param>
        /// 
        /// <returns>The response from the ListTestGridSessionActions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionActions">REST API Reference for ListTestGridSessionActions Operation</seealso>
        public virtual ListTestGridSessionActionsResponse ListTestGridSessionActions(ListTestGridSessionActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionActionsResponseUnmarshaller.Instance;

            return Invoke<ListTestGridSessionActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestGridSessionActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessionActions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestGridSessionActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionActions">REST API Reference for ListTestGridSessionActions Operation</seealso>
        public virtual IAsyncResult BeginListTestGridSessionActions(ListTestGridSessionActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestGridSessionActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestGridSessionActions.</param>
        /// 
        /// <returns>Returns a  ListTestGridSessionActionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionActions">REST API Reference for ListTestGridSessionActions Operation</seealso>
        public virtual ListTestGridSessionActionsResponse EndListTestGridSessionActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestGridSessionActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTestGridSessionArtifacts

        /// <summary>
        /// Retrieves a list of artifacts created during the session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessionArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListTestGridSessionArtifacts service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionArtifacts">REST API Reference for ListTestGridSessionArtifacts Operation</seealso>
        public virtual ListTestGridSessionArtifactsResponse ListTestGridSessionArtifacts(ListTestGridSessionArtifactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListTestGridSessionArtifactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestGridSessionArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessionArtifacts operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestGridSessionArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionArtifacts">REST API Reference for ListTestGridSessionArtifacts Operation</seealso>
        public virtual IAsyncResult BeginListTestGridSessionArtifacts(ListTestGridSessionArtifactsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionArtifactsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestGridSessionArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestGridSessionArtifacts.</param>
        /// 
        /// <returns>Returns a  ListTestGridSessionArtifactsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessionArtifacts">REST API Reference for ListTestGridSessionArtifacts Operation</seealso>
        public virtual ListTestGridSessionArtifactsResponse EndListTestGridSessionArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestGridSessionArtifactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTestGridSessions

        /// <summary>
        /// Retrieves a list of sessions for a <a>TestGridProject</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessions service method.</param>
        /// 
        /// <returns>The response from the ListTestGridSessions service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessions">REST API Reference for ListTestGridSessions Operation</seealso>
        public virtual ListTestGridSessionsResponse ListTestGridSessions(ListTestGridSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionsResponseUnmarshaller.Instance;

            return Invoke<ListTestGridSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestGridSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestGridSessions operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestGridSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessions">REST API Reference for ListTestGridSessions Operation</seealso>
        public virtual IAsyncResult BeginListTestGridSessions(ListTestGridSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestGridSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestGridSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestGridSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestGridSessions.</param>
        /// 
        /// <returns>Returns a  ListTestGridSessionsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTestGridSessions">REST API Reference for ListTestGridSessions Operation</seealso>
        public virtual ListTestGridSessionsResponse EndListTestGridSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestGridSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTests

        /// <summary>
        /// Gets information about tests in a given test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTests service method.</param>
        /// 
        /// <returns>The response from the ListTests service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public virtual ListTestsResponse ListTests(ListTestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestsResponseUnmarshaller.Instance;

            return Invoke<ListTestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTests operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public virtual IAsyncResult BeginListTests(ListTestsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTests.</param>
        /// 
        /// <returns>Returns a  ListTestsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListTests">REST API Reference for ListTests Operation</seealso>
        public virtual ListTestsResponse EndListTests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUniqueProblems

        /// <summary>
        /// Gets information about unique problems, such as exceptions or crashes.
        /// 
        ///  
        /// <para>
        /// Unique problems are defined as a single instance of an error across a run, job, or
        /// suite. For example, if a call in your application consistently raises an exception
        /// (<c>OutOfBoundsException in MyActivity.java:386</c>), <c>ListUniqueProblems</c> returns
        /// a single entry instead of many individual entries for that exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems service method.</param>
        /// 
        /// <returns>The response from the ListUniqueProblems service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public virtual ListUniqueProblemsResponse ListUniqueProblems(ListUniqueProblemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUniqueProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return Invoke<ListUniqueProblemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUniqueProblems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public virtual IAsyncResult BeginListUniqueProblems(ListUniqueProblemsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUniqueProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUniqueProblemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUniqueProblems.</param>
        /// 
        /// <returns>Returns a  ListUniqueProblemsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUniqueProblems">REST API Reference for ListUniqueProblems Operation</seealso>
        public virtual ListUniqueProblemsResponse EndListUniqueProblems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUniqueProblemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUploads

        /// <summary>
        /// Gets information about uploads, given an AWS Device Farm project ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploads service method.</param>
        /// 
        /// <returns>The response from the ListUploads service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public virtual ListUploadsResponse ListUploads(ListUploadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return Invoke<ListUploadsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploads operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUploads
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public virtual IAsyncResult BeginListUploads(ListUploadsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUploads.</param>
        /// 
        /// <returns>Returns a  ListUploadsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListUploads">REST API Reference for ListUploads Operation</seealso>
        public virtual ListUploadsResponse EndListUploads(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUploadsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVPCEConfigurations

        /// <summary>
        /// Returns information about all Amazon Virtual Private Cloud (VPC) endpoint configurations
        /// in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCEConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListVPCEConfigurations service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListVPCEConfigurations">REST API Reference for ListVPCEConfigurations Operation</seealso>
        public virtual ListVPCEConfigurationsResponse ListVPCEConfigurations(ListVPCEConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVPCEConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCEConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListVPCEConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVPCEConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVPCEConfigurations operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVPCEConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListVPCEConfigurations">REST API Reference for ListVPCEConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListVPCEConfigurations(ListVPCEConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVPCEConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCEConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVPCEConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVPCEConfigurations.</param>
        /// 
        /// <returns>Returns a  ListVPCEConfigurationsResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ListVPCEConfigurations">REST API Reference for ListVPCEConfigurations Operation</seealso>
        public virtual ListVPCEConfigurationsResponse EndListVPCEConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVPCEConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseOffering

        /// <summary>
        /// Immediately purchases offerings for an AWS account. Offerings renew with the latest
        /// total purchased quantity for an offering, unless the renewal was overridden. The API
        /// returns a <c>NotEligible</c> error if the user is not permitted to invoke the operation.
        /// If you must be able to invoke this operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseOffering(PurchaseOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseOfferingResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse EndPurchaseOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RenewOffering

        /// <summary>
        /// Explicitly sets the quantity of devices to renew for an offering, starting from the
        /// <c>effectiveDate</c> of the next period. The API returns a <c>NotEligible</c> error
        /// if the user is not permitted to invoke the operation. If you must be able to invoke
        /// this operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewOffering service method.</param>
        /// 
        /// <returns>The response from the RenewOffering service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotEligibleException">
        /// Exception gets thrown when a user is not eligible to perform the specified transaction.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public virtual RenewOfferingResponse RenewOffering(RenewOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenewOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return Invoke<RenewOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenewOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewOffering operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenewOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public virtual IAsyncResult BeginRenewOffering(RenewOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenewOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenewOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenewOffering.</param>
        /// 
        /// <returns>Returns a  RenewOfferingResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/RenewOffering">REST API Reference for RenewOffering Operation</seealso>
        public virtual RenewOfferingResponse EndRenewOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<RenewOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  ScheduleRun

        /// <summary>
        /// Schedules a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun service method.</param>
        /// 
        /// <returns>The response from the ScheduleRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public virtual ScheduleRunResponse ScheduleRun(ScheduleRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScheduleRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return Invoke<ScheduleRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScheduleRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public virtual IAsyncResult BeginScheduleRun(ScheduleRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScheduleRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScheduleRun.</param>
        /// 
        /// <returns>Returns a  ScheduleRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/ScheduleRun">REST API Reference for ScheduleRun Operation</seealso>
        public virtual ScheduleRunResponse EndScheduleRun(IAsyncResult asyncResult)
        {
            return EndInvoke<ScheduleRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopJob

        /// <summary>
        /// Initiates a stop request for the current job. AWS Device Farm immediately stops the
        /// job on the device where tests have not started. You are not billed for this device.
        /// On the device where tests have started, setup suite and teardown suite tests run to
        /// completion on the device. You are billed for setup, teardown, and any tests that were
        /// in progress or already completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual StopJobResponse StopJob(StopJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return Invoke<StopJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopJob operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual IAsyncResult BeginStopJob(StopJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  StopJobResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual StopJobResponse EndStopJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRemoteAccessSession

        /// <summary>
        /// Ends a specified remote access session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRemoteAccessSession service method.</param>
        /// 
        /// <returns>The response from the StopRemoteAccessSession service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public virtual StopRemoteAccessSessionResponse StopRemoteAccessSession(StopRemoteAccessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return Invoke<StopRemoteAccessSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRemoteAccessSession operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRemoteAccessSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public virtual IAsyncResult BeginStopRemoteAccessSession(StopRemoteAccessSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRemoteAccessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRemoteAccessSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRemoteAccessSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRemoteAccessSession.</param>
        /// 
        /// <returns>Returns a  StopRemoteAccessSessionResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRemoteAccessSession">REST API Reference for StopRemoteAccessSession Operation</seealso>
        public virtual StopRemoteAccessSessionResponse EndStopRemoteAccessSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRemoteAccessSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRun

        /// <summary>
        /// Initiates a stop request for the current test run. AWS Device Farm immediately stops
        /// the run on devices where tests have not started. You are not billed for these devices.
        /// On devices where tests have started executing, setup suite and teardown suite tests
        /// run to completion on those devices. You are billed for setup, teardown, and any tests
        /// that were in progress or already completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRun service method.</param>
        /// 
        /// <returns>The response from the StopRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public virtual StopRunResponse StopRun(StopRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRunResponseUnmarshaller.Instance;

            return Invoke<StopRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public virtual IAsyncResult BeginStopRun(StopRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRun.</param>
        /// 
        /// <returns>Returns a  StopRunResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/StopRun">REST API Reference for StopRun Operation</seealso>
        public virtual StopRunResponse EndStopRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRunResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagOperationException">
        /// The operation was not successful. Try again.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagPolicyException">
        /// The request doesn't comply with the AWS Identity and Access Management (IAM) tag policy.
        /// Correct your request and then retry it.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.TagOperationException">
        /// The operation was not successful. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeviceInstance

        /// <summary>
        /// Updates information about a private device instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceInstance service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDeviceInstance">REST API Reference for UpdateDeviceInstance Operation</seealso>
        public virtual UpdateDeviceInstanceResponse UpdateDeviceInstance(UpdateDeviceInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceInstance operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDeviceInstance">REST API Reference for UpdateDeviceInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateDeviceInstance(UpdateDeviceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeviceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceInstance.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceInstanceResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDeviceInstance">REST API Reference for UpdateDeviceInstance Operation</seealso>
        public virtual UpdateDeviceInstanceResponse EndUpdateDeviceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevicePool

        /// <summary>
        /// Modifies the name, description, and rules in a device pool given the attributes and
        /// the pool ARN. Rule updates are all-or-nothing, meaning they can only be updated as
        /// a whole (or not at all).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePool service method.</param>
        /// 
        /// <returns>The response from the UpdateDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public virtual UpdateDevicePoolResponse UpdateDevicePool(UpdateDevicePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevicePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevicePool(UpdateDevicePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDevicePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevicePool.</param>
        /// 
        /// <returns>Returns a  UpdateDevicePoolResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateDevicePool">REST API Reference for UpdateDevicePool Operation</seealso>
        public virtual UpdateDevicePoolResponse EndUpdateDevicePool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevicePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstanceProfile

        /// <summary>
        /// Updates information about an existing private device instance profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateInstanceProfile">REST API Reference for UpdateInstanceProfile Operation</seealso>
        public virtual UpdateInstanceProfileResponse UpdateInstanceProfile(UpdateInstanceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateInstanceProfile">REST API Reference for UpdateInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstanceProfile(UpdateInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateInstanceProfile">REST API Reference for UpdateInstanceProfile Operation</seealso>
        public virtual UpdateInstanceProfileResponse EndUpdateInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkProfile

        /// <summary>
        /// Updates the network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkProfile service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public virtual UpdateNetworkProfileResponse UpdateNetworkProfile(UpdateNetworkProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetworkProfile(UpdateNetworkProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkProfile.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkProfileResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public virtual UpdateNetworkProfileResponse EndUpdateNetworkProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProject

        /// <summary>
        /// Modifies the specified project name, given the project ARN and a new name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTestGridProject

        /// <summary>
        /// Change details of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestGridProject service method.</param>
        /// 
        /// <returns>The response from the UpdateTestGridProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InternalServiceException">
        /// An internal exception was raised in the service. Contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>
        /// if you see this error.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateTestGridProject">REST API Reference for UpdateTestGridProject Operation</seealso>
        public virtual UpdateTestGridProjectResponse UpdateTestGridProject(UpdateTestGridProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestGridProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateTestGridProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestGridProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTestGridProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateTestGridProject">REST API Reference for UpdateTestGridProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateTestGridProject(UpdateTestGridProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestGridProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestGridProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTestGridProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTestGridProject.</param>
        /// 
        /// <returns>Returns a  UpdateTestGridProjectResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateTestGridProject">REST API Reference for UpdateTestGridProject Operation</seealso>
        public virtual UpdateTestGridProjectResponse EndUpdateTestGridProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTestGridProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUpload

        /// <summary>
        /// Updates an uploaded test spec.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUpload service method.</param>
        /// 
        /// <returns>The response from the UpdateUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateUpload">REST API Reference for UpdateUpload Operation</seealso>
        public virtual UpdateUploadResponse UpdateUpload(UpdateUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUploadResponseUnmarshaller.Instance;

            return Invoke<UpdateUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateUpload">REST API Reference for UpdateUpload Operation</seealso>
        public virtual IAsyncResult BeginUpdateUpload(UpdateUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUpload.</param>
        /// 
        /// <returns>Returns a  UpdateUploadResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateUpload">REST API Reference for UpdateUpload Operation</seealso>
        public virtual UpdateUploadResponse EndUpdateUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVPCEConfiguration

        /// <summary>
        /// Updates information about an Amazon Virtual Private Cloud (VPC) endpoint configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCEConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateVPCEConfiguration service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.InvalidOperationException">
        /// There was an error with the update request, or you do not have sufficient permissions
        /// to update this VPC endpoint configuration.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateVPCEConfiguration">REST API Reference for UpdateVPCEConfiguration Operation</seealso>
        public virtual UpdateVPCEConfigurationResponse UpdateVPCEConfiguration(UpdateVPCEConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCEConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateVPCEConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCEConfiguration operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVPCEConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateVPCEConfiguration">REST API Reference for UpdateVPCEConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateVPCEConfiguration(UpdateVPCEConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVPCEConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCEConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVPCEConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVPCEConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateVPCEConfigurationResult from DeviceFarm.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devicefarm-2015-06-23/UpdateVPCEConfiguration">REST API Reference for UpdateVPCEConfiguration Operation</seealso>
        public virtual UpdateVPCEConfigurationResponse EndUpdateVPCEConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVPCEConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonDeviceFarmEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}