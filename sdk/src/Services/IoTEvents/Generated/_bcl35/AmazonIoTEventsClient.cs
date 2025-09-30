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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTEvents.Model;
using Amazon.IoTEvents.Model.Internal.MarshallTransformations;
using Amazon.IoTEvents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IoTEvents
{
    /// <summary>
    /// <para>Implementation for accessing IoTEvents</para>
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur. You can use AWS IoT Events
    /// API operations to create, read, update, and delete inputs and detector models, and
    /// to list their versions.
    /// </summary>
    public partial class AmazonIoTEventsClient : AmazonServiceClient, IAmazonIoTEvents
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTEventsMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        public AmazonIoTEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        public AmazonIoTEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(AmazonIoTEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials and an
        /// AmazonIoTEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(AWSCredentials credentials, AmazonIoTEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTEventsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTEventsEndpointResolver());
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


        #region  CreateAlarmModel

        /// <summary>
        /// Creates an alarm model to monitor an AWS IoT Events input attribute. You can use the
        /// alarm to get notified when the value is outside a specified range. For more information,
        /// see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/create-alarms.html">Create
        /// an alarm model</a> in the <i>AWS IoT Events Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlarmModel service method.</param>
        /// 
        /// <returns>The response from the CreateAlarmModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateAlarmModel">REST API Reference for CreateAlarmModel Operation</seealso>
        public virtual CreateAlarmModelResponse CreateAlarmModel(CreateAlarmModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlarmModelResponseUnmarshaller.Instance;

            return Invoke<CreateAlarmModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlarmModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlarmModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateAlarmModel">REST API Reference for CreateAlarmModel Operation</seealso>
        public virtual IAsyncResult BeginCreateAlarmModel(CreateAlarmModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlarmModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlarmModel.</param>
        /// 
        /// <returns>Returns a  CreateAlarmModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateAlarmModel">REST API Reference for CreateAlarmModel Operation</seealso>
        public virtual CreateAlarmModelResponse EndCreateAlarmModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAlarmModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDetectorModel

        /// <summary>
        /// Creates a detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorModel service method.</param>
        /// 
        /// <returns>The response from the CreateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        public virtual CreateDetectorModelResponse CreateDetectorModel(CreateDetectorModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorModelResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetectorModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        public virtual IAsyncResult BeginCreateDetectorModel(CreateDetectorModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetectorModel.</param>
        /// 
        /// <returns>Returns a  CreateDetectorModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        public virtual CreateDetectorModelResponse EndCreateDetectorModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDetectorModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInput

        /// <summary>
        /// Creates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual CreateInputResponse CreateInput(CreateInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return Invoke<CreateInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInput operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual IAsyncResult BeginCreateInput(CreateInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInput.</param>
        /// 
        /// <returns>Returns a  CreateInputResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual CreateInputResponse EndCreateInput(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlarmModel

        /// <summary>
        /// Deletes an alarm model. Any alarm instances that were created based on this alarm
        /// model are also deleted. This action can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarmModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarmModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteAlarmModel">REST API Reference for DeleteAlarmModel Operation</seealso>
        public virtual DeleteAlarmModelResponse DeleteAlarmModel(DeleteAlarmModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAlarmModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarmModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlarmModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteAlarmModel">REST API Reference for DeleteAlarmModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlarmModel(DeleteAlarmModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarmModel.</param>
        /// 
        /// <returns>Returns a  DeleteAlarmModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteAlarmModel">REST API Reference for DeleteAlarmModel Operation</seealso>
        public virtual DeleteAlarmModelResponse EndDeleteAlarmModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlarmModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDetectorModel

        /// <summary>
        /// Deletes a detector model. Any active instances of the detector model are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorModel service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        public virtual DeleteDetectorModelResponse DeleteDetectorModel(DeleteDetectorModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorModelResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetectorModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteDetectorModel(DeleteDetectorModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetectorModel.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        public virtual DeleteDetectorModelResponse EndDeleteDetectorModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDetectorModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInput

        /// <summary>
        /// Deletes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual DeleteInputResponse DeleteInput(DeleteInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return Invoke<DeleteInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual IAsyncResult BeginDeleteInput(DeleteInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInput.</param>
        /// 
        /// <returns>Returns a  DeleteInputResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual DeleteInputResponse EndDeleteInput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlarmModel

        /// <summary>
        /// Retrieves information about an alarm model. If you don't specify a value for the <c>alarmModelVersion</c>
        /// parameter, the latest version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmModel service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeAlarmModel">REST API Reference for DescribeAlarmModel Operation</seealso>
        public virtual DescribeAlarmModelResponse DescribeAlarmModel(DescribeAlarmModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeAlarmModel">REST API Reference for DescribeAlarmModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlarmModel(DescribeAlarmModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmModel.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeAlarmModel">REST API Reference for DescribeAlarmModel Operation</seealso>
        public virtual DescribeAlarmModelResponse EndDescribeAlarmModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlarmModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDetectorModel

        /// <summary>
        /// Describes a detector model. If the <c>version</c> parameter is not specified, information
        /// about the latest version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModel service method.</param>
        /// 
        /// <returns>The response from the DescribeDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        public virtual DescribeDetectorModelResponse DescribeDetectorModel(DescribeDetectorModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetectorModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeDetectorModel(DescribeDetectorModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetectorModel.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        public virtual DescribeDetectorModelResponse EndDescribeDetectorModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDetectorModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDetectorModelAnalysis

        /// <summary>
        /// Retrieves runtime information about a detector model analysis.
        /// 
        ///  <note> 
        /// <para>
        /// After AWS IoT Events starts analyzing your detector model, you have up to 24 hours
        /// to retrieve the analysis results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModelAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeDetectorModelAnalysis service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModelAnalysis">REST API Reference for DescribeDetectorModelAnalysis Operation</seealso>
        public virtual DescribeDetectorModelAnalysisResponse DescribeDetectorModelAnalysis(DescribeDetectorModelAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelAnalysisResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorModelAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetectorModelAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModelAnalysis operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetectorModelAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModelAnalysis">REST API Reference for DescribeDetectorModelAnalysis Operation</seealso>
        public virtual IAsyncResult BeginDescribeDetectorModelAnalysis(DescribeDetectorModelAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetectorModelAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetectorModelAnalysis.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorModelAnalysisResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModelAnalysis">REST API Reference for DescribeDetectorModelAnalysis Operation</seealso>
        public virtual DescribeDetectorModelAnalysisResponse EndDescribeDetectorModelAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDetectorModelAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInput

        /// <summary>
        /// Describes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual DescribeInputResponse DescribeInput(DescribeInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return Invoke<DescribeInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual IAsyncResult BeginDescribeInput(DescribeInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInput.</param>
        /// 
        /// <returns>Returns a  DescribeInputResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual DescribeInputResponse EndDescribeInput(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingOptions

        /// <summary>
        /// Retrieves the current settings of the AWS IoT Events logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingOptions(DescribeLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingOptions.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingOptionsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual DescribeLoggingOptionsResponse EndDescribeLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDetectorModelAnalysisResults

        /// <summary>
        /// Retrieves one or more analysis results of the detector model.
        /// 
        ///  <note> 
        /// <para>
        /// After AWS IoT Events starts analyzing your detector model, you have up to 24 hours
        /// to retrieve the analysis results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorModelAnalysisResults service method.</param>
        /// 
        /// <returns>The response from the GetDetectorModelAnalysisResults service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/GetDetectorModelAnalysisResults">REST API Reference for GetDetectorModelAnalysisResults Operation</seealso>
        public virtual GetDetectorModelAnalysisResultsResponse GetDetectorModelAnalysisResults(GetDetectorModelAnalysisResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDetectorModelAnalysisResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorModelAnalysisResultsResponseUnmarshaller.Instance;

            return Invoke<GetDetectorModelAnalysisResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetectorModelAnalysisResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorModelAnalysisResults operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectorModelAnalysisResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/GetDetectorModelAnalysisResults">REST API Reference for GetDetectorModelAnalysisResults Operation</seealso>
        public virtual IAsyncResult BeginGetDetectorModelAnalysisResults(GetDetectorModelAnalysisResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDetectorModelAnalysisResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorModelAnalysisResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectorModelAnalysisResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectorModelAnalysisResults.</param>
        /// 
        /// <returns>Returns a  GetDetectorModelAnalysisResultsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/GetDetectorModelAnalysisResults">REST API Reference for GetDetectorModelAnalysisResults Operation</seealso>
        public virtual GetDetectorModelAnalysisResultsResponse EndGetDetectorModelAnalysisResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorModelAnalysisResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlarmModels

        /// <summary>
        /// Lists the alarm models that you created. The operation returns only the metadata associated
        /// with each alarm model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmModels service method.</param>
        /// 
        /// <returns>The response from the ListAlarmModels service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModels">REST API Reference for ListAlarmModels Operation</seealso>
        public virtual ListAlarmModelsResponse ListAlarmModels(ListAlarmModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmModelsResponseUnmarshaller.Instance;

            return Invoke<ListAlarmModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlarmModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmModels operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlarmModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModels">REST API Reference for ListAlarmModels Operation</seealso>
        public virtual IAsyncResult BeginListAlarmModels(ListAlarmModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlarmModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlarmModels.</param>
        /// 
        /// <returns>Returns a  ListAlarmModelsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModels">REST API Reference for ListAlarmModels Operation</seealso>
        public virtual ListAlarmModelsResponse EndListAlarmModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlarmModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlarmModelVersions

        /// <summary>
        /// Lists all the versions of an alarm model. The operation returns only the metadata
        /// associated with each alarm model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmModelVersions service method.</param>
        /// 
        /// <returns>The response from the ListAlarmModelVersions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModelVersions">REST API Reference for ListAlarmModelVersions Operation</seealso>
        public virtual ListAlarmModelVersionsResponse ListAlarmModelVersions(ListAlarmModelVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmModelVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAlarmModelVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlarmModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmModelVersions operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlarmModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModelVersions">REST API Reference for ListAlarmModelVersions Operation</seealso>
        public virtual IAsyncResult BeginListAlarmModelVersions(ListAlarmModelVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmModelVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlarmModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlarmModelVersions.</param>
        /// 
        /// <returns>Returns a  ListAlarmModelVersionsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListAlarmModelVersions">REST API Reference for ListAlarmModelVersions Operation</seealso>
        public virtual ListAlarmModelVersionsResponse EndListAlarmModelVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlarmModelVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDetectorModels

        /// <summary>
        /// Lists the detector models you have created. Only the metadata associated with each
        /// detector model is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModels service method.</param>
        /// 
        /// <returns>The response from the ListDetectorModels service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        public virtual ListDetectorModelsResponse ListDetectorModels(ListDetectorModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectorModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModels operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectorModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        public virtual IAsyncResult BeginListDetectorModels(ListDetectorModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectorModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectorModels.</param>
        /// 
        /// <returns>Returns a  ListDetectorModelsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        public virtual ListDetectorModelsResponse EndListDetectorModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDetectorModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDetectorModelVersions

        /// <summary>
        /// Lists all the versions of a detector model. Only the metadata associated with each
        /// detector model version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModelVersions service method.</param>
        /// 
        /// <returns>The response from the ListDetectorModelVersions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        public virtual ListDetectorModelVersionsResponse ListDetectorModelVersions(ListDetectorModelVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorModelVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectorModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModelVersions operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectorModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        public virtual IAsyncResult BeginListDetectorModelVersions(ListDetectorModelVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectorModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectorModelVersions.</param>
        /// 
        /// <returns>Returns a  ListDetectorModelVersionsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        public virtual ListDetectorModelVersionsResponse EndListDetectorModelVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDetectorModelVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInputRoutings

        /// <summary>
        /// Lists one or more input routings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputRoutings service method.</param>
        /// 
        /// <returns>The response from the ListInputRoutings service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputRoutings">REST API Reference for ListInputRoutings Operation</seealso>
        public virtual ListInputRoutingsResponse ListInputRoutings(ListInputRoutingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputRoutingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputRoutingsResponseUnmarshaller.Instance;

            return Invoke<ListInputRoutingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputRoutings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputRoutings operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputRoutings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputRoutings">REST API Reference for ListInputRoutings Operation</seealso>
        public virtual IAsyncResult BeginListInputRoutings(ListInputRoutingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputRoutingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputRoutingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputRoutings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputRoutings.</param>
        /// 
        /// <returns>Returns a  ListInputRoutingsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputRoutings">REST API Reference for ListInputRoutings Operation</seealso>
        public virtual ListInputRoutingsResponse EndListInputRoutings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInputRoutingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInputs

        /// <summary>
        /// Lists the inputs you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual ListInputsResponse ListInputs(ListInputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return Invoke<ListInputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputs operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual IAsyncResult BeginListInputs(ListInputsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputs.</param>
        /// 
        /// <returns>Returns a  ListInputsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual ListInputsResponse EndListInputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLoggingOptions

        /// <summary>
        /// Sets or updates the AWS IoT Events logging options.
        /// 
        ///  
        /// <para>
        /// If you update the value of any <c>loggingOptions</c> field, it takes up to one minute
        /// for the change to take effect. If you change the policy attached to the role you specified
        /// in the <c>roleArn</c> field (for example, to correct an invalid policy), it takes
        /// up to five minutes for that change to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginPutLoggingOptions(PutLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingOptions.</param>
        /// 
        /// <returns>Returns a  PutLoggingOptionsResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDetectorModelAnalysis

        /// <summary>
        /// Performs an analysis of your detector model. For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-analyze-api.html">Troubleshooting
        /// a detector model</a> in the <i>AWS IoT Events Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDetectorModelAnalysis service method.</param>
        /// 
        /// <returns>The response from the StartDetectorModelAnalysis service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/StartDetectorModelAnalysis">REST API Reference for StartDetectorModelAnalysis Operation</seealso>
        public virtual StartDetectorModelAnalysisResponse StartDetectorModelAnalysis(StartDetectorModelAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDetectorModelAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDetectorModelAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartDetectorModelAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDetectorModelAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDetectorModelAnalysis operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDetectorModelAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/StartDetectorModelAnalysis">REST API Reference for StartDetectorModelAnalysis Operation</seealso>
        public virtual IAsyncResult BeginStartDetectorModelAnalysis(StartDetectorModelAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDetectorModelAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDetectorModelAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDetectorModelAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDetectorModelAnalysis.</param>
        /// 
        /// <returns>Returns a  StartDetectorModelAnalysisResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/StartDetectorModelAnalysis">REST API Reference for StartDetectorModelAnalysis Operation</seealso>
        public virtual StartDetectorModelAnalysisResponse EndStartDetectorModelAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDetectorModelAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlarmModel

        /// <summary>
        /// Updates an alarm model. Any alarms that were created based on the previous version
        /// are deleted and then created again as new data arrives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlarmModel service method.</param>
        /// 
        /// <returns>The response from the UpdateAlarmModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateAlarmModel">REST API Reference for UpdateAlarmModel Operation</seealso>
        public virtual UpdateAlarmModelResponse UpdateAlarmModel(UpdateAlarmModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlarmModelResponseUnmarshaller.Instance;

            return Invoke<UpdateAlarmModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlarmModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlarmModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateAlarmModel">REST API Reference for UpdateAlarmModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateAlarmModel(UpdateAlarmModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlarmModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlarmModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlarmModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlarmModel.</param>
        /// 
        /// <returns>Returns a  UpdateAlarmModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateAlarmModel">REST API Reference for UpdateAlarmModel Operation</seealso>
        public virtual UpdateAlarmModelResponse EndUpdateAlarmModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAlarmModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDetectorModel

        /// <summary>
        /// Updates a detector model. Detectors (instances) spawned by the previous version are
        /// deleted and then re-created as new inputs arrive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorModel service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        public virtual UpdateDetectorModelResponse UpdateDetectorModel(UpdateDetectorModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorModelResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorModel operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorModel(UpdateDetectorModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorModel.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorModelResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        public virtual UpdateDetectorModelResponse EndUpdateDetectorModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInput

        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual UpdateInputResponse UpdateInput(UpdateInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return Invoke<UpdateInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput operation on AmazonIoTEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual IAsyncResult BeginUpdateInput(UpdateInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInput.</param>
        /// 
        /// <returns>Returns a  UpdateInputResult from IoTEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual UpdateInputResponse EndUpdateInput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInputResponse>(asyncResult);
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
            var resolver = new AmazonIoTEventsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}