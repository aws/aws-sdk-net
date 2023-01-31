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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Cancels a contact with a specified contact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelContact service method.</param>
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
        public virtual CancelContactResponse CancelContact(CancelContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelContactResponseUnmarshaller.Instance;

            return Invoke<CancelContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        public virtual IAsyncResult BeginCancelContact(CancelContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelContact.</param>
        /// 
        /// <returns>Returns a  CancelContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        public virtual CancelContactResponse EndCancelContact(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelContactResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfig

        /// <summary>
        /// Creates a <code>Config</code> with the specified <code>configData</code> parameters.
        /// 
        ///  
        /// <para>
        /// Only one type of <code>configData</code> can be specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig service method.</param>
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
        public virtual CreateConfigResponse CreateConfig(CreateConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigResponseUnmarshaller.Instance;

            return Invoke<CreateConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateConfig(CreateConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfig.</param>
        /// 
        /// <returns>Returns a  CreateConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        public virtual CreateConfigResponse EndCreateConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataflowEndpointGroup

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
        public virtual CreateDataflowEndpointGroupResponse CreateDataflowEndpointGroup(CreateDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDataflowEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDataflowEndpointGroup(CreateDataflowEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataflowEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  CreateDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        public virtual CreateDataflowEndpointGroupResponse EndCreateDataflowEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataflowEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEphemeris

        /// <summary>
        /// Creates an Ephemeris with the specified <code>EphemerisData</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris service method.</param>
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
        public virtual CreateEphemerisResponse CreateEphemeris(CreateEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEphemerisResponseUnmarshaller.Instance;

            return Invoke<CreateEphemerisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        public virtual IAsyncResult BeginCreateEphemeris(CreateEphemerisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEphemerisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEphemeris.</param>
        /// 
        /// <returns>Returns a  CreateEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        public virtual CreateEphemerisResponse EndCreateEphemeris(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEphemerisResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMissionProfile

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
        public virtual CreateMissionProfileResponse CreateMissionProfile(CreateMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMissionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateMissionProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateMissionProfile(CreateMissionProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMissionProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMissionProfile.</param>
        /// 
        /// <returns>Returns a  CreateMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        public virtual CreateMissionProfileResponse EndCreateMissionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMissionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfig

        /// <summary>
        /// Deletes a <code>Config</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig service method.</param>
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
        public virtual DeleteConfigResponse DeleteConfig(DeleteConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfig(DeleteConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfig.</param>
        /// 
        /// <returns>Returns a  DeleteConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        public virtual DeleteConfigResponse EndDeleteConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataflowEndpointGroup

        /// <summary>
        /// Deletes a dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup service method.</param>
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
        public virtual DeleteDataflowEndpointGroupResponse DeleteDataflowEndpointGroup(DeleteDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDataflowEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataflowEndpointGroup(DeleteDataflowEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataflowEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        public virtual DeleteDataflowEndpointGroupResponse EndDeleteDataflowEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataflowEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEphemeris

        /// <summary>
        /// Deletes an ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris service method.</param>
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
        public virtual DeleteEphemerisResponse DeleteEphemeris(DeleteEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEphemerisResponseUnmarshaller.Instance;

            return Invoke<DeleteEphemerisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        public virtual IAsyncResult BeginDeleteEphemeris(DeleteEphemerisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEphemerisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEphemeris.</param>
        /// 
        /// <returns>Returns a  DeleteEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        public virtual DeleteEphemerisResponse EndDeleteEphemeris(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEphemerisResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMissionProfile

        /// <summary>
        /// Deletes a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile service method.</param>
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
        public virtual DeleteMissionProfileResponse DeleteMissionProfile(DeleteMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMissionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteMissionProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteMissionProfile(DeleteMissionProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMissionProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMissionProfile.</param>
        /// 
        /// <returns>Returns a  DeleteMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        public virtual DeleteMissionProfileResponse EndDeleteMissionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMissionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContact

        /// <summary>
        /// Describes an existing contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
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
        public virtual DescribeContactResponse DescribeContact(DescribeContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return Invoke<DescribeContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual IAsyncResult BeginDescribeContact(DescribeContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContact.</param>
        /// 
        /// <returns>Returns a  DescribeContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual DescribeContactResponse EndDescribeContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContactResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEphemeris

        /// <summary>
        /// Describes an existing ephemeris.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris service method.</param>
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
        public virtual DescribeEphemerisResponse DescribeEphemeris(DescribeEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEphemerisResponseUnmarshaller.Instance;

            return Invoke<DescribeEphemerisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        public virtual IAsyncResult BeginDescribeEphemeris(DescribeEphemerisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEphemerisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEphemeris.</param>
        /// 
        /// <returns>Returns a  DescribeEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        public virtual DescribeEphemerisResponse EndDescribeEphemeris(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEphemerisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentConfiguration

        /// <summary>
        /// Gets the latest configuration information for a registered agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration service method.</param>
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
        public virtual GetAgentConfigurationResponse GetAgentConfiguration(GetAgentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAgentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetAgentConfiguration(GetAgentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAgentConfigurationResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        public virtual GetAgentConfigurationResponse EndGetAgentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfig

        /// <summary>
        /// Returns <code>Config</code> information.
        /// 
        ///  
        /// <para>
        /// Only one <code>Config</code> response can be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
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
        public virtual GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual IAsyncResult BeginGetConfig(GetConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfig.</param>
        /// 
        /// <returns>Returns a  GetConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual GetConfigResponse EndGetConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataflowEndpointGroup

        /// <summary>
        /// Returns the dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup service method.</param>
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
        public virtual GetDataflowEndpointGroupResponse GetDataflowEndpointGroup(GetDataflowEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<GetDataflowEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataflowEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginGetDataflowEndpointGroup(GetDataflowEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataflowEndpointGroup.</param>
        /// 
        /// <returns>Returns a  GetDataflowEndpointGroupResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        public virtual GetDataflowEndpointGroupResponse EndGetDataflowEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataflowEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMinuteUsage

        /// <summary>
        /// Returns the number of minutes used by account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage service method.</param>
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
        public virtual GetMinuteUsageResponse GetMinuteUsage(GetMinuteUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMinuteUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMinuteUsageResponseUnmarshaller.Instance;

            return Invoke<GetMinuteUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMinuteUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMinuteUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        public virtual IAsyncResult BeginGetMinuteUsage(GetMinuteUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMinuteUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMinuteUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMinuteUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMinuteUsage.</param>
        /// 
        /// <returns>Returns a  GetMinuteUsageResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        public virtual GetMinuteUsageResponse EndGetMinuteUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMinuteUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMissionProfile

        /// <summary>
        /// Returns a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile service method.</param>
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
        public virtual GetMissionProfileResponse GetMissionProfile(GetMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMissionProfileResponseUnmarshaller.Instance;

            return Invoke<GetMissionProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        public virtual IAsyncResult BeginGetMissionProfile(GetMissionProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMissionProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMissionProfile.</param>
        /// 
        /// <returns>Returns a  GetMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        public virtual GetMissionProfileResponse EndGetMissionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMissionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSatellite

        /// <summary>
        /// Returns a satellite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite service method.</param>
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
        public virtual GetSatelliteResponse GetSatellite(GetSatelliteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSatelliteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSatelliteResponseUnmarshaller.Instance;

            return Invoke<GetSatelliteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSatellite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSatellite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        public virtual IAsyncResult BeginGetSatellite(GetSatelliteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSatelliteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSatelliteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSatellite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSatellite.</param>
        /// 
        /// <returns>Returns a  GetSatelliteResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        public virtual GetSatelliteResponse EndGetSatellite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSatelliteResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigs

        /// <summary>
        /// Returns a list of <code>Config</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs service method.</param>
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
        public virtual ListConfigsResponse ListConfigs(ListConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigsResponseUnmarshaller.Instance;

            return Invoke<ListConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        public virtual IAsyncResult BeginListConfigs(ListConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigs.</param>
        /// 
        /// <returns>Returns a  ListConfigsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        public virtual ListConfigsResponse EndListConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContacts

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
        public virtual ListContactsResponse ListContacts(ListContactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return Invoke<ListContactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual IAsyncResult BeginListContacts(ListContactsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContacts.</param>
        /// 
        /// <returns>Returns a  ListContactsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual ListContactsResponse EndListContacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataflowEndpointGroups

        /// <summary>
        /// Returns a list of <code>DataflowEndpoint</code> groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups service method.</param>
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
        public virtual ListDataflowEndpointGroupsResponse ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataflowEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataflowEndpointGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDataflowEndpointGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataflowEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataflowEndpointGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        public virtual IAsyncResult BeginListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataflowEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataflowEndpointGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataflowEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataflowEndpointGroups.</param>
        /// 
        /// <returns>Returns a  ListDataflowEndpointGroupsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        public virtual ListDataflowEndpointGroupsResponse EndListDataflowEndpointGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataflowEndpointGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEphemerides

        /// <summary>
        /// List existing ephemerides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides service method.</param>
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
        public virtual ListEphemeridesResponse ListEphemerides(ListEphemeridesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEphemeridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEphemeridesResponseUnmarshaller.Instance;

            return Invoke<ListEphemeridesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEphemerides operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEphemerides
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        public virtual IAsyncResult BeginListEphemerides(ListEphemeridesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEphemeridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEphemeridesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEphemerides operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEphemerides.</param>
        /// 
        /// <returns>Returns a  ListEphemeridesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        public virtual ListEphemeridesResponse EndListEphemerides(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEphemeridesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroundStations

        /// <summary>
        /// Returns a list of ground stations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations service method.</param>
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
        public virtual ListGroundStationsResponse ListGroundStations(ListGroundStationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroundStationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroundStationsResponseUnmarshaller.Instance;

            return Invoke<ListGroundStationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroundStations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroundStations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        public virtual IAsyncResult BeginListGroundStations(ListGroundStationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroundStationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroundStationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroundStations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroundStations.</param>
        /// 
        /// <returns>Returns a  ListGroundStationsResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        public virtual ListGroundStationsResponse EndListGroundStations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroundStationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMissionProfiles

        /// <summary>
        /// Returns a list of mission profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles service method.</param>
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
        public virtual ListMissionProfilesResponse ListMissionProfiles(ListMissionProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMissionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMissionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListMissionProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMissionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMissionProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        public virtual IAsyncResult BeginListMissionProfiles(ListMissionProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMissionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMissionProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMissionProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMissionProfiles.</param>
        /// 
        /// <returns>Returns a  ListMissionProfilesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        public virtual ListMissionProfilesResponse EndListMissionProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMissionProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSatellites

        /// <summary>
        /// Returns a list of satellites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites service method.</param>
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
        public virtual ListSatellitesResponse ListSatellites(ListSatellitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSatellitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSatellitesResponseUnmarshaller.Instance;

            return Invoke<ListSatellitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSatellites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSatellites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        public virtual IAsyncResult BeginListSatellites(ListSatellitesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSatellitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSatellitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSatellites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSatellites.</param>
        /// 
        /// <returns>Returns a  ListSatellitesResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        public virtual ListSatellitesResponse EndListSatellites(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSatellitesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterAgent

        /// <summary>
        /// Registers a new agent with AWS Groundstation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent service method.</param>
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
        public virtual RegisterAgentResponse RegisterAgent(RegisterAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAgentResponseUnmarshaller.Instance;

            return Invoke<RegisterAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        public virtual IAsyncResult BeginRegisterAgent(RegisterAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAgent.</param>
        /// 
        /// <returns>Returns a  RegisterAgentResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        public virtual RegisterAgentResponse EndRegisterAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  ReserveContact

        /// <summary>
        /// Reserves a contact using specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact service method.</param>
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
        public virtual ReserveContactResponse ReserveContact(ReserveContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReserveContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReserveContactResponseUnmarshaller.Instance;

            return Invoke<ReserveContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReserveContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReserveContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        public virtual IAsyncResult BeginReserveContact(ReserveContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReserveContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReserveContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReserveContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReserveContact.</param>
        /// 
        /// <returns>Returns a  ReserveContactResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        public virtual ReserveContactResponse EndReserveContact(IAsyncResult asyncResult)
        {
            return EndInvoke<ReserveContactResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deassigns a resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentStatus

        /// <summary>
        /// Update the status of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
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
        public virtual UpdateAgentStatusResponse UpdateAgentStatus(UpdateAgentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentStatus(UpdateAgentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAgentStatusResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual UpdateAgentStatusResponse EndUpdateAgentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfig

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
        public virtual UpdateConfigResponse UpdateConfig(UpdateConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfig(UpdateConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfig.</param>
        /// 
        /// <returns>Returns a  UpdateConfigResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        public virtual UpdateConfigResponse EndUpdateConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEphemeris

        /// <summary>
        /// Updates an existing ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris service method.</param>
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
        public virtual UpdateEphemerisResponse UpdateEphemeris(UpdateEphemerisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEphemerisResponseUnmarshaller.Instance;

            return Invoke<UpdateEphemerisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEphemeris
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        public virtual IAsyncResult BeginUpdateEphemeris(UpdateEphemerisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEphemerisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEphemerisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEphemeris operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEphemeris.</param>
        /// 
        /// <returns>Returns a  UpdateEphemerisResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        public virtual UpdateEphemerisResponse EndUpdateEphemeris(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEphemerisResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMissionProfile

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
        public virtual UpdateMissionProfileResponse UpdateMissionProfile(UpdateMissionProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMissionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateMissionProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile operation on AmazonGroundStationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMissionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateMissionProfile(UpdateMissionProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMissionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMissionProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMissionProfile.</param>
        /// 
        /// <returns>Returns a  UpdateMissionProfileResult from GroundStation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        public virtual UpdateMissionProfileResponse EndUpdateMissionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMissionProfileResponse>(asyncResult);
        }

        #endregion
        
    }
}