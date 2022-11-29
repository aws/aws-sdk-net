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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SimSpaceWeaver.Model;
using Amazon.SimSpaceWeaver.Model.Internal.MarshallTransformations;
using Amazon.SimSpaceWeaver.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimSpaceWeaver
{
    /// <summary>
    /// Implementation for accessing SimSpaceWeaver
    ///
    /// Amazon Web Services SimSpace Weaver (SimSpace Weaver) is a managed service that you
    /// can use to build and operate large-scale spatial simulations in the Amazon Web Services
    /// Cloud. For example, you can create a digital twin of a city, crowd simulations with
    /// millions of people and objects, and massilvely-multiplayer games with hundreds of
    /// thousands of connected players. For more information about SimSpace Weaver, see the
    /// <i> <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/">Amazon
    /// Web Services SimSpace Weaver User Guide</a> </i>.
    /// 
    ///  
    /// <para>
    /// This API reference describes the API operations and data types that you can use to
    /// communicate directly with SimSpace Weaver.
    /// </para>
    ///  
    /// <para>
    /// SimSpace Weaver also provides the SimSpace Weaver app SDK, which you use for app development.
    /// The SimSpace Weaver app SDK API reference is included in the SimSpace Weaver app SDK
    /// documentation, which is part of the SimSpace Weaver app SDK distributable package.
    /// </para>
    /// </summary>
    public partial class AmazonSimSpaceWeaverClient : AmazonServiceClient, IAmazonSimSpaceWeaver
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimSpaceWeaverMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISimSpaceWeaverPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimSpaceWeaverPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimSpaceWeaverPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        public AmazonSimSpaceWeaverClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimSpaceWeaverConfig()) { }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        public AmazonSimSpaceWeaverClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimSpaceWeaverConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(AmazonSimSpaceWeaverConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimSpaceWeaverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials and an
        /// AmazonSimSpaceWeaverClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials, AmazonSimSpaceWeaverConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimSpaceWeaverConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimSpaceWeaverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimSpaceWeaverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimSpaceWeaverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimSpaceWeaverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimSpaceWeaverConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimSpaceWeaverEndpointResolver());
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


        #region  DeleteApp

        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSimulation

        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services services. This API operation
        /// doesn't delete resources in other Amazon Web Services services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        public virtual DeleteSimulationResponse DeleteSimulation(DeleteSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationResponseUnmarshaller.Instance;

            return Invoke<DeleteSimulationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        public virtual IAsyncResult BeginDeleteSimulation(DeleteSimulationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSimulation.</param>
        /// 
        /// <returns>Returns a  DeleteSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        public virtual DeleteSimulationResponse EndDeleteSimulation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSimulationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApp

        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSimulation

        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        public virtual DescribeSimulationResponse DescribeSimulation(DescribeSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        public virtual IAsyncResult BeginDescribeSimulation(DescribeSimulationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSimulation.</param>
        /// 
        /// <returns>Returns a  DescribeSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        public virtual DescribeSimulationResponse EndDescribeSimulation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSimulationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApps

        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse EndListApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSimulations

        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        public virtual ListSimulationsResponse ListSimulations(ListSimulationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSimulationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSimulations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSimulations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        public virtual IAsyncResult BeginListSimulations(ListSimulationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSimulationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSimulations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSimulations.</param>
        /// 
        /// <returns>Returns a  ListSimulationsResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        public virtual ListSimulationsResponse EndListSimulations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSimulationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartApp

        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        public virtual StartAppResponse StartApp(StartAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppResponseUnmarshaller.Instance;

            return Invoke<StartAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        public virtual IAsyncResult BeginStartApp(StartAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartApp.</param>
        /// 
        /// <returns>Returns a  StartAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        public virtual StartAppResponse EndStartApp(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAppResponse>(asyncResult);
        }

        #endregion
        
        #region  StartClock

        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        public virtual StartClockResponse StartClock(StartClockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClockResponseUnmarshaller.Instance;

            return Invoke<StartClockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartClock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartClock operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartClock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        public virtual IAsyncResult BeginStartClock(StartClockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartClock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartClock.</param>
        /// 
        /// <returns>Returns a  StartClockResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        public virtual StartClockResponse EndStartClock(IAsyncResult asyncResult)
        {
            return EndInvoke<StartClockResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSimulation

        /// <summary>
        /// Starts a simulation with the given name and schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        public virtual StartSimulationResponse StartSimulation(StartSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationResponseUnmarshaller.Instance;

            return Invoke<StartSimulationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        public virtual IAsyncResult BeginStartSimulation(StartSimulationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSimulation.</param>
        /// 
        /// <returns>Returns a  StartSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        public virtual StartSimulationResponse EndStartSimulation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSimulationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopApp

        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        public virtual StopAppResponse StopApp(StopAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppResponseUnmarshaller.Instance;

            return Invoke<StopAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApp operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        public virtual IAsyncResult BeginStopApp(StopAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopApp.</param>
        /// 
        /// <returns>Returns a  StopAppResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        public virtual StopAppResponse EndStopApp(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAppResponse>(asyncResult);
        }

        #endregion
        
        #region  StopClock

        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        public virtual StopClockResponse StopClock(StopClockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClockResponseUnmarshaller.Instance;

            return Invoke<StopClockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopClock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopClock operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopClock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        public virtual IAsyncResult BeginStopClock(StopClockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopClock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopClock.</param>
        /// 
        /// <returns>Returns a  StopClockResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        public virtual StopClockResponse EndStopClock(IAsyncResult asyncResult)
        {
            return EndInvoke<StopClockResponse>(asyncResult);
        }

        #endregion
        
        #region  StopSimulation

        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you need to restart a simulation,
        /// you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        public virtual StopSimulationResponse StopSimulation(StopSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSimulationResponseUnmarshaller.Instance;

            return Invoke<StopSimulationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSimulation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSimulation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        public virtual IAsyncResult BeginStopSimulation(StopSimulationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSimulationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopSimulation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSimulation.</param>
        /// 
        /// <returns>Returns a  StopSimulationResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        public virtual StopSimulationResponse EndStopSimulation(IAsyncResult asyncResult)
        {
            return EndInvoke<StopSimulationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSimSpaceWeaverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SimSpaceWeaver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}