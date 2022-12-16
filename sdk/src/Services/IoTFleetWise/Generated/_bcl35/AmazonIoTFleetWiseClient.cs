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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTFleetWise.Model;
using Amazon.IoTFleetWise.Model.Internal.MarshallTransformations;
using Amazon.IoTFleetWise.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTFleetWise
{
    /// <summary>
    /// Implementation for accessing IoTFleetWise
    ///
    /// Amazon Web Services IoT FleetWise is a fully managed service that you can use to collect,
    /// model, and transfer vehicle data to the Amazon Web Services cloud at scale. With Amazon
    /// Web Services IoT FleetWise, you can standardize all of your vehicle data models, independent
    /// of the in-vehicle communication architecture, and define data collection rules to
    /// transfer only high-value data to the cloud. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/">What
    /// is Amazon Web Services IoT FleetWise?</a> in the <i>Amazon Web Services IoT FleetWise
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTFleetWiseClient : AmazonServiceClient, IAmazonIoTFleetWise
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTFleetWiseMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTFleetWisePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTFleetWisePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTFleetWisePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with the credentials loaded from the application's
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
        public AmazonIoTFleetWiseClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTFleetWiseConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with the credentials loaded from the application's
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
        public AmazonIoTFleetWiseClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTFleetWiseConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTFleetWiseClient Configuration Object</param>
        public AmazonIoTFleetWiseClient(AmazonIoTFleetWiseConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTFleetWiseClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTFleetWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTFleetWiseClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTFleetWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Credentials and an
        /// AmazonIoTFleetWiseClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTFleetWiseClient Configuration Object</param>
        public AmazonIoTFleetWiseClient(AWSCredentials credentials, AmazonIoTFleetWiseConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTFleetWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTFleetWiseConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTFleetWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTFleetWiseClient Configuration Object</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTFleetWiseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTFleetWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTFleetWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTFleetWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTFleetWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTFleetWiseClient Configuration Object</param>
        public AmazonIoTFleetWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTFleetWiseConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTFleetWiseEndpointResolver());
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


        #region  AssociateVehicleFleet

        /// <summary>
        /// Adds, or associates, a vehicle with a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        public virtual AssociateVehicleFleetResponse AssociateVehicleFleet(AssociateVehicleFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVehicleFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateVehicleFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVehicleFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        public virtual IAsyncResult BeginAssociateVehicleFleet(AssociateVehicleFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVehicleFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVehicleFleet.</param>
        /// 
        /// <returns>Returns a  AssociateVehicleFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        public virtual AssociateVehicleFleetResponse EndAssociateVehicleFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateVehicleFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateVehicle

        /// <summary>
        /// Creates a group, or batch, of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicles-cli.html">Create
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVehicle service method.</param>
        /// 
        /// <returns>The response from the BatchCreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        public virtual BatchCreateVehicleResponse BatchCreateVehicle(BatchCreateVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVehicleResponseUnmarshaller.Instance;

            return Invoke<BatchCreateVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateVehicle(BatchCreateVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateVehicle.</param>
        /// 
        /// <returns>Returns a  BatchCreateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        public virtual BatchCreateVehicleResponse EndBatchCreateVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateVehicle

        /// <summary>
        /// Updates a group, or batch, of vehicles.
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/update-vehicles-cli.html">Update
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateVehicle service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        public virtual BatchUpdateVehicleResponse BatchUpdateVehicle(BatchUpdateVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateVehicleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateVehicle(BatchUpdateVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateVehicle.</param>
        /// 
        /// <returns>Returns a  BatchUpdateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        public virtual BatchUpdateVehicleResponse EndBatchUpdateVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCampaign

        /// <summary>
        /// Creates an orchestration of data collection rules. The Amazon Web Services IoT FleetWise
        /// Edge Agent software running in vehicles uses campaigns to decide how to collect and
        /// transfer data to the cloud. You create campaigns in the cloud. After you or your team
        /// approve campaigns, Amazon Web Services IoT FleetWise automatically deploys them to
        /// vehicles. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/campaigns.html">Collect
        /// and transfer data with campaigns</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDecoderManifest

        /// <summary>
        /// Creates the decoder manifest associated with a model manifest. To create a decoder
        /// manifest, the following must be true:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Every signal decoder has a unique name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each signal decoder is associated with a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each network interface has a unique ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The signal decoders are specified in the model manifest.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the CreateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        public virtual CreateDecoderManifestResponse CreateDecoderManifest(CreateDecoderManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDecoderManifestResponseUnmarshaller.Instance;

            return Invoke<CreateDecoderManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        public virtual IAsyncResult BeginCreateDecoderManifest(CreateDecoderManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDecoderManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDecoderManifest.</param>
        /// 
        /// <returns>Returns a  CreateDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        public virtual CreateDecoderManifestResponse EndCreateDecoderManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDecoderManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a fleet that represents a group of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// You must create both a signal catalog and vehicles before you can create a fleet.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleets.html">Fleets</a>
        /// in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
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
        /// <returns>Returns a  CreateFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModelManifest

        /// <summary>
        /// Creates a vehicle model (model manifest) that specifies signals (attributes, branches,
        /// sensors, and actuators). 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/vehicle-models.html">Vehicle
        /// models</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelManifest service method.</param>
        /// 
        /// <returns>The response from the CreateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        public virtual CreateModelManifestResponse CreateModelManifest(CreateModelManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelManifestResponseUnmarshaller.Instance;

            return Invoke<CreateModelManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        public virtual IAsyncResult BeginCreateModelManifest(CreateModelManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelManifest.</param>
        /// 
        /// <returns>Returns a  CreateModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        public virtual CreateModelManifestResponse EndCreateModelManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSignalCatalog

        /// <summary>
        /// Creates a collection of standardized signals that can be reused to create vehicle
        /// models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the CreateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        public virtual CreateSignalCatalogResponse CreateSignalCatalog(CreateSignalCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalCatalogResponseUnmarshaller.Instance;

            return Invoke<CreateSignalCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        public virtual IAsyncResult BeginCreateSignalCatalog(CreateSignalCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSignalCatalog.</param>
        /// 
        /// <returns>Returns a  CreateSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        public virtual CreateSignalCatalogResponse EndCreateSignalCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSignalCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVehicle

        /// <summary>
        /// Creates a vehicle, which is an instance of a vehicle model (model manifest). Vehicles
        /// created from the same vehicle model consist of the same signals inherited from the
        /// vehicle model.
        /// 
        ///  <note> 
        /// <para>
        ///  If you have an existing Amazon Web Services IoT Thing, you can use Amazon Web Services
        /// IoT FleetWise to create a vehicle and collect data from your thing. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicle-cli.html">Create
        /// a vehicle (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVehicle service method.</param>
        /// 
        /// <returns>The response from the CreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        public virtual CreateVehicleResponse CreateVehicle(CreateVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVehicleResponseUnmarshaller.Instance;

            return Invoke<CreateVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        public virtual IAsyncResult BeginCreateVehicle(CreateVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVehicle.</param>
        /// 
        /// <returns>Returns a  CreateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        public virtual CreateVehicleResponse EndCreateVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaign

        /// <summary>
        /// Deletes a data collection campaign. Deleting a campaign suspends all data collection
        /// and removes it from any vehicles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDecoderManifest

        /// <summary>
        /// Deletes a decoder manifest. You can't delete a decoder manifest if it has vehicles
        /// associated with it. 
        /// 
        ///  <note> 
        /// <para>
        /// If the decoder manifest is successfully deleted, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the DeleteDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        public virtual DeleteDecoderManifestResponse DeleteDecoderManifest(DeleteDecoderManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDecoderManifestResponseUnmarshaller.Instance;

            return Invoke<DeleteDecoderManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        public virtual IAsyncResult BeginDeleteDecoderManifest(DeleteDecoderManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDecoderManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDecoderManifest.</param>
        /// 
        /// <returns>Returns a  DeleteDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        public virtual DeleteDecoderManifestResponse EndDeleteDecoderManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDecoderManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes a fleet. Before you delete a fleet, all vehicles must be dissociated from
        /// the fleet. For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/delete-fleet-cli.html">Delete
        /// a fleet (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
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
        /// <returns>Returns a  DeleteFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModelManifest

        /// <summary>
        /// Deletes a vehicle model (model manifest).
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle model is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelManifest service method.</param>
        /// 
        /// <returns>The response from the DeleteModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        public virtual DeleteModelManifestResponse DeleteModelManifest(DeleteModelManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelManifestResponseUnmarshaller.Instance;

            return Invoke<DeleteModelManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        public virtual IAsyncResult BeginDeleteModelManifest(DeleteModelManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelManifest.</param>
        /// 
        /// <returns>Returns a  DeleteModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        public virtual DeleteModelManifestResponse EndDeleteModelManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSignalCatalog

        /// <summary>
        /// Deletes a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// If the signal catalog is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        public virtual DeleteSignalCatalogResponse DeleteSignalCatalog(DeleteSignalCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalCatalogResponseUnmarshaller.Instance;

            return Invoke<DeleteSignalCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        public virtual IAsyncResult BeginDeleteSignalCatalog(DeleteSignalCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSignalCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        public virtual DeleteSignalCatalogResponse EndDeleteSignalCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSignalCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVehicle

        /// <summary>
        /// Deletes a vehicle and removes it from any campaigns.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVehicle service method.</param>
        /// 
        /// <returns>The response from the DeleteVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        public virtual DeleteVehicleResponse DeleteVehicle(DeleteVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVehicleResponseUnmarshaller.Instance;

            return Invoke<DeleteVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        public virtual IAsyncResult BeginDeleteVehicle(DeleteVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVehicle.</param>
        /// 
        /// <returns>Returns a  DeleteVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        public virtual DeleteVehicleResponse EndDeleteVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateVehicleFleet

        /// <summary>
        /// Removes, or disassociates, a vehicle from a fleet. Disassociating a vehicle from a
        /// fleet doesn't delete the vehicle.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully dissociated from a fleet, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVehicleFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        public virtual DisassociateVehicleFleetResponse DisassociateVehicleFleet(DisassociateVehicleFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVehicleFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateVehicleFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVehicleFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVehicleFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        public virtual IAsyncResult BeginDisassociateVehicleFleet(DisassociateVehicleFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVehicleFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVehicleFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateVehicleFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        public virtual DisassociateVehicleFleetResponse EndDisassociateVehicleFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateVehicleFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaign

        /// <summary>
        /// Retrieves information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDecoderManifest

        /// <summary>
        /// Retrieves information about a created decoder manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the GetDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        public virtual GetDecoderManifestResponse GetDecoderManifest(GetDecoderManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDecoderManifestResponseUnmarshaller.Instance;

            return Invoke<GetDecoderManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        public virtual IAsyncResult BeginGetDecoderManifest(GetDecoderManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDecoderManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDecoderManifest.</param>
        /// 
        /// <returns>Returns a  GetDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        public virtual GetDecoderManifestResponse EndGetDecoderManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDecoderManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFleet

        /// <summary>
        /// Retrieves information about a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual GetFleetResponse GetFleet(GetFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;

            return Invoke<GetFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual IAsyncResult BeginGetFleet(GetFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFleet.</param>
        /// 
        /// <returns>Returns a  GetFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual GetFleetResponse EndGetFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLoggingOptions

        /// <summary>
        /// Retrieves the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        public virtual GetLoggingOptionsResponse GetLoggingOptions(GetLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<GetLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginGetLoggingOptions(GetLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingOptions.</param>
        /// 
        /// <returns>Returns a  GetLoggingOptionsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        public virtual GetLoggingOptionsResponse EndGetLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelManifest

        /// <summary>
        /// Retrieves information about a vehicle model (model manifest).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest service method.</param>
        /// 
        /// <returns>The response from the GetModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        public virtual GetModelManifestResponse GetModelManifest(GetModelManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelManifestResponseUnmarshaller.Instance;

            return Invoke<GetModelManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        public virtual IAsyncResult BeginGetModelManifest(GetModelManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelManifest.</param>
        /// 
        /// <returns>Returns a  GetModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        public virtual GetModelManifestResponse EndGetModelManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRegisterAccountStatus

        /// <summary>
        /// Retrieves information about the status of registering your Amazon Web Services account,
        /// IAM, and Amazon Timestream resources so that Amazon Web Services IoT FleetWise can
        /// transfer your vehicle data to the Amazon Web Services Cloud. 
        /// 
        ///  
        /// <para>
        /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation doesn't require input parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegisterAccountStatus service method.</param>
        /// 
        /// <returns>The response from the GetRegisterAccountStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        public virtual GetRegisterAccountStatusResponse GetRegisterAccountStatus(GetRegisterAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegisterAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegisterAccountStatusResponseUnmarshaller.Instance;

            return Invoke<GetRegisterAccountStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegisterAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegisterAccountStatus operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegisterAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        public virtual IAsyncResult BeginGetRegisterAccountStatus(GetRegisterAccountStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegisterAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegisterAccountStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegisterAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegisterAccountStatus.</param>
        /// 
        /// <returns>Returns a  GetRegisterAccountStatusResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        public virtual GetRegisterAccountStatusResponse EndGetRegisterAccountStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRegisterAccountStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSignalCatalog

        /// <summary>
        /// Retrieves information about a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the GetSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        public virtual GetSignalCatalogResponse GetSignalCatalog(GetSignalCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalCatalogResponseUnmarshaller.Instance;

            return Invoke<GetSignalCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        public virtual IAsyncResult BeginGetSignalCatalog(GetSignalCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSignalCatalog.</param>
        /// 
        /// <returns>Returns a  GetSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        public virtual GetSignalCatalogResponse EndGetSignalCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSignalCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVehicle

        /// <summary>
        /// Retrieves information about a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle service method.</param>
        /// 
        /// <returns>The response from the GetVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        public virtual GetVehicleResponse GetVehicle(GetVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleResponseUnmarshaller.Instance;

            return Invoke<GetVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        public virtual IAsyncResult BeginGetVehicle(GetVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVehicle.</param>
        /// 
        /// <returns>Returns a  GetVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        public virtual GetVehicleResponse EndGetVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVehicleStatus

        /// <summary>
        /// Retrieves information about the status of a vehicle with any associated campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus service method.</param>
        /// 
        /// <returns>The response from the GetVehicleStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        public virtual GetVehicleStatusResponse GetVehicleStatus(GetVehicleStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleStatusResponseUnmarshaller.Instance;

            return Invoke<GetVehicleStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVehicleStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVehicleStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        public virtual IAsyncResult BeginGetVehicleStatus(GetVehicleStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVehicleStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVehicleStatus.</param>
        /// 
        /// <returns>Returns a  GetVehicleStatusResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        public virtual GetVehicleStatusResponse EndGetVehicleStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVehicleStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportDecoderManifest

        /// <summary>
        /// Creates a decoder manifest using your existing CAN DBC file from your local device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the ImportDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        public virtual ImportDecoderManifestResponse ImportDecoderManifest(ImportDecoderManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDecoderManifestResponseUnmarshaller.Instance;

            return Invoke<ImportDecoderManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        public virtual IAsyncResult BeginImportDecoderManifest(ImportDecoderManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDecoderManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDecoderManifest.</param>
        /// 
        /// <returns>Returns a  ImportDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        public virtual ImportDecoderManifestResponse EndImportDecoderManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportDecoderManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportSignalCatalog

        /// <summary>
        /// Creates a signal catalog using your existing VSS formatted content from your local
        /// device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        public virtual ImportSignalCatalogResponse ImportSignalCatalog(ImportSignalCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSignalCatalogResponseUnmarshaller.Instance;

            return Invoke<ImportSignalCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        public virtual IAsyncResult BeginImportSignalCatalog(ImportSignalCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSignalCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSignalCatalog.</param>
        /// 
        /// <returns>Returns a  ImportSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        public virtual ImportSignalCatalogResponse EndImportSignalCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportSignalCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCampaigns

        /// <summary>
        /// Lists information about created campaigns. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCampaignsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDecoderManifestNetworkInterfaces

        /// <summary>
        /// Lists the network interfaces specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifestNetworkInterfaces service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        public virtual ListDecoderManifestNetworkInterfacesResponse ListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<ListDecoderManifestNetworkInterfacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDecoderManifestNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestNetworkInterfaces operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifestNetworkInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        public virtual IAsyncResult BeginListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestNetworkInterfacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifestNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifestNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestNetworkInterfacesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        public virtual ListDecoderManifestNetworkInterfacesResponse EndListDecoderManifestNetworkInterfaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDecoderManifestNetworkInterfacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDecoderManifests

        /// <summary>
        /// Lists decoder manifests. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifests service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        public virtual ListDecoderManifestsResponse ListDecoderManifests(ListDecoderManifestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestsResponseUnmarshaller.Instance;

            return Invoke<ListDecoderManifestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDecoderManifests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifests operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        public virtual IAsyncResult BeginListDecoderManifests(ListDecoderManifestsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifests.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        public virtual ListDecoderManifestsResponse EndListDecoderManifests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDecoderManifestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDecoderManifestSignals

        /// <summary>
        /// A list of information about signal decoders specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestSignals service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifestSignals service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        public virtual ListDecoderManifestSignalsResponse ListDecoderManifestSignals(ListDecoderManifestSignalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestSignalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestSignalsResponseUnmarshaller.Instance;

            return Invoke<ListDecoderManifestSignalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDecoderManifestSignals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestSignals operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifestSignals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        public virtual IAsyncResult BeginListDecoderManifestSignals(ListDecoderManifestSignalsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestSignalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestSignalsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifestSignals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifestSignals.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestSignalsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        public virtual ListDecoderManifestSignalsResponse EndListDecoderManifestSignals(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDecoderManifestSignalsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleets

        /// <summary>
        /// Retrieves information for each created fleet in an Amazon Web Services account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleetsForVehicle

        /// <summary>
        /// Retrieves a list of IDs for all fleets that the vehicle is associated with.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetsForVehicle service method.</param>
        /// 
        /// <returns>The response from the ListFleetsForVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        public virtual ListFleetsForVehicleResponse ListFleetsForVehicle(ListFleetsForVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsForVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsForVehicleResponseUnmarshaller.Instance;

            return Invoke<ListFleetsForVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleetsForVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleetsForVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleetsForVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        public virtual IAsyncResult BeginListFleetsForVehicle(ListFleetsForVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsForVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsForVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleetsForVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleetsForVehicle.</param>
        /// 
        /// <returns>Returns a  ListFleetsForVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        public virtual ListFleetsForVehicleResponse EndListFleetsForVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsForVehicleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelManifestNodes

        /// <summary>
        /// Lists information about nodes specified in a vehicle model (model manifest). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifestNodes service method.</param>
        /// 
        /// <returns>The response from the ListModelManifestNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        public virtual ListModelManifestNodesResponse ListModelManifestNodes(ListModelManifestNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestNodesResponseUnmarshaller.Instance;

            return Invoke<ListModelManifestNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelManifestNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifestNodes operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelManifestNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        public virtual IAsyncResult BeginListModelManifestNodes(ListModelManifestNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelManifestNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelManifestNodes.</param>
        /// 
        /// <returns>Returns a  ListModelManifestNodesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        public virtual ListModelManifestNodesResponse EndListModelManifestNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelManifestNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelManifests

        /// <summary>
        /// Retrieves a list of vehicle models (model manifests). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifests service method.</param>
        /// 
        /// <returns>The response from the ListModelManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        public virtual ListModelManifestsResponse ListModelManifests(ListModelManifestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestsResponseUnmarshaller.Instance;

            return Invoke<ListModelManifestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelManifests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifests operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelManifests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        public virtual IAsyncResult BeginListModelManifests(ListModelManifestsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelManifests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelManifests.</param>
        /// 
        /// <returns>Returns a  ListModelManifestsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        public virtual ListModelManifestsResponse EndListModelManifests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelManifestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSignalCatalogNodes

        /// <summary>
        /// Lists of information about the signals (nodes) specified in a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogNodes service method.</param>
        /// 
        /// <returns>The response from the ListSignalCatalogNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        public virtual ListSignalCatalogNodesResponse ListSignalCatalogNodes(ListSignalCatalogNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogNodesResponseUnmarshaller.Instance;

            return Invoke<ListSignalCatalogNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSignalCatalogNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogNodes operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalCatalogNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        public virtual IAsyncResult BeginListSignalCatalogNodes(ListSignalCatalogNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalCatalogNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalCatalogNodes.</param>
        /// 
        /// <returns>Returns a  ListSignalCatalogNodesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        public virtual ListSignalCatalogNodesResponse EndListSignalCatalogNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSignalCatalogNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSignalCatalogs

        /// <summary>
        /// Lists all the created signal catalogs in an Amazon Web Services account. 
        /// 
        ///  
        /// <para>
        /// You can use to list information about each signal (node) specified in a signal catalog.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogs service method.</param>
        /// 
        /// <returns>The response from the ListSignalCatalogs service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        public virtual ListSignalCatalogsResponse ListSignalCatalogs(ListSignalCatalogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogsResponseUnmarshaller.Instance;

            return Invoke<ListSignalCatalogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSignalCatalogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogs operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalCatalogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        public virtual IAsyncResult BeginListSignalCatalogs(ListSignalCatalogsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalCatalogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalCatalogs.</param>
        /// 
        /// <returns>Returns a  ListSignalCatalogsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        public virtual ListSignalCatalogsResponse EndListSignalCatalogs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSignalCatalogsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVehicles

        /// <summary>
        /// Retrieves a list of summaries of created vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehicles service method.</param>
        /// 
        /// <returns>The response from the ListVehicles service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        public virtual ListVehiclesResponse ListVehicles(ListVehiclesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesResponseUnmarshaller.Instance;

            return Invoke<ListVehiclesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVehicles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVehicles operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVehicles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        public virtual IAsyncResult BeginListVehicles(ListVehiclesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVehicles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVehicles.</param>
        /// 
        /// <returns>Returns a  ListVehiclesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        public virtual ListVehiclesResponse EndListVehicles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVehiclesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVehiclesInFleet

        /// <summary>
        /// Retrieves a list of summaries of all vehicles associated with a fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehiclesInFleet service method.</param>
        /// 
        /// <returns>The response from the ListVehiclesInFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        public virtual ListVehiclesInFleetResponse ListVehiclesInFleet(ListVehiclesInFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesInFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesInFleetResponseUnmarshaller.Instance;

            return Invoke<ListVehiclesInFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVehiclesInFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVehiclesInFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVehiclesInFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        public virtual IAsyncResult BeginListVehiclesInFleet(ListVehiclesInFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesInFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesInFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVehiclesInFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVehiclesInFleet.</param>
        /// 
        /// <returns>Returns a  ListVehiclesInFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        public virtual ListVehiclesInFleetResponse EndListVehiclesInFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVehiclesInFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLoggingOptions

        /// <summary>
        /// Creates or updates the logging option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginPutLoggingOptions(PutLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  PutLoggingOptionsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterAccount

        /// <summary>
        /// Registers your Amazon Web Services account, IAM, and Amazon Timestream resources so
        /// Amazon Web Services IoT FleetWise can transfer your vehicle data to the Amazon Web
        /// Services Cloud. For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// An Amazon Web Services account is <b>not</b> the same thing as a "user account". An
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/introduction_identity-management.html#intro-identity-users">Amazon
        /// Web Services user</a> is an identity that you create using Identity and Access Management
        /// (IAM) and takes the form of either an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users.html">IAM
        /// user</a> or an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// role, both with credentials</a>. A single Amazon Web Services account can, and typically
        /// does, contain many users and roles.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual RegisterAccountResponse RegisterAccount(RegisterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return Invoke<RegisterAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual IAsyncResult BeginRegisterAccount(RegisterAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccount.</param>
        /// 
        /// <returns>Returns a  RegisterAccountResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual RegisterAccountResponse EndRegisterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaign

        /// <summary>
        /// Updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDecoderManifest

        /// <summary>
        /// Updates a decoder manifest.
        /// 
        ///  
        /// <para>
        /// A decoder manifest can only be updated when the status is <code>DRAFT</code>. Only
        /// <code>ACTIVE</code> decoder manifests can be associated with vehicles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the UpdateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        public virtual UpdateDecoderManifestResponse UpdateDecoderManifest(UpdateDecoderManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDecoderManifestResponseUnmarshaller.Instance;

            return Invoke<UpdateDecoderManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        public virtual IAsyncResult BeginUpdateDecoderManifest(UpdateDecoderManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDecoderManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDecoderManifest.</param>
        /// 
        /// <returns>Returns a  UpdateDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        public virtual UpdateDecoderManifestResponse EndUpdateDecoderManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDecoderManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleet

        /// <summary>
        /// Updates the description of an existing fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully updated, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
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
        /// <returns>Returns a  UpdateFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModelManifest

        /// <summary>
        /// Updates a vehicle model (model manifest). If created vehicles are associated with
        /// a vehicle model, it can't be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest service method.</param>
        /// 
        /// <returns>The response from the UpdateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        public virtual UpdateModelManifestResponse UpdateModelManifest(UpdateModelManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelManifestResponseUnmarshaller.Instance;

            return Invoke<UpdateModelManifestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        public virtual IAsyncResult BeginUpdateModelManifest(UpdateModelManifestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelManifestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelManifest.</param>
        /// 
        /// <returns>Returns a  UpdateModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        public virtual UpdateModelManifestResponse EndUpdateModelManifest(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelManifestResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSignalCatalog

        /// <summary>
        /// Updates a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the UpdateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        public virtual UpdateSignalCatalogResponse UpdateSignalCatalog(UpdateSignalCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalCatalogResponseUnmarshaller.Instance;

            return Invoke<UpdateSignalCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        public virtual IAsyncResult BeginUpdateSignalCatalog(UpdateSignalCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSignalCatalog.</param>
        /// 
        /// <returns>Returns a  UpdateSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        public virtual UpdateSignalCatalogResponse EndUpdateSignalCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSignalCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVehicle

        /// <summary>
        /// Updates a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle service method.</param>
        /// 
        /// <returns>The response from the UpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        public virtual UpdateVehicleResponse UpdateVehicle(UpdateVehicleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVehicleResponseUnmarshaller.Instance;

            return Invoke<UpdateVehicleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        public virtual IAsyncResult BeginUpdateVehicle(UpdateVehicleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVehicleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVehicle.</param>
        /// 
        /// <returns>Returns a  UpdateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        public virtual UpdateVehicleResponse EndUpdateVehicle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVehicleResponse>(asyncResult);
        }

        #endregion
        
    }
}