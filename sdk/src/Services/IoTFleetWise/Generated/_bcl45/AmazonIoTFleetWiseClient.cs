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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// Adds, or associates, a vehicle with a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateVehicleFleetResponse> AssociateVehicleFleetAsync(AssociateVehicleFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVehicleFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateVehicleFleetResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchCreateVehicleResponse> BatchCreateVehicleAsync(BatchCreateVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchCreateVehicleResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchUpdateVehicleResponse> BatchUpdateVehicleAsync(BatchUpdateVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateVehicleResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCampaignResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDecoderManifestResponse> CreateDecoderManifestAsync(CreateDecoderManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDecoderManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDecoderManifestResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateModelManifestResponse> CreateModelManifestAsync(CreateModelManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelManifestResponse>(request, options, cancellationToken);
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
        /// Creates a collection of standardized signals that can be reused to create vehicle
        /// models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSignalCatalogResponse> CreateSignalCatalogAsync(CreateSignalCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSignalCatalogResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateVehicleResponse> CreateVehicleAsync(CreateVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVehicleResponse>(request, options, cancellationToken);
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
        /// Deletes a data collection campaign. Deleting a campaign suspends all data collection
        /// and removes it from any vehicles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCampaignResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDecoderManifestResponse> DeleteDecoderManifestAsync(DeleteDecoderManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDecoderManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDecoderManifestResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteModelManifestResponse> DeleteModelManifestAsync(DeleteModelManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteModelManifestResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSignalCatalogResponse> DeleteSignalCatalogAsync(DeleteSignalCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSignalCatalogResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteVehicleResponse> DeleteVehicleAsync(DeleteVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVehicleResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateVehicleFleetResponse> DisassociateVehicleFleetAsync(DisassociateVehicleFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVehicleFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVehicleFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateVehicleFleetResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCampaignResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a created decoder manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDecoderManifestResponse> GetDecoderManifestAsync(GetDecoderManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDecoderManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDecoderManifestResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFleetResponse> GetFleetAsync(GetFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFleetResponse>(request, options, cancellationToken);
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
        /// Retrieves the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLoggingOptionsResponse> GetLoggingOptionsAsync(GetLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoggingOptionsResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a vehicle model (model manifest).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetModelManifestResponse> GetModelManifestAsync(GetModelManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelManifestResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRegisterAccountStatusResponse> GetRegisterAccountStatusAsync(GetRegisterAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegisterAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegisterAccountStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRegisterAccountStatusResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSignalCatalogResponse> GetSignalCatalogAsync(GetSignalCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSignalCatalogResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetVehicleResponse> GetVehicleAsync(GetVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVehicleResponse>(request, options, cancellationToken);
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
        /// Retrieves information about the status of a vehicle with any associated campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetVehicleStatusResponse> GetVehicleStatusAsync(GetVehicleStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVehicleStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVehicleStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVehicleStatusResponse>(request, options, cancellationToken);
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
        /// Creates a decoder manifest using your existing CAN DBC file from your local device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ImportDecoderManifestResponse> ImportDecoderManifestAsync(ImportDecoderManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDecoderManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportDecoderManifestResponse>(request, options, cancellationToken);
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
        /// Creates a signal catalog using your existing VSS formatted content from your local
        /// device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ImportSignalCatalogResponse> ImportSignalCatalogAsync(ImportSignalCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSignalCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportSignalCatalogResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCampaignsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDecoderManifestNetworkInterfacesResponse> ListDecoderManifestNetworkInterfacesAsync(ListDecoderManifestNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestNetworkInterfacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDecoderManifestNetworkInterfacesResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDecoderManifestsResponse> ListDecoderManifestsAsync(ListDecoderManifestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDecoderManifestsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDecoderManifestSignalsResponse> ListDecoderManifestSignalsAsync(ListDecoderManifestSignalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDecoderManifestSignalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDecoderManifestSignalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDecoderManifestSignalsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFleetsForVehicleResponse> ListFleetsForVehicleAsync(ListFleetsForVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsForVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsForVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFleetsForVehicleResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListModelManifestNodesResponse> ListModelManifestNodesAsync(ListModelManifestNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestNodesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelManifestNodesResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListModelManifestsResponse> ListModelManifestsAsync(ListModelManifestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelManifestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelManifestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelManifestsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSignalCatalogNodesResponse> ListSignalCatalogNodesAsync(ListSignalCatalogNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogNodesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSignalCatalogNodesResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSignalCatalogsResponse> ListSignalCatalogsAsync(ListSignalCatalogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalCatalogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSignalCatalogsResponse>(request, options, cancellationToken);
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
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListVehiclesResponse> ListVehiclesAsync(ListVehiclesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVehiclesResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListVehiclesInFleetResponse> ListVehiclesInFleetAsync(ListVehiclesInFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVehiclesInFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVehiclesInFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVehiclesInFleetResponse>(request, options, cancellationToken);
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
        /// Creates or updates the logging option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterAccountResponse>(request, options, cancellationToken);
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
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCampaignResponse>(request, options, cancellationToken);
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
        /// Updates a decoder manifest.
        /// 
        ///  
        /// <para>
        /// A decoder manifest can only be updated when the status is <code>DRAFT</code>. Only
        /// <code>ACTIVE</code> decoder manifests can be associated with vehicles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDecoderManifestResponse> UpdateDecoderManifestAsync(UpdateDecoderManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDecoderManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDecoderManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDecoderManifestResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFleetResponse>(request, options, cancellationToken);
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
        /// Updates a vehicle model (model manifest). If created vehicles are associated with
        /// a vehicle model, it can't be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateModelManifestResponse> UpdateModelManifestAsync(UpdateModelManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelManifestResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelManifestResponse>(request, options, cancellationToken);
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
        /// Updates a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSignalCatalogResponse> UpdateSignalCatalogAsync(UpdateSignalCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSignalCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSignalCatalogResponse>(request, options, cancellationToken);
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
        /// Updates a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateVehicleResponse> UpdateVehicleAsync(UpdateVehicleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVehicleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVehicleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVehicleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}