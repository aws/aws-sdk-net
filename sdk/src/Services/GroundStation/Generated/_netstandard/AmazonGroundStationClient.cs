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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GroundStation.Model;
using Amazon.GroundStation.Model.Internal.MarshallTransformations;
using Amazon.GroundStation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GroundStation
{
    /// <summary>
    /// Implementation for accessing GroundStation
    ///
    /// Welcome to the AWS Ground Station API Reference. AWS Ground Station is a fully managed
    /// service that enables you to control satellite communications, downlink and process
    /// satellite data, and scale your satellite operations efficiently and cost-effectively
    /// without having to build or manage your own ground station infrastructure.
    /// </summary>
    public partial class AmazonGroundStationClient : AmazonServiceClient, IAmazonGroundStation
    {
        private static IServiceMetadata serviceMetadata = new AmazonGroundStationMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGroundStationClient with the credentials loaded from the application's
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
        public AmazonGroundStationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGroundStationConfig()) { }

        /// <summary>
        /// Constructs AmazonGroundStationClient with the credentials loaded from the application's
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
        public AmazonGroundStationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGroundStationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGroundStationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGroundStationClient Configuration Object</param>
        public AmazonGroundStationClient(AmazonGroundStationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGroundStationClient(AWSCredentials credentials)
            : this(credentials, new AmazonGroundStationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGroundStationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGroundStationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Credentials and an
        /// AmazonGroundStationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGroundStationClient Configuration Object</param>
        public AmazonGroundStationClient(AWSCredentials credentials, AmazonGroundStationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGroundStationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGroundStationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGroundStationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGroundStationClient Configuration Object</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGroundStationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGroundStationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGroundStationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGroundStationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGroundStationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGroundStationClient Configuration Object</param>
        public AmazonGroundStationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGroundStationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IGroundStationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGroundStationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GroundStationPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGroundStationEndpointResolver());
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


        #region  CancelContact

        internal virtual CancelContactResponse CancelContact(CancelContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelContactResponseUnmarshaller.Instance;

            return Invoke<CancelContactResponse>(request, options);
        }



        /// <summary>
        /// Cancels a contact with a specified contact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        public virtual Task<CancelContactResponse> CancelContactAsync(CancelContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelContactResponseUnmarshaller.Instance;

            return InvokeAsync<CancelContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfig

        internal virtual CreateConfigResponse CreateConfig(CreateConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigResponseUnmarshaller.Instance;

            return Invoke<CreateConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a <code>Config</code> with the specified <code>configData</code> parameters.
        /// 
        ///  
        /// <para>
        /// Only one type of <code>configData</code> can be specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceLimitExceededException">
        /// Account limits for this resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        public virtual Task<CreateConfigResponse> CreateConfigAsync(CreateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataflowEndpointGroup

        internal virtual CreateDataflowEndpointGroupResponse CreateDataflowEndpointGroup(CreateDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDataflowEndpointGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a <code>DataflowEndpoint</code> group containing the specified list of <code>DataflowEndpoint</code>
        /// objects.
        /// 
        ///  
        /// <para>
        /// The <code>name</code> field in each endpoint is used in your mission profile <code>DataflowEndpointConfig</code>
        /// to specify which endpoints to use during a contact.
        /// </para>
        ///  
        /// <para>
        /// When a contact uses multiple <code>DataflowEndpointConfig</code> objects, each <code>Config</code>
        /// must match a <code>DataflowEndpoint</code> in the same group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        public virtual Task<CreateDataflowEndpointGroupResponse> CreateDataflowEndpointGroupAsync(CreateDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataflowEndpointGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataflowEndpointGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEphemeris

        internal virtual CreateEphemerisResponse CreateEphemeris(CreateEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEphemerisResponseUnmarshaller.Instance;

            return Invoke<CreateEphemerisResponse>(request, options);
        }



        /// <summary>
        /// Creates an Ephemeris with the specified <code>EphemerisData</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        public virtual Task<CreateEphemerisResponse> CreateEphemerisAsync(CreateEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEphemerisResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEphemerisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMissionProfile

        internal virtual CreateMissionProfileResponse CreateMissionProfile(CreateMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMissionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateMissionProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a mission profile.
        /// 
        ///  
        /// <para>
        ///  <code>dataflowEdges</code> is a list of lists of strings. Each lower level list of
        /// strings has two elements: a <i>from</i> ARN and a <i>to</i> ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        public virtual Task<CreateMissionProfileResponse> CreateMissionProfileAsync(CreateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMissionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMissionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfig

        internal virtual DeleteConfigResponse DeleteConfig(DeleteConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <code>Config</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        public virtual Task<DeleteConfigResponse> DeleteConfigAsync(DeleteConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataflowEndpointGroup

        internal virtual DeleteDataflowEndpointGroupResponse DeleteDataflowEndpointGroup(DeleteDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDataflowEndpointGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        public virtual Task<DeleteDataflowEndpointGroupResponse> DeleteDataflowEndpointGroupAsync(DeleteDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataflowEndpointGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataflowEndpointGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEphemeris

        internal virtual DeleteEphemerisResponse DeleteEphemeris(DeleteEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEphemerisResponseUnmarshaller.Instance;

            return Invoke<DeleteEphemerisResponse>(request, options);
        }



        /// <summary>
        /// Deletes an ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        public virtual Task<DeleteEphemerisResponse> DeleteEphemerisAsync(DeleteEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEphemerisResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEphemerisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMissionProfile

        internal virtual DeleteMissionProfileResponse DeleteMissionProfile(DeleteMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMissionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteMissionProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        public virtual Task<DeleteMissionProfileResponse> DeleteMissionProfileAsync(DeleteMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMissionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMissionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContact

        internal virtual DescribeContactResponse DescribeContact(DescribeContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return Invoke<DescribeContactResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual Task<DescribeContactResponse> DescribeContactAsync(DescribeContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEphemeris

        internal virtual DescribeEphemerisResponse DescribeEphemeris(DescribeEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEphemerisResponseUnmarshaller.Instance;

            return Invoke<DescribeEphemerisResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing ephemeris.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        public virtual Task<DescribeEphemerisResponse> DescribeEphemerisAsync(DescribeEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEphemerisResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEphemerisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAgentConfiguration

        internal virtual GetAgentConfigurationResponse GetAgentConfiguration(GetAgentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAgentConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the latest configuration information for a registered agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentConfiguration service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        public virtual Task<GetAgentConfigurationResponse> GetAgentConfigurationAsync(GetAgentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfig

        internal virtual GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigResponse>(request, options);
        }



        /// <summary>
        /// Returns <code>Config</code> information.
        /// 
        ///  
        /// <para>
        /// Only one <code>Config</code> response can be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataflowEndpointGroup

        internal virtual GetDataflowEndpointGroupResponse GetDataflowEndpointGroup(GetDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<GetDataflowEndpointGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns the dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        public virtual Task<GetDataflowEndpointGroupResponse> GetDataflowEndpointGroupAsync(GetDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowEndpointGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataflowEndpointGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMinuteUsage

        internal virtual GetMinuteUsageResponse GetMinuteUsage(GetMinuteUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMinuteUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMinuteUsageResponseUnmarshaller.Instance;

            return Invoke<GetMinuteUsageResponse>(request, options);
        }



        /// <summary>
        /// Returns the number of minutes used by account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMinuteUsage service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        public virtual Task<GetMinuteUsageResponse> GetMinuteUsageAsync(GetMinuteUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMinuteUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMinuteUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetMinuteUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMissionProfile

        internal virtual GetMissionProfileResponse GetMissionProfile(GetMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMissionProfileResponseUnmarshaller.Instance;

            return Invoke<GetMissionProfileResponse>(request, options);
        }



        /// <summary>
        /// Returns a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        public virtual Task<GetMissionProfileResponse> GetMissionProfileAsync(GetMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMissionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetMissionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSatellite

        internal virtual GetSatelliteResponse GetSatellite(GetSatelliteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSatelliteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSatelliteResponseUnmarshaller.Instance;

            return Invoke<GetSatelliteResponse>(request, options);
        }



        /// <summary>
        /// Returns a satellite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSatellite service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        public virtual Task<GetSatelliteResponse> GetSatelliteAsync(GetSatelliteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSatelliteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSatelliteResponseUnmarshaller.Instance;

            return InvokeAsync<GetSatelliteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigs

        internal virtual ListConfigsResponse ListConfigs(ListConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigsResponseUnmarshaller.Instance;

            return Invoke<ListConfigsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of <code>Config</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigs service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        public virtual Task<ListConfigsResponse> ListConfigsAsync(ListConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContacts

        internal virtual ListContactsResponse ListContacts(ListContactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return Invoke<ListContactsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of contacts.
        /// 
        ///  
        /// <para>
        /// If <code>statusList</code> contains AVAILABLE, the request must include <code>groundStation</code>,
        /// <code>missionprofileArn</code>, and <code>satelliteArn</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataflowEndpointGroups

        internal virtual ListDataflowEndpointGroupsResponse ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataflowEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataflowEndpointGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDataflowEndpointGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of <code>DataflowEndpoint</code> groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataflowEndpointGroups service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        public virtual Task<ListDataflowEndpointGroupsResponse> ListDataflowEndpointGroupsAsync(ListDataflowEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataflowEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataflowEndpointGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataflowEndpointGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEphemerides

        internal virtual ListEphemeridesResponse ListEphemerides(ListEphemeridesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEphemeridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEphemeridesResponseUnmarshaller.Instance;

            return Invoke<ListEphemeridesResponse>(request, options);
        }



        /// <summary>
        /// List existing ephemerides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEphemerides service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        public virtual Task<ListEphemeridesResponse> ListEphemeridesAsync(ListEphemeridesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEphemeridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEphemeridesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEphemeridesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroundStations

        internal virtual ListGroundStationsResponse ListGroundStations(ListGroundStationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroundStationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroundStationsResponseUnmarshaller.Instance;

            return Invoke<ListGroundStationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of ground stations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroundStations service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        public virtual Task<ListGroundStationsResponse> ListGroundStationsAsync(ListGroundStationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroundStationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroundStationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroundStationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMissionProfiles

        internal virtual ListMissionProfilesResponse ListMissionProfiles(ListMissionProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMissionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMissionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListMissionProfilesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of mission profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMissionProfiles service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        public virtual Task<ListMissionProfilesResponse> ListMissionProfilesAsync(ListMissionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMissionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMissionProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMissionProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSatellites

        internal virtual ListSatellitesResponse ListSatellites(ListSatellitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSatellitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSatellitesResponseUnmarshaller.Instance;

            return Invoke<ListSatellitesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of satellites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSatellites service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        public virtual Task<ListSatellitesResponse> ListSatellitesAsync(ListSatellitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSatellitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSatellitesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSatellitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterAgent

        internal virtual RegisterAgentResponse RegisterAgent(RegisterAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAgentResponseUnmarshaller.Instance;

            return Invoke<RegisterAgentResponse>(request, options);
        }



        /// <summary>
        /// Registers a new agent with AWS Groundstation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAgent service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        public virtual Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAgentResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReserveContact

        internal virtual ReserveContactResponse ReserveContact(ReserveContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReserveContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReserveContactResponseUnmarshaller.Instance;

            return Invoke<ReserveContactResponse>(request, options);
        }



        /// <summary>
        /// Reserves a contact using specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReserveContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        public virtual Task<ReserveContactResponse> ReserveContactAsync(ReserveContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReserveContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReserveContactResponseUnmarshaller.Instance;

            return InvokeAsync<ReserveContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Deassigns a resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAgentStatus

        internal virtual UpdateAgentStatusResponse UpdateAgentStatus(UpdateAgentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentStatusResponse>(request, options);
        }



        /// <summary>
        /// Update the status of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentStatus service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual Task<UpdateAgentStatusResponse> UpdateAgentStatusAsync(UpdateAgentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfig

        internal virtual UpdateConfigResponse UpdateConfig(UpdateConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the <code>Config</code> used when scheduling contacts.
        /// 
        ///  
        /// <para>
        /// Updating a <code>Config</code> will not update the execution parameters for existing
        /// future contacts scheduled with this <code>Config</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        public virtual Task<UpdateConfigResponse> UpdateConfigAsync(UpdateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEphemeris

        internal virtual UpdateEphemerisResponse UpdateEphemeris(UpdateEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEphemerisResponseUnmarshaller.Instance;

            return Invoke<UpdateEphemerisResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        public virtual Task<UpdateEphemerisResponse> UpdateEphemerisAsync(UpdateEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEphemerisResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEphemerisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMissionProfile

        internal virtual UpdateMissionProfileResponse UpdateMissionProfile(UpdateMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMissionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateMissionProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a mission profile.
        /// 
        ///  
        /// <para>
        /// Updating a mission profile will not update the execution parameters for existing future
        /// contacts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        public virtual Task<UpdateMissionProfileResponse> UpdateMissionProfileAsync(UpdateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMissionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMissionProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}