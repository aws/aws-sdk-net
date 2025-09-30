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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTSecureTunneling.Model;
using Amazon.IoTSecureTunneling.Model.Internal.MarshallTransformations;
using Amazon.IoTSecureTunneling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// <para>Implementation for accessing IoTSecureTunneling</para>
    ///
    /// IoT Secure Tunneling 
    /// <para>
    /// IoT Secure Tunneling creates remote connections to devices deployed in the field.
    /// </para>
    ///  
    /// <para>
    /// For more information about how IoT Secure Tunneling works, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/secure-tunneling.html">IoT
    /// Secure Tunneling</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTSecureTunnelingClient : AmazonServiceClient, IAmazonIoTSecureTunneling
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTSecureTunnelingMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTSecureTunnelingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTSecureTunnelingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTSecureTunnelingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        public AmazonIoTSecureTunnelingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTSecureTunnelingConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        public AmazonIoTSecureTunnelingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(AmazonIoTSecureTunnelingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials and an
        /// AmazonIoTSecureTunnelingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials, AmazonIoTSecureTunnelingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSecureTunnelingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSecureTunnelingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTSecureTunnelingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSecureTunnelingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTSecureTunnelingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSecureTunnelingEndpointResolver());
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


        #region  CloseTunnel

        /// <summary>
        /// Closes a tunnel identified by the unique tunnel id. When a <c>CloseTunnel</c> request
        /// is received, we close the WebSocket connections between the client and proxy server
        /// so no data can be transmitted.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CloseTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel service method.</param>
        /// 
        /// <returns>The response from the CloseTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        public virtual CloseTunnelResponse CloseTunnel(CloseTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseTunnelResponseUnmarshaller.Instance;

            return Invoke<CloseTunnelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloseTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        public virtual IAsyncResult BeginCloseTunnel(CloseTunnelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseTunnelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CloseTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseTunnel.</param>
        /// 
        /// <returns>Returns a  CloseTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        public virtual CloseTunnelResponse EndCloseTunnel(IAsyncResult asyncResult)
        {
            return EndInvoke<CloseTunnelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTunnel

        /// <summary>
        /// Gets information about a tunnel identified by the unique tunnel id.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel service method.</param>
        /// 
        /// <returns>The response from the DescribeTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        public virtual DescribeTunnelResponse DescribeTunnel(DescribeTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTunnelResponseUnmarshaller.Instance;

            return Invoke<DescribeTunnelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        public virtual IAsyncResult BeginDescribeTunnel(DescribeTunnelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTunnelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTunnel.</param>
        /// 
        /// <returns>Returns a  DescribeTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        public virtual DescribeTunnelResponse EndDescribeTunnel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTunnelResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTunnels

        /// <summary>
        /// List all tunnels for an Amazon Web Services account. Tunnels are listed by creation
        /// time in descending order, newer tunnels will be listed before older tunnels.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTunnels</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels service method.</param>
        /// 
        /// <returns>The response from the ListTunnels service method, as returned by IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        public virtual ListTunnelsResponse ListTunnels(ListTunnelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTunnelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTunnelsResponseUnmarshaller.Instance;

            return Invoke<ListTunnelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTunnels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTunnels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        public virtual IAsyncResult BeginListTunnels(ListTunnelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTunnelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTunnelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTunnels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTunnels.</param>
        /// 
        /// <returns>Returns a  ListTunnelsResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        public virtual ListTunnelsResponse EndListTunnels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTunnelsResponse>(asyncResult);
        }

        #endregion
        
        #region  OpenTunnel

        /// <summary>
        /// Creates a new tunnel, and returns two client access tokens for clients to use to connect
        /// to the IoT Secure Tunneling proxy server.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">OpenTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel service method.</param>
        /// 
        /// <returns>The response from the OpenTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.LimitExceededException">
        /// Thrown when a tunnel limit is exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        public virtual OpenTunnelResponse OpenTunnel(OpenTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OpenTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenTunnelResponseUnmarshaller.Instance;

            return Invoke<OpenTunnelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OpenTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOpenTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        public virtual IAsyncResult BeginOpenTunnel(OpenTunnelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OpenTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenTunnelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OpenTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOpenTunnel.</param>
        /// 
        /// <returns>Returns a  OpenTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        public virtual OpenTunnelResponse EndOpenTunnel(IAsyncResult asyncResult)
        {
            return EndInvoke<OpenTunnelResponse>(asyncResult);
        }

        #endregion
        
        #region  RotateTunnelAccessToken

        /// <summary>
        /// Revokes the current client access token (CAT) and returns new CAT for clients to use
        /// when reconnecting to secure tunneling to access the same tunnel.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RotateTunnelAccessToken</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// Rotating the CAT doesn't extend the tunnel duration. For example, say the tunnel duration
        /// is 12 hours and the tunnel has already been open for 4 hours. When you rotate the
        /// access tokens, the new tokens that are generated can only be used for the remaining
        /// 8 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateTunnelAccessToken service method.</param>
        /// 
        /// <returns>The response from the RotateTunnelAccessToken service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/RotateTunnelAccessToken">REST API Reference for RotateTunnelAccessToken Operation</seealso>
        public virtual RotateTunnelAccessTokenResponse RotateTunnelAccessToken(RotateTunnelAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RotateTunnelAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateTunnelAccessTokenResponseUnmarshaller.Instance;

            return Invoke<RotateTunnelAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateTunnelAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateTunnelAccessToken operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateTunnelAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/RotateTunnelAccessToken">REST API Reference for RotateTunnelAccessToken Operation</seealso>
        public virtual IAsyncResult BeginRotateTunnelAccessToken(RotateTunnelAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RotateTunnelAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateTunnelAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RotateTunnelAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateTunnelAccessToken.</param>
        /// 
        /// <returns>Returns a  RotateTunnelAccessTokenResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/RotateTunnelAccessToken">REST API Reference for RotateTunnelAccessToken Operation</seealso>
        public virtual RotateTunnelAccessTokenResponse EndRotateTunnelAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<RotateTunnelAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// A resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var resolver = new AmazonIoTSecureTunnelingEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}