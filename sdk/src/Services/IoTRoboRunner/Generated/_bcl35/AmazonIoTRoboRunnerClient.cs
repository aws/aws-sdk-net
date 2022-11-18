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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTRoboRunner.Model;
using Amazon.IoTRoboRunner.Model.Internal.MarshallTransformations;
using Amazon.IoTRoboRunner.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTRoboRunner
{
    /// <summary>
    /// Implementation for accessing IoTRoboRunner
    ///
    /// An example service, deployed with the Octane Service creator, which will echo the
    /// string
    /// </summary>
    public partial class AmazonIoTRoboRunnerClient : AmazonServiceClient, IAmazonIoTRoboRunner
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTRoboRunnerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTRoboRunnerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTRoboRunnerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTRoboRunnerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with the credentials loaded from the application's
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
        public AmazonIoTRoboRunnerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTRoboRunnerConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with the credentials loaded from the application's
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
        public AmazonIoTRoboRunnerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTRoboRunnerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTRoboRunnerClient Configuration Object</param>
        public AmazonIoTRoboRunnerClient(AmazonIoTRoboRunnerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTRoboRunnerClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTRoboRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTRoboRunnerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTRoboRunnerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Credentials and an
        /// AmazonIoTRoboRunnerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTRoboRunnerClient Configuration Object</param>
        public AmazonIoTRoboRunnerClient(AWSCredentials credentials, AmazonIoTRoboRunnerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTRoboRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTRoboRunnerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTRoboRunnerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTRoboRunnerClient Configuration Object</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTRoboRunnerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTRoboRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTRoboRunnerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTRoboRunnerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTRoboRunnerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTRoboRunnerClient Configuration Object</param>
        public AmazonIoTRoboRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTRoboRunnerConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTRoboRunnerEndpointResolver());
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


        #region  CreateDestination

        /// <summary>
        /// Grants permission to create a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSite

        /// <summary>
        /// Grants permission to create a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual CreateSiteResponse CreateSite(CreateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return Invoke<CreateSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual IAsyncResult BeginCreateSite(CreateSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSite.</param>
        /// 
        /// <returns>Returns a  CreateSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual CreateSiteResponse EndCreateSite(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorker

        /// <summary>
        /// Grants permission to create a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// 
        /// <returns>The response from the CreateWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual CreateWorkerResponse CreateWorker(CreateWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual IAsyncResult BeginCreateWorker(CreateWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorker.</param>
        /// 
        /// <returns>Returns a  CreateWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual CreateWorkerResponse EndCreateWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkerFleet

        /// <summary>
        /// Grants permission to create a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        public virtual CreateWorkerFleetResponse CreateWorkerFleet(CreateWorkerFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerFleetResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkerFleet(CreateWorkerFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkerFleet.</param>
        /// 
        /// <returns>Returns a  CreateWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        public virtual CreateWorkerFleetResponse EndCreateWorkerFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkerFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDestination

        /// <summary>
        /// Grants permission to delete a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSite

        /// <summary>
        /// Grants permission to delete a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual DeleteSiteResponse DeleteSite(DeleteSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return Invoke<DeleteSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual IAsyncResult BeginDeleteSite(DeleteSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSite.</param>
        /// 
        /// <returns>Returns a  DeleteSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual DeleteSiteResponse EndDeleteSite(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorker

        /// <summary>
        /// Grants permission to delete a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// 
        /// <returns>The response from the DeleteWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual DeleteWorkerResponse DeleteWorker(DeleteWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorker(DeleteWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorker.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual DeleteWorkerResponse EndDeleteWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkerFleet

        /// <summary>
        /// Grants permission to delete a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        public virtual DeleteWorkerFleetResponse DeleteWorkerFleet(DeleteWorkerFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkerFleet(DeleteWorkerFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkerFleet.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        public virtual DeleteWorkerFleetResponse EndDeleteWorkerFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkerFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDestination

        /// <summary>
        /// Grants permission to get a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse EndGetDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSite

        /// <summary>
        /// Grants permission to get a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// 
        /// <returns>The response from the GetSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        public virtual GetSiteResponse GetSite(GetSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteResponseUnmarshaller.Instance;

            return Invoke<GetSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        public virtual IAsyncResult BeginGetSite(GetSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSite.</param>
        /// 
        /// <returns>Returns a  GetSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        public virtual GetSiteResponse EndGetSite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorker

        /// <summary>
        /// Grants permission to get a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// 
        /// <returns>The response from the GetWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual GetWorkerResponse GetWorker(GetWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerResponseUnmarshaller.Instance;

            return Invoke<GetWorkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual IAsyncResult BeginGetWorker(GetWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorker.</param>
        /// 
        /// <returns>Returns a  GetWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual GetWorkerResponse EndGetWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkerFleet

        /// <summary>
        /// Grants permission to get a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the GetWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        public virtual GetWorkerFleetResponse GetWorkerFleet(GetWorkerFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerFleetResponseUnmarshaller.Instance;

            return Invoke<GetWorkerFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        public virtual IAsyncResult BeginGetWorkerFleet(GetWorkerFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkerFleet.</param>
        /// 
        /// <returns>Returns a  GetWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        public virtual GetWorkerFleetResponse EndGetWorkerFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkerFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDestinations

        /// <summary>
        /// Grants permission to list destinations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDestinationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSites

        /// <summary>
        /// Grants permission to list sites
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual ListSitesResponse ListSites(ListSitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;

            return Invoke<ListSitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSites operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual IAsyncResult BeginListSites(ListSitesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSites.</param>
        /// 
        /// <returns>Returns a  ListSitesResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual ListSitesResponse EndListSites(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSitesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkerFleets

        /// <summary>
        /// Grants permission to list worker fleets
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerFleets service method.</param>
        /// 
        /// <returns>The response from the ListWorkerFleets service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        public virtual ListWorkerFleetsResponse ListWorkerFleets(ListWorkerFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkerFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerFleetsResponseUnmarshaller.Instance;

            return Invoke<ListWorkerFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerFleets operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkerFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        public virtual IAsyncResult BeginListWorkerFleets(ListWorkerFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkerFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkerFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkerFleets.</param>
        /// 
        /// <returns>Returns a  ListWorkerFleetsResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        public virtual ListWorkerFleetsResponse EndListWorkerFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkerFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkers

        /// <summary>
        /// Grants permission to list workers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// 
        /// <returns>The response from the ListWorkers service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual ListWorkersResponse ListWorkers(ListWorkersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersResponseUnmarshaller.Instance;

            return Invoke<ListWorkersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual IAsyncResult BeginListWorkers(ListWorkersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkers.</param>
        /// 
        /// <returns>Returns a  ListWorkersResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual ListWorkersResponse EndListWorkers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkersResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Grants permission to update a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSite

        /// <summary>
        /// Grants permission to update a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual UpdateSiteResponse UpdateSite(UpdateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual IAsyncResult BeginUpdateSite(UpdateSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSite.</param>
        /// 
        /// <returns>Returns a  UpdateSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual UpdateSiteResponse EndUpdateSite(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorker

        /// <summary>
        /// Grants permission to update a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// 
        /// <returns>The response from the UpdateWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual UpdateWorkerResponse UpdateWorker(UpdateWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorker(UpdateWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorker.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual UpdateWorkerResponse EndUpdateWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkerFleet

        /// <summary>
        /// Grants permission to update a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        public virtual UpdateWorkerFleetResponse UpdateWorkerFleet(UpdateWorkerFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkerFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkerFleet(UpdateWorkerFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkerFleet.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        public virtual UpdateWorkerFleetResponse EndUpdateWorkerFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkerFleetResponse>(asyncResult);
        }

        #endregion
        
    }
}